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
            this.button1 = new System.Windows.Forms.Button();
            this.number_of_figures = new System.Windows.Forms.TextBox();
            this.sf = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.dimensiune = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Salveaza = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.Tablou)).BeginInit();
            this.SuspendLayout();
            // 
            // Tablou
            // 
            this.Tablou.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tablou.Location = new System.Drawing.Point(50, 50);
            this.Tablou.Name = "Tablou";
            this.Tablou.Size = new System.Drawing.Size(500, 500);
            this.Tablou.TabIndex = 0;
            this.Tablou.TabStop = false;
            this.Tablou.Click += new System.EventHandler(this.Tablou_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1134, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "rendereaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // number_of_figures
            // 
            this.number_of_figures.Location = new System.Drawing.Point(1134, 103);
            this.number_of_figures.Name = "number_of_figures";
            this.number_of_figures.Size = new System.Drawing.Size(180, 27);
            this.number_of_figures.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1134, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 71);
            this.button3.TabIndex = 5;
            this.button3.Text = "culoreaza punctul";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dimensiune
            // 
            this.dimensiune.AutoSize = true;
            this.dimensiune.Location = new System.Drawing.Point(1134, 448);
            this.dimensiune.Name = "dimensiune";
            this.dimensiune.Size = new System.Drawing.Size(170, 20);
            this.dimensiune.TabIndex = 6;
            this.dimensiune.Text = "max size of bitmap data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1135, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of random shapes";
            // 
            // Salveaza
            // 
            this.Salveaza.Location = new System.Drawing.Point(1177, 266);
            this.Salveaza.Name = "Salveaza";
            this.Salveaza.Size = new System.Drawing.Size(94, 29);
            this.Salveaza.TabIndex = 8;
            this.Salveaza.Text = "save";
            this.Salveaza.UseVisualStyleBackColor = true;
            this.Salveaza.Click += new System.EventHandler(this.Salveaza_Click);
            // 
            // coordonate_punct_clickat
            // 
            this.coordonate_punct_clickat.AutoSize = true;
            this.coordonate_punct_clickat.Location = new System.Drawing.Point(752, 439);
            this.coordonate_punct_clickat.Name = "coordonate_punct_clickat";
            this.coordonate_punct_clickat.Size = new System.Drawing.Size(177, 20);
            this.coordonate_punct_clickat.TabIndex = 9;
            this.coordonate_punct_clickat.Text = "coordonate punc selectat";
            // 
            // bitmap_after_click
            // 
            this.bitmap_after_click.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bitmap_after_click.Location = new System.Drawing.Point(750, 389);
            this.bitmap_after_click.Name = "bitmap_after_click";
            this.bitmap_after_click.Size = new System.Drawing.Size(179, 40);
            this.bitmap_after_click.TabIndex = 10;
            this.bitmap_after_click.Text = "The bitmap after click";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Color of pixel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Coordinates of pixel:";
            // 
            // verificare_event
            // 
            this.verificare_event.AutoSize = true;
            this.verificare_event.Location = new System.Drawing.Point(1145, 506);
            this.verificare_event.Name = "verificare_event";
            this.verificare_event.Size = new System.Drawing.Size(112, 20);
            this.verificare_event.TabIndex = 13;
            this.verificare_event.Text = "verificare_event";
            // 
            // ultimul_point
            // 
            this.ultimul_point.AutoSize = true;
            this.ultimul_point.Location = new System.Drawing.Point(583, 509);
            this.ultimul_point.Name = "ultimul_point";
            this.ultimul_point.Size = new System.Drawing.Size(50, 20);
            this.ultimul_point.TabIndex = 14;
            this.ultimul_point.Text = "label4";
            // 
            // Portiune
            // 
            this.Portiune.AutoSize = true;
            this.Portiune.Location = new System.Drawing.Point(660, 67);
            this.Portiune.Name = "Portiune";
            this.Portiune.Size = new System.Drawing.Size(162, 20);
            this.Portiune.TabIndex = 15;
            this.Portiune.Text = "Numarul de pixeli este ";
            // 
            // Blue_color
            // 
            this.Blue_color.AutoSize = true;
            this.Blue_color.Location = new System.Drawing.Point(865, 157);
            this.Blue_color.Name = "Blue_color";
            this.Blue_color.Size = new System.Drawing.Size(38, 20);
            this.Blue_color.TabIndex = 16;
            this.Blue_color.Text = "blue";
            // 
            // Red_color
            // 
            this.Red_color.AutoSize = true;
            this.Red_color.Location = new System.Drawing.Point(660, 157);
            this.Red_color.Name = "Red_color";
            this.Red_color.Size = new System.Drawing.Size(31, 20);
            this.Red_color.TabIndex = 17;
            this.Red_color.Text = "red";
            // 
            // Green_color
            // 
            this.Green_color.AutoSize = true;
            this.Green_color.Location = new System.Drawing.Point(750, 157);
            this.Green_color.Name = "Green_color";
            this.Green_color.Size = new System.Drawing.Size(47, 20);
            this.Green_color.TabIndex = 18;
            this.Green_color.Text = "green";
            // 
            // C_total
            // 
            this.C_total.AutoSize = true;
            this.C_total.Location = new System.Drawing.Point(660, 195);
            this.C_total.Name = "C_total";
            this.C_total.Size = new System.Drawing.Size(17, 20);
            this.C_total.TabIndex = 19;
            this.C_total.Text = "0";
            // 
            // M_total
            // 
            this.M_total.AutoSize = true;
            this.M_total.Location = new System.Drawing.Point(660, 225);
            this.M_total.Name = "M_total";
            this.M_total.Size = new System.Drawing.Size(17, 20);
            this.M_total.TabIndex = 20;
            this.M_total.Text = "0";
            // 
            // Y_total
            // 
            this.Y_total.AutoSize = true;
            this.Y_total.Location = new System.Drawing.Point(743, 195);
            this.Y_total.Name = "Y_total";
            this.Y_total.Size = new System.Drawing.Size(17, 20);
            this.Y_total.TabIndex = 21;
            this.Y_total.Text = "0";
            // 
            // K_total
            // 
            this.K_total.AutoSize = true;
            this.K_total.Location = new System.Drawing.Point(747, 225);
            this.K_total.Name = "K_total";
            this.K_total.Size = new System.Drawing.Size(17, 20);
            this.K_total.TabIndex = 22;
            this.K_total.Text = "0";
            // 
            // pixeli_totali
            // 
            this.pixeli_totali.AutoSize = true;
            this.pixeli_totali.Location = new System.Drawing.Point(660, 103);
            this.pixeli_totali.Name = "pixeli_totali";
            this.pixeli_totali.Size = new System.Drawing.Size(17, 20);
            this.pixeli_totali.TabIndex = 23;
            this.pixeli_totali.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 655);
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
            this.Controls.Add(this.Salveaza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dimensiune);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.number_of_figures);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tablou);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Tablou)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Tablou;
        private Button button1;
        private TextBox number_of_figures;
        private SaveFileDialog sf;
        private Button button3;
        private Label dimensiune;
        private Label label1;
        private Button Salveaza;
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
    }
}