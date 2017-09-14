using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTrab_Trem
{
    public partial class frm_manutencaoViagens : Form
    {
        int indiceLista = 0;
        List<Viagens> listaViagens = null;


        public frm_manutencaoViagens()
        {
            InitializeComponent();

        }
        private void frm_manutencaoViagens_Load(object sender, EventArgs e)
        {
            MontaLista(); //Montar e exibir a lista de viagens e cidades por onde passa
            ExibirLista();// ao carregar o form
            ExibirListaDest();

        }
        public void MontaLista() // monta a lista de ciagens e trens
        {
            BLLViagens umaBLL = new BLLViagens();
            listaViagens = umaBLL.listaViagens();
        } 

        public void ExibirLista()
        {
            if (indiceLista >= 0 && indiceLista <= listaViagens.Count - 1)
            {
                txt_codViagem.Text = listaViagens[indiceLista].CodViagens;
                txt_codTrem.Text = listaViagens[indiceLista].CodTrens;
            }

        } // exibe a lista de viagens e trens
        public void ExibirListaDest()
        {
            BLLViagens umaBLL = new BLLViagens();
            Viagens v = new Viagens();
            v.CodViagens = txt_codViagem.Text;
            dgv_viagens.DataSource = umaBLL.selecionaViagens(v);


        } // exibe a lista de destinos (cidades)

        public void DesabilitaHabilitaCampos(string x)
        {
            if (x == "cancelar")
            {
                btn_inicio.Enabled = true;
                btn_anterior.Enabled = true;
                btn_proximo.Enabled = true;
                btn_ultimo.Enabled = true;
                btn_procurar.Enabled = true;
                btn_sair.Enabled = true;
                btn_imprimir.Enabled = true;
            }
            else
            if (x == "editar")
            {
                btn_inicio.Enabled = false;
                btn_anterior.Enabled = false;
                btn_proximo.Enabled = false;
                btn_ultimo.Enabled = false;
                btn_procurar.Enabled = false;
                btn_sair.Enabled = false;
                btn_imprimir.Enabled = false;
            }
            else
                if (x == "inicio")
            {
                btn_ultimo.Enabled = true;
                btn_proximo.Enabled = true;
                btn_inicio.Enabled = false;
                btn_anterior.Enabled = false;
            }
            else
                    if (x == "anterior")
            {
                btn_proximo.Enabled = true;
                btn_ultimo.Enabled = true;
                if (indiceLista == 0)
                {
                    btn_inicio.Enabled = false;
                    btn_anterior.Enabled = false;
                }
            }
            else
                        if (x == "proximo")
            {
                btn_inicio.Enabled = true;
                btn_anterior.Enabled = true;
                if (indiceLista == listaViagens.Count - 1)
                {
                    btn_proximo.Enabled = false;
                    btn_ultimo.Enabled = false;
                }
            }
            else
                            if (x == "ultimo")
            {
                btn_ultimo.Enabled = false;
                btn_proximo.Enabled = false;
                btn_inicio.Enabled = true;
                btn_anterior.Enabled = true;
            }


        } //método de faz a dinâmica de habilitar e desabilitar campos


        private void tsm_inicio_Click(object sender, EventArgs e) //vai para o primeiro registro da lista
        {
            indiceLista = 0;
            DesabilitaHabilitaCampos("inicio");
            ExibirLista();
            ExibirListaDest();
        }

        private void tsm_anterior_Click(object sender, EventArgs e)// vai para o registro anterior da lista
        {
            indiceLista--;
            DesabilitaHabilitaCampos("anterior");
            ExibirLista();
            ExibirListaDest();
        }

        private void tsm_proximo_Click(object sender, EventArgs e)// vai para o próximo registro da lista
        {
            indiceLista++;
            DesabilitaHabilitaCampos("proximo");
            ExibirLista();
            ExibirListaDest();


        }

        private void tsm_ultimo_Click(object sender, EventArgs e) //vai para o ultimo registro da lista
        {
            indiceLista = listaViagens.Count - 1;
            DesabilitaHabilitaCampos("ultimo");
            ExibirLista();
            ExibirListaDest();

        }
        private void btn_incluir_Click(object sender, EventArgs e)  // PREPARA os campos para incluir um registro
        {
            DesabilitaHabilitaCampos("editar");
            txt_codViagem.Enabled = true;
            txt_codTrem.Enabled = true;
            txt_codViagem.Focus();

            DesabilitaHabilitaCampos("editar/cancelar");


        }

        private void btn_excluir_Click(object sender, EventArgs e) //EXCLUI um registro e atualiza as listas
        {

            Viagens myViagem = new Viagens();
            myViagem.CodViagens = txt_codViagem.Text;
            myViagem.CodTrens = txt_codTrem.Text;
            try
            {
                BLLViagens bll = new BLLViagens();
                bll.excluirViagem(myViagem);
                MessageBox.Show("Registro excluído com sucesso.");
                MontaLista();
                ExibirLista();
                ExibirListaDest();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message.ToString());
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e) // dinamica de enables
        {
            DesabilitaHabilitaCampos("cancelar");
            txt_codViagem.Enabled = false;
            txt_codTrem.Enabled = false;
        }

        private void btn_salvar_Click(object sender, EventArgs e) // verifica se os campos sao válidos e salva um novo registro
        {
            Validacao valida = new Validacao();
            bool erro = false;

            if (txt_codViagem.Text == "" || txt_codTrem.Text == "")
            {
                MessageBox.Show("Digite o codigo da cidade e do trem!");
                erro = true;
            }
            else
                if (txt_codViagem.Text.Length != 5)
            {
                MessageBox.Show("Codigo deve ter 5 dígitos");
                erro = true;
            }
            else
                    if (!valida.verificaCod(txt_codViagem.Text))
            {
                MessageBox.Show("Este codigo já foi cadastrado");
                erro = true;
            }

            if (erro == false)
            {
                BLLViagens umaBLL = new BLLViagens();
                Viagens umaViagem = new Viagens();

                umaViagem.CodViagens = txt_codViagem.Text;
                umaViagem.CodTrens = txt_codTrem.Text;
                umaBLL.novaViagem(umaViagem);

                MessageBox.Show("Viagem cadastrada com sucesso !!!");
                txt_codTrem.Text = "";
                txt_codViagem.Text = "";
                MontaLista();
                ExibirLista();
                ExibirListaDest();
            }
        }

        private void btn_procurar_Click(object sender, EventArgs e) //procura um determinado registro na lista
        {

            BLLViagens umaBLL = new BLLViagens();
            Viagens umaViagem = new Viagens();

            txt_codViagem.Clear();
            txt_codTrem.Clear();
            txt_codViagem.Focus();

            ExibirListaDest();


        }

        private void btn_sair_Click(object sender, EventArgs e)// fecha o programa
        {
            this.Close();
        }

        private void dgv_viagens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
