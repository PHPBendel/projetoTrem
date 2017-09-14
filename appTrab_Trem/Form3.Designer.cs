namespace appTrab_Trem
{
    partial class frm_manutencaoViagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_manutencaoViagens));
            this.ms_cadastro = new System.Windows.Forms.MenuStrip();
            this.tsm_inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_anterior = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_proximo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ultimo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_incluir = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_excluir = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_procurar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_imprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.tbc_paginaCadastro = new System.Windows.Forms.TabControl();
            this.tb_cadastro = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gvViagens = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_lista = new System.Windows.Forms.TabPage();
            this.ms_cadastro.SuspendLayout();
            this.tbc_paginaCadastro.SuspendLayout();
            this.tb_cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvViagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btn_cancelar,
            this.btn_salvar,
            this.btn_excluir,
            this.btn_procurar,
            this.btn_imprimir,
            this.btn_sair});
            this.ms_cadastro.Location = new System.Drawing.Point(-1, 9);
            this.ms_cadastro.Name = "ms_cadastro";
            this.ms_cadastro.Size = new System.Drawing.Size(896, 24);
            this.ms_cadastro.TabIndex = 3;
            this.ms_cadastro.Text = "menuStrip1";
            // 
            // tsm_inicio
            // 
            this.tsm_inicio.Image = ((System.Drawing.Image)(resources.GetObject("tsm_inicio.Image")));
            this.tsm_inicio.Name = "tsm_inicio";
            this.tsm_inicio.Size = new System.Drawing.Size(75, 20);
            this.tsm_inicio.Text = "Inicio";
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
            // tbc_paginaCadastro
            // 
            this.tbc_paginaCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_paginaCadastro.Controls.Add(this.tb_cadastro);
            this.tbc_paginaCadastro.Controls.Add(this.tb_lista);
            this.tbc_paginaCadastro.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_paginaCadastro.Location = new System.Drawing.Point(-1, 36);
            this.tbc_paginaCadastro.Name = "tbc_paginaCadastro";
            this.tbc_paginaCadastro.SelectedIndex = 0;
            this.tbc_paginaCadastro.Size = new System.Drawing.Size(954, 394);
            this.tbc_paginaCadastro.TabIndex = 4;
            // 
            // tb_cadastro
            // 
            this.tb_cadastro.BackColor = System.Drawing.Color.Transparent;
            this.tb_cadastro.Controls.Add(this.numericUpDown1);
            this.tb_cadastro.Controls.Add(this.gvViagens);
            this.tb_cadastro.Controls.Add(this.textBox2);
            this.tb_cadastro.Controls.Add(this.textBox1);
            this.tb_cadastro.Controls.Add(this.label3);
            this.tb_cadastro.Controls.Add(this.label2);
            this.tb_cadastro.Controls.Add(this.label1);
            this.tb_cadastro.Controls.Add(this.pictureBox1);
            this.tb_cadastro.Location = new System.Drawing.Point(4, 21);
            this.tb_cadastro.Name = "tb_cadastro";
            this.tb_cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tb_cadastro.Size = new System.Drawing.Size(946, 369);
            this.tb_cadastro.TabIndex = 0;
            this.tb_cadastro.Text = "Cadastro";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(162, 125);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 18);
            this.numericUpDown1.TabIndex = 16;
            // 
            // gvViagens
            // 
            this.gvViagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvViagens.Location = new System.Drawing.Point(38, 180);
            this.gvViagens.Name = "gvViagens";
            this.gvViagens.Size = new System.Drawing.Size(621, 162);
            this.gvViagens.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 18);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 18);
            this.textBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 11);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantas cidades :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 11);
            this.label2.TabIndex = 10;
            this.label2.Text = "Código do trem :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 11);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código da viagem :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(774, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 77);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // tb_lista
            // 
            this.tb_lista.BackColor = System.Drawing.Color.White;
            this.tb_lista.Location = new System.Drawing.Point(4, 21);
            this.tb_lista.Name = "tb_lista";
            this.tb_lista.Padding = new System.Windows.Forms.Padding(3);
            this.tb_lista.Size = new System.Drawing.Size(946, 369);
            this.tb_lista.TabIndex = 1;
            this.tb_lista.Text = "Lista";
            // 
            // frm_manutencaoViagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(954, 427);
            this.Controls.Add(this.tbc_paginaCadastro);
            this.Controls.Add(this.ms_cadastro);
            this.Name = "frm_manutencaoViagens";
            this.Text = "Manutenção Viagens";
            this.ms_cadastro.ResumeLayout(false);
            this.ms_cadastro.PerformLayout();
            this.tbc_paginaCadastro.ResumeLayout(false);
            this.tb_cadastro.ResumeLayout(false);
            this.tb_cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvViagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_cadastro;
        private System.Windows.Forms.ToolStripMenuItem tsm_inicio;
        private System.Windows.Forms.ToolStripMenuItem tsm_anterior;
        private System.Windows.Forms.ToolStripMenuItem tsm_proximo;
        private System.Windows.Forms.ToolStripMenuItem tsm_ultimo;
        private System.Windows.Forms.ToolStripMenuItem btn_incluir;
        private System.Windows.Forms.ToolStripMenuItem btn_cancelar;
        private System.Windows.Forms.ToolStripMenuItem btn_salvar;
        private System.Windows.Forms.ToolStripMenuItem btn_excluir;
        private System.Windows.Forms.ToolStripMenuItem btn_procurar;
        private System.Windows.Forms.ToolStripMenuItem btn_imprimir;
        private System.Windows.Forms.ToolStripMenuItem btn_sair;
        private System.Windows.Forms.TabControl tbc_paginaCadastro;
        private System.Windows.Forms.TabPage tb_cadastro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tb_lista;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView gvViagens;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}