using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace appTrab_Trem
{
    class DALCidades
    {
        SqlConnection _conexaoBD;
        string _cadeiaConexao;

        public DALCidades(string servidor, string bancoDeDados, string usuario)
        {
            _cadeiaConexao = "Data Source=" + servidor +
                             ";Initial Catalog=" + bancoDeDados +
                             ";Persist Security Info=True;" +
                             ";User ID=" + usuario +
                             ";Password=BD16394";
        }

        public DataTable selectCidades()
        {
            try
            {
                String sql = "SELECT * FROM trem_cidade order by nome";
                _conexaoBD = new SqlConnection(_cadeiaConexao);

                SqlCommand cmd = new SqlCommand(sql, _conexaoBD);

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Cidade selectCidadeBySigla(string sigla)
        {
            try
            {
                String sql = "SELECT * FROM trem_cidade WHERE sigla = @sigla";
                _conexaoBD = new SqlConnection(_cadeiaConexao);
                SqlCommand cmd = new SqlCommand(sql, _conexaoBD);
                cmd.Parameters.AddWithValue("@sigla", sigla);
                _conexaoBD.Open();

                SqlDataReader dr;

                Cidade cidadeLida = new Cidade();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.Read())
                {
                    cidadeLida.siglaCidade = Convert.ToString(dr["sigla"]);
                    cidadeLida.Nome = dr["nome"].ToString();
                    
                }
                else
                    cidadeLida.siglaCidade = ""; // indica que não achou o id procurado
                return cidadeLida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Cidade> selectListCidades()
        {
            try
            {
                _conexaoBD = new SqlConnection(_cadeiaConexao);
                SqlCommand comSql = new SqlCommand("Select * from trem_cidade", _conexaoBD);
                _conexaoBD.Open();
                List<Cidade> listaCidades = new List<Cidade>();
                SqlDataReader dr = comSql.ExecuteReader();
                while (dr.Read())
                {
                    Cidade cidade = new Cidade();
                    cidade.siglaCidade = (String)dr["sigla"];
                    cidade.Nome = (String)dr["nome"];                    
                    listaCidades.Add(cidade);
                }
                _conexaoBD.Close();
                return listaCidades;
            }
            catch (Exception ex)
            {
                _conexaoBD.Close();
                throw new Exception("Erro ao acessar cidades " + ex.Message);
            }
        }

        public void insertCidade(Cidade cidade)
        {
            try
            {
                String sql = "INSERT INTO trem_cidade (sigla,nome)" +
                             " VALUES (@sigla,@nome)";
                _conexaoBD = new SqlConnection(_cadeiaConexao);

                SqlCommand cmdSql = new SqlCommand(sql, _conexaoBD);

                cmdSql.Parameters.AddWithValue("@sigla", cidade.siglaCidade);
                cmdSql.Parameters.AddWithValue("@nome", cidade.Nome);
                _conexaoBD.Open();
                cmdSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conexaoBD.Close();
            }
        }

        public void updateCidade(Cidade cidade)
        {
            try
            {
                String sql = "UPDATE trem_cidade" +
                             " SET nome = @nome" +
                             " WHERE sigla = @sigla ";

                _conexaoBD = new SqlConnection(_cadeiaConexao);
                SqlCommand cmd = new SqlCommand(sql, _conexaoBD);
                cmd.Parameters.AddWithValue("@sigla", cidade.siglaCidade);
                cmd.Parameters.AddWithValue("@nome", cidade.Nome);                
                _conexaoBD.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conexaoBD.Close();
            }
        }

        public void deleteCidade(Cidade cidade)
        {
            try
            {
                String sql = "DELETE FROM trem_cidade WHERE sigla = @sigla ";
                _conexaoBD = new SqlConnection(_cadeiaConexao);
                SqlCommand cmd = new SqlCommand(sql, _conexaoBD);
                cmd.Parameters.AddWithValue("@sigla", cidade.siglaCidade);
                _conexaoBD.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conexaoBD.Close();
            }
        }
    }
}

