using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace appTrab_Trem
{
    class BLLPassageiro
    {
        public BLLPassageiro()
        {

        }
        public DataTable selecionaPassageiro() // retorna todos os passageiros numa tabela
        {
            DataTable tb = new DataTable();
            try
            {
                var dal = new DALPassageiros("regulus", "BD16394", "BD16394");
                tb = dal.selectPassageiros();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }
                             
        public Passageiro listaPassageiroPorCPF(string cpf) // retorna um único passageiro
        {
            try
            {
                var dal = new DALPassageiros("regulus", "BD16394", "BD16394");
                return dal.selectPassageiroByCPF(cpf);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
