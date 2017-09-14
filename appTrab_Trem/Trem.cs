using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTrab_Trem
{
    class Trem
    {
        string _codTrem;
        Int32 _numVagoes;


        public String codTrem
        {
            get { return _codTrem; }
            set { _codTrem = value; }
        }

        public Int32 numVagoes
        {
            get { return _numVagoes; }
            set
            { _numVagoes = value; }
        }
    }
}
