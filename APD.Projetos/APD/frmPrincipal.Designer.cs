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
            this.pcbImagem1 = new System.Windows.Forms.PictureBox();
            this.pcbImagem2 = new System.Windows.Forms.PictureBox();
            this.pcbImagem3 = new System.Windows.Forms.PictureBox();
            this.pcbImagem4 = new System.Windows.Forms.PictureBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.gpbImagens = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem4)).BeginInit();
            this.gpbImagens.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbImagem1
            // 
            this.pcbImagem1.Location = new System.Drawing.Point(21, 29);
            this.pcbImagem1.Name = "pcbImagem1";
            this.pcbImagem1.Size = new System.Drawing.Size(158, 158);
            this.pcbImagem1.TabIndex = 0;
            this.pcbImagem1.TabStop = false;
            // 
            // pcbImagem2
            // 
            this.pcbImagem2.Location = new System.Drawing.Point(185, 29);
            this.pcbImagem2.Name = "pcbImagem2";
            this.pcbImagem2.Size = new System.Drawing.Size(158, 158);
            this.pcbImagem2.TabIndex = 1;
            this.pcbImagem2.TabStop = false;
            // 
            // pcbImagem3
            // 
            this.pcbImagem3.Location = new System.Drawing.Point(349, 29);
            this.pcbImagem3.Name = "pcbImagem3";
            this.pcbImagem3.Size = new System.Drawing.Size(158, 158);
            this.pcbImagem3.TabIndex = 2;
            this.pcbImagem3.TabStop = false;
            // 
            // pcbImagem4
            // 
            this.pcbImagem4.Location = new System.Drawing.Point(513, 29);
            this.pcbImagem4.Name = "pcbImagem4";
            this.pcbImagem4.Size = new System.Drawing.Size(158, 158);
            this.pcbImagem4.TabIndex = 3;
            this.pcbImagem4.TabStop = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(16, 234);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(179, 62);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // gpbImagens
            // 
            this.gpbImagens.Controls.Add(this.pcbImagem4);
            this.gpbImagens.Controls.Add(this.pcbImagem3);
            this.gpbImagens.Controls.Add(this.pcbImagem2);
            this.gpbImagens.Controls.Add(this.pcbImagem1);
            this.gpbImagens.Location = new System.Drawing.Point(16, 5);
            this.gpbImagens.Name = "gpbImagens";
            this.gpbImagens.Size = new System.Drawing.Size(691, 210);
            this.gpbImagens.TabIndex = 5;
            this.gpbImagens.TabStop = false;
            this.gpbImagens.Text = "Imagens";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 377);
            this.Controls.Add(this.gpbImagens);
            this.Controls.Add(this.btnAtualizar);
            this.Name = "Form1";
            this.Text = "Programação Paralela";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem4)).EndInit();
            this.gpbImagens.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbImagem1;
        private System.Windows.Forms.PictureBox pcbImagem2;
        private System.Windows.Forms.PictureBox pcbImagem3;
        private System.Windows.Forms.PictureBox pcbImagem4;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.GroupBox gpbImagens;
    }
}

