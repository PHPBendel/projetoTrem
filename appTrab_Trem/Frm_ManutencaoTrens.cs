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
    public partial class Frm_ManutencaoTrens : Form
    {
        public Frm_ManutencaoTrens()
        {
            InitializeComponent();
        }

        List<Trem> listaTrens = new List<Trem>();
        BLLTrens umaBLL = new BLLTrens();
        Trem umTrem = new Trem();
        int registroAtual = 0;
        int idVagao;

        private void Frm_ManutencaoTrens_Load(object sender, EventArgs e)
        {
            listaTrens = umaBLL.listaTrens();

            dgv_trens.DataSource = umaBLL.selecionaTrens();
            txt_vagaoVisualizado.Text = "1";
                        
            if (registroAtual >= 0 && registroAtual <= listaTrens.Count - 1) //caso tenha no minimo um registro no BD, ele carrega o primeiro registro no textBox
            {
                txt_codTrem.Text = listaTrens[registroAtual].codTrem;
                txt_nVagoes.Text = Convert.ToString(listaTrens[registroAtual].numVagoes);

                dgv_vagao.DataSource = umaBLL.selecionaPoltronas(txt_codTrem.Text);
            }

            if (registroAtual == listaTrens.Count - 1)
            {
                btn_proximo.Enabled = false;
                btn_ultimo.Enabled = false;
            }
            else
            {
                btn_proximo.Enabled = true;
                btn_ultimo.Enabled = true;
            }

            if (registroAtual == 0)
            {
                btn_anterior.Enabled = false;
                btn_inicio.Enabled = false;
            }
            else
            {
                btn_anterior.Enabled = true;
                btn_inicio.Enabled = true;
            }           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            txt_codTrem.Enabled = true;
            txt_codTrem.Text = "";
            txt_nVagoes.Text = "";
            txt_nVagoes.Enabled = false;
            txt_vagaoVisualizado.Enabled = false;            
            btn_anterior.Enabled = false;
            btn_inicio.Enabled = false;
            btn_proximo.Enabled = false;
            btn_ultimo.Enabled = false;
            btn_editar.Enabled = false;
            btn_procurar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_imprimir.Enabled = false;
        }

        private void txt_codTrem_KeyUp(object sender, KeyEventArgs e)
        {
            string codigo = txt_codTrem.Text;

            if (btn_incluir.Enabled == true)    //caso incluir esteja habilitado, não podemos permitir um código repetido, pois um novo cadastro será feito
            {
                if (codigo.Length == 6)
                {
                    Validacao validar = new Validacao();

                    if (!validar.verificaCodTrem(codigo))  //usa a função que verifica código da classe verificação
                    { //caso retorne false, o código já existe no BD
                        MessageBox.Show("Este código já foi cadastrado");
                        txt_codTrem.Text = "";
                    }
                    else
                        txt_nVagoes.Enabled = true;  //se não existir, habilita textbox do número de vagões
                }
                else
                    txt_nVagoes.Enabled = false; //se o usuário não estiver incluindo, podemos desabilitar o textbox vagões

            }
            else     //keyup para caso o usuário esteja usando a função de procurar
            {
                if (codigo.Length == 6) //ao digitar 6 caracteres, faz a procura do código
                {
                    umTrem = umaBLL.listaTremPorCod(codigo);

                    if (umTrem.codTrem == "")  //se o método retornar uma string vazia, significa que não encontrou o código
                    {
                        MessageBox.Show("Esta código não existe.");

                        txt_codTrem.Text = "";
                    }
                    else
                    {   //retorna o código encontrado no BD
                        txt_codTrem.Text = umTrem.codTrem;
                        txt_nVagoes.Text = Convert.ToString(umTrem.numVagoes);
                    }

                }

            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Validacao validar = new Validacao();
            bool erro = false; //variável usada para caso algum erro ocorra na validação

            //verifica se os textbox estão vazios
            if (txt_codTrem.Text == "" || txt_nVagoes.Text == "")
            {
                MessageBox.Show("Digite o código e número de vagões do trem!");
                erro = true;
            }

            //verifica se o textbox tem 6 dígitos
            else if (txt_codTrem.Text.Length != 6)
            {
                MessageBox.Show("Código deve ter 6 dígitos");
                erro = true;
            }

            //se não encontrou nenhum problema na validação
            if (erro == false)
            {
                //caso o usuário tenha clicado me salvar sem motivo
                if (btn_editar.Enabled == true && btn_incluir.Enabled == true)
                {
                    MessageBox.Show("Escolha uma opção antes de salvar.");
                }
                //caso o método retorne que o código já existe, significa que queremos editar o registro
                else if (!validar.verificaCodTrem(txt_codTrem.Text))
                {
                    umTrem.codTrem = txt_codTrem.Text;
                    umTrem.numVagoes = Convert.ToInt32(txt_nVagoes.Text);

                    umaBLL.alteraTrem(umTrem); //edita o nome da cidade
                    txt_codTrem.Enabled = false;//e habilita os botões 
                    txt_nVagoes.Enabled = false;
                    btn_anterior.Enabled = true;
                    btn_inicio.Enabled = true;
                    btn_proximo.Enabled = true;
                    btn_ultimo.Enabled = true;
                    btn_incluir.Enabled = true;
                    btn_procurar.Enabled = true;
                    btn_excluir.Enabled = true;
                    btn_imprimir.Enabled = true;
                    Frm_ManutencaoTrens_Load(sender, e);

                    MessageBox.Show("Trem editado com sucesso!");
                }
                else
                {
                    //se queremos adicionar um novo trem                                                
                    umTrem.codTrem = txt_codTrem.Text;
                    umTrem.numVagoes = Convert.ToInt32(txt_nVagoes.Text);
                    umaBLL.novoTrem(umTrem);

                    MessageBox.Show("Trem cadastrado com sucesso!");
                    txt_codTrem.Text = "";
                    txt_nVagoes.Text = "";
                    txt_nVagoes.Enabled = false;
                    txt_codTrem.Enabled = false;
                    btn_anterior.Enabled = true;
                    btn_inicio.Enabled = true;
                    btn_proximo.Enabled = true;
                    btn_ultimo.Enabled = true;
                    btn_incluir.Enabled = true;
                    btn_procurar.Enabled = true;
                    btn_excluir.Enabled = true;
                    btn_imprimir.Enabled = true;
                    btn_editar.Enabled = true;
                    registroAtual = 0;
                    Frm_ManutencaoTrens_Load(sender, e);
                }
            }
        }

        private void txt_nVagoes_KeyUp(object sender, KeyEventArgs e)
        {            
            if (txt_nVagoes.Text != "")
            {
                try
                {
                    int vagoes = Convert.ToInt32(txt_nVagoes.Text);

                    if (vagoes < 1 || vagoes > 10)
                    {
                        MessageBox.Show("Trem deve ter no máximo 10 vagões");
                        txt_nVagoes.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Digite somente números!");
                    txt_nVagoes.Text = "";
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            tbc_paginaCadastro.SelectTab(0);
            txt_nVagoes.Enabled = true;            //habilita o txt número de vagões
            txt_nVagoes.Focus();
            txt_codTrem.Enabled = false;                //desabilita a possibilidade de editar o código
            btn_anterior.Enabled = false;             //desabilita os botões, com exceção do editar, salvar, cancelar e sair
            btn_inicio.Enabled = false;
            btn_proximo.Enabled = false;
            btn_ultimo.Enabled = false;
            btn_incluir.Enabled = false;
            btn_procurar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_imprimir.Enabled = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //habilita todos o botões
            txt_codTrem.Text = "";
            txt_nVagoes.Text = "";
            txt_nVagoes.Enabled = false;
            txt_codTrem.Enabled = false;
            btn_anterior.Enabled = true;
            btn_inicio.Enabled = true;
            btn_proximo.Enabled = true;
            btn_ultimo.Enabled = true;
            btn_incluir.Enabled = true;
            btn_procurar.Enabled = true;
            btn_excluir.Enabled = true;
            btn_imprimir.Enabled = true;
            btn_editar.Enabled = true;
            btn_salvar.Enabled = true;
            Frm_ManutencaoTrens_Load(sender, e);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            //exclui o registro que está sendo mostrado atualmente            
            umTrem.codTrem = txt_codTrem.Text;
            umaBLL.excluiTrem(umTrem);

            MessageBox.Show("Trem excluído com sucesso!");
            registroAtual = 0;
            Frm_ManutencaoTrens_Load(sender, e);  // chama para remontar a lista de cidades, agora atualizada sem o registro excluído
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            tbc_paginaCadastro.SelectTab(0);
            txt_codTrem.Text = "";            
            txt_nVagoes.Text = "";
            txt_codTrem.Enabled = true;
            btn_anterior.Enabled = false;
            btn_inicio.Enabled = false;
            btn_proximo.Enabled = false;
            btn_ultimo.Enabled = false;
            btn_incluir.Enabled = false;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_salvar.Enabled = false;
            btn_imprimir.Enabled = false;
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            //carrega o primeiro registro e atualiza a lista
            registroAtual = 0;
            Frm_ManutencaoTrens_Load(sender, e);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            //carrega o registro anterior e atualiza a lista
            registroAtual--;
            Frm_ManutencaoTrens_Load(sender, e);
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            //vai pra o próximo registro e atualiza a lista            
            registroAtual++;
            Frm_ManutencaoTrens_Load(sender, e);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            //carrega o ultimo registro e atualiza a lista
            registroAtual = listaTrens.Count - 1;
            Frm_ManutencaoTrens_Load(sender, e);
        }

        private void numUp_vagao_ValueChanged(object sender, EventArgs e)
        {                                                        
        }

        private void btn_vagaoAnterior_Click(object sender, EventArgs e)
        {
            int vagaoVisualizado = Convert.ToInt32(txt_vagaoVisualizado.Text);
            if (vagaoVisualizado > 1)
            {
                vagaoVisualizado--;
                txt_vagaoVisualizado.Text = Convert.ToString(vagaoVisualizado);
            }                  
        }

        private void btn_proximoVagao_Click(object sender, EventArgs e)
        {
            int vagaoVisualizado = Convert.ToInt32(txt_vagaoVisualizado.Text);
            if (vagaoVisualizado < Convert.ToInt32(txt_nVagoes.Text))
            {
                vagaoVisualizado++;
                txt_vagaoVisualizado.Text = Convert.ToString(vagaoVisualizado);
            }
        }
    }
}
