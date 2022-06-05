namespace Doar_Picturebox
{
    partial class InkCalculator
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
            this.ShapesPixels = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PaintingTotalPixels = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NonShapesChangedPixels = new System.Windows.Forms.Label();
            this.CalculatorAndPrinter = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cInk = new System.Windows.Forms.Label();
            this.mInk = new System.Windows.Forms.Label();
            this.kInk = new System.Windows.Forms.Label();
            this.yInk = new System.Windows.Forms.Label();
            this.ScaledWidth = new System.Windows.Forms.TextBox();
            this.ScaledHeight = new System.Windows.Forms.TextBox();
            this.inkCons = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CalculatorAndPrinter)).BeginInit();
            this.SuspendLayout();
            // 
            // ShapesPixels
            // 
            this.ShapesPixels.AutoSize = true;
            this.ShapesPixels.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShapesPixels.Location = new System.Drawing.Point(385, 78);
            this.ShapesPixels.Name = "ShapesPixels";
            this.ShapesPixels.Size = new System.Drawing.Size(16, 18);
            this.ShapesPixels.TabIndex = 0;
            this.ShapesPixels.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of pixels in the shapes generated: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of pixels of painting: ";
            // 
            // PaintingTotalPixels
            // 
            this.PaintingTotalPixels.AutoSize = true;
            this.PaintingTotalPixels.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PaintingTotalPixels.Location = new System.Drawing.Point(283, 118);
            this.PaintingTotalPixels.Name = "PaintingTotalPixels";
            this.PaintingTotalPixels.Size = new System.Drawing.Size(16, 18);
            this.PaintingTotalPixels.TabIndex = 4;
            this.PaintingTotalPixels.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of pixels of non-shapes changed from background color: ";
            // 
            // NonShapesChangedPixels
            // 
            this.NonShapesChangedPixels.AutoSize = true;
            this.NonShapesChangedPixels.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NonShapesChangedPixels.Location = new System.Drawing.Point(568, 155);
            this.NonShapesChangedPixels.Name = "NonShapesChangedPixels";
            this.NonShapesChangedPixels.Size = new System.Drawing.Size(16, 18);
            this.NonShapesChangedPixels.TabIndex = 6;
            this.NonShapesChangedPixels.Text = "0";
            // 
            // CalculatorAndPrinter
            // 
            this.CalculatorAndPrinter.Image = global::Doar_Picturebox.Properties.Resources.print_outline;
            this.CalculatorAndPrinter.Location = new System.Drawing.Point(1090, 301);
            this.CalculatorAndPrinter.Name = "CalculatorAndPrinter";
            this.CalculatorAndPrinter.Size = new System.Drawing.Size(70, 70);
            this.CalculatorAndPrinter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CalculatorAndPrinter.TabIndex = 7;
            this.CalculatorAndPrinter.TabStop = false;
            this.CalculatorAndPrinter.Click += new System.EventHandler(this.CalculatorAndPrinter_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1070, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 61);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ink Calculator and Print";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(40, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 34);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ink consumption";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(40, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "C :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(301, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "M :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(40, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Y :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(301, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "K :";
            // 
            // cInk
            // 
            this.cInk.AutoSize = true;
            this.cInk.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cInk.Location = new System.Drawing.Point(103, 279);
            this.cInk.Name = "cInk";
            this.cInk.Size = new System.Drawing.Size(17, 20);
            this.cInk.TabIndex = 14;
            this.cInk.Text = "0";
            // 
            // mInk
            // 
            this.mInk.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mInk.Location = new System.Drawing.Point(366, 282);
            this.mInk.Name = "mInk";
            this.mInk.Size = new System.Drawing.Size(126, 20);
            this.mInk.TabIndex = 15;
            this.mInk.Text = "0";
            // 
            // kInk
            // 
            this.kInk.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kInk.Location = new System.Drawing.Point(366, 354);
            this.kInk.Name = "kInk";
            this.kInk.Size = new System.Drawing.Size(164, 20);
            this.kInk.TabIndex = 16;
            this.kInk.Text = "0";
            // 
            // yInk
            // 
            this.yInk.AutoSize = true;
            this.yInk.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yInk.Location = new System.Drawing.Point(103, 351);
            this.yInk.Name = "yInk";
            this.yInk.Size = new System.Drawing.Size(17, 20);
            this.yInk.TabIndex = 17;
            this.yInk.Text = "0";
            // 
            // ScaledWidth
            // 
            this.ScaledWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScaledWidth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScaledWidth.Location = new System.Drawing.Point(1030, 81);
            this.ScaledWidth.Name = "ScaledWidth";
            this.ScaledWidth.Size = new System.Drawing.Size(190, 25);
            this.ScaledWidth.TabIndex = 18;
            this.ScaledWidth.Text = "Write width...";
            // 
            // ScaledHeight
            // 
            this.ScaledHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScaledHeight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScaledHeight.Location = new System.Drawing.Point(1030, 155);
            this.ScaledHeight.Name = "ScaledHeight";
            this.ScaledHeight.Size = new System.Drawing.Size(190, 25);
            this.ScaledHeight.TabIndex = 19;
            this.ScaledHeight.Text = "Write length...";
            // 
            // inkCons
            // 
            this.inkCons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inkCons.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inkCons.Location = new System.Drawing.Point(997, 226);
            this.inkCons.Name = "inkCons";
            this.inkCons.Size = new System.Drawing.Size(250, 25);
            this.inkCons.TabIndex = 20;
            this.inkCons.Text = "Ink Consumption / ml";
            // 
            // InkCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 683);
            this.Controls.Add(this.inkCons);
            this.Controls.Add(this.ScaledHeight);
            this.Controls.Add(this.ScaledWidth);
            this.Controls.Add(this.yInk);
            this.Controls.Add(this.kInk);
            this.Controls.Add(this.mInk);
            this.Controls.Add(this.cInk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CalculatorAndPrinter);
            this.Controls.Add(this.NonShapesChangedPixels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PaintingTotalPixels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShapesPixels);
            this.Name = "InkCalculator";
            this.Text = "InkCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.CalculatorAndPrinter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ShapesPixels;
        private Label label1;
        private Label label2;
        private Label PaintingTotalPixels;
        private Label label3;
        private Label NonShapesChangedPixels;
        private PictureBox CalculatorAndPrinter;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label cInk;
        private Label mInk;
        private Label kInk;
        private Label yInk;
        private TextBox ScaledWidth;
        private TextBox ScaledHeight;
        private TextBox inkCons;
    }
}