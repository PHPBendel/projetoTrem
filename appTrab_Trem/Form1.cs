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
    public partial class frm_paginaPrincipal : Form
    {
        public frm_paginaPrincipal()
        {
            InitializeComponent();
        }

        private void mItens_cidades_Click(object sender, EventArgs e)
        {
            frm_manutencaoCidades frmCidades = new frm_manutencaoCidades();
            frmCidades.Show();
        }

        private void mItens_viagens_Click(object sender, EventArgs e)
        {
            frm_manutencaoViagens frmViagens = new frm_manutencaoViagens();
            frmViagens.Show();
        }
    }
}
