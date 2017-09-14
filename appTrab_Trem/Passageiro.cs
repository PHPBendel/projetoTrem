using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTrab_Trem
{
    class Passageiro
    {
        string _nomePassageiro;
        string _emailPassageiro;


        public String Nome
        {
            get { return _nomePassageiro; }
            set { _nomePassageiro = value; }
        }

        public String Email
        {
            get { return _emailPassageiro; }
            set
            { _emailPassageiro = value; }
        }
    }
}
