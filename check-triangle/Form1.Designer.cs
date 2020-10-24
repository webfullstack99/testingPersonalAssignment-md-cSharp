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
            this.lbA = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.lbB = new System.Windows.Forms.Label();
            this.tbC = new System.Windows.Forms.TextBox();
            this.lbC = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(270, 85);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(52, 17);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "Type a";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(345, 85);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(208, 22);
            this.tbA.TabIndex = 1;
            this.tbA.TextChanged += new System.EventHandler(this.tbA_TextChanged);
            this.tbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbA_KeyPress);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(345, 130);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(208, 22);
            this.tbB.TabIndex = 3;
            this.tbB.TextChanged += new System.EventHandler(this.tbB_TextChanged);
            this.tbB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbB_KeyPress);
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(270, 130);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(52, 17);
            this.lbB.TabIndex = 2;
            this.lbB.Text = "Type b";
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(345, 179);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(208, 22);
            this.tbC.TabIndex = 5;
            this.tbC.TextChanged += new System.EventHandler(this.tbC_TextChanged);
            this.tbC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbC_KeyPress);
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Location = new System.Drawing.Point(270, 179);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(51, 17);
            this.lbC.TabIndex = 4;
            this.lbC.Text = "Type c";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(478, 229);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbResult.Location = new System.Drawing.Point(270, 262);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 31);
            this.lbResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.lbA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbResult;
    }
}

