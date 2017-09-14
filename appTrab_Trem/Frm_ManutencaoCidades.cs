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
    public partial class frm_manutencaoCidades : Form
    {


        int registroAtual = 0; //variável usada para a navegação nos registros
        List<Cidade> listaCidades = new List<Cidade>();
        BLLCidades umaBLL = new BLLCidades();
        Cidade umaCidade = new Cidade();

        public frm_manutencaoCidades()
        {                                           
            InitializeComponent();
        }

        private void frm_cadastro_Load(object sender, EventArgs e)
        {            

            dgvCidades.DataSource = umaBLL.selecionaCidades();//cria a lista a partir de um dataTable do BD

            listaCidades = umaBLL.listaCidades();            

            if (registroAtual >= 0 && registroAtual <= listaCidades.Count - 1) //caso tenha no minimo um registro no BD, ele carrega o primeiro registro no textBox
            {                
                txt_sigla.Text = listaCidades[registroAtual].siglaCidade;
                txt_nomeCidade.Text = listaCidades[registroAtual].Nome;
            }

            if (registroAtual == listaCidades.Count - 1)
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

        private void txt_sigla_KeyUp(object sender, KeyEventArgs e)  //funções para keyUp, na aba cadastro
        {
          

        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btn_salvar_Click(object sender, EventArgs e)
        {         
         
         }

        private void btn_proximo_Click(object sender, EventArgs e)
        {     
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
                           
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {                    
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_inicio_Click_1(object sender, EventArgs e)
        {   //carrega o primeiro registro e atualiza a lista
            registroAtual = 0;
            frm_cadastro_Load(sender, e);
        }

        private void btn_sair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_anterior_Click_1(object sender, EventArgs e)
        {
            //carrega o registro anterior e atualiza a lista
            registroAtual--;
            frm_cadastro_Load(sender, e);
        }

        private void btn_proximo_Click_1(object sender, EventArgs e)
        {

            //vai pra o próximo registro e atualiza a lista            
            registroAtual++;
            frm_cadastro_Load(sender, e);
        }

        private void btn_ultimo_Click_1(object sender, EventArgs e)
        {
            //carrega o ultimo registro e atualiza a lista
            registroAtual = listaCidades.Count - 1;
            frm_cadastro_Load(sender, e);
        }

        private void btn_incluir_Click_1(object sender, EventArgs e)
        {
            tbc_paginaCadastro.SelectTab(1);
            //desabilita os botões que não serão usados na função de incluir, e deixa o cancelar habilitado
            txt_sigla.Text = "";
            txt_nomeCidade.Text = "";
            txt_sigla.Enabled = true;
            txt_sigla.Focus();
            btn_anterior.Enabled = false;
            btn_inicio.Enabled = false;
            btn_proximo.Enabled = false;
            btn_ultimo.Enabled = false;
            btn_editar.Enabled = false;
            btn_procurar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_imprimir.Enabled = false;
        }

        private void btn_editar_Click_1(object sender, EventArgs e)
        {
            tbc_paginaCadastro.SelectTab(1);
            txt_nomeCidade.Enabled = true;            //habilita o txt cidade
            txt_sigla.Enabled = false;                //desabilita a possibilidade de editar a sigla                
            btn_anterior.Enabled = false;             //desabilita os botões, com exceção do editar, salvar, cancelar e sair
            btn_inicio.Enabled = false;
            btn_proximo.Enabled = false;
            btn_ultimo.Enabled = false;
            btn_incluir.Enabled = false;
            btn_procurar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_imprimir.Enabled = false;
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            //habilita todos o botões
            txt_sigla.Text = "";
            txt_nomeCidade.Text = "";
            txt_nomeCidade.Enabled = false;
            txt_sigla.Enabled = false;
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
            frm_cadastro_Load(sender, e);
        }

        private void btn_salvar_Click_1(object sender, EventArgs e)
        {

            Validacao validar = new Validacao();
            bool erro = false; //variável usada para caso algum erro ocorra na validação

            //verifica se os textbox estão vazios
            if (txt_sigla.Text == "" || txt_nomeCidade.Text == "")
            {
                MessageBox.Show("Digite a sigla e o nome da cidade!");
                erro = true;
            }

            //verifica se o textbox tem 4 dígitos
            else if (txt_sigla.Text.Length != 4)
            {
                MessageBox.Show("Sigla deve ter 4 dígitos");
                erro = true;
            }

            //caso não tenha encontrado nenhum problema na validação
            if (erro == false)
            {
                //caso o método retorne que a sigla já exista, significa que queremos editar o registro
                if (btn_editar.Enabled == true && btn_incluir.Enabled == true)
                {
                    MessageBox.Show("Escolha uma opção antes de salvar.");
                }
                else if (!validar.verificaSigla(txt_sigla.Text))
                {
                    umaCidade.siglaCidade = txt_sigla.Text;
                    umaCidade.Nome = txt_nomeCidade.Text;
                                        
                    umaBLL.alteraCidade(umaCidade); //edita o nome da cidade
                    txt_nomeCidade.Enabled = false;//e habilita os botões 
                    txt_sigla.Enabled = false;
                    btn_anterior.Enabled = true;
                    btn_inicio.Enabled = true;
                    btn_proximo.Enabled = true;
                    btn_ultimo.Enabled = true;
                    btn_incluir.Enabled = true;
                    btn_procurar.Enabled = true;
                    btn_excluir.Enabled = true;
                    btn_imprimir.Enabled = true;
                    frm_cadastro_Load(sender, e);

                    MessageBox.Show("Cidade editada com sucesso!");
                }
                else
                {
                    //se queremos adicionar uma nova cidade                                                            
                    umaCidade.siglaCidade = txt_sigla.Text;
                    umaCidade.Nome = txt_nomeCidade.Text;
                    umaBLL.novaCidade(umaCidade);

                    MessageBox.Show("Cidade cadastrada com sucesso!");
                    txt_sigla.Text = "";
                    txt_nomeCidade.Text = "";
                    txt_nomeCidade.Enabled = false;
                    txt_sigla.Enabled = false;
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
                    frm_cadastro_Load(sender, e);
                }
            }
        }

        private void btn_excluir_Click_1(object sender, EventArgs e)
        {
            //exclui o registro que está sendo mostrado atualmente            
            umaCidade.siglaCidade = txt_sigla.Text;
            umaBLL.excluiCidade(umaCidade);

            MessageBox.Show("Cidade excluída com sucesso!");
            registroAtual = 0;
            frm_cadastro_Load(sender, e);  // chama para remontar a lista de cidades, agora atualizada sem o registro excluído
        }

        private void btn_procurar_Click_1(object sender, EventArgs e)
        {
            tbc_paginaCadastro.SelectTab(1);
            txt_sigla.Text = "";
            txt_nomeCidade.Text = "";
            txt_sigla.Enabled = true;
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

        private void btn_imprimir_Click(object sender, EventArgs e)
        {

        }

        private void txt_sigla_KeyUp_1(object sender, KeyEventArgs e)
        {
            string sigla = txt_sigla.Text;  //variável com o texto atual

            if (btn_incluir.Enabled == true)    //caso incluir esteja habilitado, não podemos permitir uma sigla repetida, pois um novo cadastro será feito
            {
                if (sigla.Length == 4)
                {
                    Validacao validar = new Validacao();

                    if (!validar.verificaSigla(txt_sigla.Text))  //usa a função que verifica sigla da classe verificação
                    { //caso retorne false, a sigla já existe no BD
                        MessageBox.Show("Esta sigla já foi cadastrada");
                        txt_sigla.Text = "";
                    }
                    else
                        txt_nomeCidade.Enabled = true;  //se não existir, habilita textbox do nome da cidade
                }
                else
                    txt_nomeCidade.Enabled = false; //se o usuário não estiver incluindo, podemos desabilitar o textbox cidade

            }
            else     //keyup para caso o usuário esteja usando a função de procurar
            {
                if (sigla.Length == 4) //ao digitar 4 caracteres, faz a procura da sigla
                {
                    umaCidade = umaBLL.listaCidadePorSigla(sigla);

                    if (umaCidade.siglaCidade == "")  //se o método retornar uma string vazia, significa que não encontrou a sigla
                    {
                        MessageBox.Show("Esta sigla não existe."); 

                        txt_sigla.Text = "";
                    }
                    else
                    {   //retorna a sigla encontrada no BD
                        txt_sigla.Text = umaCidade.siglaCidade;
                        txt_nomeCidade.Text = umaCidade.Nome;
                    }

                }

            }
        }

        private void dgvCidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
