namespace DrawShape
{
    partial class CustomDialog
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
            this.Rectaingle = new System.Windows.Forms.RadioButton();
            this.Shape = new System.Windows.Forms.GroupBox();
            this.Line = new System.Windows.Forms.RadioButton();
            this.Ellipse = new System.Windows.Forms.RadioButton();
            this.Triangle = new System.Windows.Forms.RadioButton();
            this.previewColor = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.Shape.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rectaingle
            // 
            this.Rectaingle.AutoSize = true;
            this.Rectaingle.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Rectaingle.Location = new System.Drawing.Point(7, 39);
            this.Rectaingle.Margin = new System.Windows.Forms.Padding(4);
            this.Rectaingle.Name = "Rectaingle";
            this.Rectaingle.Size = new System.Drawing.Size(117, 24);
            this.Rectaingle.TabIndex = 0;
            this.Rectaingle.Text = "Rectaingle";
            this.Rectaingle.UseVisualStyleBackColor = true;
            this.Rectaingle.CheckedChanged += new System.EventHandler(this.Rectaingle_CheckedChanged);
            // 
            // Shape
            // 
            this.Shape.Controls.Add(this.Line);
            this.Shape.Controls.Add(this.Ellipse);
            this.Shape.Controls.Add(this.Triangle);
            this.Shape.Controls.Add(this.Rectaingle);
            this.Shape.Location = new System.Drawing.Point(90, 21);
            this.Shape.Name = "Shape";
            this.Shape.Size = new System.Drawing.Size(210, 220);
            this.Shape.TabIndex = 1;
            this.Shape.TabStop = false;
            this.Shape.Text = "Shape";
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Checked = true;
            this.Line.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Line.Location = new System.Drawing.Point(7, 170);
            this.Line.Margin = new System.Windows.Forms.Padding(4);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(65, 24);
            this.Line.TabIndex = 0;
            this.Line.TabStop = true;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.CheckedChanged += new System.EventHandler(this.Line_CheckedChanged);
            // 
            // Ellipse
            // 
            this.Ellipse.AutoSize = true;
            this.Ellipse.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Ellipse.Location = new System.Drawing.Point(7, 126);
            this.Ellipse.Margin = new System.Windows.Forms.Padding(4);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(82, 24);
            this.Ellipse.TabIndex = 0;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.CheckedChanged += new System.EventHandler(this.Ellipse_CheckedChanged);
            // 
            // Triangle
            // 
            this.Triangle.AutoSize = true;
            this.Triangle.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Triangle.Location = new System.Drawing.Point(7, 82);
            this.Triangle.Margin = new System.Windows.Forms.Padding(4);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(96, 24);
            this.Triangle.TabIndex = 0;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.CheckedChanged += new System.EventHandler(this.Triangle_CheckedChanged);
            // 
            // previewColor
            // 
            this.previewColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewColor.Location = new System.Drawing.Point(42, 251);
            this.previewColor.Name = "previewColor";
            this.previewColor.Size = new System.Drawing.Size(304, 38);
            this.previewColor.TabIndex = 2;
            this.previewColor.Click += new System.EventHandler(this.previewColor_Click);
            // 
            // btOK
            // 
            this.btOK.AutoSize = true;
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(79, 303);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(83, 30);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.AutoSize = true;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(201, 303);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(83, 30);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // CustomDialog
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(395, 357);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.previewColor);
            this.Controls.Add(this.Shape);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomDialog";
            this.Text = "CustomDialog";
            this.Load += new System.EventHandler(this.CustomDialog_Load);
            this.Shape.ResumeLayout(false);
            this.Shape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Rectaingle;
        private System.Windows.Forms.GroupBox Shape;
        private System.Windows.Forms.RadioButton Line;
        private System.Windows.Forms.RadioButton Ellipse;
        private System.Windows.Forms.RadioButton Triangle;
        private System.Windows.Forms.Label previewColor;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
    }
}