using System.Drawing.Imaging;

namespace Doar_Picturebox
{
    public partial class Form1 : Form
    {
        public string selected_shape="0";

        public Color background_color = Color.LightGray;

        public Color brush_color = Color.Red;

        public Color fill_color = Color.Purple;
       

        public Form1()
        {
            InitializeComponent();
        }

        

        void deseneaza()
        {
            using (Graphics g = Graphics.FromImage(Tablou.Image))
            {
                g.Clear(background_color);
               
            }

            int nr_figuri = Convert.ToInt32(number_of_figures.Text);

            for (int i = 1; i <= nr_figuri; i++)
            {
                Random figure = new Random();
                int figure_id = figure.Next(1, 5);

                if (figure_id == 1)
                {
                    // draw rectangle

                    Random r1 = new Random(); int r1_x = r1.Next(0, 500);
                    Random r2 = new Random(); int r2_y = r2.Next(0, 500);

                    Random r3 = new Random(); int r3_width = r3.Next(20, 500);
                    Random r4 = new Random(); int r4_height = r4.Next(20, 500);



                    Rectangle r = new Rectangle(r1_x, r2_y, r3_width, r4_height);

                    using (Graphics g = Graphics.FromImage(Tablou.Image))
                    {
                        g.DrawRectangle(new Pen(Color.Red, 4), r);
                    }

                }

                else if (figure_id == 2)
                {
                    //draw triangle
                    Random r1 = new Random(); int r1_x = r1.Next(0, 500);
                    Random r2 = new Random(); int r2_y = r2.Next(0, 500);

                    Random r3 = new Random(); int r3_x = r3.Next(0, 500);
                    Random r4 = new Random(); int r4_y = r4.Next(0, 500);

                    Random r5 = new Random(); int r5_x = r5.Next(0, 500);
                    Random r6 = new Random(); int r6_y = r6.Next(0, 500);



                    Point[] Triangle_points = new Point[] { new Point { X = r1_x, Y = r2_y }, new Point { X = r3_x, Y = r4_y }, new Point { X = r5_x, Y = r6_y } };

                    using (Graphics g = Graphics.FromImage(Tablou.Image))
                    {
                        g.DrawPolygon(new Pen(Color.Red, 4), Triangle_points);
                    }

                }

                else if (figure_id == 3)
                {
                    //draw line
                    Random r1 = new Random(); int r1_x = r1.Next(0, 500);
                    Random r2 = new Random(); int r2_y = r2.Next(0, 500);

                    Random r3 = new Random(); int r3_x = r3.Next(0, 500);
                    Random r4 = new Random(); int r4_y = r4.Next(0, 500);

                    Point p1 = new Point(r1_x, r2_y);
                    Point p2 = new Point(r3_x, r4_y);

                    using (Graphics g = Graphics.FromImage(Tablou.Image))
                    {
                        g.DrawLine(new Pen(Color.Red, 4), p1, p2);
                    }
                }

                else if (figure_id == 4)
                {
                    //draw Bezier curve
                    Random r1 = new Random(); int r1_x = r1.Next(0, 500);
                    Random r2 = new Random(); int r2_y = r2.Next(0, 500);

                    Random r3 = new Random(); int r3_x = r3.Next(0, 500);
                    Random r4 = new Random(); int r4_y = r4.Next(0, 500);

                    Random r5 = new Random(); int r5_x = r5.Next(0, 500);
                    Random r6 = new Random(); int r6_y = r6.Next(0, 500);

                    Random r7 = new Random(); int r7_x = r7.Next(0, 500);
                    Random r8 = new Random(); int r8_y = r8.Next(0, 500);



                    Point p1 = new Point(r1_x, r2_y);
                    Point p2 = new Point(r3_x, r4_y);
                    Point p3 = new Point(r5_x, r6_y);
                    Point p4 = new Point(r7_x, r8_y);

                    using (Graphics g = Graphics.FromImage(Tablou.Image))
                    {
                        g.DrawBezier(new Pen(Color.Red, 4), p1, p2, p3, p4);
                    }
                }

                else
                {
                    //draw elipse

                    Random r1 = new Random(); int r1_x = r1.Next(0, 500);
                    Random r2 = new Random(); int r2_y = r2.Next(0, 500);

                    Random r3 = new Random(); int r3_width = r3.Next(20, 500);
                    Random r4 = new Random(); int r4_height = r4.Next(20, 500);

                    using (Graphics g = Graphics.FromImage(Tablou.Image))
                    {
                        g.DrawEllipse(new Pen(Color.Red, 4), r1_x, r2_y, r3_width, r4_height);
                    }
                }

            }

        }


        

       

