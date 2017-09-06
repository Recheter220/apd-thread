namespace APD
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pcbLua = new System.Windows.Forms.PictureBox();
            this.pcbMJ = new System.Windows.Forms.PictureBox();
            this.pcbNeil = new System.Windows.Forms.PictureBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.pnlGif = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlDgv = new System.Windows.Forms.Panel();
            this.dgvRender = new System.Windows.Forms.DataGridView();
            this.dgv_colMj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_colNeil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNeil)).BeginInit();
            this.pnlGif.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.pnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRender)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbLua
            // 
            this.pcbLua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbLua.Location = new System.Drawing.Point(0, 0);
            this.pcbLua.Name = "pcbLua";
            this.pcbLua.Size = new System.Drawing.Size(401, 419);
            this.pcbLua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLua.TabIndex = 0;
            this.pcbLua.TabStop = false;
            this.pcbLua.Click += new System.EventHandler(this.pcbLua_Click);
            // 
            // pcbMJ
            // 
            this.pcbMJ.Location = new System.Drawing.Point(42, 27);
            this.pcbMJ.Name = "pcbMJ";
            this.pcbMJ.Size = new System.Drawing.Size(150, 150);
            this.pcbMJ.TabIndex = 1;
            this.pcbMJ.TabStop = false;
            // 
            // pcbNeil
            // 
            this.pcbNeil.Location = new System.Drawing.Point(64, 194);
            this.pcbNeil.Name = "pcbNeil";
            this.pcbNeil.Size = new System.Drawing.Size(108, 111);
            this.pcbNeil.TabIndex = 2;
            this.pcbNeil.TabStop = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(12, 8);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(383, 62);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "EU ENTENDI A REFERÊNCIA!";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // pnlGif
            // 
            this.pnlGif.Controls.Add(this.pcbMJ);
            this.pnlGif.Controls.Add(this.pcbNeil);
            this.pnlGif.Controls.Add(this.pcbLua);
            this.pnlGif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGif.Location = new System.Drawing.Point(0, 0);
            this.pnlGif.Name = "pnlGif";
            this.pnlGif.Size = new System.Drawing.Size(401, 419);
            this.pnlGif.TabIndex = 5;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.btnAtualizar);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 419);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(401, 78);
            this.pnlTitulo.TabIndex = 6;
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvRender);
            this.pnlDgv.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDgv.Location = new System.Drawing.Point(401, 0);
            this.pnlDgv.Name = "pnlDgv";
            this.pnlDgv.Size = new System.Drawing.Size(316, 497);
            this.pnlDgv.TabIndex = 3;
            // 
            // dgvRender
            // 
            this.dgvRender.AllowUserToAddRows = false;
            this.dgvRender.AllowUserToDeleteRows = false;
            this.dgvRender.AllowUserToResizeColumns = false;
            this.dgvRender.AllowUserToResizeRows = false;
            this.dgvRender.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvRender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRender.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_colMj,
            this.dgv_colNeil});
            this.dgvRender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRender.GridColor = System.Drawing.Color.White;
            this.dgvRender.Location = new System.Drawing.Point(0, 0);
            this.dgvRender.Name = "dgvRender";
            this.dgvRender.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRender.Size = new System.Drawing.Size(316, 497);
            this.dgvRender.TabIndex = 0;
            this.dgvRender.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRender_CellClick);
            this.dgvRender.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRender_CellDoubleClick);
            // 
            // dgv_colMj
            // 
            this.dgv_colMj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_colMj.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_colMj.HeaderText = "Michael Jackson";
            this.dgv_colMj.Name = "dgv_colMj";
            this.dgv_colMj.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_colMj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_colNeil
            // 
            this.dgv_colNeil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgv_colNeil.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_colNeil.HeaderText = "Neil";
            this.dgv_colNeil.Name = "dgv_colNeil";
            this.dgv_colNeil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_colNeil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 497);
            this.Controls.Add(this.pnlGif);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlDgv);
            this.Name = "Form1";
            this.Text = "Neil the Tiger getting his arm strong while Michael Jackson moonwalks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNeil)).EndInit();
            this.pnlGif.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLua;
        private System.Windows.Forms.PictureBox pcbMJ;
        private System.Windows.Forms.PictureBox pcbNeil;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Panel pnlGif;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlDgv;
        private System.Windows.Forms.DataGridView dgvRender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_colMj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_colNeil;
    }
}

