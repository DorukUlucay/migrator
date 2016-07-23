namespace migrator
{
    partial class Form_QueryGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourceQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.targetTable = new System.Windows.Forms.TextBox();
            this.generatedQuery = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIgnore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbMsSql = new System.Windows.Forms.RadioButton();
            this.rbOracle = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConnStr = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.rbInsert = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtWhereCols = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceQuery
            // 
            this.sourceQuery.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceQuery.Location = new System.Drawing.Point(107, 64);
            this.sourceQuery.Multiline = true;
            this.sourceQuery.Name = "sourceQuery";
            this.sourceQuery.Size = new System.Drawing.Size(506, 277);
            this.sourceQuery.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Query";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Target Table";
            // 
            // targetTable
            // 
            this.targetTable.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetTable.Location = new System.Drawing.Point(107, 347);
            this.targetTable.Name = "targetTable";
            this.targetTable.Size = new System.Drawing.Size(506, 28);
            this.targetTable.TabIndex = 3;
            this.targetTable.Enter += new System.EventHandler(this.targetTable_Enter);
            // 
            // generatedQuery
            // 
            this.generatedQuery.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedQuery.Location = new System.Drawing.Point(148, 21);
            this.generatedQuery.Multiline = true;
            this.generatedQuery.Name = "generatedQuery";
            this.generatedQuery.Size = new System.Drawing.Size(506, 277);
            this.generatedQuery.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWhereCols);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtIgnore);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtConnStr);
            this.groupBox1.Controls.Add(this.lblMessage);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sourceQuery);
            this.groupBox1.Controls.Add(this.targetTable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 691);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            this.groupBox1.Leave += new System.EventHandler(this.groupBox1_Leave);
            // 
            // txtIgnore
            // 
            this.txtIgnore.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgnore.Location = new System.Drawing.Point(107, 458);
            this.txtIgnore.Name = "txtIgnore";
            this.txtIgnore.Size = new System.Drawing.Size(506, 28);
            this.txtIgnore.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 51);
            this.label6.TabIndex = 14;
            this.label6.Text = "Columns\r\nto be ignored\r\n(seperate with ,)";
            // 
            // rbMsSql
            // 
            this.rbMsSql.AutoSize = true;
            this.rbMsSql.Location = new System.Drawing.Point(80, 3);
            this.rbMsSql.Name = "rbMsSql";
            this.rbMsSql.Size = new System.Drawing.Size(77, 21);
            this.rbMsSql.TabIndex = 13;
            this.rbMsSql.Text = "MSSQL";
            this.rbMsSql.UseVisualStyleBackColor = true;
            // 
            // rbOracle
            // 
            this.rbOracle.AutoSize = true;
            this.rbOracle.Checked = true;
            this.rbOracle.Location = new System.Drawing.Point(3, 3);
            this.rbOracle.Name = "rbOracle";
            this.rbOracle.Size = new System.Drawing.Size(71, 21);
            this.rbOracle.TabIndex = 12;
            this.rbOracle.TabStop = true;
            this.rbOracle.Text = "Oracle";
            this.rbOracle.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "Target \r\nRDBMS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "Connection \r\nString";
            // 
            // txtConnStr
            // 
            this.txtConnStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnStr.Location = new System.Drawing.Point(107, 30);
            this.txtConnStr.Name = "txtConnStr";
            this.txtConnStr.Size = new System.Drawing.Size(506, 28);
            this.txtConnStr.TabIndex = 9;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblMessage.Location = new System.Drawing.Point(351, 616);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 29);
            this.lblMessage.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(108, 600);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(212, 68);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate Insert Code";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCopyToClipboard);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.generatedQuery);
            this.groupBox2.Location = new System.Drawing.Point(679, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 691);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(148, 345);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(212, 68);
            this.btnCopyToClipboard.TabIndex = 6;
            this.btnCopyToClipboard.Text = "Copy to clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Generated Query";
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.Location = new System.Drawing.Point(73, 3);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(75, 21);
            this.rbUpdate.TabIndex = 18;
            this.rbUpdate.Text = "Update";
            this.rbUpdate.UseVisualStyleBackColor = true;
            // 
            // rbInsert
            // 
            this.rbInsert.AutoSize = true;
            this.rbInsert.Checked = true;
            this.rbInsert.Location = new System.Drawing.Point(3, 3);
            this.rbInsert.Name = "rbInsert";
            this.rbInsert.Size = new System.Drawing.Size(64, 21);
            this.rbInsert.TabIndex = 17;
            this.rbInsert.TabStop = true;
            this.rbInsert.Text = "Insert";
            this.rbInsert.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbInsert);
            this.panel1.Controls.Add(this.rbUpdate);
            this.panel1.Location = new System.Drawing.Point(107, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 31);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbOracle);
            this.panel2.Controls.Add(this.rbMsSql);
            this.panel2.Location = new System.Drawing.Point(107, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 33);
            this.panel2.TabIndex = 20;
            // 
            // txtWhereCols
            // 
            this.txtWhereCols.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhereCols.Location = new System.Drawing.Point(107, 524);
            this.txtWhereCols.Name = "txtWhereCols";
            this.txtWhereCols.Size = new System.Drawing.Size(506, 28);
            this.txtWhereCols.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Where Columns";
            // 
            // Form_QueryGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 715);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_QueryGenerator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox sourceQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox targetTable;
        private System.Windows.Forms.TextBox generatedQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConnStr;
        private System.Windows.Forms.RadioButton rbMsSql;
        private System.Windows.Forms.RadioButton rbOracle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIgnore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbUpdate;
        private System.Windows.Forms.RadioButton rbInsert;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtWhereCols;
        private System.Windows.Forms.Label label7;
    }
}

