namespace appTrab_Trem
{
    partial class frm_paginaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_paginaPrincipal));
            this.ms_pagPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsm_pp_cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mItens_cidades = new System.Windows.Forms.ToolStripMenuItem();
            this.mItens_viagens = new System.Windows.Forms.ToolStripMenuItem();
            this.mItens_trens = new System.Windows.Forms.ToolStripMenuItem();
            this.mItens_passageiros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_pp_reserva = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_pp_consulta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_pp_acerca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_pp_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ms_pagPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_pagPrincipal
            // 
            this.ms_pagPrincipal.BackColor = System.Drawing.Color.White;
            this.ms_pagPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_pp_cadastro,
            this.tsm_pp_reserva,
            this.tsm_pp_consulta,
            this.tsm_pp_acerca,
            this.tsm_pp_sair});
            this.ms_pagPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ms_pagPrincipal.Name = "ms_pagPrincipal";
            this.ms_pagPrincipal.Size = new System.Drawing.Size(474, 26);
            this.ms_pagPrincipal.TabIndex = 0;
            this.ms_pagPrincipal.Text = "menuStrip1";
            // 
            // tsm_pp_cadastro
            // 
            this.tsm_pp_cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItens_cidades,
            this.mItens_viagens,
            this.mItens_trens,
            this.mItens_passageiros});
            this.tsm_pp_cadastro.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_pp_cadastro.Name = "tsm_pp_cadastro";
            this.tsm_pp_cadastro.Size = new System.Drawing.Size(78, 22);
            this.tsm_pp_cadastro.Text = "Cadastro";
            // 
            // mItens_cidades
            // 
            this.mItens_cidades.Name = "mItens_cidades";
            this.mItens_cidades.Size = new System.Drawing.Size(152, 22);
            this.mItens_cidades.Text = "Cidades";
            this.mItens_cidades.Click += new System.EventHandler(this.mItens_cidades_Click);
            // 
            // mItens_viagens
            // 
            this.mItens_viagens.Name = "mItens_viagens";
            this.mItens_viagens.Size = new System.Drawing.Size(152, 22);
            this.mItens_viagens.Text = "Viagens";
            this.mItens_viagens.Click += new System.EventHandler(this.mItens_viagens_Click);
            // 
            // mItens_trens
            // 
            this.mItens_trens.Name = "mItens_trens";
            this.mItens_trens.Size = new System.Drawing.Size(152, 22);
            this.mItens_trens.Text = "Trens";
            // 
            // mItens_passageiros
            // 
            this.mItens_passageiros.Name = "mItens_passageiros";
            this.mItens_passageiros.Size = new System.Drawing.Size(152, 22);
            this.mItens_passageiros.Text = "Passageiros";
            // 
            // tsm_pp_reserva
            // 
            this.tsm_pp_reserva.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_pp_reserva.Name = "tsm_pp_reserva";
            this.tsm_pp_reserva.Size = new System.Drawing.Size(80, 22);
            this.tsm_pp_reserva.Text = "Reservas";
            // 
            // tsm_pp_consulta
            // 
            this.tsm_pp_consulta.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_pp_consulta.Name = "tsm_pp_consulta";
            this.tsm_pp_consulta.Size = new System.Drawing.Size(82, 22);
            this.tsm_pp_consulta.Text = "Consultas";
            // 
            // tsm_pp_acerca
            // 
            this.tsm_pp_acerca.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_pp_acerca.Name = "tsm_pp_acerca";
            this.tsm_pp_acerca.Size = new System.Drawing.Size(64, 22);
            this.tsm_pp_acerca.Text = "Acerca";
            // 
            // tsm_pp_sair
            // 
            this.tsm_pp_sair.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_pp_sair.Name = "tsm_pp_sair";
            this.tsm_pp_sair.Size = new System.Drawing.Size(43, 22);
            this.tsm_pp_sair.Text = "Sair";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 569);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frm_paginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 254);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ms_pagPrincipal);
            this.MainMenuStrip = this.ms_pagPrincipal;
            this.Name = "frm_paginaPrincipal";
            this.Text = "Pagina principal";
            this.ms_pagPrincipal.ResumeLayout(false);
            this.ms_pagPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_pagPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsm_pp_cadastro;
        private System.Windows.Forms.ToolStripMenuItem mItens_cidades;
        private System.Windows.Forms.ToolStripMenuItem mItens_viagens;
        private System.Windows.Forms.ToolStripMenuItem mItens_trens;
        private System.Windows.Forms.ToolStripMenuItem mItens_passageiros;
        private System.Windows.Forms.ToolStripMenuItem tsm_pp_reserva;
        private System.Windows.Forms.ToolStripMenuItem tsm_pp_consulta;
        private System.Windows.Forms.ToolStripMenuItem tsm_pp_acerca;
        private System.Windows.Forms.ToolStripMenuItem tsm_pp_sair;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

