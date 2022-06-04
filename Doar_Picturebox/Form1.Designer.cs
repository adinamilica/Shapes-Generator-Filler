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
            this.number_of_figures = new System.Windows.Forms.TextBox();
            this.sf = new System.Windows.Forms.SaveFileDialog();
            this.dimensiune = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.coordonate_punct_clickat = new System.Windows.Forms.Label();
            this.bitmap_after_click = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.verificare_event = new System.Windows.Forms.Label();
            this.ultimul_point = new System.Windows.Forms.Label();
            this.Portiune = new System.Windows.Forms.Label();
            this.Blue_color = new System.Windows.Forms.Label();
            this.Red_color = new System.Windows.Forms.Label();
            this.Green_color = new System.Windows.Forms.Label();
            this.C_total = new System.Windows.Forms.Label();
            this.M_total = new System.Windows.Forms.Label();
            this.Y_total = new System.Windows.Forms.Label();
            this.K_total = new System.Windows.Forms.Label();
            this.pixeli_totali = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.Tablou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomFiguresGenerator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SavePainting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomSelectedShapesRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrushColor)).BeginInit();
            this.SuspendLayout();
            // 
            // Tablou
            // 
            this.Tablou.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tablou.Location = new System.Drawing.Point(37, 67);
            this.Tablou.Name = "Tablou";
            this.Tablou.Size = new System.Drawing.Size(500, 500);
            this.Tablou.TabIndex = 0;
            this.Tablou.TabStop = false;
            this.Tablou.Click += new System.EventHandler(this.Tablou_Click);
            // 
            // number_of_figures
            // 
            this.number_of_figures.BackColor = System.Drawing.Color.WhiteSmoke;
            this.number_of_figures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.number_of_figures.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_of_figures.Location = new System.Drawing.Point(1198, 86);
            this.number_of_figures.Name = "number_of_figures";
            this.number_of_figures.Size = new System.Drawing.Size(100, 25);
            this.number_of_figures.TabIndex = 2;
            // 
            // dimensiune
            // 
            this.dimensiune.AutoSize = true;
            this.dimensiune.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dimensiune.Location = new System.Drawing.Point(751, 509);
            this.dimensiune.Name = "dimensiune";
            this.dimensiune.Size = new System.Drawing.Size(181, 20);
            this.dimensiune.TabIndex = 6;
            this.dimensiune.Text = "max size of bitmap data";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1099, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 65);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of random shapes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coordonate_punct_clickat
            // 
            this.coordonate_punct_clickat.AutoSize = true;
            this.coordonate_punct_clickat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coordonate_punct_clickat.Location = new System.Drawing.Point(752, 439);
            this.coordonate_punct_clickat.Name = "coordonate_punct_clickat";
            this.coordonate_punct_clickat.Size = new System.Drawing.Size(203, 20);
            this.coordonate_punct_clickat.TabIndex = 9;
            this.coordonate_punct_clickat.Text = "coordonate punc selectat";
            // 
            // bitmap_after_click
            // 
            this.bitmap_after_click.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bitmap_after_click.Location = new System.Drawing.Point(750, 389);
            this.bitmap_after_click.Name = "bitmap_after_click";
            this.bitmap_after_click.Size = new System.Drawing.Size(179, 40);
            this.bitmap_after_click.TabIndex = 10;
            this.bitmap_after_click.Text = "The bitmap after click";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(579, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Color of pixel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(579, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Coordinates of pixel:";
            // 
            // verificare_event
            // 
            this.verificare_event.AutoSize = true;
            this.verificare_event.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verificare_event.Location = new System.Drawing.Point(762, 567);
            this.verificare_event.Name = "verificare_event";
            this.verificare_event.Size = new System.Drawing.Size(132, 20);
            this.verificare_event.TabIndex = 13;
            this.verificare_event.Text = "verificare_event";
            // 
            // ultimul_point
            // 
            this.ultimul_point.AutoSize = true;
            this.ultimul_point.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ultimul_point.Location = new System.Drawing.Point(583, 509);
            this.ultimul_point.Name = "ultimul_point";
            this.ultimul_point.Size = new System.Drawing.Size(53, 20);
            this.ultimul_point.TabIndex = 14;
            this.ultimul_point.Text = "label4";
            // 
            // Portiune
            // 
            this.Portiune.AutoSize = true;
            this.Portiune.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Portiune.Location = new System.Drawing.Point(590, 76);
            this.Portiune.Name = "Portiune";
            this.Portiune.Size = new System.Drawing.Size(172, 20);
            this.Portiune.TabIndex = 15;
            this.Portiune.Text = "Numarul de pixeli este ";
            // 
            // Blue_color
            // 
            this.Blue_color.AutoSize = true;
            this.Blue_color.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Blue_color.Location = new System.Drawing.Point(795, 166);
            this.Blue_color.Name = "Blue_color";
            this.Blue_color.Size = new System.Drawing.Size(41, 20);
            this.Blue_color.TabIndex = 16;
            this.Blue_color.Text = "blue";
            // 
            // Red_color
            // 
            this.Red_color.AutoSize = true;
            this.Red_color.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Red_color.Location = new System.Drawing.Point(590, 166);
            this.Red_color.Name = "Red_color";
            this.Red_color.Size = new System.Drawing.Size(34, 20);
            this.Red_color.TabIndex = 17;
            this.Red_color.Text = "red";
            // 
            // Green_color
            // 
            this.Green_color.AutoSize = true;
            this.Green_color.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Green_color.Location = new System.Drawing.Point(680, 166);
            this.Green_color.Name = "Green_color";
            this.Green_color.Size = new System.Drawing.Size(53, 20);
            this.Green_color.TabIndex = 18;
            this.Green_color.Text = "green";
            // 
            // C_total
            // 
            this.C_total.AutoSize = true;
            this.C_total.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C_total.Location = new System.Drawing.Point(590, 204);
            this.C_total.Name = "C_total";
            this.C_total.Size = new System.Drawing.Size(17, 20);
            this.C_total.TabIndex = 19;
            this.C_total.Text = "0";
            // 
            // M_total
            // 
            this.M_total.AutoSize = true;
            this.M_total.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.M_total.Location = new System.Drawing.Point(590, 234);
            this.M_total.Name = "M_total";
            this.M_total.Size = new System.Drawing.Size(17, 20);
            this.M_total.TabIndex = 20;
            this.M_total.Text = "0";
            // 
            // Y_total
            // 
            this.Y_total.AutoSize = true;
            this.Y_total.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Y_total.Location = new System.Drawing.Point(695, 204);
            this.Y_total.Name = "Y_total";
            this.Y_total.Size = new System.Drawing.Size(17, 20);
            this.Y_total.TabIndex = 21;
            this.Y_total.Text = "0";
            // 
            // K_total
            // 
            this.K_total.AutoSize = true;
            this.K_total.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.K_total.Location = new System.Drawing.Point(695, 234);
            this.K_total.Name = "K_total";
            this.K_total.Size = new System.Drawing.Size(17, 20);
            this.K_total.TabIndex = 22;
            this.K_total.Text = "0";
            // 
            // pixeli_totali
            // 
            this.pixeli_totali.AutoSize = true;
            this.pixeli_totali.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pixeli_totali.Location = new System.Drawing.Point(590, 112);
            this.pixeli_totali.Name = "pixeli_totali";
            this.pixeli_totali.Size = new System.Drawing.Size(17, 20);
            this.pixeli_totali.TabIndex = 23;
            this.pixeli_totali.Text = "0";
            // 
            // RandomFiguresGenerator
            // 
            this.RandomFiguresGenerator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RandomFiguresGenerator.Image = global::Doar_Picturebox.Properties.Resources.random;
            this.RandomFiguresGenerator.Location = new System.Drawing.Point(1321, 67);
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
            this.SavePainting.Location = new System.Drawing.Point(1112, 349);
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
            this.label4.Location = new System.Drawing.Point(1099, 412);
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
            this.PrintPicture.Location = new System.Drawing.Point(1321, 349);
            this.PrintPicture.Name = "PrintPicture";
            this.PrintPicture.Size = new System.Drawing.Size(60, 60);
            this.PrintPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PrintPicture.TabIndex = 27;
            this.PrintPicture.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1324, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 36);
            this.label5.TabIndex = 28;
            this.label5.Text = "Print";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RandomSelectedShapesRun
            // 
            this.RandomSelectedShapesRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RandomSelectedShapesRun.Image = global::Doar_Picturebox.Properties.Resources.istockphoto_1295474183_612x612;
            this.RandomSelectedShapesRun.Location = new System.Drawing.Point(1321, 221);
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
            this.label6.Location = new System.Drawing.Point(1099, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 65);
            this.label6.TabIndex = 30;
            this.label6.Text = "Number of selected shapes";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // number_selected_shapes
            // 
            this.number_selected_shapes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.number_selected_shapes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.number_selected_shapes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_selected_shapes.Location = new System.Drawing.Point(1198, 240);
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
            this.comboBox1.Location = new System.Drawing.Point(1148, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 29);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.Text = "Select a shape...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BackgroundColor
            // 
            this.BackgroundColor.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundColor.Location = new System.Drawing.Point(1216, 349);
            this.BackgroundColor.Name = "BackgroundColor";
            this.BackgroundColor.Size = new System.Drawing.Size(60, 60);
            this.BackgroundColor.TabIndex = 33;
            this.BackgroundColor.TabStop = false;
            this.BackgroundColor.Click += new System.EventHandler(this.BackgroundColor_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1193, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 64);
            this.label7.TabIndex = 34;
            this.label7.Text = "Background Color";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BrushColor
            // 
            this.BrushColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BrushColor.Location = new System.Drawing.Point(1216, 507);
            this.BrushColor.Name = "BrushColor";
            this.BrushColor.Size = new System.Drawing.Size(60, 60);
            this.BrushColor.TabIndex = 35;
            this.BrushColor.TabStop = false;
            this.BrushColor.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1193, 570);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 37);
            this.label8.TabIndex = 36;
            this.label8.Text = "Brush Color";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 730);
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
            this.Controls.Add(this.pixeli_totali);
            this.Controls.Add(this.K_total);
            this.Controls.Add(this.Y_total);
            this.Controls.Add(this.M_total);
            this.Controls.Add(this.C_total);
            this.Controls.Add(this.Green_color);
            this.Controls.Add(this.Red_color);
            this.Controls.Add(this.Blue_color);
            this.Controls.Add(this.Portiune);
            this.Controls.Add(this.ultimul_point);
            this.Controls.Add(this.verificare_event);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bitmap_after_click);
            this.Controls.Add(this.coordonate_punct_clickat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dimensiune);
            this.Controls.Add(this.number_of_figures);
            this.Controls.Add(this.Tablou);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Tablou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomFiguresGenerator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SavePainting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomSelectedShapesRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrushColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Tablou;
        private TextBox number_of_figures;
        private SaveFileDialog sf;
        private Label dimensiune;
        private Label label1;
        private Label coordonate_punct_clickat;
        private Label bitmap_after_click;
        private Label label2;
        private Label label3;
        private Label verificare_event;
        private Label ultimul_point;
        private Label Portiune;
        private Label Blue_color;
        private Label Red_color;
        private Label Green_color;
        private Label C_total;
        private Label M_total;
        private Label Y_total;
        private Label K_total;
        private Label pixeli_totali;
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
    }
}