namespace check_triangle
{
    partial class Dlg_Data
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
            this.Txt_Date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Item = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Cash = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Type = new System.Windows.Forms.ComboBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Date
            // 
            this.Txt_Date.Location = new System.Drawing.Point(167, 57);
            this.Txt_Date.Name = "Txt_Date";
            this.Txt_Date.Size = new System.Drawing.Size(167, 22);
            this.Txt_Date.TabIndex = 0;
            this.Txt_Date.Tag = "";
            this.Txt_Date.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNgay_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // Txt_Item
            // 
            this.Txt_Item.Location = new System.Drawing.Point(167, 85);
            this.Txt_Item.Name = "Txt_Item";
            this.Txt_Item.Size = new System.Drawing.Size(167, 22);
            this.Txt_Item.TabIndex = 2;
            this.Txt_Item.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKhoan_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cash";
            // 
            // Txt_Cash
            // 
            this.Txt_Cash.Location = new System.Drawing.Point(167, 113);
            this.Txt_Cash.Name = "Txt_Cash";
            this.Txt_Cash.Size = new System.Drawing.Size(167, 22);
            this.Txt_Cash.TabIndex = 4;
            this.Txt_Cash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMoney_KeyPress);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(259, 141);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 6;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.btnAddData);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Item";
            // 
            // Txt_Type
            // 
            this.Txt_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Txt_Type.FormattingEnabled = true;
            this.Txt_Type.Items.AddRange(new object[] {
            "Doanh thu",
            "Chi phí được trừ",
            "Thu nhập khác",
            "Thu nhập được miễn thuế",
            "Khoản lỗ"});
            this.Txt_Type.Location = new System.Drawing.Point(167, 27);
            this.Txt_Type.Name = "Txt_Type";
            this.Txt_Type.Size = new System.Drawing.Size(167, 24);
            this.Txt_Type.TabIndex = 9;
            this.Txt_Type.SelectedIndexChanged += new System.EventHandler(this.comboBoxMuc_SelectedIndexChanged);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(178, 141);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 10;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Dlg_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 180);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Txt_Type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Cash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Item);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Date);
            this.Name = "Dlg_Data";
            this.Text = "Add Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Cash;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Txt_Type;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}