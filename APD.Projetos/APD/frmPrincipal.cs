using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace APD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void Animacao1()
        {
            try
            {
                int i = 1;
                bool pos = true;
                while (true)
                {
                    Image img = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\resources\img_" + i + ".png");
                    this.Refresh();
                    PictureBox picBox = ((PictureBox)this.Controls.Find("pcbImagem1", true)[0]);
                    //picBox.Invoke((Action)delegate
                    pcbImagem1.Invoke((Action)delegate
                        {
                            pcbImagem1.Image = img;
                            Thread.Sleep(100);
                            this.Refresh();
                            this.DestroyHandle();
                        });
                    /*
                    pcbImagem2.Invoke((Action)delegate
                    {
                        pcbImagem2.Image = img;
                        Thread.Sleep(100);
                        this.Refresh();
                    });*/


                    if (pos)
                    {
                        if (i < 6)
                        {
                            i++;
                        }
                        else
                        {
                            pos = false;
                        }
                    }
                    else
                    {
                        if (i > 1)
                        {
                            i--;
                        }
                        else
                        {
                            pos = true;
                        }
                    }
                }
            }

            catch (Exception mess)
            {
                MessageBox.Show(mess.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Animacao2()
        {
            try
            {
                int i = 1;
                bool pos = true;
                for (i = 1; i <= 6; i++)
                {
                    Image img = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\resources\img2_" + i + ".png");
                    this.Refresh();
                    PictureBox picBox = ((PictureBox)this.Controls.Find("pcbImagem2", true)[0]);
                    pcbImagem2.Invoke((Action)delegate
                    {
                        pcbImagem2.Image = img;
                        Thread.Sleep(100);
                        this.Refresh();
                        this.DestroyHandle();
                    });
                }
            }

            catch (Exception mess)
            {
                MessageBox.Show(mess.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Animacao3()
        {
            try
            {
                int i = 1;
                bool pos = true;
                while (true)
                {
                    Image img = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\resources\img_" + i + ".png");
                    this.Refresh();
                    PictureBox picBox = ((PictureBox)this.Controls.Find("pcbImagem3", true)[0]);
                    picBox.Invoke((Action)delegate
                    {
                        picBox.Image = img;
                        Thread.Sleep(100);
                        this.Refresh();
                    });
                    if (pos)
                    {
                        if (i < 6)
                        {
                            i++;
                        }
                        else
                        {
                            pos = false;
                        }
                    }
                    else
                    {
                        if (i > 1)
                        {
                            i--;
                        }
                        else
                        {
                            pos = true;
                        }
                    }
                }
            }

            catch (Exception mess)
            {
                MessageBox.Show(mess.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            pcbImagem1.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbImagem2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbImagem3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            pcbImagem1.Image = null;
            pcbImagem2.Image = null;
            pcbImagem3.Image = null;

            //// Setup the cancellation mechanism.
            //var cts = new CancellationTokenSource();
            //var po = new ParallelOptions();
            //po.CancellationToken = cts.Token;

            //Parallel.Invoke(po() => {
            //    new Action(() => { Animacao1(); })
            //        });

            //);
            Parallel.Invoke(
                new Action(() => { Animacao1(); }),
                new Action(() => { Animacao2(); })//,
                //new Action(() => { Animacao3(); })
            );

        }
    }
}

