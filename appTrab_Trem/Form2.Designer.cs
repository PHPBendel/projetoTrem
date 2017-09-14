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
            this.tb_cadastro = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_nomeCidade = new System.Windows.Forms.TextBox();
            this.txt_sigla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_lista = new System.Windows.Forms.TabPage();
            this.ms_cadastro = new System.Windows.Forms.MenuStrip();
            this.tsm_inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_anterior = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_proximo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ultimo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_incluir = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_editar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_excluir = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_procurar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_imprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbc_paginaCadastro.SuspendLayout();
            this.tb_cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ms_cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_paginaCadastro
            // 
            this.tbc_paginaCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_paginaCadastro.Controls.Add(this.tb_cadastro);
            this.tbc_paginaCadastro.Controls.Add(this.tb_lista);
            this.tbc_paginaCadastro.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_paginaCadastro.Location = new System.Drawing.Point(0, 40);
            this.tbc_paginaCadastro.Name = "tbc_paginaCadastro";
            this.tbc_paginaCadastro.SelectedIndex = 0;
            this.tbc_paginaCadastro.Size = new System.Drawing.Size(966, 332);
            this.tbc_paginaCadastro.TabIndex = 1;
            // 
            // tb_cadastro
            // 
            this.tb_cadastro.BackColor = System.Drawing.Color.Transparent;
            this.tb_cadastro.Controls.Add(this.dataGridView1);
            this.tb_cadastro.Controls.Add(this.pictureBox1);
            this.tb_cadastro.Controls.Add(this.txt_nomeCidade);
            this.tb_cadastro.Controls.Add(this.txt_sigla);
            this.tb_cadastro.Controls.Add(this.label2);
            this.tb_cadastro.Controls.Add(this.label1);
            this.tb_cadastro.Location = new System.Drawing.Point(4, 21);
            this.tb_cadastro.Name = "tb_cadastro";
            this.tb_cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tb_cadastro.Size = new System.Drawing.Size(958, 307);
            this.tb_cadastro.TabIndex = 0;
            this.tb_cadastro.Text = "Cadastro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(786, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 77);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txt_nomeCidade
            // 
            this.txt_nomeCidade.Location = new System.Drawing.Point(164, 76);
            this.txt_nomeCidade.Name = "txt_nomeCidade";
            this.txt_nomeCidade.Size = new System.Drawing.Size(140, 18);
            this.txt_nomeCidade.TabIndex = 7;
            // 
            // txt_sigla
            // 
            this.txt_sigla.Location = new System.Drawing.Point(164, 23);
            this.txt_sigla.Name = "txt_sigla";
            this.txt_sigla.Size = new System.Drawing.Size(49, 18);
            this.txt_sigla.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome da cidade :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sigla :";
            // 
            // tb_lista
            // 
            this.tb_lista.BackColor = System.Drawing.Color.White;
            this.tb_lista.Location = new System.Drawing.Point(4, 21);
            this.tb_lista.Name = "tb_lista";
            this.tb_lista.Padding = new System.Windows.Forms.Padding(3);
            this.tb_lista.Size = new System.Drawing.Size(958, 307);
            this.tb_lista.TabIndex = 1;
            this.tb_lista.Text = "Lista";
            // 
            // ms_cadastro
            // 
            this.ms_cadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_cadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.ms_cadastro.Dock = System.Windows.Forms.DockStyle.None;
            this.ms_cadastro.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_cadastro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_inicio,
            this.tsm_anterior,
            this.tsm_proximo,
            this.tsm_ultimo,
            this.btn_incluir,
            this.btn_editar,
            this.btn_cancelar,
            this.btn_salvar,
            this.btn_excluir,
            this.btn_procurar,
            this.btn_imprimir,
            this.btn_sair});
            this.ms_cadastro.Location = new System.Drawing.Point(0, 9);
            this.ms_cadastro.Name = "ms_cadastro";
            this.ms_cadastro.Size = new System.Drawing.Size(955, 24);
            this.ms_cadastro.TabIndex = 2;
            this.ms_cadastro.Text = "menuStrip1";
            // 
            // tsm_inicio
            // 
            this.tsm_inicio.Image = ((System.Drawing.Image)(resources.GetObject("tsm_inicio.Image")));
            this.tsm_inicio.Name = "tsm_inicio";
            this.tsm_inicio.Size = new System.Drawing.Size(75, 20);
            this.tsm_inicio.Text = "Inicio";
            this.tsm_inicio.MouseEnter += new System.EventHandler(this.tsm_inicio_MouseEnter);
            this.tsm_inicio.MouseLeave += new System.EventHandler(this.tsm_inicio_MouseLeave);
            // 
            // tsm_anterior
            // 
            this.tsm_anterior.Image = ((System.Drawing.Image)(resources.GetObject("tsm_anterior.Image")));
            this.tsm_anterior.Name = "tsm_anterior";
            this.tsm_anterior.Size = new System.Drawing.Size(89, 20);
            this.tsm_anterior.Text = "Anterior";
            // 
            // tsm_proximo
            // 
            this.tsm_proximo.Image = ((System.Drawing.Image)(resources.GetObject("tsm_proximo.Image")));
            this.tsm_proximo.Name = "tsm_proximo";
            this.tsm_proximo.Size = new System.Drawing.Size(82, 20);
            this.tsm_proximo.Text = "Próximo";
            // 
            // tsm_ultimo
            // 
            this.tsm_ultimo.Image = ((System.Drawing.Image)(resources.GetObject("tsm_ultimo.Image")));
            this.tsm_ultimo.Name = "tsm_ultimo";
            this.tsm_ultimo.Size = new System.Drawing.Size(75, 20);
            this.tsm_ultimo.Text = "Último";
            // 
            // btn_incluir
            // 
            this.btn_incluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_incluir.Image")));
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(82, 20);
            this.btn_incluir.Text = "Incluir";
            // 
            // btn_editar
            // 
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(59, 20);
            this.btn_editar.Text = "Editar";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(89, 20);
            this.btn_cancelar.Text = "Cancelar";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Image = ((System.Drawing.Image)(resources.GetObject("btn_salvar.Image")));
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 20);
            this.btn_salvar.Text = "Salvar";
            // 
            // btn_excluir
            // 
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(82, 20);
            this.btn_excluir.Text = "Excluir";
            // 
            // btn_procurar
            // 
            this.btn_procurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_procurar.Image")));
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(89, 20);
            this.btn_procurar.Text = "Procurar";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.Image")));
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(89, 20);
            this.btn_imprimir.Text = "Imprimir";
            // 
            // btn_sair
            // 
            this.btn_sair.Image = ((System.Drawing.Image)(resources.GetObject("btn_sair.Image")));
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(61, 20);
            this.btn_sair.Text = "Sair";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(729, 162);
            this.dataGridView1.TabIndex = 16;
            // 
            // frm_manutencaoCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(966, 372);
            this.Controls.Add(this.ms_cadastro);
            this.Controls.Add(this.tbc_paginaCadastro);
            this.Name = "frm_manutencaoCidades";
            this.Text = "Manutenção Cidades";
            this.Load += new System.EventHandler(this.frm_cadastro_Load);
            this.tbc_paginaCadastro.ResumeLayout(false);
            this.tb_cadastro.ResumeLayout(false);
            this.tb_cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ms_cadastro.ResumeLayout(false);
            this.ms_cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_paginaCadastro;
        private System.Windows.Forms.TabPage tb_cadastro;
        private System.Windows.Forms.TabPage tb_lista;
        private System.Windows.Forms.MenuStrip ms_cadastro;
        private System.Windows.Forms.ToolStripMenuItem tsm_inicio;
        private System.Windows.Forms.ToolStripMenuItem tsm_anterior;
        private System.Windows.Forms.ToolStripMenuItem tsm_proximo;
        private System.Windows.Forms.ToolStripMenuItem tsm_ultimo;
        private System.Windows.Forms.ToolStripMenuItem btn_incluir;
        private System.Windows.Forms.ToolStripMenuItem btn_editar;
        private System.Windows.Forms.ToolStripMenuItem btn_cancelar;
        private System.Windows.Forms.ToolStripMenuItem btn_salvar;
        private System.Windows.Forms.ToolStripMenuItem btn_excluir;
        private System.Windows.Forms.ToolStripMenuItem btn_procurar;
        private System.Windows.Forms.ToolStripMenuItem btn_imprimir;
        private System.Windows.Forms.ToolStripMenuItem btn_sair;
        private System.Windows.Forms.TextBox txt_nomeCidade;
        private System.Windows.Forms.TextBox txt_sigla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}