        byte[] BitmapData_Din_Bitmap(Bitmap bmp)
        {
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Bmp);
            return (ms.GetBuffer());
        }

        void set_color(byte[] sir_biti, int rezO, Color col, int l, int c)
        {
            sir_biti[54 + 4 * c + 4 * l * rezO] = col.R;
            sir_biti[54 + 4 * c + 4 * l * rezO + 1] = col.G;
            sir_biti[54 + 4 * c + 4 * l * rezO + 2] = col.B;
            sir_biti[54 + 4 * c + 4 * l * rezO + 3] = col.A;
        }

        Bitmap Bitmap_Din_BitmapData(byte[] bmpData)
        {
            MemoryStream ms = new MemoryStream(bmpData);
            return (new Bitmap(ms));
        }

        private void Tablou_Click(object sender, EventArgs e)
        {
            var mouseEventArgs = e as MouseEventArgs;

            int x = mouseEventArgs.X;
            int y = mouseEventArgs.Y;

            Bitmap bmp;

            if (File.Exists(@"C:\Users\Adina Milica\Desktop\tot momentan\oop s2\Shapes-Generator-Filler\Doar_Picturebox\figuri\figura.bmp"))
            { 
                bmp = new Bitmap(@"C:\Users\Adina Milica\Desktop\tot momentan\oop s2\Shapes-Generator-Filler\Doar_Picturebox\figuri\figura.bmp");
                dimensiune.Text = "DA, EXISTA FILEUL";
            }
            else { 
                bmp = new Bitmap(Tablou.Width, Tablou.Height);

                dimensiune.Text = "NU, NU EXISTA FILEUL";
            }


            Point pt = new Point(x, y);

            

            Color targetColor = bmp.GetPixel(x, y);
            Color replacementColor = Color.Purple;


            if (targetColor.ToArgb().Equals(replacementColor.ToArgb()))
            {
                return;

            }
            else
                FloodFillPrint(bmp, pt, Color.Purple, 0);

            //afisare

            Graphics g = Graphics.FromImage(bmp);
            Tablou.Image = bmp.Clone(new Rectangle(0, 0, 500, 500), System.Drawing.Imaging.PixelFormat.DontCare);
            g.DrawImage(bmp, 0, 0);


            Tablou.Image.Save(@"C:\Users\Adina Milica\Desktop\tot momentan\oop s2\Shapes-Generator-Filler\Doar_Picturebox\figuri\figura_tmp.bmp");

            bmp.Dispose();

            bmp = null;

            Tablou.Image.Dispose();

            Tablou.Image = null;

           

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

            try { 
            File.Delete(@"C:\Users\Adina Milica\Desktop\tot momentan\oop s2\Shapes-Generator-Filler\Doar_Picturebox\figuri\figura.bmp");
            }

            catch
            {
               
                Tablou.Image = bmp;
            }

            System.IO.File.Move(@"C:\Users\Adina Milica\Desktop\tot momentan\oop s2\Shapes-Generator-Filler\Doar_Picturebox\figuri\figura_tmp.bmp",
                                @"C:\Users\Adina Milica\Desktop\tot momentan\oop s2\Shapes-Generator-Filler\Doar_Picturebox\figuri\figura.bmp");

             bmp = new Bitmap(@"C:\Users\Adina Milica\Desktop\tot momentan\oop s2\Shapes-Generator-Filler\Doar_Picturebox\figuri\figura.bmp");

             Tablou.Image = bmp;
        }

       

