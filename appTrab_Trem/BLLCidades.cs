using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace appTrab_Trem
{
    class BLLCidades
    {
         public BLLCidades()
    {

    }
    public DataTable selecionaCidades() // retorna todos as cidades numa tabela
    {
      DataTable tb = new DataTable();
      try
      {
        var dal = new DALCidades("regulus","BD16394","BD16394");
        tb = dal.selectCidades();
      }
      catch (Exception ex)
      {
        throw ex;
      }
      return tb;
    }
    public void novaCidade(Cidade cidade) // inclui uma nova cidade
    {
      try
      {
          var dal = new DALCidades("regulus", "BD16394", "BD16394");
        dal.insertCidade(cidade);
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public void alteraCidade(Cidade cidade) // altera os dados de uma cidade
    {
      try
      {
          var dal = new DALCidades("regulus", "BD16394", "BD16394");
        dal.updateCidade(cidade);
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public void excluiCidade(Cidade cidade) // exclui uma cidade
    {
      try
      {
          var dal = new DALCidades("regulus", "BD16394", "BD16394");
        dal.deleteCidade(cidade);
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public List<Cidade> listaCidades() // retorna uma lista genérica de cidades
    {
      try{
          var dal = new DALCidades("regulus", "BD16394", "BD16394");
        return dal.selectListCidades();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public Cidade listaCidadePorSigla(string sigla) // retorna uma única cidade
    {
      try
      {
          var dal = new DALCidades("regulus", "BD16394", "BD16394");
        return dal.selectCidadeBySigla(sigla);
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    }
}
