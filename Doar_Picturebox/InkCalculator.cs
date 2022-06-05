using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doar_Picturebox
{
    public partial class InkCalculator : Form
    {
        public string file_path = @"C:\Users\Adina Milica\Desktop\tot momentan\oop s2\Shapes-Generator-Filler\Doar_Picturebox\figuri\";
       // public string file_path = @"../../../figuri/";
        public InkCalculator()
        {
            InitializeComponent();
        }

        public double max_color(double R_derivat, double G_derivat, double B_derivat)
        {
            if (R_derivat >= G_derivat && R_derivat >= B_derivat)
                return R_derivat;

            else if (G_derivat >= R_derivat && G_derivat >= B_derivat)
                return G_derivat;

            else return B_derivat;
        }
        private void CalculatorAndPrinter_Click(object sender, EventArgs e)
        {
            

            Bitmap bmp = new Bitmap(file_path + "figura.bmp");

            double suprafata = (double)(double.Parse(ScaledWidth.Text) * double.Parse(ScaledHeight.Text)/((double)(bmp.Width * bmp.Height * 100)));
            double consum_cerneala_peCM = double.Parse(inkCons.Text);

            double cT = (double)((double) suprafata / (double) consum_cerneala_peCM);
            double cTc = 0, cTm = 0, cTy = 0, cTk = 0;

            for (int i=0;i<bmp.Width; i++)
                for(int j=0;j<bmp.Height; j++)
                {
                    Color culoare = bmp.GetPixel(i,j);

                    // identificarea culorilor RGB
                    
                    int red = culoare.R;
                    int green = culoare.G;
                    int blue = culoare.B;

                    //derivatele

                    
                    double red_derivat = (double)((double)red / (double)255);
                    double green_derivat = (double)((double)green / (double)255);
                    double blue_derivat = (double)((double)blue / (double)255);

                    //cmyk

                    double K = (double)(1 - max_color(red_derivat, green_derivat, red_derivat));
                    double C = (double)((double)(1 - red_derivat - K) / (double)(1 - K));
                    double M = (double)((double)(1 - green_derivat - K) / (double)(1 - K));
                    double Y = (double)((double)(1 - blue_derivat - K) / (double)(1 - K));
                    

                    double cC = (double)((double)((double)cT * (double)C) / (double)(C + M + Y + K));
                    double cM = (double)((double)((double)cT * (double)M) / (double)(C + M + Y + K));
                    double cY = (double)((double)((double)cT * (double)Y) / (double)(C + M + Y + K));
                    double cK = (double)((double)((double)cT * (double)K) / (double)(C + M + Y + K));

                    cTc = cTc + cC;
                   
                    cTm = cTm + cM;
                    
                    cTy = cTy + cY;
                   
                    cTk = cTk + cK;
                    
                }


            cInk.Text = cTc.ToString();
            mInk.Text = cTm.ToString();
            yInk.Text = cTy.ToString();
            kInk.Text = cTk.ToString();


            
        }
    }
}
