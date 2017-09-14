using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace appTrab_Trem
{
    class BLLViagens
    {
        public BLLViagens()
        {
        }
        public DataTable selecionaViagens(Viagens v) 
        {
            DataTable tb = new DataTable();
            try
            {
                var dal = new DALViagens("regulus", "BD16394", "BD16394");
                tb = dal.selectViagem(v);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        public DataTable selecionaTodasViagens()
        {
            DataTable tb = new DataTable();
            try
            {
                var dal = new DALViagens("regulus", "BD16394", "BD16394");
                tb = dal.selectViagens();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        public void novaViagem(Viagens viagem)
        {
            try
            {
                var dal = new DALViagens("regulus", "BD16394", "BD16394");
                dal.insertViagem(viagem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Viagens listaViagemPorCod(string cod) 
        {
          try
          {
            var dal = new DALViagens("regulus", "BD16394", "BD16394");
            return dal.selectViagemPorCod(cod);
          }
          catch (Exception ex)
          {
            throw ex;
          }
        }
    
        public void alteraViagem(Viagens viagem)
        {
            try
            {
                var dal = new DALViagens("regulus", "BD16394", "BD16394");
                dal.updateViagem(viagem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void excluirViagem(Viagens viagem)
        {
            try
            {
                var dal = new DALViagens("regulus", "BD16394", "BD16394");
                dal.deleteViagem(viagem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Viagens> listaViagens()
        {
            try
            {
                var dal = new DALViagens("regulus", "BD16394", "BD16394");
                return
                dal.selectListViagens();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
