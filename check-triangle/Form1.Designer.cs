namespace check_triangle
{
    partial class Form1
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
            this.Btn_Report = new System.Windows.Forms.Button();
            this.Lst_AllData = new System.Windows.Forms.ListView();
            this.Col_Check = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Cash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbDoanhThu = new System.Windows.Forms.Label();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.lvResult = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.btnFake = new System.Windows.Forms.Button();
            this.Btn_Import = new System.Windows.Forms.Button();
            this.Txt_Report = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Report
            // 
            this.Btn_Report.Location = new System.Drawing.Point(1133, 608);
            this.Btn_Report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Report.Name = "Btn_Report";
            this.Btn_Report.Size = new System.Drawing.Size(123, 37);
            this.Btn_Report.TabIndex = 6;
            this.Btn_Report.Text = "Report";
            this.Btn_Report.UseVisualStyleBackColor = true;
            this.Btn_Report.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Lst_AllData
            // 
            this.Lst_AllData.CheckBoxes = true;
            this.Lst_AllData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_Check,
            this.Col_Item,
            this.Col_Date,
            this.Col_Type,
            this.Col_Cash});
            this.Lst_AllData.GridLines = true;
            this.Lst_AllData.HideSelection = false;
            this.Lst_AllData.Location = new System.Drawing.Point(47, 147);
            this.Lst_AllData.Name = "Lst_AllData";
            this.Lst_AllData.Size = new System.Drawing.Size(630, 455);
            this.Lst_AllData.TabIndex = 13;
            this.Lst_AllData.UseCompatibleStateImageBehavior = false;
            this.Lst_AllData.View = System.Windows.Forms.View.Details;
            this.Lst_AllData.SelectedIndexChanged += new System.EventHandler(this.lvThuChi_SelectedIndexChanged);
            // 
            // Col_Check
            // 
            this.Col_Check.Text = "Check";
            // 
            // Col_Item
            // 
            this.Col_Item.Text = "Item";
            this.Col_Item.Width = 83;
            // 
            // Col_Date
            // 
            this.Col_Date.Text = "Date";
            this.Col_Date.Width = 100;
            // 
            // Col_Type
            // 
            this.Col_Type.Text = "Type";
            this.Col_Type.Width = 100;
            // 
            // Col_Cash
            // 
            this.Col_Cash.Text = "Cash";
            this.Col_Cash.Width = 100;
            // 
            // lbDoanhThu
            // 
            this.lbDoanhThu.AutoSize = true;
            this.lbDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbDoanhThu.ForeColor = System.Drawing.Color.Black;
            this.lbDoanhThu.Location = new System.Drawing.Point(41, 113);
            this.lbDoanhThu.Name = "lbDoanhThu";
            this.lbDoanhThu.Size = new System.Drawing.Size(72, 31);
            this.lbDoanhThu.TabIndex = 15;
            this.lbDoanhThu.Text = "Data";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(602, 608);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 37);
            this.Btn_Add.TabIndex = 17;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvResult
            // 
            this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader20});
            this.lvResult.GridLines = true;
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(760, 147);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(496, 237);
            this.lvResult.TabIndex = 30;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "#";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Year";
            this.columnHeader21.Width = 85;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Tax level";
            this.columnHeader22.Width = 115;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Cash";
            this.columnHeader20.Width = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(754, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 31);
            this.label7.TabIndex = 31;
            this.label7.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(40, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(710, 39);
            this.label2.TabIndex = 33;
            this.label2.Text = "ENTERPRISE INCOME TAX CALCULATION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Location = new System.Drawing.Point(521, 608);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(75, 37);
            this.Btn_Remove.TabIndex = 34;
            this.Btn_Remove.Text = "Remove";
            this.Btn_Remove.UseVisualStyleBackColor = true;
            this.Btn_Remove.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRemove_MouseClick);
            // 
            // btnFake
            // 
            this.btnFake.Location = new System.Drawing.Point(359, 608);
            this.btnFake.Name = "btnFake";
            this.btnFake.Size = new System.Drawing.Size(75, 37);
            this.btnFake.TabIndex = 35;
            this.btnFake.Text = "Fake";
            this.btnFake.UseVisualStyleBackColor = true;
            this.btnFake.Visible = false;
            this.btnFake.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFake_MouseClick);
            // 
            // Btn_Import
            // 
            this.Btn_Import.Location = new System.Drawing.Point(440, 608);
            this.Btn_Import.Name = "Btn_Import";
            this.Btn_Import.Size = new System.Drawing.Size(75, 37);
            this.Btn_Import.TabIndex = 37;
            this.Btn_Import.Text = "Import";
            this.Btn_Import.UseVisualStyleBackColor = true;
            this.Btn_Import.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMerge_MouseClick);
            // 
            // Txt_Report
            // 
            this.Txt_Report.Location = new System.Drawing.Point(760, 390);
            this.Txt_Report.Multiline = true;
            this.Txt_Report.Name = "Txt_Report";
            this.Txt_Report.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Report.Size = new System.Drawing.Size(496, 212);
            this.Txt_Report.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 925);
            this.Controls.Add(this.Txt_Report);
            this.Controls.Add(this.Btn_Import);
            this.Controls.Add(this.btnFake);
            this.Controls.Add(this.Btn_Remove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.lbDoanhThu);
            this.Controls.Add(this.Lst_AllData);
            this.Controls.Add(this.Btn_Report);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Report;
        private System.Windows.Forms.ListView Lst_AllData;
        private System.Windows.Forms.ColumnHeader Col_Date;
        private System.Windows.Forms.ColumnHeader Col_Check;
        private System.Windows.Forms.ColumnHeader Col_Type;
        private System.Windows.Forms.ColumnHeader Col_Cash;
        private System.Windows.Forms.Label lbDoanhThu;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Col_Item;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.Button btnFake;
        private System.Windows.Forms.Button Btn_Import;
        private System.Windows.Forms.TextBox Txt_Report;
    }
}