        public double max_color(double R_derivat, double G_derivat, double B_derivat)
        {
            if(R_derivat >= G_derivat && R_derivat>=B_derivat)
            return R_derivat;

            else if(G_derivat >= R_derivat && G_derivat >= B_derivat)
            return G_derivat;

            else return B_derivat;
        }
        public void printColors(int nr_pixeli, Color culoare_pusa, int lungime, int latime)
        {
            Portiune.Text = nr_pixeli.ToString();
            double procent = (double)((double)nr_pixeli/(double)(Tablou.Width * Tablou.Height));
            double suprafata =(double)( (double)((double)lungime * (double)latime * (double)procent) /(double) 100);

            int blue = culoare_pusa.B;
            int red = culoare_pusa.R;
            int green = culoare_pusa.G;

            Blue_color.Text = blue.ToString();
            Red_color.Text = red.ToString();
            Green_color.Text = green.ToString();

            double green_derivat = (double)((double)green /(double)255);
            double red_derivat = (double) ((double) red / (double)255);
            double blue_derivat = (double)((double)blue / (double)255);

            double K = (double)(1 - max_color(red_derivat, green_derivat, red_derivat));
            double C = (double)((double)(1 - red_derivat - K) / (double)(1-K));
            double M = (double)((double)(1- green_derivat - K) /(double)(1-K));
            double Y = (double)((double)(1-blue_derivat - K) / (double)(1-K));

            int consum_cerneala_peCM = 2;
            double cT = (double)( (double)suprafata / (double)consum_cerneala_peCM );

            double cC = (double)((double)((double)cT * (double)C) / (double)(C + M + Y + K));
            double cM = (double)((double)((double)cT * (double)M) / (double)(C + M + Y + K));
            double cY = (double)((double)((double)cT * (double)Y) / (double)(C + M + Y + K));
            double cK = (double)((double)((double)cT * (double)K) / (double)(C + M + Y + K));

            
            double cTc = double.Parse(C_total.Text);
            cTc = cTc + cC;
            C_total.Text = cTc.ToString();

            double cTm = double.Parse(M_total.Text);
            cTm = cTm + cM;
            M_total.Text = cTm.ToString();

            double cTy = double.Parse(Y_total.Text);
            cTy = cTy + cY;
            Y_total.Text = cTy.ToString();

            double cTk = double.Parse(K_total.Text);
            cTk = cTk + cK;
            K_total.Text = cTk.ToString();

            double nr_pixeli_total = double.Parse(pixeli_totali.Text);
            nr_pixeli_total = nr_pixeli_total + nr_pixeli;
            pixeli_totali.Text = nr_pixeli_total.ToString();

        }

        
        public void FloodFillPrint(Bitmap bmp, Point pt, Color replacementColor, int nr_pixeli)
        {
           Color targetColor = bmp.GetPixel(pt.X, pt.Y);

            

            Stack<Point> pixels = new Stack<Point>();

            pixels.Push(pt);
            while (pixels.Count != 0)
            {
                Point temp = pixels.Pop();
                int y1 = temp.Y;

                while (y1 >= 0 && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    y1--;
                }

                y1++;

                bool spanLeft = false;
                bool spanRight = false;

                while (y1 < bmp.Height && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    bmp.SetPixel(temp.X, y1, replacementColor);

                    if (!spanLeft && temp.X > 0 && bmp.GetPixel(temp.X - 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X - 1, y1));
                        nr_pixeli++;

                        spanLeft = true;
                    }


                    else if (spanLeft && temp.X - 1 == 0 && bmp.GetPixel(temp.X - 1, y1) != targetColor)
                    {
                        spanLeft = false;
                    }


                    if (!spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X + 1, y1));
                        nr_pixeli++;

                        spanRight = true;
                    }


