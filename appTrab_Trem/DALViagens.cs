using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace appTrab_Trem
{
    class DALViagens
    {
        SqlConnection _conexaoBD;
        string _cadeiaConexao = "Data Source=regulus;Initial Catalog=BD16394;Persist Security Info=True;" +
                                                        "User ID=BD16394";

        public DALViagens(string servidor, string bancoDeDados, string usuario)
    {
      _cadeiaConexao = "Data Source=" + servidor +
                       ";Initial Catalog=" + bancoDeDados +
                       ";Persist Security Info=True;" +
                       ";User ID=" + usuario +
                       ";Password=BD16394";
    }
        public DataTable selectViagem(Viagens v)
        {
            try
            {
                String sql = "SELECT siglaCidade as Destinos FROM trem_cidades_viagem where codViagem = @codV";
                _conexaoBD = new SqlConnection(_cadeiaConexao);
                SqlCommand cmd = new SqlCommand(sql, _conexaoBD);
                cmd.Parameters.AddWithValue("@codV", v.CodViagens);
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
        public DataTable selectViagens()
        {
            try
            {
                String sql = "SELECT * FROM trem_viagem";
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
        public List<Viagens> selectListViagens()
        {
            try
            {
                _conexaoBD = new SqlConnection(_cadeiaConexao);
                SqlCommand comSql = new SqlCommand("Select * from trem_viagem", _conexaoBD);
                _conexaoBD.Open();
                List<Viagens> listaViagem = new List<Viagens>();
                SqlDataReader dr = comSql.ExecuteReader();
                while (dr.Read())
                {
                    Viagens umaViagem = new Viagens();
                    umaViagem.CodViagens = (string)dr["codigo"];
                    umaViagem.CodTrens = (string)dr["codTrem"];
                    listaViagem.Add(umaViagem);
                }
                _conexaoBD.Close();
                return listaViagem;
            }
            catch (Exception ex)
            {
                _conexaoBD.Close();
                throw new Exception("Erro ao acessar estoque " + ex.Message);
            }
        }
        public void insertViagem(Viagens viagem)
        {
            try
            {
                String sql = "INSERT INTO trem_viagem (codigo,codTrem)" +
                             " VALUES (@codV,@codT)";
                _conexaoBD = new SqlConnection(_cadeiaConexao);

                SqlCommand cmdSql = new SqlCommand(sql, _conexaoBD);

                cmdSql.Parameters.AddWithValue("@codV",viagem.CodViagens);
                cmdSql.Parameters.AddWithValue("@codT", viagem.CodTrens);
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
        public void updateViagem(Viagens viagem)
        {
            try
            {
                 String sql = "UPDATE trem_viagem SET codTrem=@codT  WHERE codigo = @cod ";  

                _conexaoBD = new SqlConnection(_cadeiaConexao);
                SqlCommand cmd = new SqlCommand(sql, _conexaoBD);
                 cmd.Parameters.AddWithValue("@cod", viagem.CodViagens);
                 cmd.Parameters.AddWithValue("@codT", viagem.CodTrens);
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

        public Viagens selectViagemPorCod(string cod)
        {
            try
            {
                String sql = "SELECT * FROM trem_viagem WHERE codigo = @cod";
                _conexaoBD = new SqlConnection(_cadeiaConexao);
                SqlCommand cmd = new SqlCommand(sql, _conexaoBD);
                cmd.Parameters.AddWithValue("@cod", cod);
                _conexaoBD.Open();

                SqlDataReader dr;

                Viagens viagemLida = new Viagens();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.Read())
                {
                    viagemLida.CodViagens = Convert.ToString(dr["codigo"]);
                    viagemLida.CodTrens = dr["codTrem"].ToString();

                }
                else
                    viagemLida.CodViagens = "nada"; // indica que não achou o id procurado
                return viagemLida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteViagem(Viagens viagem)
        {
            try
            {
                String sql = "DELETE FROM trem_viagem WHERE codigo = @cod "; 
                _conexaoBD = new SqlConnection(_cadeiaConexao);
                SqlCommand cmd = new SqlCommand(sql, _conexaoBD);
                cmd.Parameters.AddWithValue("@cod", viagem.CodViagens);
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
