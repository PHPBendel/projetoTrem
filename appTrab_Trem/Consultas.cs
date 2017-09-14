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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Consultas_Load(object sender, EventArgs e) //preenche todos os dataGridView's
        {
            BLLPassageiro bllPassageiro = new BLLPassageiro();
            BLLCidades bllCidades = new BLLCidades();
            BLLViagens bllViagens = new BLLViagens();
            BLLTrens bllTrens = new BLLTrens();

            dgv_Passageiros.DataSource = bllPassageiro.selecionaPassageiro();
            dgv_cidades.DataSource = bllCidades.selecionaCidades();
            dgv_Viagens.DataSource = bllViagens.selecionaTodasViagens();
            dgv_trens.DataSource = bllTrens.selecionaTrens();

        }

        private void lb_nomeCidade_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_procurarPassageiro_Click(object sender, EventArgs e)//procura o passageiro a partir do seu CPF
        {
            if (txt_cpf.Text != "")
            {
                BLLPassageiro bllPassageiro = new BLLPassageiro();
                Passageiro umPassageiro = new Passageiro();
                umPassageiro = bllPassageiro.listaPassageiroPorCPF(txt_cpf.Text);

                if (umPassageiro.Nome == "")
                {
                    MessageBox.Show("CPF não cadastrado!");
                    txt_cpf.Text = "";
                }
                else
                {
                    lb_nomePassageiro.Text = umPassageiro.Nome;
                    lb_emailPassageiro.Text = umPassageiro.Email;
                }

            }
            else
            {
                MessageBox.Show("Digite o CPF do passageiro");
                txt_cpf.Text = "";
            }             
        }

        private void btn_procurarCidade_Click(object sender, EventArgs e)
        {
            if (txt_siglaCidade.Text != "")
            {
                BLLCidades bllCidades = new BLLCidades();
                Cidade umaCidade = new Cidade();
                umaCidade = bllCidades.listaCidadePorSigla(txt_siglaCidade.Text);

                if (umaCidade.siglaCidade == "")
                {
                    MessageBox.Show("Sigla não cadastrada!");
                    txt_cpf.Text = "";
                }
                else
                {
                    lb_nomeCidade.Text = umaCidade.Nome;                    
                }

            }
            else
            {
                MessageBox.Show("Digite a sigla da cidade");
                txt_cpf.Text = "";
            }
        }

        private void vtn_procurarViagem_Click(object sender, EventArgs e)
        {
            if (txt_codViagem.Text != "")
            {
                BLLViagens bllViagens = new BLLViagens();
                Viagens umaViagem = new Viagens();                
                umaViagem = bllViagens.listaViagemPorCod(txt_codViagem.Text);

                if (umaViagem.CodViagens == "nada")
                {
                    MessageBox.Show("Viagem não cadastrada");
                    txt_cpf.Text = "";
                }
                else
                {
                    dgv_destinos.DataSource = bllViagens.selecionaViagens(umaViagem);
                }

            }
            else
            {
                MessageBox.Show("Digite a sigla da cidade");
                txt_cpf.Text = "";
            }
        }

        private void btn_procurarTrem_Click(object sender, EventArgs e)
        {
            if (txt_codTrem.Text != "")
            {
                BLLTrens bllTrens = new BLLTrens();
                Trem umTrem = new Trem();
                umTrem = bllTrens.listaTremPorCod(txt_codTrem.Text);
               

                if (umTrem.codTrem == "")
                {                   
                    MessageBox.Show("Trem não cadastrado");
                    txt_cpf.Text = "";
                }
                else
                {
                    umTrem.codTrem = txt_codTrem.Text;
                    List<String> listaViagens = new List<String>();
                    listaViagens = bllTrens.listaViagens(umTrem);

                    lb_viagensFeitas.Text = listaViagens[0];
                    lb_viagensFeitas2.Text = listaViagens[1];
                }

            }
            else
            {
                MessageBox.Show("Digite a sigla da cidade");
                txt_cpf.Text = "";
            }
        }
    }
}
