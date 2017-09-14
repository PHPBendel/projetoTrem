using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace appTrab_Trem
{
    class DALTrens
    {
        SqlConnection _conexaoBD;
        string _cadeiaConexao;

        public DALTrens(string servidor, string bancoDeDados, string usuario)
        {
            _cadeiaConexao = "Data Source=" + servidor +
                             ";Initial Catalog=" + bancoDeDados +
                             ";Persist Security Info=True;" +
                             ";User ID=" + usuario +
                             ";Password=BD16394";
        }

        public DataTable selectTrens()
        {
            try
            {
                String sql = "SELECT * FROM trem_trem order by Codigo";
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

        public DataTable selecionaPoltronas(string cod) //seleciona as poltronas de um trem, a partir de seu código
        {
            try
            {
                String sql = "SELECT (CAST(tp.fileira as varchar(2))+ tp.coluna) as Fileira FROM trem_poltrona tp INNER JOIN trem_vagao tv ON tv.id = tp.idVagao INNER JOIN trem_trem tt ON tt.Codigo = tv.codTrem WHERE tt.Codigo = @codTrem";
                _conexaoBD = new SqlConnection(_cadeiaConexao);

                SqlCommand cmd = new SqlCommand(sql, _conexaoBD);
                cmd.Parameters.AddWithValue("@codTrem", cod);               

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
      
        public List<String> consultaViagens(Trem umTrem)
        {
            try
            {
                _conexaoBD = new SqlConnection(_cadeiaConexao);
                SqlCommand comSql = new SqlCommand("Select codigo from trem_viagem WHERE codTrem = @cod", _conexaoBD);
                comSql.Parameters.AddWithValue("@cod", umTrem.codTrem);
                _conexaoBD.Open();
                List<String> listaViagens = new List<String>();
                SqlDataReader dr = comSql.ExecuteReader();
                while (dr.Read())
                {                
                    listaViagens.Add((String)dr["codigo"]);
                }
                _conexaoBD.Close();
                return listaViagens;
            }
            catch (Exception ex)
            {
                _conexaoBD.Close();
                throw new Exception("Erro ao acessar trens " + ex.Message);
            }
        }

        public Trem selectTremByCod(string cod)
        {
            try
            {
                String sql = "SELECT * FROM trem_trem WHERE Codigo = @cod";
                _conexaoBD = new SqlConnection(_cadeiaConexao);
                SqlCommand cmd = new SqlCommand(sql, _conexaoBD);
                cmd.Parameters.AddWithValue("@cod", cod);
                _conexaoBD.Open();

                SqlDataReader dr;

                Trem tremLido = new Trem();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.Read())
                {
                    tremLido.codTrem = Convert.ToString(dr["codigo"]);
                    tremLido.numVagoes = Convert.ToInt32(dr["qtosVagoes"].ToString());

                }
                else
                    tremLido.codTrem = ""; // indica que não achou o id procurado
                return tremLido;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Trem> selectListTrens()
        {
            try
            {
                _conexaoBD = new SqlConnection(_cadeiaConexao);
                SqlCommand comSql = new SqlCommand("Select * from trem_trem", _conexaoBD);
                _conexaoBD.Open();
                List<Trem> listaTrens = new List<Trem>();
                SqlDataReader dr = comSql.ExecuteReader();
                while (dr.Read())
                {
                    Trem trem = new Trem();
                    trem.codTrem = (String)dr["Codigo"];
                    trem.numVagoes = (Int32)dr["qtosVagoes"];
                    listaTrens.Add(trem);
                }
                _conexaoBD.Close();
                return listaTrens;
            }
            catch (Exception ex)
            {
                _conexaoBD.Close();
                throw new Exception("Erro ao acessar trens " + ex.Message);
            }
        }

        public void insertTrens(Trem trem)
        {
            try
            {
                String sql = "INSERT INTO trem_trem (Codigo,qtosVagoes)" +
                             " VALUES (@cod,@vagoes)";
                _conexaoBD = new SqlConnection(_cadeiaConexao);

                SqlCommand cmdSql = new SqlCommand(sql, _conexaoBD);

                cmdSql.Parameters.AddWithValue("@cod", trem.codTrem);
                cmdSql.Parameters.AddWithValue("@vagoes", trem.numVagoes);
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

        public void updateTrem(Trem trem)
        {
            try
            {
                String sql = "UPDATE trem_trem" +
                             " SET qtosVagoes = @vagoes" +
                             " WHERE Codigo = @cod ";

                _conexaoBD = new SqlConnection(_cadeiaConexao);
                SqlCommand cmd = new SqlCommand(sql, _conexaoBD);
                cmd.Parameters.AddWithValue("@cod", trem.codTrem);
                cmd.Parameters.AddWithValue("@vagoes", trem.numVagoes);
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

        public void deleteTrem(Trem trem)
        {
            try
            {
                String sql = "DELETE FROM trem_trem WHERE Codigo = @cod ";
                _conexaoBD = new SqlConnection(_cadeiaConexao);
                SqlCommand cmd = new SqlCommand(sql, _conexaoBD);
                cmd.Parameters.AddWithValue("@cod", trem.codTrem);
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
