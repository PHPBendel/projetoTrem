namespace appTrab_Trem
{
    partial class Frm_ManutencaoTrens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ManutencaoTrens));
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
            this.tbc_paginaCadastro = new System.Windows.Forms.TabControl();
            this.tb_cadastro = new System.Windows.Forms.TabPage();
            this.btn_proximoVagao = new System.Windows.Forms.Button();
            this.btn_vagaoAnterior = new System.Windows.Forms.Button();
            this.txt_vagaoVisualizado = new System.Windows.Forms.TextBox();
            this.lb_passageiroSelecionado = new System.Windows.Forms.Label();
            this.lb_descida1 = new System.Windows.Forms.Label();
            this.lb_viagem1 = new System.Windows.Forms.Label();
            this.lb_nome1 = new System.Windows.Forms.Label();
            this.lb_embarque1 = new System.Windows.Forms.Label();
            this.lb_codigo1 = new System.Windows.Forms.Label();
            this.lb_descida = new System.Windows.Forms.Label();
            this.lb_viagem = new System.Windows.Forms.Label();
            this.lb_embarque = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_codigo = new System.Windows.Forms.Label();
            this.dgv_vagao = new System.Windows.Forms.DataGridView();
            this.txt_nVagoes = new System.Windows.Forms.TextBox();
            this.txt_codTrem = new System.Windows.Forms.TextBox();
            this.lb_nVagoes = new System.Windows.Forms.Label();
            this.lb_vagaoVisualizado = new System.Windows.Forms.Label();
            this.lb_CodigoTrem = new System.Windows.Forms.Label();
            this.tb_lista = new System.Windows.Forms.TabPage();
            this.lb_trensCadastrados = new System.Windows.Forms.Label();
            this.dgv_trens = new System.Windows.Forms.DataGridView();
            this.ms_cadastro.SuspendLayout();
            this.tbc_paginaCadastro.SuspendLayout();
            this.tb_cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vagao)).BeginInit();
            this.tb_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trens)).BeginInit();
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
            this.ms_cadastro.Location = new System.Drawing.Point(2, 9);
            this.ms_cadastro.Name = "ms_cadastro";
            this.ms_cadastro.Size = new System.Drawing.Size(1043, 32);
            this.ms_cadastro.TabIndex = 6;
            this.ms_cadastro.Text = "menuStrip1";
            // 
            // btn_inicio
            // 
            this.btn_inicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_inicio.Image")));
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(83, 28);
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("btn_anterior.Image")));
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(97, 28);
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_proximo
            // 
            this.btn_proximo.Image = ((System.Drawing.Image)(resources.GetObject("btn_proximo.Image")));
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(90, 28);
            this.btn_proximo.Text = "Próximo";
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.Image = ((System.Drawing.Image)(resources.GetObject("btn_ultimo.Image")));
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(83, 28);
            this.btn_ultimo.Text = "Último";
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click);
            // 
            // btn_incluir
            // 
            this.btn_incluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_incluir.Image")));
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(90, 28);
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(59, 28);
            this.btn_editar.Text = "Editar";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
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
            this.tbc_paginaCadastro.Controls.Add(this.tb_lista);
            this.tbc_paginaCadastro.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_paginaCadastro.Location = new System.Drawing.Point(2, 44);
            this.tbc_paginaCadastro.Name = "tbc_paginaCadastro";
            this.tbc_paginaCadastro.SelectedIndex = 0;
            this.tbc_paginaCadastro.Size = new System.Drawing.Size(1043, 343);
            this.tbc_paginaCadastro.TabIndex = 5;
            // 
            // tb_cadastro
            // 
            this.tb_cadastro.BackColor = System.Drawing.Color.Transparent;
            this.tb_cadastro.Controls.Add(this.btn_proximoVagao);
            this.tb_cadastro.Controls.Add(this.btn_vagaoAnterior);
            this.tb_cadastro.Controls.Add(this.txt_vagaoVisualizado);
            this.tb_cadastro.Controls.Add(this.lb_passageiroSelecionado);
            this.tb_cadastro.Controls.Add(this.lb_descida1);
            this.tb_cadastro.Controls.Add(this.lb_viagem1);
            this.tb_cadastro.Controls.Add(this.lb_nome1);
            this.tb_cadastro.Controls.Add(this.lb_embarque1);
            this.tb_cadastro.Controls.Add(this.lb_codigo1);
            this.tb_cadastro.Controls.Add(this.lb_descida);
            this.tb_cadastro.Controls.Add(this.lb_viagem);
            this.tb_cadastro.Controls.Add(this.lb_embarque);
            this.tb_cadastro.Controls.Add(this.lb_nome);
            this.tb_cadastro.Controls.Add(this.lb_codigo);
            this.tb_cadastro.Controls.Add(this.dgv_vagao);
            this.tb_cadastro.Controls.Add(this.txt_nVagoes);
            this.tb_cadastro.Controls.Add(this.txt_codTrem);
            this.tb_cadastro.Controls.Add(this.lb_nVagoes);
            this.tb_cadastro.Controls.Add(this.lb_vagaoVisualizado);
            this.tb_cadastro.Controls.Add(this.lb_CodigoTrem);
            this.tb_cadastro.Location = new System.Drawing.Point(4, 21);
            this.tb_cadastro.Name = "tb_cadastro";
            this.tb_cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tb_cadastro.Size = new System.Drawing.Size(1035, 318);
            this.tb_cadastro.TabIndex = 0;
            this.tb_cadastro.Text = "Cadastro";
            // 
            // btn_proximoVagao
            // 
            this.btn_proximoVagao.Image = global::appTrab_Trem.Properties.Resources.proximo;
            this.btn_proximoVagao.Location = new System.Drawing.Point(300, 94);
            this.btn_proximoVagao.Name = "btn_proximoVagao";
            this.btn_proximoVagao.Size = new System.Drawing.Size(27, 23);
            this.btn_proximoVagao.TabIndex = 32;
            this.btn_proximoVagao.UseVisualStyleBackColor = true;
            this.btn_proximoVagao.Click += new System.EventHandler(this.btn_proximoVagao_Click);
            // 
            // btn_vagaoAnterior
            // 
            this.btn_vagaoAnterior.Image = global::appTrab_Trem.Properties.Resources.anterior;
            this.btn_vagaoAnterior.Location = new System.Drawing.Point(273, 94);
            this.btn_vagaoAnterior.Name = "btn_vagaoAnterior";
            this.btn_vagaoAnterior.Size = new System.Drawing.Size(27, 23);
            this.btn_vagaoAnterior.TabIndex = 31;
            this.btn_vagaoAnterior.UseVisualStyleBackColor = true;
            this.btn_vagaoAnterior.Click += new System.EventHandler(this.btn_vagaoAnterior_Click);
            // 
            // txt_vagaoVisualizado
            // 
            this.txt_vagaoVisualizado.Location = new System.Drawing.Point(208, 97);
            this.txt_vagaoVisualizado.Name = "txt_vagaoVisualizado";
            this.txt_vagaoVisualizado.Size = new System.Drawing.Size(59, 18);
            this.txt_vagaoVisualizado.TabIndex = 30;
            // 
            // lb_passageiroSelecionado
            // 
            this.lb_passageiroSelecionado.AutoSize = true;
            this.lb_passageiroSelecionado.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_passageiroSelecionado.Location = new System.Drawing.Point(613, 21);
            this.lb_passageiroSelecionado.Name = "lb_passageiroSelecionado";
            this.lb_passageiroSelecionado.Size = new System.Drawing.Size(237, 25);
            this.lb_passageiroSelecionado.TabIndex = 29;
            this.lb_passageiroSelecionado.Text = "Passageiro selecionado";
            // 
            // lb_descida1
            // 
            this.lb_descida1.AutoSize = true;
            this.lb_descida1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descida1.ForeColor = System.Drawing.Color.Red;
            this.lb_descida1.Location = new System.Drawing.Point(882, 95);
            this.lb_descida1.Name = "lb_descida1";
            this.lb_descida1.Size = new System.Drawing.Size(49, 18);
            this.lb_descida1.TabIndex = 28;
            this.lb_descida1.Text = "label5";
            // 
            // lb_viagem1
            // 
            this.lb_viagem1.AutoSize = true;
            this.lb_viagem1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_viagem1.ForeColor = System.Drawing.Color.Red;
            this.lb_viagem1.Location = new System.Drawing.Point(882, 55);
            this.lb_viagem1.Name = "lb_viagem1";
            this.lb_viagem1.Size = new System.Drawing.Size(49, 18);
            this.lb_viagem1.TabIndex = 27;
            this.lb_viagem1.Text = "label4";
            // 
            // lb_nome1
            // 
            this.lb_nome1.AutoSize = true;
            this.lb_nome1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome1.ForeColor = System.Drawing.Color.Blue;
            this.lb_nome1.Location = new System.Drawing.Point(707, 74);
            this.lb_nome1.Name = "lb_nome1";
            this.lb_nome1.Size = new System.Drawing.Size(49, 18);
            this.lb_nome1.TabIndex = 26;
            this.lb_nome1.Text = "label3";
            // 
            // lb_embarque1
            // 
            this.lb_embarque1.AutoSize = true;
            this.lb_embarque1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_embarque1.ForeColor = System.Drawing.Color.Red;
            this.lb_embarque1.Location = new System.Drawing.Point(707, 95);
            this.lb_embarque1.Name = "lb_embarque1";
            this.lb_embarque1.Size = new System.Drawing.Size(49, 18);
            this.lb_embarque1.TabIndex = 25;
            this.lb_embarque1.Text = "label2";
            // 
            // lb_codigo1
            // 
            this.lb_codigo1.AutoSize = true;
            this.lb_codigo1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codigo1.ForeColor = System.Drawing.Color.Blue;
            this.lb_codigo1.Location = new System.Drawing.Point(707, 55);
            this.lb_codigo1.Name = "lb_codigo1";
            this.lb_codigo1.Size = new System.Drawing.Size(49, 18);
            this.lb_codigo1.TabIndex = 24;
            this.lb_codigo1.Text = "label1";
            // 
            // lb_descida
            // 
            this.lb_descida.AutoSize = true;
            this.lb_descida.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descida.Location = new System.Drawing.Point(808, 94);
            this.lb_descida.Name = "lb_descida";
            this.lb_descida.Size = new System.Drawing.Size(71, 19);
            this.lb_descida.TabIndex = 23;
            this.lb_descida.Text = "Descida:";
            // 
            // lb_viagem
            // 
            this.lb_viagem.AutoSize = true;
            this.lb_viagem.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_viagem.Location = new System.Drawing.Point(808, 54);
            this.lb_viagem.Name = "lb_viagem";
            this.lb_viagem.Size = new System.Drawing.Size(68, 19);
            this.lb_viagem.TabIndex = 22;
            this.lb_viagem.Text = "Viagem:";
            // 
            // lb_embarque
            // 
            this.lb_embarque.AutoSize = true;
            this.lb_embarque.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_embarque.Location = new System.Drawing.Point(614, 94);
            this.lb_embarque.Name = "lb_embarque";
            this.lb_embarque.Size = new System.Drawing.Size(87, 19);
            this.lb_embarque.TabIndex = 21;
            this.lb_embarque.Text = "Embarque:";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(614, 73);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(56, 19);
            this.lb_nome.TabIndex = 20;
            this.lb_nome.Text = "Nome:";
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codigo.Location = new System.Drawing.Point(614, 54);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(64, 19);
            this.lb_codigo.TabIndex = 19;
            this.lb_codigo.Text = "Código:";
            // 
            // dgv_vagao
            // 
            this.dgv_vagao.AllowUserToAddRows = false;
            this.dgv_vagao.AllowUserToDeleteRows = false;
            this.dgv_vagao.AllowUserToResizeColumns = false;
            this.dgv_vagao.AllowUserToResizeRows = false;
            this.dgv_vagao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vagao.Location = new System.Drawing.Point(52, 138);
            this.dgv_vagao.Name = "dgv_vagao";
            this.dgv_vagao.RowHeadersWidth = 50;
            this.dgv_vagao.Size = new System.Drawing.Size(962, 170);
            this.dgv_vagao.TabIndex = 18;
            // 
            // txt_nVagoes
            // 
            this.txt_nVagoes.Enabled = false;
            this.txt_nVagoes.Location = new System.Drawing.Point(208, 64);
            this.txt_nVagoes.Name = "txt_nVagoes";
            this.txt_nVagoes.Size = new System.Drawing.Size(59, 18);
            this.txt_nVagoes.TabIndex = 14;
            this.txt_nVagoes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_nVagoes_KeyUp);
            // 
            // txt_codTrem
            // 
            this.txt_codTrem.Enabled = false;
            this.txt_codTrem.Location = new System.Drawing.Point(208, 29);
            this.txt_codTrem.Name = "txt_codTrem";
            this.txt_codTrem.Size = new System.Drawing.Size(100, 18);
            this.txt_codTrem.TabIndex = 12;
            this.txt_codTrem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_codTrem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_codTrem_KeyUp);
            // 
            // lb_nVagoes
            // 
            this.lb_nVagoes.AutoSize = true;
            this.lb_nVagoes.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nVagoes.Location = new System.Drawing.Point(28, 58);
            this.lb_nVagoes.Name = "lb_nVagoes";
            this.lb_nVagoes.Size = new System.Drawing.Size(176, 23);
            this.lb_nVagoes.TabIndex = 11;
            this.lb_nVagoes.Text = "Número de vagões:";
            // 
            // lb_vagaoVisualizado
            // 
            this.lb_vagaoVisualizado.AutoSize = true;
            this.lb_vagaoVisualizado.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vagaoVisualizado.Location = new System.Drawing.Point(28, 94);
            this.lb_vagaoVisualizado.Name = "lb_vagaoVisualizado";
            this.lb_vagaoVisualizado.Size = new System.Drawing.Size(172, 23);
            this.lb_vagaoVisualizado.TabIndex = 10;
            this.lb_vagaoVisualizado.Text = "Vagão visualizado:";
            // 
            // lb_CodigoTrem
            // 
            this.lb_CodigoTrem.AutoSize = true;
            this.lb_CodigoTrem.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CodigoTrem.Location = new System.Drawing.Point(26, 23);
            this.lb_CodigoTrem.Name = "lb_CodigoTrem";
            this.lb_CodigoTrem.Size = new System.Drawing.Size(148, 23);
            this.lb_CodigoTrem.TabIndex = 9;
            this.lb_CodigoTrem.Text = "Código do trem:";
            // 
            // tb_lista
            // 
            this.tb_lista.BackColor = System.Drawing.Color.White;
            this.tb_lista.Controls.Add(this.lb_trensCadastrados);
            this.tb_lista.Controls.Add(this.dgv_trens);
            this.tb_lista.Location = new System.Drawing.Point(4, 21);
            this.tb_lista.Name = "tb_lista";
            this.tb_lista.Padding = new System.Windows.Forms.Padding(3);
            this.tb_lista.Size = new System.Drawing.Size(1035, 318);
            this.tb_lista.TabIndex = 1;
            this.tb_lista.Text = "Lista";
            // 
            // lb_trensCadastrados
            // 
            this.lb_trensCadastrados.AutoSize = true;
            this.lb_trensCadastrados.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trensCadastrados.Location = new System.Drawing.Point(391, 21);
            this.lb_trensCadastrados.Name = "lb_trensCadastrados";
            this.lb_trensCadastrados.Size = new System.Drawing.Size(298, 29);
            this.lb_trensCadastrados.TabIndex = 1;
            this.lb_trensCadastrados.Text = "Lista de trens cadastrados";
            // 
            // dgv_trens
            // 
            this.dgv_trens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trens.Location = new System.Drawing.Point(442, 74);
            this.dgv_trens.Name = "dgv_trens";
            this.dgv_trens.RowHeadersVisible = false;
            this.dgv_trens.Size = new System.Drawing.Size(203, 209);
            this.dgv_trens.TabIndex = 0;
            // 
            // Frm_ManutencaoTrens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1053, 388);
            this.Controls.Add(this.ms_cadastro);
            this.Controls.Add(this.tbc_paginaCadastro);
            this.Name = "Frm_ManutencaoTrens";
            this.Text = "Frm_ManutencaoTrens";
            this.Load += new System.EventHandler(this.Frm_ManutencaoTrens_Load);
            this.ms_cadastro.ResumeLayout(false);
            this.ms_cadastro.PerformLayout();
            this.tbc_paginaCadastro.ResumeLayout(false);
            this.tb_cadastro.ResumeLayout(false);
            this.tb_cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vagao)).EndInit();
            this.tb_lista.ResumeLayout(false);
            this.tb_lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trens)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem btn_editar;
        private System.Windows.Forms.ToolStripMenuItem btn_cancelar;
        private System.Windows.Forms.ToolStripMenuItem btn_salvar;
        private System.Windows.Forms.ToolStripMenuItem btn_excluir;
        private System.Windows.Forms.ToolStripMenuItem btn_procurar;
        private System.Windows.Forms.ToolStripMenuItem btn_imprimir;
        private System.Windows.Forms.ToolStripMenuItem btn_sair;
        private System.Windows.Forms.TabControl tbc_paginaCadastro;
        private System.Windows.Forms.TabPage tb_lista;
        private System.Windows.Forms.TabPage tb_cadastro;
        private System.Windows.Forms.Label lb_nVagoes;
        private System.Windows.Forms.Label lb_CodigoTrem;
        private System.Windows.Forms.Label lb_vagaoVisualizado;
        private System.Windows.Forms.TextBox txt_nVagoes;
        private System.Windows.Forms.TextBox txt_codTrem;
        private System.Windows.Forms.DataGridView dgv_vagao;
        private System.Windows.Forms.Label lb_descida1;
        private System.Windows.Forms.Label lb_viagem1;
        private System.Windows.Forms.Label lb_nome1;
        private System.Windows.Forms.Label lb_embarque1;
        private System.Windows.Forms.Label lb_codigo1;
        private System.Windows.Forms.Label lb_descida;
        private System.Windows.Forms.Label lb_viagem;
        private System.Windows.Forms.Label lb_embarque;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_codigo;
        private System.Windows.Forms.Label lb_passageiroSelecionado;
        private System.Windows.Forms.Label lb_trensCadastrados;
        private System.Windows.Forms.DataGridView dgv_trens;
        private System.Windows.Forms.TextBox txt_vagaoVisualizado;
        private System.Windows.Forms.Button btn_proximoVagao;
        private System.Windows.Forms.Button btn_vagaoAnterior;
    }
}