                    else if (spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) != targetColor)
                    {
                        spanRight = false;
                    }


                    y1++;
                }

            }

            //Tablou.Refresh();

            
            printColors(nr_pixeli,replacementColor, 100,100);

        }

        public void FloodFill(Bitmap bmp, Point pt, Color replacementColor)
        {
            Color targetColor = bmp.GetPixel(pt.X, pt.Y);

            if (targetColor.ToArgb().Equals(replacementColor.ToArgb()))
            {
                return;

            }

            Stack<Point> pixels = new Stack<Point>();

            pixels.Push(pt);
            while (pixels.Count != 0)
            {
                Point temp = pixels.Pop();
                int y1 = temp.Y;

                while (y1 >= 0 && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    y1--;
                }

                y1++;

                bool spanLeft = false;
                bool spanRight = false;

                while (y1 < bmp.Height && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    bmp.SetPixel(temp.X, y1, replacementColor);

                    if (!spanLeft && temp.X > 0 && bmp.GetPixel(temp.X - 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X - 1, y1));

                        spanLeft = true;
                    }


                    else if (spanLeft && temp.X - 1 == 0 && bmp.GetPixel(temp.X - 1, y1) != targetColor)
                    {
                        spanLeft = false;
                    }


                    if (!spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X + 1, y1));
                        spanRight = true;
                    }


                    else if (spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) != targetColor)
                    {
                        spanRight = false;
                    }


                    y1++;
                }

            }
            //Tablou.Refresh();

        }

        
        private void RandomShapesGenerator_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(Tablou.Width, Tablou.Height);

            // Tablou.BackColor = Color.LightGray;
            background_color = Color.LightGray;

            Tablou.Image = bmp;

            deseneaza();


        }

        private void SavePainting_Click(object sender, EventArgs e)
        {
            sf.DefaultExt = "bmp";
            sf.FileName = "figura.bmp";
            sf.Filter = "Bitmap Image (.bmp)|*.bmp";
            sf.FilterIndex = 1;
            sf.RestoreDirectory = true;
            sf.ShowDialog();


            Tablou.Image.Save(sf.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
        }

       public void draw_random_lines()
        {
            using (Graphics g = Graphics.FromImage(Tablou.Image))
            {
                background_color = BackgroundColor.BackColor;
                g.Clear(background_color);

            }

            int nr_figuri = Convert.ToInt32(number_selected_shapes.Text);

            for (int i = 1; i <= nr_figuri; i++)
            {
              
                //draw line
                Random r1 = new Random(); int r1_x = r1.Next(0, 500);
                Random r2 = new Random(); int r2_y = r2.Next(0, 500);

                Random r3 = new Random(); int r3_x = r3.Next(0, 500);
                Random r4 = new Random(); int r4_y = r4.Next(0, 500);

                Point p1 = new Point(r1_x, r2_y);
                Point p2 = new Point(r3_x, r4_y);

                using (Graphics g = Graphics.FromImage(Tablou.Image))
                {
                    g.DrawLine(new Pen(BrushColor.BackColor, 4), p1, p2);
                }

            }

        }

        public void draw_random_rectangles()
        {
            using (Graphics g = Graphics.FromImage(Tablou.Image))
            {
                background_color = BackgroundColor.BackColor;
                g.Clear(background_color);

            }

            int nr_figuri = Convert.ToInt32(number_selected_shapes.Text);

            for (int i = 1; i <= nr_figuri; i++)
            {


                Random r1 = new Random(); int r1_x = r1.Next(0, 500);
                Random r2 = new Random(); int r2_y = r2.Next(0, 500);

                Random r3 = new Random(); int r3_width = r3.Next(20, 500);
                Random r4 = new Random(); int r4_height = r4.Next(20, 500);



                Rectangle r = new Rectangle(r1_x, r2_y, r3_width, r4_height);

                using (Graphics g = Graphics.FromImage(Tablou.Image))
                {
                    g.DrawRectangle(new Pen(BrushColor.BackColor, 4), r);
                }

            }
        }

        public void draw_random_triangles()
        {
            using (Graphics g = Graphics.FromImage(Tablou.Image))
            {
                background_color = BackgroundColor.BackColor;
                g.Clear(background_color);

            }

            int nr_figuri = Convert.ToInt32(number_selected_shapes.Text);

            for (int i = 1; i <= nr_figuri; i++)
            {


                //draw triangle
                Random r1 = new Random(); int r1_x = r1.Next(0, 500);
                Random r2 = new Random(); int r2_y = r2.Next(0, 500);

                Random r3 = new Random(); int r3_x = r3.Next(0, 500);
                Random r4 = new Random(); int r4_y = r4.Next(0, 500);

                Random r5 = new Random(); int r5_x = r5.Next(0, 500);
                Random r6 = new Random(); int r6_y = r6.Next(0, 500);



                Point[] Triangle_points = new Point[] { new Point { X = r1_x, Y = r2_y }, new Point { X = r3_x, Y = r4_y }, new Point { X = r5_x, Y = r6_y } };

                using (Graphics g = Graphics.FromImage(Tablou.Image))
                {
                    g.DrawPolygon(new Pen(BrushColor.BackColor, 4), Triangle_points);
                }



            }
        }

        public void draw_random_beziers()
        {

            using (Graphics g = Graphics.FromImage(Tablou.Image))
            {
                background_color = BackgroundColor.BackColor;
                g.Clear(background_color);

            }

            int nr_figuri = Convert.ToInt32(number_selected_shapes.Text);

            for (int i = 1; i <= nr_figuri; i++)
            {

                //draw Bezier curve
                Random r1 = new Random(); int r1_x = r1.Next(0, 500);
                Random r2 = new Random(); int r2_y = r2.Next(0, 500);

                Random r3 = new Random(); int r3_x = r3.Next(0, 500);
                Random r4 = new Random(); int r4_y = r4.Next(0, 500);

                Random r5 = new Random(); int r5_x = r5.Next(0, 500);
                Random r6 = new Random(); int r6_y = r6.Next(0, 500);

                Random r7 = new Random(); int r7_x = r7.Next(0, 500);
                Random r8 = new Random(); int r8_y = r8.Next(0, 500);



                Point p1 = new Point(r1_x, r2_y);
                Point p2 = new Point(r3_x, r4_y);
                Point p3 = new Point(r5_x, r6_y);
                Point p4 = new Point(r7_x, r8_y);

                using (Graphics g = Graphics.FromImage(Tablou.Image))
                {
                    g.DrawBezier(new Pen(BrushColor.BackColor, 4), p1, p2, p3, p4);
                }

            }

        }

        public void draw_random_elipses()
        {

            using (Graphics g = Graphics.FromImage(Tablou.Image))
            {
                background_color = BackgroundColor.BackColor;
                g.Clear(background_color);

            }

            int nr_figuri = Convert.ToInt32(number_selected_shapes.Text);

            for (int i = 1; i <= nr_figuri; i++)
            {


                Random r1 = new Random(); int r1_x = r1.Next(0, 500);
                Random r2 = new Random(); int r2_y = r2.Next(0, 500);

                Random r3 = new Random(); int r3_width = r3.Next(20, 500);
                Random r4 = new Random(); int r4_height = r4.Next(20, 500);

                using (Graphics g = Graphics.FromImage(Tablou.Image))
                {
                    g.DrawEllipse(new Pen(BrushColor.BackColor, 4), r1_x, r2_y, r3_width, r4_height);
                }



            }

        }
        private void RandomSelectedShapesRun_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(Tablou.Width, Tablou.Height);

            // Tablou.BackColor = Color.LightGray;
            background_color = Color.LightGray;

            Tablou.Image = bmp;

                 if(selected_shape=="0")
                    draw_random_lines();

            else if (selected_shape == "1")
                    draw_random_triangles();

            else if (selected_shape=="2")
                    draw_random_rectangles();

            else if (selected_shape == "3")
                    draw_random_elipses();

            else
                    draw_random_beziers();

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_shape = comboBox1.SelectedIndex.ToString();
            
        }

        private void BackgroundColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                background_color= colorDialog1.Color;

                BackgroundColor.BackColor=background_color;

                

                Tablou.BackColor = background_color;


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                brush_color = colorDialog1.Color;

                BrushColor.BackColor = brush_color;

            }

        }
    }
}