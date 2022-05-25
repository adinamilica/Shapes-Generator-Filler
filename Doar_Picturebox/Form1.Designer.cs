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
            this.button2 = new System.Windows.Forms.Button();
            this.bitmap_text = new System.Windows.Forms.Label();
            this.sf = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.dimensiune = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.button1.Location = new System.Drawing.Point(1042, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "rendereaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // number_of_figures
            // 
            this.number_of_figures.Location = new System.Drawing.Point(1042, 92);
            this.number_of_figures.Name = "number_of_figures";
            this.number_of_figures.Size = new System.Drawing.Size(180, 27);
            this.number_of_figures.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1042, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 87);
            this.button2.TabIndex = 3;
            this.button2.Text = "verifica ceva";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bitmap_text
            // 
            this.bitmap_text.Font = new System.Drawing.Font("Segoe UI", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bitmap_text.Location = new System.Drawing.Point(582, 9);
            this.bitmap_text.Name = "bitmap_text";
            this.bitmap_text.Size = new System.Drawing.Size(390, 607);
            this.bitmap_text.TabIndex = 4;
            this.bitmap_text.Text = "The bitmap";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1042, 371);
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
            this.dimensiune.Location = new System.Drawing.Point(1052, 486);
            this.dimensiune.Name = "dimensiune";
            this.dimensiune.Size = new System.Drawing.Size(170, 20);
            this.dimensiune.TabIndex = 6;
            this.dimensiune.Text = "max size of bitmap data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1043, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of random shapes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 655);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dimensiune);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bitmap_text);
            this.Controls.Add(this.button2);
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
        private Button button2;
        private Label bitmap_text;
        private SaveFileDialog sf;
        private Button button3;
        private Label dimensiune;
        private Label label1;
    }
}