using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTrab_Trem
{
    class Viagens
    {
        string _codViagem;
        string _codTrem;

        public string CodViagens 
        {
            get { return _codViagem; }
            set { _codViagem = value; }
        }

        public string CodTrens
        {
            get { return _codTrem; }
            set { _codTrem = value; }
        }
    }
}
