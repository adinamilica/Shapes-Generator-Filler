namespace Doar_Picturebox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tablou = new System.Windows.Forms.PictureBox();
            this.number_of_shapes = new System.Windows.Forms.TextBox();
            this.sf = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.RandomFiguresGenerator = new System.Windows.Forms.PictureBox();
            this.SavePainting = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PrintPicture = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RandomSelectedShapesRun = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.number_selected_shapes = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BackgroundColor = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BrushColor = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pd = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.FillColor = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.InkCalculator = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NewFile = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tablou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomFiguresGenerator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SavePainting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomSelectedShapesRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrushColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FillColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InkCalculator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Tablou
            // 
            this.Tablou.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Tablou.Location = new System.Drawing.Point(151, 79);
            this.Tablou.Name = "Tablou";
            this.Tablou.Size = new System.Drawing.Size(500, 500);
            this.Tablou.TabIndex = 0;
            this.Tablou.TabStop = false;
            this.Tablou.Click += new System.EventHandler(this.Tablou_Click);
            // 
            // number_of_shapes
            // 
            this.number_of_shapes.BackColor = System.Drawing.Color.White;
            this.number_of_shapes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.number_of_shapes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_of_shapes.Location = new System.Drawing.Point(1063, 100);
            this.number_of_shapes.Name = "number_of_shapes";
            this.number_of_shapes.Size = new System.Drawing.Size(100, 25);
            this.number_of_shapes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(964, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 65);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of random shapes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RandomFiguresGenerator
            // 
            this.RandomFiguresGenerator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RandomFiguresGenerator.Image = global::Doar_Picturebox.Properties.Resources.random;
            this.RandomFiguresGenerator.Location = new System.Drawing.Point(1186, 81);
            this.RandomFiguresGenerator.Name = "RandomFiguresGenerator";
            this.RandomFiguresGenerator.Size = new System.Drawing.Size(60, 60);
            this.RandomFiguresGenerator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RandomFiguresGenerator.TabIndex = 24;
            this.RandomFiguresGenerator.TabStop = false;
            this.RandomFiguresGenerator.Click += new System.EventHandler(this.RandomShapesGenerator_Click);
            // 
            // SavePainting
            // 
            this.SavePainting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SavePainting.Image = global::Doar_Picturebox.Properties.Resources.save;
            this.SavePainting.Location = new System.Drawing.Point(1023, 361);
            this.SavePainting.Name = "SavePainting";
            this.SavePainting.Size = new System.Drawing.Size(60, 60);
            this.SavePainting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SavePainting.TabIndex = 25;
            this.SavePainting.TabStop = false;
            this.SavePainting.Click += new System.EventHandler(this.SavePainting_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1010, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 65);
            this.label4.TabIndex = 26;
            this.label4.Text = "Save your work";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrintPicture
            // 
            this.PrintPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PrintPicture.Image = global::Doar_Picturebox.Properties.Resources.print_outline;
            this.PrintPicture.Location = new System.Drawing.Point(1232, 361);
            this.PrintPicture.Name = "PrintPicture";
            this.PrintPicture.Size = new System.Drawing.Size(60, 60);
            this.PrintPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PrintPicture.TabIndex = 27;
            this.PrintPicture.TabStop = false;
            this.PrintPicture.Click += new System.EventHandler(this.PrintPicture_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1235, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 36);
            this.label5.TabIndex = 28;
            this.label5.Text = "Print";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RandomSelectedShapesRun
            // 
            this.RandomSelectedShapesRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RandomSelectedShapesRun.Image = global::Doar_Picturebox.Properties.Resources.random1;
            this.RandomSelectedShapesRun.Location = new System.Drawing.Point(1186, 235);
            this.RandomSelectedShapesRun.Name = "RandomSelectedShapesRun";
            this.RandomSelectedShapesRun.Size = new System.Drawing.Size(60, 60);
            this.RandomSelectedShapesRun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RandomSelectedShapesRun.TabIndex = 31;
            this.RandomSelectedShapesRun.TabStop = false;
            this.RandomSelectedShapesRun.Click += new System.EventHandler(this.RandomSelectedShapesRun_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(964, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 65);
            this.label6.TabIndex = 30;
            this.label6.Text = "Number of selected shapes";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // number_selected_shapes
            // 
            this.number_selected_shapes.BackColor = System.Drawing.Color.White;
            this.number_selected_shapes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.number_selected_shapes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_selected_shapes.Location = new System.Drawing.Point(1063, 254);
            this.number_selected_shapes.Name = "number_selected_shapes";
            this.number_selected_shapes.Size = new System.Drawing.Size(100, 25);
            this.number_selected_shapes.TabIndex = 29;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Line",
            "Triangle",
            "Rectangle",
            "Elipse",
            "Bezier Curve"});
            this.comboBox1.Location = new System.Drawing.Point(1013, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 29);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.Text = "Select a shape...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BackgroundColor
            // 
            this.BackgroundColor.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundColor.Location = new System.Drawing.Point(974, 517);
            this.BackgroundColor.Name = "BackgroundColor";
            this.BackgroundColor.Size = new System.Drawing.Size(60, 60);
            this.BackgroundColor.TabIndex = 33;
            this.BackgroundColor.TabStop = false;
            this.BackgroundColor.Click += new System.EventHandler(this.BackgroundColor_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(944, 580);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 64);
            this.label7.TabIndex = 34;
            this.label7.Text = "Background Color";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BrushColor
            // 
            this.BrushColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BrushColor.Location = new System.Drawing.Point(1078, 517);
            this.BrushColor.Name = "BrushColor";
            this.BrushColor.Size = new System.Drawing.Size(60, 60);
            this.BrushColor.TabIndex = 35;
            this.BrushColor.TabStop = false;
            this.BrushColor.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1055, 580);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 37);
            this.label8.TabIndex = 36;
            this.label8.Text = "Brush Color";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pd
            // 
            this.pd.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.print_EndPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.print_PrintPage);
            // 
            // FillColor
            // 
            this.FillColor.BackColor = System.Drawing.Color.Teal;
            this.FillColor.Location = new System.Drawing.Point(1186, 519);
            this.FillColor.Name = "FillColor";
            this.FillColor.Size = new System.Drawing.Size(60, 60);
            this.FillColor.TabIndex = 37;
            this.FillColor.TabStop = false;
            this.FillColor.Click += new System.EventHandler(this.FillColor_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1160, 582);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 37);
            this.label9.TabIndex = 38;
            this.label9.Text = "Fill Color";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InkCalculator
            // 
            this.InkCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.InkCalculator.Image = global::Doar_Picturebox.Properties.Resources.inks;
            this.InkCalculator.Location = new System.Drawing.Point(1127, 361);
            this.InkCalculator.Name = "InkCalculator";
            this.InkCalculator.Size = new System.Drawing.Size(60, 60);
            this.InkCalculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InkCalculator.TabIndex = 39;
            this.InkCalculator.TabStop = false;
            this.InkCalculator.Click += new System.EventHandler(this.InkCalculator_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1108, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 55);
            this.label2.TabIndex = 40;
            this.label2.Text = "Ink Calculator";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Doar_Picturebox.Properties.Resources.newfile;
            this.pictureBox1.Location = new System.Drawing.Point(917, 361);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // NewFile
            // 
            this.NewFile.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewFile.Location = new System.Drawing.Point(897, 421);
            this.NewFile.Name = "NewFile";
            this.NewFile.Size = new System.Drawing.Size(93, 65);
            this.NewFile.TabIndex = 42;
            this.NewFile.Text = "New Painting";
            this.NewFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Doar_Picturebox.Properties.Resources.sevalet;
            this.pictureBox2.Location = new System.Drawing.Point(-4, -151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 1228);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 683);
            this.Controls.Add(this.NewFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InkCalculator);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FillColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BrushColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BackgroundColor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RandomSelectedShapesRun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.number_selected_shapes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrintPicture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SavePainting);
            this.Controls.Add(this.RandomFiguresGenerator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number_of_shapes);
            this.Controls.Add(this.Tablou);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Tablou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomFiguresGenerator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SavePainting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomSelectedShapesRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrushColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FillColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InkCalculator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Tablou;
        private TextBox number_of_shapes;
        private SaveFileDialog sf;
        private Label label1;
        private PictureBox RandomFiguresGenerator;
        private PictureBox SavePainting;
        private Label label4;
        private PictureBox PrintPicture;
        private Label label5;
        private PictureBox RandomSelectedShapesRun;
        private Label label6;
        private TextBox number_selected_shapes;
        private ComboBox comboBox1;
        private ColorDialog colorDialog1;
        private PictureBox BackgroundColor;
        private Label label7;
        private PictureBox BrushColor;
        private Label label8;
        private PrintDialog pd;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PictureBox FillColor;
        private Label label9;
        private PictureBox InkCalculator;
        private Label label2;
        private PictureBox pictureBox1;
        private Label NewFile;
        private PictureBox pictureBox2;
    }
}