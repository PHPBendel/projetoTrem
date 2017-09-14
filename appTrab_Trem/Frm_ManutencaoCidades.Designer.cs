namespace appTrab_Trem
{
    partial class frm_manutencaoCidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_manutencaoCidades));
            this.tbc_paginaCadastro = new System.Windows.Forms.TabControl();
            this.tb_lista = new System.Windows.Forms.TabPage();
            this.lb_Cidades = new System.Windows.Forms.Label();
            this.dgvCidades = new System.Windows.Forms.DataGridView();
            this.tb_cadastro = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_nomeCidade = new System.Windows.Forms.TextBox();
            this.txt_sigla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ms_cadastro = new System.Windows.Forms.MenuStrip();
            this.btn_inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_anterior = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_proximo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ultimo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_incluir = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_editar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_excluir = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_procurar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_imprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.tbc_paginaCadastro.SuspendLayout();
            this.tb_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).BeginInit();
            this.tb_cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ms_cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_paginaCadastro
            // 
            this.tbc_paginaCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_paginaCadastro.Controls.Add(this.tb_lista);
            this.tbc_paginaCadastro.Controls.Add(this.tb_cadastro);
            this.tbc_paginaCadastro.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_paginaCadastro.Location = new System.Drawing.Point(0, 40);
            this.tbc_paginaCadastro.Name = "tbc_paginaCadastro";
            this.tbc_paginaCadastro.SelectedIndex = 0;
            this.tbc_paginaCadastro.Size = new System.Drawing.Size(1068, 332);
            this.tbc_paginaCadastro.TabIndex = 1;
            // 
            // tb_lista
            // 
            this.tb_lista.BackColor = System.Drawing.Color.White;
            this.tb_lista.Controls.Add(this.lb_Cidades);
            this.tb_lista.Controls.Add(this.dgvCidades);
            this.tb_lista.Location = new System.Drawing.Point(4, 21);
            this.tb_lista.Name = "tb_lista";
            this.tb_lista.Padding = new System.Windows.Forms.Padding(3);
            this.tb_lista.Size = new System.Drawing.Size(1060, 307);
            this.tb_lista.TabIndex = 1;
            this.tb_lista.Text = "Lista";
            // 
            // lb_Cidades
            // 
            this.lb_Cidades.AutoSize = true;
            this.lb_Cidades.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cidades.Location = new System.Drawing.Point(326, 30);
            this.lb_Cidades.Name = "lb_Cidades";
            this.lb_Cidades.Size = new System.Drawing.Size(287, 35);
            this.lb_Cidades.TabIndex = 1;
            this.lb_Cidades.Text = "Cidades cadastradas";
            // 
            // dgvCidades
            // 
            this.dgvCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCidades.Location = new System.Drawing.Point(63, 101);
            this.dgvCidades.Name = "dgvCidades";
            this.dgvCidades.Size = new System.Drawing.Size(815, 174);
            this.dgvCidades.TabIndex = 0;
            this.dgvCidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCidades_CellContentClick);
            // 
            // tb_cadastro
            // 
            this.tb_cadastro.BackColor = System.Drawing.Color.Transparent;
            this.tb_cadastro.Controls.Add(this.pictureBox1);
            this.tb_cadastro.Controls.Add(this.txt_nomeCidade);
            this.tb_cadastro.Controls.Add(this.txt_sigla);
            this.tb_cadastro.Controls.Add(this.label2);
            this.tb_cadastro.Controls.Add(this.label1);
            this.tb_cadastro.Location = new System.Drawing.Point(4, 21);
            this.tb_cadastro.Name = "tb_cadastro";
            this.tb_cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tb_cadastro.Size = new System.Drawing.Size(1060, 307);
            this.tb_cadastro.TabIndex = 0;
            this.tb_cadastro.Text = "Cadastro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(790, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 77);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txt_nomeCidade
            // 
            this.txt_nomeCidade.Enabled = false;
            this.txt_nomeCidade.Location = new System.Drawing.Point(210, 77);
            this.txt_nomeCidade.Name = "txt_nomeCidade";
            this.txt_nomeCidade.Size = new System.Drawing.Size(140, 18);
            this.txt_nomeCidade.TabIndex = 7;
            // 
            // txt_sigla
            // 
            this.txt_sigla.Enabled = false;
            this.txt_sigla.Location = new System.Drawing.Point(210, 25);
            this.txt_sigla.Name = "txt_sigla";
            this.txt_sigla.Size = new System.Drawing.Size(49, 18);
            this.txt_sigla.TabIndex = 6;
            this.txt_sigla.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_sigla_KeyUp_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome da cidade :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sigla :";
            // 
            // ms_cadastro
            // 
            this.ms_cadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_cadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.ms_cadastro.Dock = System.Windows.Forms.DockStyle.None;
            this.ms_cadastro.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_cadastro.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ms_cadastro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_inicio,
            this.btn_anterior,
            this.btn_proximo,
            this.btn_ultimo,
            this.btn_incluir,
            this.btn_editar,
            this.btn_cancelar,
            this.btn_salvar,
            this.btn_excluir,
            this.btn_procurar,
            this.btn_imprimir,
            this.btn_sair});
            this.ms_cadastro.Location = new System.Drawing.Point(-6, 5);
            this.ms_cadastro.Name = "ms_cadastro";
            this.ms_cadastro.Size = new System.Drawing.Size(1043, 32);
            this.ms_cadastro.TabIndex = 4;
            this.ms_cadastro.Text = "menuStrip1";
            // 
            // btn_inicio
            // 
            this.btn_inicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_inicio.Image")));
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(83, 28);
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click_1);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("btn_anterior.Image")));
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(97, 28);
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click_1);
            // 
            // btn_proximo
            // 
            this.btn_proximo.Image = ((System.Drawing.Image)(resources.GetObject("btn_proximo.Image")));
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(90, 28);
            this.btn_proximo.Text = "Próximo";
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click_1);
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.Image = ((System.Drawing.Image)(resources.GetObject("btn_ultimo.Image")));
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(83, 28);
            this.btn_ultimo.Text = "Último";
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click_1);
            // 
            // btn_incluir
            // 
            this.btn_incluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_incluir.Image")));
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(90, 28);
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click_1);
            // 
            // btn_editar
            // 
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(59, 28);
            this.btn_editar.Text = "Editar";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click_1);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(97, 28);
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Image = ((System.Drawing.Image)(resources.GetObject("btn_salvar.Image")));
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(83, 28);
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click_1);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(90, 28);
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click_1);
            // 
            // btn_procurar
            // 
            this.btn_procurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_procurar.Image")));
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(97, 28);
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click_1);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.Image")));
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(97, 28);
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Image = ((System.Drawing.Image)(resources.GetObject("btn_sair.Image")));
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(69, 28);
            this.btn_sair.Text = "Sair";
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click_1);
            // 
            // frm_manutencaoCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1068, 372);
            this.Controls.Add(this.ms_cadastro);
            this.Controls.Add(this.tbc_paginaCadastro);
            this.Name = "frm_manutencaoCidades";
            this.Text = "Manutenção Cidades";
            this.Load += new System.EventHandler(this.frm_cadastro_Load);
            this.tbc_paginaCadastro.ResumeLayout(false);
            this.tb_lista.ResumeLayout(false);
            this.tb_lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).EndInit();
            this.tb_cadastro.ResumeLayout(false);
            this.tb_cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ms_cadastro.ResumeLayout(false);
            this.ms_cadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_paginaCadastro;
        private System.Windows.Forms.TabPage tb_cadastro;
        private System.Windows.Forms.TabPage tb_lista;
        private System.Windows.Forms.TextBox txt_nomeCidade;
        private System.Windows.Forms.TextBox txt_sigla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip ms_cadastro;
        private System.Windows.Forms.ToolStripMenuItem btn_inicio;
        private System.Windows.Forms.ToolStripMenuItem btn_anterior;
        private System.Windows.Forms.ToolStripMenuItem btn_proximo;
        private System.Windows.Forms.ToolStripMenuItem btn_ultimo;
        private System.Windows.Forms.ToolStripMenuItem btn_incluir;
        private System.Windows.Forms.ToolStripMenuItem btn_cancelar;
        private System.Windows.Forms.ToolStripMenuItem btn_salvar;
        private System.Windows.Forms.ToolStripMenuItem btn_excluir;
        private System.Windows.Forms.ToolStripMenuItem btn_procurar;
        private System.Windows.Forms.ToolStripMenuItem btn_imprimir;
        private System.Windows.Forms.ToolStripMenuItem btn_sair;
        private System.Windows.Forms.Label lb_Cidades;
        private System.Windows.Forms.DataGridView dgvCidades;
        private System.Windows.Forms.ToolStripMenuItem btn_editar;
    }
}