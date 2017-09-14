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
            this.btn_inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_anterior = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_proximo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ultimo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_incluir = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_excluir = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_procurar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_imprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.tbc_paginaCadastro = new System.Windows.Forms.TabControl();
            this.tb_cadastro = new System.Windows.Forms.TabPage();
            this.dgv_viagens = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gpBox_cadastro = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codTrem = new System.Windows.Forms.TextBox();
            this.txt_codViagem = new System.Windows.Forms.TextBox();
            this.ms_cadastro.SuspendLayout();
            this.tbc_paginaCadastro.SuspendLayout();
            this.tb_cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gpBox_cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_cadastro
            // 
            this.ms_cadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.ms_cadastro.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_cadastro.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.ms_cadastro.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ms_cadastro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_inicio,
            this.btn_anterior,
            this.btn_proximo,
            this.btn_ultimo,
            this.btn_incluir,
            this.btn_cancelar,
            this.btn_salvar,
            this.btn_excluir,
            this.btn_procurar,
            this.btn_imprimir,
            this.btn_sair});
            this.ms_cadastro.Location = new System.Drawing.Point(0, 0);
            this.ms_cadastro.Name = "ms_cadastro";
            this.ms_cadastro.Size = new System.Drawing.Size(1054, 32);
            this.ms_cadastro.TabIndex = 3;
            this.ms_cadastro.Text = "menuStrip1";
            // 
            // btn_inicio
            // 
            this.btn_inicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_inicio.Image")));
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(83, 28);
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.Click += new System.EventHandler(this.tsm_inicio_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("btn_anterior.Image")));
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(97, 28);
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.Click += new System.EventHandler(this.tsm_anterior_Click);
            // 
            // btn_proximo
            // 
            this.btn_proximo.Image = ((System.Drawing.Image)(resources.GetObject("btn_proximo.Image")));
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(90, 28);
            this.btn_proximo.Text = "Próximo";
            this.btn_proximo.Click += new System.EventHandler(this.tsm_proximo_Click);
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.Image = ((System.Drawing.Image)(resources.GetObject("btn_ultimo.Image")));
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(83, 28);
            this.btn_ultimo.Text = "Último";
            this.btn_ultimo.Click += new System.EventHandler(this.tsm_ultimo_Click);
            // 
            // btn_incluir
            // 
            this.btn_incluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_incluir.Image")));
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(90, 28);
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(97, 28);
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Image = ((System.Drawing.Image)(resources.GetObject("btn_salvar.Image")));
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(83, 28);
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(90, 28);
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_procurar
            // 
            this.btn_procurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_procurar.Image")));
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(97, 28);
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.Image")));
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(97, 28);
            this.btn_imprimir.Text = "Imprimir";
            // 
            // btn_sair
            // 
            this.btn_sair.Image = ((System.Drawing.Image)(resources.GetObject("btn_sair.Image")));
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(69, 28);
            this.btn_sair.Text = "Sair";
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // tbc_paginaCadastro
            // 
            this.tbc_paginaCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_paginaCadastro.Controls.Add(this.tb_cadastro);
            this.tbc_paginaCadastro.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_paginaCadastro.Location = new System.Drawing.Point(-1, 36);
            this.tbc_paginaCadastro.Name = "tbc_paginaCadastro";
            this.tbc_paginaCadastro.SelectedIndex = 0;
            this.tbc_paginaCadastro.Size = new System.Drawing.Size(1054, 394);
            this.tbc_paginaCadastro.TabIndex = 4;
            // 
            // tb_cadastro
            // 
            this.tb_cadastro.BackColor = System.Drawing.Color.Transparent;
            this.tb_cadastro.Controls.Add(this.dgv_viagens);
            this.tb_cadastro.Controls.Add(this.pictureBox2);
            this.tb_cadastro.Controls.Add(this.gpBox_cadastro);
            this.tb_cadastro.Location = new System.Drawing.Point(4, 21);
            this.tb_cadastro.Name = "tb_cadastro";
            this.tb_cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tb_cadastro.Size = new System.Drawing.Size(1046, 369);
            this.tb_cadastro.TabIndex = 1;
            this.tb_cadastro.Text = "Cadastro";
            // 
            // dgv_viagens
            // 
            this.dgv_viagens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_viagens.BackgroundColor = System.Drawing.Color.White;
            this.dgv_viagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_viagens.Location = new System.Drawing.Point(503, 54);
            this.dgv_viagens.Name = "dgv_viagens";
            this.dgv_viagens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_viagens.Size = new System.Drawing.Size(420, 176);
            this.dgv_viagens.TabIndex = 20;
            this.dgv_viagens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_viagens_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(881, 292);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 77);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // gpBox_cadastro
            // 
            this.gpBox_cadastro.BackColor = System.Drawing.Color.Transparent;
            this.gpBox_cadastro.Controls.Add(this.label2);
            this.gpBox_cadastro.Controls.Add(this.label1);
            this.gpBox_cadastro.Controls.Add(this.txt_codTrem);
            this.gpBox_cadastro.Controls.Add(this.txt_codViagem);
            this.gpBox_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBox_cadastro.Location = new System.Drawing.Point(33, 54);
            this.gpBox_cadastro.Name = "gpBox_cadastro";
            this.gpBox_cadastro.Size = new System.Drawing.Size(377, 176);
            this.gpBox_cadastro.TabIndex = 18;
            this.gpBox_cadastro.TabStop = false;
            this.gpBox_cadastro.Text = "Cadastro de Viagens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Código do trem :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código da viagem :";
            // 
            // txt_codTrem
            // 
            this.txt_codTrem.Enabled = false;
            this.txt_codTrem.Location = new System.Drawing.Point(242, 103);
            this.txt_codTrem.Name = "txt_codTrem";
            this.txt_codTrem.Size = new System.Drawing.Size(100, 24);
            this.txt_codTrem.TabIndex = 13;
            // 
            // txt_codViagem
            // 
            this.txt_codViagem.Enabled = false;
            this.txt_codViagem.Location = new System.Drawing.Point(242, 61);
            this.txt_codViagem.Name = "txt_codViagem";
            this.txt_codViagem.Size = new System.Drawing.Size(68, 24);
            this.txt_codViagem.TabIndex = 12;
            // 
            // frm_manutencaoViagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1054, 427);
            this.Controls.Add(this.tbc_paginaCadastro);
            this.Controls.Add(this.ms_cadastro);
            this.Name = "frm_manutencaoViagens";
            this.Text = "Manutenção Viagens";
            this.Load += new System.EventHandler(this.frm_manutencaoViagens_Load);
            this.ms_cadastro.ResumeLayout(false);
            this.ms_cadastro.PerformLayout();
            this.tbc_paginaCadastro.ResumeLayout(false);
            this.tb_cadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gpBox_cadastro.ResumeLayout(false);
            this.gpBox_cadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TabControl tbc_paginaCadastro;
        private System.Windows.Forms.TabPage tb_cadastro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gpBox_cadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codTrem;
        private System.Windows.Forms.TextBox txt_codViagem;
        private System.Windows.Forms.DataGridView dgv_viagens;
    }
}