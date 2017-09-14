using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace appTrab_Trem
{
    class BLLTrens
    {
        public BLLTrens()
        {

        }
        public DataTable selecionaTrens() 
        {
            DataTable tb = new DataTable();
            try
            {
                var dal = new DALTrens("regulus", "BD16394", "BD16394");
                tb = dal.selectTrens();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        public DataTable selecionaPoltronas(string codTrem)
        {
            DataTable tb = new DataTable();
            try
            {
                var dal = new DALTrens("regulus", "BD16394", "BD16394");
                tb = dal.selecionaPoltronas(codTrem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        public void novoTrem(Trem trem)
        {
            try
            {
                var dal = new DALTrens("regulus", "BD16394", "BD16394");
                dal.insertTrens(trem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void alteraTrem(Trem trem) 
        {
            try
            {
                var dal = new DALTrens("regulus", "BD16394", "BD16394");
                dal.updateTrem(trem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void excluiTrem(Trem trem) 
        {
            try
            {
                var dal = new DALTrens("regulus", "BD16394", "BD16394");
                dal.deleteTrem(trem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Trem> listaTrens() 
        {
            try
            {
                var dal = new DALTrens("regulus", "BD16394", "BD16394");
                return dal.selectListTrens();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<String> listaViagens(Trem umTrem) 
        {
            try
            {
                var dal = new DALTrens("regulus", "BD16394", "BD16394");
                return dal.consultaViagens(umTrem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Trem listaTremPorCod(string cod) 
        {
            try
            {
                var dal = new DALTrens("regulus", "BD16394", "BD16394");
                return dal.selectTremByCod(cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
