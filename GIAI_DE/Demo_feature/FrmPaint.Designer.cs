namespace Demo_feature
{
    partial class FrmPaint
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
            this.colorBt = new System.Windows.Forms.Button();
            this.listShape = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // colorBt
            // 
            this.colorBt.Location = new System.Drawing.Point(12, 58);
            this.colorBt.Name = "colorBt";
            this.colorBt.Size = new System.Drawing.Size(75, 23);
            this.colorBt.TabIndex = 0;
            this.colorBt.Text = "Color";
            this.colorBt.UseVisualStyleBackColor = true;
            this.colorBt.Click += new System.EventHandler(this.colorBt_Click);
            // 
            // listShape
            // 
            this.listShape.FormattingEnabled = true;
            this.listShape.Location = new System.Drawing.Point(12, 12);
            this.listShape.Name = "listShape";
            this.listShape.Size = new System.Drawing.Size(121, 23);
            this.listShape.TabIndex = 1;
            // 
            // FrmPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listShape);
            this.Controls.Add(this.colorBt);
            this.DoubleBuffered = true;
            this.Name = "FrmPaint";
            this.Text = "FrmPaint";
            this.Load += new System.EventHandler(this.FrmPaint_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmPaint_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPaint_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPaint_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button colorBt;
        private System.Windows.Forms.ComboBox listShape;
    }
}