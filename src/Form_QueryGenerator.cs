﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace migrator
{
    public partial class Form_QueryGenerator : Form
    {
        public Form_QueryGenerator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("settings.txt"))
            {
                TextReader reader = File.OpenText("settings.txt");
                string settings = reader.ReadToEnd();
                txtConnStr.Text = settings;
            }

            sourceQuery.Text = "SELECT * FROM ";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var ignoreColumns = txtIgnore.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList().FindAll(o => (o != null && o.Trim() != ""));

            SqlConnection con = new SqlConnection(txtConnStr.Text);

            using (con)
            {
                SqlDataAdapter da = new SqlDataAdapter(sourceQuery.Text, con);
                DataTable table = new DataTable();
                da.Fill(table);

                string q = "INSERT INTO " + targetTable.Text + "({0}) VALUES({1});";
                string uq = "UPDATE {0} SET {1} {2}";
                string finalQ = "";

                foreach (DataRow row in table.Rows)
                {

                    if (rbInsert.Checked)
                    {
                        string COLS = "";
                        string VALS = "";

                        for (int i = 0; i < row.ItemArray.Length; i++)
                        {

                            if (!ignoreColumns.Contains(row.Table.Columns[i].ColumnName))
                            {

                                COLS += "\"" + row.Table.Columns[i].ColumnName + "\",";


                                if (row.Table.Columns[i].ColumnName == "CREATETIME"
                                    || row.Table.Columns[i].ColumnName == "UPDATETIME")
                                {

                                    if (rbOracle.Checked)
                                    {
                                        VALS += "sysdate,";
                                    }
                                    else
                                    {
                                        VALS += "getdate(),";
                                    }

                                }
                                else if (row.Table.Columns[i].ColumnName == "CREATEUSERID" || row.Table.Columns[i].ColumnName == "UPDATEUSERID")
                                {
                                    VALS += "1,";
                                }
                                else
                                {
                                    if (row.Table.Columns[i].DataType == typeof(DateTime))
                                    {
                                        if (row[i] == null)
                                        {
                                            VALS += "NULL,";
                                        }
                                        else
                                        {
                                            string val = row[i].ToString().Contains("'") ? row[i].ToString().Replace("'", "''") : row[i].ToString();
                                            VALS += "'" + val + "'" + ",";
                                        }
                                    }
                                    else if (row.Table.Columns[i].DataType == typeof(string))
                                    {
                                        if (row[i] == null)
                                        {
                                            VALS += "NULL,";
                                        }
                                        else
                                        {
                                            string val = row[i].ToString().Contains("'") ? row[i].ToString().Replace("'", "''") : row[i].ToString();
                                            VALS += "N('" + val + "')" + ",";
                                        }
                                    }
                                    else if (row.Table.Columns[i].DataType == typeof(int))
                                    {
                                        if (row[i] == null)
                                        {
                                            VALS += "0,";
                                        }
                                        else
                                        {
                                            VALS += row[i] + ",";
                                        }
                                    }
                                    else//bool
                                    {
                                        if (row[i].ToString() == "True")
                                        {
                                            VALS += "1,";
                                        }
                                        else
                                        {
                                            VALS += "0,";
                                        }
                                    }
                                }
                            }
                        }


                        COLS = COLS.TrimEnd(',');
                        VALS = VALS.TrimEnd(',');

                        finalQ += "\r\n" + string.Format(q, COLS, VALS);
                    }
                    else
                    {
                        var whereCols = txtWhereCols.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList().FindAll(o => (o != null && o.Trim() != ""));

                        string setPart = "";
                        string wherePart = "";

                        for (int i = 0; i < row.ItemArray.Length; i++)
                        {
                            if (!ignoreColumns.Contains(row.Table.Columns[i].ColumnName) && !whereCols.Contains(row.Table.Columns[i].ColumnName))
                            {
                                setPart += row.Table.Columns[i].ColumnName + "=";

                                if (row.Table.Columns[i].DataType == typeof(string))
                                {
                                    setPart += "N'" + (row[i].ToString().Contains("'") ? row[i].ToString().Replace("'", "''") : row[i].ToString()) + "',";
                                }
                                else if (row.Table.Columns[i].DataType == typeof(int))
                                {
                                    setPart += row[i] + ",";
                                }
                            }
                            else if (whereCols.Contains(row.Table.Columns[i].ColumnName))
                            {
                                wherePart += row.Table.Columns[i].ColumnName + "=";

                                if (row.Table.Columns[i].DataType == typeof(string))
                                {
                                    wherePart += "'" + (row[i].ToString().Contains("'") ? row[i].ToString().Replace("'", "''") : row[i].ToString()) + "' AND ";
                                }
                                else if (row.Table.Columns[i].DataType == typeof(int))
                                {
                                    wherePart += row[i] + " AND ";
                                }
                            }
                        }

                        setPart = setPart.TrimEnd(',');
                        if (wherePart.Length != 0)
                        {
                            wherePart = "WHERE " + wherePart.Remove(wherePart.Length - 5, 5);
                        }

                        finalQ += "\r\n" + string.Format(uq, targetTable.Text, setPart, wherePart);
                    }
                }

                generatedQuery.Text = finalQ;
                sourceQuery.Text = "SELECT * FROM ";
                targetTable.Text = "";
                lblMessage.Visible = true;
                lblMessage.Text = "done!";
            }
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(generatedQuery.Text);
        }

        private void groupBox1_Leave(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }

        private void targetTable_Enter(object sender, EventArgs e)
        {
            try
            {
                targetTable.Text =
                    sourceQuery.Text.Split(
                    new string[] { "FROM" },
                    StringSplitOptions.RemoveEmptyEntries)[1]
                    .Split(
                    new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0];
            }
            catch (Exception)
            {
                targetTable.Text = "";
            }
        }
    }
}
