namespace ChuyenMaASCII
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maASCII = new System.Windows.Forms.TextBox();
            this.KQ1 = new System.Windows.Forms.TextBox();
            this.ASCIItoStrBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kyTu = new System.Windows.Forms.TextBox();
            this.KQ2 = new System.Windows.Forms.TextBox();
            this.StrtoASCIIBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1010, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHUYỂN MÃ ASCII";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ASCIItoStrBtn);
            this.groupBox1.Controls.Add(this.KQ1);
            this.groupBox1.Controls.Add(this.maASCII);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(35, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 357);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chuyển mã ASCII sang ký tự";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StrtoASCIIBtn);
            this.groupBox2.Controls.Add(this.KQ2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.kyTu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(580, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 357);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chuyển ký tự sang mã ASCII";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã ASCII";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // maASCII
            // 
            this.maASCII.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maASCII.Location = new System.Drawing.Point(152, 58);
            this.maASCII.Name = "maASCII";
            this.maASCII.Size = new System.Drawing.Size(219, 50);
            this.maASCII.TabIndex = 2;
            // 
            // KQ1
            // 
            this.KQ1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KQ1.Location = new System.Drawing.Point(152, 245);
            this.KQ1.Name = "KQ1";
            this.KQ1.Size = new System.Drawing.Size(219, 50);
            this.KQ1.TabIndex = 2;
            // 
            // ASCIItoStrBtn
            // 
            this.ASCIItoStrBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ASCIItoStrBtn.Location = new System.Drawing.Point(182, 151);
            this.ASCIItoStrBtn.Name = "ASCIItoStrBtn";
            this.ASCIItoStrBtn.Size = new System.Drawing.Size(155, 53);
            this.ASCIItoStrBtn.TabIndex = 2;
            this.ASCIItoStrBtn.Text = "Chuyển";
            this.ASCIItoStrBtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ký tự";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kết quả";
            // 
            // kyTu
            // 
            this.kyTu.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kyTu.Location = new System.Drawing.Point(151, 58);
            this.kyTu.Name = "kyTu";
            this.kyTu.Size = new System.Drawing.Size(219, 50);
            this.kyTu.TabIndex = 2;
            // 
            // KQ2
            // 
            this.KQ2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KQ2.Location = new System.Drawing.Point(151, 245);
            this.KQ2.Name = "KQ2";
            this.KQ2.Size = new System.Drawing.Size(219, 50);
            this.KQ2.TabIndex = 2;
            // 
            // StrtoASCIIBtn
            // 
            this.StrtoASCIIBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StrtoASCIIBtn.Location = new System.Drawing.Point(181, 151);
            this.StrtoASCIIBtn.Name = "StrtoASCIIBtn";
            this.StrtoASCIIBtn.Size = new System.Drawing.Size(155, 53);
            this.StrtoASCIIBtn.TabIndex = 2;
            this.StrtoASCIIBtn.Text = "Chuyển";
            this.StrtoASCIIBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Chuyển mã ASCII";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ASCIItoStrBtn;
        private System.Windows.Forms.TextBox KQ1;
        private System.Windows.Forms.TextBox maASCII;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StrtoASCIIBtn;
        private System.Windows.Forms.TextBox KQ2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kyTu;
        private System.Windows.Forms.Label label5;
    }
}

