namespace Calculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minusRB = new System.Windows.Forms.RadioButton();
            this.timesRB = new System.Windows.Forms.RadioButton();
            this.modRB = new System.Windows.Forms.RadioButton();
            this.divRB = new System.Windows.Forms.RadioButton();
            this.plusRB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các phép tính đơn giản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F);
            this.label2.Location = new System.Drawing.Point(105, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ 1";
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("Arial Narrow", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(224, 107);
            this.input1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(272, 40);
            this.input1.TabIndex = 2;
            // 
            // input2
            // 
            this.input2.Font = new System.Drawing.Font("Arial Narrow", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input2.Location = new System.Drawing.Point(764, 107);
            this.input2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(272, 40);
            this.input2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F);
            this.label3.Location = new System.Drawing.Point(628, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số thứ 2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.minusRB);
            this.groupBox1.Controls.Add(this.timesRB);
            this.groupBox1.Controls.Add(this.modRB);
            this.groupBox1.Controls.Add(this.divRB);
            this.groupBox1.Controls.Add(this.plusRB);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(302, 246);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(556, 137);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // minusRB
            // 
            this.minusRB.AutoSize = true;
            this.minusRB.Location = new System.Drawing.Point(138, 64);
            this.minusRB.Name = "minusRB";
            this.minusRB.Size = new System.Drawing.Size(44, 36);
            this.minusRB.TabIndex = 4;
            this.minusRB.TabStop = true;
            this.minusRB.Text = "-";
            this.minusRB.UseVisualStyleBackColor = true;
            // 
            // timesRB
            // 
            this.timesRB.AutoSize = true;
            this.timesRB.Location = new System.Drawing.Point(235, 64);
            this.timesRB.Name = "timesRB";
            this.timesRB.Size = new System.Drawing.Size(46, 36);
            this.timesRB.TabIndex = 3;
            this.timesRB.TabStop = true;
            this.timesRB.Text = "*";
            this.timesRB.UseVisualStyleBackColor = true;
            // 
            // modRB
            // 
            this.modRB.AutoSize = true;
            this.modRB.Location = new System.Drawing.Point(461, 64);
            this.modRB.Name = "modRB";
            this.modRB.Size = new System.Drawing.Size(60, 36);
            this.modRB.TabIndex = 2;
            this.modRB.TabStop = true;
            this.modRB.Text = "%";
            this.modRB.UseVisualStyleBackColor = true;
            // 
            // divRB
            // 
            this.divRB.AutoSize = true;
            this.divRB.Location = new System.Drawing.Point(345, 64);
            this.divRB.Name = "divRB";
            this.divRB.Size = new System.Drawing.Size(43, 36);
            this.divRB.TabIndex = 1;
            this.divRB.TabStop = true;
            this.divRB.Text = "/";
            this.divRB.UseVisualStyleBackColor = true;
            // 
            // plusRB
            // 
            this.plusRB.AutoSize = true;
            this.plusRB.Location = new System.Drawing.Point(29, 64);
            this.plusRB.Name = "plusRB";
            this.plusRB.Size = new System.Drawing.Size(51, 36);
            this.plusRB.TabIndex = 0;
            this.plusRB.TabStop = true;
            this.plusRB.Text = "+";
            this.plusRB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F);
            this.label4.Location = new System.Drawing.Point(131, 507);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kết quả";
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Arial Narrow", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(251, 495);
            this.output.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(467, 40);
            this.output.TabIndex = 9;
            // 
            // calcBtn
            // 
            this.calcBtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn.Location = new System.Drawing.Point(773, 489);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(129, 46);
            this.calcBtn.TabIndex = 10;
            this.calcBtn.Text = "Tính";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(938, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1161, 684);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton minusRB;
        private System.Windows.Forms.RadioButton timesRB;
        private System.Windows.Forms.RadioButton modRB;
        private System.Windows.Forms.RadioButton divRB;
        private System.Windows.Forms.RadioButton plusRB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button button1;
    }
}

