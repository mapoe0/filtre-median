using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filtreMedian
{
    public partial class Form1 : Form
    {
        Bitmap imagesrc;
        Bitmap imageDestination;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imagesrc = new Bitmap(@"C:\HEI4IMS\image14.jpg");
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.Image = imagesrc;
        }

        private void btnNoirEtBlanc_Click(object sender, EventArgs e)
        {
            imageDestination = new Bitmap(pbImage.Image.Width, pbImage.Image.Height);

            for (int x = 0; x < pbImage.Image.Width; x++)
            {
                for (int y = 0; y < pbImage.Image.Height; y++)
                {
                    Color pixelColor = imagesrc.GetPixel(x, y);

                    int grey = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                    imageDestination.SetPixel(x, y, Color.FromArgb(grey, grey, grey));

                }
            }
            pbTraitement.Image = imageDestination;
            
        }
        private byte[] tri_a_bulle(byte[] b)
        {
            bool permut;
            do
            {
                permut = false;
                for (int i = 0; i < b.Length - 1; i++)
                {
                    if (b[i] > b[i + 1])
                    {
                        byte ai = b[i];
                        b[i] = b[i + 1];
                        b[i + 1] = ai;
                        permut = true;
                    }
                }

            } while (permut);

            return b;
        }

        private void btnFiltreMedian_Click(object sender, EventArgs e)
        {

            Bitmap bit = new Bitmap(pbImage.Image.Width, pbImage.Image.Height);
            Bitmap pb = imageDestination;
            if (pbTraintement2.Image != null)
            {
                pb = new Bitmap(pbTraintement2.Image);
            }
            for (int x = 1; x < (pbImage.Image.Width - 1); x++)
            {
                for (int y = 1; y < (pbImage.Image.Height - 1); y++)
                {
                    byte[,] mat = new byte[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                    for (int k = -1; k < 2; k++)
                    {
                        for (int n = -1; n < 2; n++)
                        {
                            Color pix = pb.GetPixel(x + k, y + n);
                            byte r = pix.R;
                            mat[k + 1, n + 1] = r;
                        }

                    }
                    byte[] neufPix = new byte[9];
                    neufPix[0] = mat[0, 0];
                    neufPix[1] = mat[0, 1];
                    neufPix[2] = mat[0, 2];

                    neufPix[3] = mat[1, 0];
                    neufPix[4] = mat[1, 1];
                    neufPix[5] = mat[1, 2];

                    neufPix[6] = mat[2, 0];
                    neufPix[7] = mat[2, 1];
                    neufPix[8] = mat[2, 2];

                    neufPix = tri_a_bulle(neufPix);

                    Color newColor = Color.FromArgb(neufPix[4], neufPix[4], neufPix[4]);
                    bit.SetPixel(x, y, newColor);
                }
                pbTraintement2.Image = bit;
            }
        }

        private void btnTriABulles_Click(object sender, EventArgs e)
        {
            // pour l'exemple
            byte[] neuf = new byte[] { 5, 6, 7, 6, 111, 8, 7, 8, 9 };
            neuf = tri_a_bulle(neuf);
            for (int i = 0; i < neuf.Length; i++)
            {
                Console.WriteLine(neuf[i].ToString());
            }
        }
    }
}
