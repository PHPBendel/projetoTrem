using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTrab_Trem
{
    class Validacao
    {
        public void Validar()
        {

        }

        public bool verificaSigla(string sigla) //verifica se a sigla já existe no banco
        {
            BLLCidades umaBLL = new BLLCidades();
            Cidade testeSigla = new Cidade();
            testeSigla.siglaCidade = sigla;
            testeSigla = umaBLL.listaCidadePorSigla(testeSigla.siglaCidade);

            if (testeSigla.siglaCidade != "")
                //caso a sigla esteja cadastrada
                return false;
            else
                //caso não esteja cadastrada
                return true;
        }


        public bool verificaCod(string cod)
        {
            BLLViagens umaBLL = new BLLViagens();
            Viagens viagem = new Viagens();
            viagem.CodViagens = cod;
            viagem = umaBLL.listaViagemPorCod(viagem.CodViagens);

            if (viagem.CodViagens != "nada")
                return false;
            else
                return true;
        }

        public bool verificaCodTrem(string cod) //verifica se o código do trem já existe no banco
        {
            BLLTrens umaBLL = new BLLTrens();
            Trem trem = new Trem();
            trem.codTrem = cod;
            trem = umaBLL.listaTremPorCod(trem.codTrem);

            if (trem.codTrem != "")
                //caso a sigla esteja cadastrada
                return false;
            else
                //caso não esteja cadastrada
                return true;
        }
    }
}
