namespace SapXepMang
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.arr = new System.Windows.Forms.TextBox();
            this.inscArr = new System.Windows.Forms.TextBox();
            this.descArr = new System.Windows.Forms.TextBox();
            this.revArr = new System.Windows.Forms.TextBox();
            this.oddEvenArr = new System.Windows.Forms.TextBox();
            this.sizeArr = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phần tử:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mảng ban đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mảng tăng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mảng giảm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mảng đảo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mảng chẵn tăng, lẻ giảm:";
            // 
            // arr
            // 
            this.arr.Location = new System.Drawing.Point(228, 73);
            this.arr.Name = "arr";
            this.arr.Size = new System.Drawing.Size(544, 35);
            this.arr.TabIndex = 1;
            // 
            // inscArr
            // 
            this.inscArr.Location = new System.Drawing.Point(228, 128);
            this.inscArr.Name = "inscArr";
            this.inscArr.Size = new System.Drawing.Size(544, 35);
            this.inscArr.TabIndex = 1;
            // 
            // descArr
            // 
            this.descArr.Location = new System.Drawing.Point(228, 183);
            this.descArr.Name = "descArr";
            this.descArr.Size = new System.Drawing.Size(544, 35);
            this.descArr.TabIndex = 1;
            // 
            // revArr
            // 
            this.revArr.Location = new System.Drawing.Point(228, 238);
            this.revArr.Name = "revArr";
            this.revArr.Size = new System.Drawing.Size(544, 35);
            this.revArr.TabIndex = 1;
            // 
            // oddEvenArr
            // 
            this.oddEvenArr.Location = new System.Drawing.Point(228, 293);
            this.oddEvenArr.Name = "oddEvenArr";
            this.oddEvenArr.Size = new System.Drawing.Size(544, 35);
            this.oddEvenArr.TabIndex = 1;
            // 
            // sizeArr
            // 
            this.sizeArr.Location = new System.Drawing.Point(148, 23);
            this.sizeArr.Name = "sizeArr";
            this.sizeArr.Size = new System.Drawing.Size(100, 35);
            this.sizeArr.TabIndex = 2;
            // 
            // generateBtn
            // 
            this.generateBtn.AutoSize = true;
            this.generateBtn.Location = new System.Drawing.Point(302, 21);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(259, 37);
            this.generateBtn.TabIndex = 3;
            this.generateBtn.Text = "Tạo mảng ngẫu nhiên";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.AutoSize = true;
            this.sortBtn.Location = new System.Drawing.Point(570, 21);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(202, 37);
            this.sortBtn.TabIndex = 3;
            this.sortBtn.Text = "Sắp xếp";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 360);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.sizeArr);
            this.Controls.Add(this.oddEvenArr);
            this.Controls.Add(this.revArr);
            this.Controls.Add(this.descArr);
            this.Controls.Add(this.inscArr);
            this.Controls.Add(this.arr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox arr;
        private System.Windows.Forms.TextBox inscArr;
        private System.Windows.Forms.TextBox descArr;
        private System.Windows.Forms.TextBox revArr;
        private System.Windows.Forms.TextBox oddEvenArr;
        private System.Windows.Forms.TextBox sizeArr;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button sortBtn;
    }
}

