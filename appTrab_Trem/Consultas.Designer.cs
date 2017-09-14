namespace appTrab_Trem
{
    partial class Consultas
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
            this.tbc_Consultas = new System.Windows.Forms.TabControl();
            this.tb_passageiros = new System.Windows.Forms.TabPage();
            this.lb_emailPassageiro = new System.Windows.Forms.Label();
            this.lb_nomePassageiro = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_Nome = new System.Windows.Forms.Label();
            this.btn_procurarPassageiro = new System.Windows.Forms.Button();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.dgv_Passageiros = new System.Windows.Forms.DataGridView();
            this.tb_cidades = new System.Windows.Forms.TabPage();
            this.btn_procurarCidade = new System.Windows.Forms.Button();
            this.lb_nomeCidade = new System.Windows.Forms.Label();
            this.lb_Cidade = new System.Windows.Forms.Label();
            this.txt_siglaCidade = new System.Windows.Forms.TextBox();
            this.lb_siglaCidade = new System.Windows.Forms.Label();
            this.dgv_cidades = new System.Windows.Forms.DataGridView();
            this.tb_viagens = new System.Windows.Forms.TabPage();
            this.dgv_destinos = new System.Windows.Forms.DataGridView();
            this.btn_procurarViagem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codViagem = new System.Windows.Forms.TextBox();
            this.lb_codViagem = new System.Windows.Forms.Label();
            this.dgv_Viagens = new System.Windows.Forms.DataGridView();
            this.tb_trens = new System.Windows.Forms.TabPage();
            this.btn_procurarTrem = new System.Windows.Forms.Button();
            this.lb_viagensFeitas = new System.Windows.Forms.Label();
            this.lb_Viagem = new System.Windows.Forms.Label();
            this.txt_codTrem = new System.Windows.Forms.TextBox();
            this.lb_codTrem = new System.Windows.Forms.Label();
            this.dgv_trens = new System.Windows.Forms.DataGridView();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lb_viagensFeitas2 = new System.Windows.Forms.Label();
            this.tbc_Consultas.SuspendLayout();
            this.tb_passageiros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Passageiros)).BeginInit();
            this.tb_cidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cidades)).BeginInit();
            this.tb_viagens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_destinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Viagens)).BeginInit();
            this.tb_trens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trens)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_Consultas
            // 
            this.tbc_Consultas.Controls.Add(this.tb_passageiros);
            this.tbc_Consultas.Controls.Add(this.tb_cidades);
            this.tbc_Consultas.Controls.Add(this.tb_viagens);
            this.tbc_Consultas.Controls.Add(this.tb_trens);
            this.tbc_Consultas.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_Consultas.Location = new System.Drawing.Point(-1, 46);
            this.tbc_Consultas.Name = "tbc_Consultas";
            this.tbc_Consultas.SelectedIndex = 0;
            this.tbc_Consultas.Size = new System.Drawing.Size(693, 272);
            this.tbc_Consultas.TabIndex = 0;
            // 
            // tb_passageiros
            // 
            this.tb_passageiros.Controls.Add(this.lb_emailPassageiro);
            this.tb_passageiros.Controls.Add(this.lb_nomePassageiro);
            this.tb_passageiros.Controls.Add(this.lb_email);
            this.tb_passageiros.Controls.Add(this.lb_Nome);
            this.tb_passageiros.Controls.Add(this.btn_procurarPassageiro);
            this.tb_passageiros.Controls.Add(this.txt_cpf);
            this.tb_passageiros.Controls.Add(this.lb_cpf);
            this.tb_passageiros.Controls.Add(this.dgv_Passageiros);
            this.tb_passageiros.Location = new System.Drawing.Point(4, 21);
            this.tb_passageiros.Name = "tb_passageiros";
            this.tb_passageiros.Padding = new System.Windows.Forms.Padding(3);
            this.tb_passageiros.Size = new System.Drawing.Size(685, 247);
            this.tb_passageiros.TabIndex = 0;
            this.tb_passageiros.Text = "Passageiros";
            this.tb_passageiros.UseVisualStyleBackColor = true;
            // 
            // lb_emailPassageiro
            // 
            this.lb_emailPassageiro.AutoSize = true;
            this.lb_emailPassageiro.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_emailPassageiro.ForeColor = System.Drawing.Color.Blue;
            this.lb_emailPassageiro.Location = new System.Drawing.Point(485, 195);
            this.lb_emailPassageiro.Name = "lb_emailPassageiro";
            this.lb_emailPassageiro.Size = new System.Drawing.Size(49, 19);
            this.lb_emailPassageiro.TabIndex = 7;
            this.lb_emailPassageiro.Text = "Email";
            // 
            // lb_nomePassageiro
            // 
            this.lb_nomePassageiro.AutoSize = true;
            this.lb_nomePassageiro.BackColor = System.Drawing.Color.Transparent;
            this.lb_nomePassageiro.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nomePassageiro.ForeColor = System.Drawing.Color.Blue;
            this.lb_nomePassageiro.Location = new System.Drawing.Point(485, 161);
            this.lb_nomePassageiro.Name = "lb_nomePassageiro";
            this.lb_nomePassageiro.Size = new System.Drawing.Size(51, 19);
            this.lb_nomePassageiro.TabIndex = 6;
            this.lb_nomePassageiro.Text = "Nome";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(407, 195);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(54, 19);
            this.lb_email.TabIndex = 5;
            this.lb_email.Text = "Email:";
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nome.Location = new System.Drawing.Point(405, 161);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(56, 19);
            this.lb_Nome.TabIndex = 4;
            this.lb_Nome.Text = "Nome:";
            // 
            // btn_procurarPassageiro
            // 
            this.btn_procurarPassageiro.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procurarPassageiro.Location = new System.Drawing.Point(496, 97);
            this.btn_procurarPassageiro.Name = "btn_procurarPassageiro";
            this.btn_procurarPassageiro.Size = new System.Drawing.Size(117, 34);
            this.btn_procurarPassageiro.TabIndex = 3;
            this.btn_procurarPassageiro.Text = "Procurar";
            this.btn_procurarPassageiro.UseVisualStyleBackColor = true;
            this.btn_procurarPassageiro.Click += new System.EventHandler(this.btn_procurarPassageiro_Click);
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(452, 64);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(210, 18);
            this.txt_cpf.TabIndex = 2;
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf.Location = new System.Drawing.Point(434, 29);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(244, 23);
            this.lb_cpf.TabIndex = 1;
            this.lb_cpf.Text = "Digite o CPF do passageiro";
            // 
            // dgv_Passageiros
            // 
            this.dgv_Passageiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Passageiros.Location = new System.Drawing.Point(9, 17);
            this.dgv_Passageiros.Name = "dgv_Passageiros";
            this.dgv_Passageiros.Size = new System.Drawing.Size(341, 224);
            this.dgv_Passageiros.TabIndex = 0;
            // 
            // tb_cidades
            // 
            this.tb_cidades.Controls.Add(this.btn_procurarCidade);
            this.tb_cidades.Controls.Add(this.lb_nomeCidade);
            this.tb_cidades.Controls.Add(this.lb_Cidade);
            this.tb_cidades.Controls.Add(this.txt_siglaCidade);
            this.tb_cidades.Controls.Add(this.lb_siglaCidade);
            this.tb_cidades.Controls.Add(this.dgv_cidades);
            this.tb_cidades.Location = new System.Drawing.Point(4, 21);
            this.tb_cidades.Name = "tb_cidades";
            this.tb_cidades.Padding = new System.Windows.Forms.Padding(3);
            this.tb_cidades.Size = new System.Drawing.Size(685, 247);
            this.tb_cidades.TabIndex = 1;
            this.tb_cidades.Text = "Cidades";
            this.tb_cidades.UseVisualStyleBackColor = true;
            // 
            // btn_procurarCidade
            // 
            this.btn_procurarCidade.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procurarCidade.Location = new System.Drawing.Point(419, 101);
            this.btn_procurarCidade.Name = "btn_procurarCidade";
            this.btn_procurarCidade.Size = new System.Drawing.Size(117, 34);
            this.btn_procurarCidade.TabIndex = 5;
            this.btn_procurarCidade.Text = "Procurar";
            this.btn_procurarCidade.UseVisualStyleBackColor = true;
            this.btn_procurarCidade.Click += new System.EventHandler(this.btn_procurarCidade_Click);
            // 
            // lb_nomeCidade
            // 
            this.lb_nomeCidade.AutoSize = true;
            this.lb_nomeCidade.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nomeCidade.ForeColor = System.Drawing.Color.Blue;
            this.lb_nomeCidade.Location = new System.Drawing.Point(421, 158);
            this.lb_nomeCidade.Name = "lb_nomeCidade";
            this.lb_nomeCidade.Size = new System.Drawing.Size(49, 19);
            this.lb_nomeCidade.TabIndex = 4;
            this.lb_nomeCidade.Text = "nome";
            this.lb_nomeCidade.Click += new System.EventHandler(this.lb_nomeCidade_Click);
            // 
            // lb_Cidade
            // 
            this.lb_Cidade.AutoSize = true;
            this.lb_Cidade.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cidade.Location = new System.Drawing.Point(286, 158);
            this.lb_Cidade.Name = "lb_Cidade";
            this.lb_Cidade.Size = new System.Drawing.Size(129, 19);
            this.lb_Cidade.TabIndex = 3;
            this.lb_Cidade.Text = "Nome da cidade:";
            // 
            // txt_siglaCidade
            // 
            this.txt_siglaCidade.Location = new System.Drawing.Point(384, 68);
            this.txt_siglaCidade.Name = "txt_siglaCidade";
            this.txt_siglaCidade.Size = new System.Drawing.Size(186, 18);
            this.txt_siglaCidade.TabIndex = 2;
            // 
            // lb_siglaCidade
            // 
            this.lb_siglaCidade.AutoSize = true;
            this.lb_siglaCidade.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_siglaCidade.Location = new System.Drawing.Point(363, 28);
            this.lb_siglaCidade.Name = "lb_siglaCidade";
            this.lb_siglaCidade.Size = new System.Drawing.Size(210, 23);
            this.lb_siglaCidade.TabIndex = 1;
            this.lb_siglaCidade.Text = "Digite a sigla da cidade";
            // 
            // dgv_cidades
            // 
            this.dgv_cidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cidades.Location = new System.Drawing.Point(23, 17);
            this.dgv_cidades.Name = "dgv_cidades";
            this.dgv_cidades.Size = new System.Drawing.Size(240, 224);
            this.dgv_cidades.TabIndex = 0;
            // 
            // tb_viagens
            // 
            this.tb_viagens.Controls.Add(this.dgv_destinos);
            this.tb_viagens.Controls.Add(this.btn_procurarViagem);
            this.tb_viagens.Controls.Add(this.label2);
            this.tb_viagens.Controls.Add(this.txt_codViagem);
            this.tb_viagens.Controls.Add(this.lb_codViagem);
            this.tb_viagens.Controls.Add(this.dgv_Viagens);
            this.tb_viagens.Location = new System.Drawing.Point(4, 21);
            this.tb_viagens.Name = "tb_viagens";
            this.tb_viagens.Padding = new System.Windows.Forms.Padding(3);
            this.tb_viagens.Size = new System.Drawing.Size(685, 247);
            this.tb_viagens.TabIndex = 2;
            this.tb_viagens.Text = "Viagens";
            this.tb_viagens.UseVisualStyleBackColor = true;
            // 
            // dgv_destinos
            // 
            this.dgv_destinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_destinos.Location = new System.Drawing.Point(393, 107);
            this.dgv_destinos.Name = "dgv_destinos";
            this.dgv_destinos.Size = new System.Drawing.Size(176, 132);
            this.dgv_destinos.TabIndex = 12;
            // 
            // btn_procurarViagem
            // 
            this.btn_procurarViagem.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procurarViagem.Location = new System.Drawing.Point(421, 67);
            this.btn_procurarViagem.Name = "btn_procurarViagem";
            this.btn_procurarViagem.Size = new System.Drawing.Size(117, 34);
            this.btn_procurarViagem.TabIndex = 11;
            this.btn_procurarViagem.Text = "Procurar";
            this.btn_procurarViagem.UseVisualStyleBackColor = true;
            this.btn_procurarViagem.Click += new System.EventHandler(this.vtn_procurarViagem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Destinos:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_codViagem
            // 
            this.txt_codViagem.Location = new System.Drawing.Point(386, 43);
            this.txt_codViagem.Name = "txt_codViagem";
            this.txt_codViagem.Size = new System.Drawing.Size(186, 18);
            this.txt_codViagem.TabIndex = 8;
            // 
            // lb_codViagem
            // 
            this.lb_codViagem.AutoSize = true;
            this.lb_codViagem.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codViagem.Location = new System.Drawing.Point(364, 17);
            this.lb_codViagem.Name = "lb_codViagem";
            this.lb_codViagem.Size = new System.Drawing.Size(234, 23);
            this.lb_codViagem.TabIndex = 7;
            this.lb_codViagem.Text = "Digite o código da viagem";
            // 
            // dgv_Viagens
            // 
            this.dgv_Viagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Viagens.Location = new System.Drawing.Point(23, 17);
            this.dgv_Viagens.Name = "dgv_Viagens";
            this.dgv_Viagens.Size = new System.Drawing.Size(240, 224);
            this.dgv_Viagens.TabIndex = 6;
            // 
            // tb_trens
            // 
            this.tb_trens.Controls.Add(this.lb_viagensFeitas2);
            this.tb_trens.Controls.Add(this.btn_procurarTrem);
            this.tb_trens.Controls.Add(this.lb_viagensFeitas);
            this.tb_trens.Controls.Add(this.lb_Viagem);
            this.tb_trens.Controls.Add(this.txt_codTrem);
            this.tb_trens.Controls.Add(this.lb_codTrem);
            this.tb_trens.Controls.Add(this.dgv_trens);
            this.tb_trens.Location = new System.Drawing.Point(4, 21);
            this.tb_trens.Name = "tb_trens";
            this.tb_trens.Size = new System.Drawing.Size(685, 247);
            this.tb_trens.TabIndex = 3;
            this.tb_trens.Text = "Trens";
            this.tb_trens.UseVisualStyleBackColor = true;
            // 
            // btn_procurarTrem
            // 
            this.btn_procurarTrem.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procurarTrem.Location = new System.Drawing.Point(422, 101);
            this.btn_procurarTrem.Name = "btn_procurarTrem";
            this.btn_procurarTrem.Size = new System.Drawing.Size(117, 34);
            this.btn_procurarTrem.TabIndex = 11;
            this.btn_procurarTrem.Text = "Procurar";
            this.btn_procurarTrem.UseVisualStyleBackColor = true;
            this.btn_procurarTrem.Click += new System.EventHandler(this.btn_procurarTrem_Click);
            // 
            // lb_viagensFeitas
            // 
            this.lb_viagensFeitas.AutoSize = true;
            this.lb_viagensFeitas.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_viagensFeitas.ForeColor = System.Drawing.Color.Blue;
            this.lb_viagensFeitas.Location = new System.Drawing.Point(484, 159);
            this.lb_viagensFeitas.Name = "lb_viagensFeitas";
            this.lb_viagensFeitas.Size = new System.Drawing.Size(61, 19);
            this.lb_viagensFeitas.TabIndex = 10;
            this.lb_viagensFeitas.Text = "viagem";
            // 
            // lb_Viagem
            // 
            this.lb_Viagem.AutoSize = true;
            this.lb_Viagem.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Viagem.Location = new System.Drawing.Point(290, 171);
            this.lb_Viagem.Name = "lb_Viagem";
            this.lb_Viagem.Size = new System.Drawing.Size(188, 19);
            this.lb_Viagem.TabIndex = 9;
            this.lb_Viagem.Text = "Viagens feitas pelo trem:";
            this.lb_Viagem.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_codTrem
            // 
            this.txt_codTrem.Location = new System.Drawing.Point(384, 68);
            this.txt_codTrem.Name = "txt_codTrem";
            this.txt_codTrem.Size = new System.Drawing.Size(186, 18);
            this.txt_codTrem.TabIndex = 8;
            // 
            // lb_codTrem
            // 
            this.lb_codTrem.AutoSize = true;
            this.lb_codTrem.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codTrem.Location = new System.Drawing.Point(367, 29);
            this.lb_codTrem.Name = "lb_codTrem";
            this.lb_codTrem.Size = new System.Drawing.Size(213, 23);
            this.lb_codTrem.TabIndex = 7;
            this.lb_codTrem.Text = "Digite o código do trem";
            // 
            // dgv_trens
            // 
            this.dgv_trens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trens.Location = new System.Drawing.Point(27, 18);
            this.dgv_trens.Name = "dgv_trens";
            this.dgv_trens.Size = new System.Drawing.Size(240, 224);
            this.dgv_trens.TabIndex = 6;
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(562, 14);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(116, 28);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lb_viagensFeitas2
            // 
            this.lb_viagensFeitas2.AutoSize = true;
            this.lb_viagensFeitas2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_viagensFeitas2.ForeColor = System.Drawing.Color.Blue;
            this.lb_viagensFeitas2.Location = new System.Drawing.Point(484, 188);
            this.lb_viagensFeitas2.Name = "lb_viagensFeitas2";
            this.lb_viagensFeitas2.Size = new System.Drawing.Size(61, 19);
            this.lb_viagensFeitas2.TabIndex = 12;
            this.lb_viagensFeitas2.Text = "viagem";
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 320);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.tbc_Consultas);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            this.tbc_Consultas.ResumeLayout(false);
            this.tb_passageiros.ResumeLayout(false);
            this.tb_passageiros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Passageiros)).EndInit();
            this.tb_cidades.ResumeLayout(false);
            this.tb_cidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cidades)).EndInit();
            this.tb_viagens.ResumeLayout(false);
            this.tb_viagens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_destinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Viagens)).EndInit();
            this.tb_trens.ResumeLayout(false);
            this.tb_trens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_Consultas;
        private System.Windows.Forms.TabPage tb_passageiros;
        private System.Windows.Forms.TabPage tb_cidades;
        private System.Windows.Forms.TabPage tb_viagens;
        private System.Windows.Forms.TabPage tb_trens;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_procurarPassageiro;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.DataGridView dgv_Passageiros;
        private System.Windows.Forms.Label lb_emailPassageiro;
        private System.Windows.Forms.Label lb_nomePassageiro;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.Label lb_nomeCidade;
        private System.Windows.Forms.Label lb_Cidade;
        private System.Windows.Forms.TextBox txt_siglaCidade;
        private System.Windows.Forms.Label lb_siglaCidade;
        private System.Windows.Forms.DataGridView dgv_cidades;
        private System.Windows.Forms.Button btn_procurarCidade;
        private System.Windows.Forms.Button btn_procurarViagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codViagem;
        private System.Windows.Forms.Label lb_codViagem;
        private System.Windows.Forms.DataGridView dgv_Viagens;
        private System.Windows.Forms.DataGridView dgv_destinos;
        private System.Windows.Forms.Button btn_procurarTrem;
        private System.Windows.Forms.Label lb_Viagem;
        private System.Windows.Forms.TextBox txt_codTrem;
        private System.Windows.Forms.Label lb_codTrem;
        private System.Windows.Forms.DataGridView dgv_trens;
        private System.Windows.Forms.Label lb_viagensFeitas;
        private System.Windows.Forms.Label lb_viagensFeitas2;
    }
}