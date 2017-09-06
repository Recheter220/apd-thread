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

        Bitmap[] mj;
        Bitmap[] neil;
        Bitmap moon;

        public Bitmap GetImage(string prefixoComExtensao, int? indice)
        {
            if (string.IsNullOrEmpty(indice.ToString()))
            {
                return (Bitmap)Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\resources\" + prefixoComExtensao);
            }
            else
            {
                return (Bitmap)Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\resources\" + prefixoComExtensao + indice + ".png");
            }
        }

        public void Moonwalk()
        {
            try
            {
                foreach (DataGridViewRow rw in dgvRender.Rows)
                {
                    int i = Convert.ToInt32(dgvRender.Rows[rw.Index].Cells["dgv_colMj"].Value);
                    if (i >= 1 && i <= 13)
                    {
                        pnlGif.Invoke((Action)delegate
                        {
                            pcbMJ.Image = mj[i - 1];
                            pcbMJ.Location = new Point(pcbLua.Width - (15 * rw.Index), pcbMJ.Location.Y);
                            pcbMJ.Refresh();
                        });
                    }
                    Thread.Sleep(66);
                }
            }
            catch (Exception mess)
            {
                MessageBox.Show(mess.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Pushups()
        {
            try
            {
                foreach (DataGridViewRow rw in dgvRender.Rows)
                {
                    int i = Convert.ToInt32(dgvRender.Rows[rw.Index].Cells["dgv_colNeil"].Value);
                    if (i >= 1 && i <= 6)
                    {
                        pnlGif.Invoke((Action)delegate
                        {
                            pcbNeil.Image = neil[i - 1];
                            pcbNeil.Refresh();
                            //Thread.Sleep(66);
                        });
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
            mj = new Bitmap[13];
            for (int indice = 1; indice <= 13; indice++)
            {
                mj[indice - 1] = GetImage("mwk", indice);
            }

            neil = new Bitmap[6];
            for (int indice = 1; indice <= 6; indice++)
            {
                neil[indice - 1] = GetImage("armstr", indice);
            }

            moon = GetImage("moon.jpg", null);

            int posX = pcbLua.Width;
            int frame = 1;
            int row = 0;
            while (posX > 0 - pcbMJ.Width)
            {
                dgvRender.Rows.Add();
                dgvRender.Rows[row].Cells["dgv_colMj"].Value = frame;
                row++;
                posX -= 15;
                if (frame < 13)
                    frame++;
                else
                    frame = 1;
            }
            for (frame = 1; frame <= 6; frame++)
            {
                dgvRender.Rows[frame - 1].Cells["dgv_colNeil"].Value = frame;
            }

            pcbLua.Image = moon;
            pcbLua.SizeMode = PictureBoxSizeMode.StretchImage;

            pcbMJ.Image = mj[0];
            pcbMJ.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbMJ.BackColor = Color.Transparent;
            pcbMJ.Parent = pcbLua;
            pcbMJ.Anchor = AnchorStyles.Right;
            pcbMJ.Location = new Point(pcbLua.Width, pcbLua.Height - 320);

            pcbNeil.Image = neil[0];
            pcbNeil.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbNeil.BackColor = Color.Transparent;
            pcbNeil.Parent = pcbLua;
            pcbNeil.Location = new Point(((pcbLua.Width / 2) - (pcbNeil.Width / 2)), pcbLua.Height - 150);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //pcbLua.Image = null;
            pcbMJ.Image = null;
            pcbMJ.Location = new Point(pcbLua.Width, pcbLua.Height - 320);
            pcbMJ.Refresh();

            pcbNeil.Image = null;
            pcbNeil.Location = new Point(((pcbLua.Width / 2) - (pcbNeil.Width / 2)), pcbLua.Height - 150);
            pcbNeil.Refresh();

            Parallel.Invoke(
                new Action(() => { Moonwalk(); }),
                new Action(() => { Pushups(); })
            );

        }

        private void pcbLua_Click(object sender, EventArgs e)
        {

        }

        private void dgvRender_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvRender_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvRender.Columns["dgv_colMj"].Index)
            {
                int posX = pcbLua.Width - (15 * e.RowIndex);
                int posY = pcbMJ.Location.Y;
                Point posicao = new Point(posX, posY);
                pcbMJ.Location = posicao;

                int frame = Convert.ToInt32(dgvRender.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (frame >= 1 && frame <= 13)
                    pcbMJ.Image = mj[frame - 1];
            }
            else if (e.ColumnIndex == dgvRender.Columns["dgv_colNeil"].Index)
            {
                if (e.ColumnIndex == dgvRender.Columns["dgv_colNeil"].Index)
                {
                    int frame = Convert.ToInt32(dgvRender.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    if (frame >= 1 && frame <= 6)
                        pcbNeil.Image = neil[frame - 1];
                }
            }
        }
    }
}

