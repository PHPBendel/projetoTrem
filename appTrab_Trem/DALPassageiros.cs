using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace appTrab_Trem
{
    class DALPassageiros
    {
        SqlConnection _conexaoBD;
        string _cadeiaConexao;

        public DALPassageiros(string servidor, string bancoDeDados, string usuario)
        {
            _cadeiaConexao = "Data Source=" + servidor +
                             ";Initial Catalog=" + bancoDeDados +
                             ";Persist Security Info=True;" +
                             ";User ID=" + usuario +
                             ";Password=BD16394";
        }

        public DataTable selectPassageiros()
        {
            try
            {
                String sql = "SELECT nome, cpf, email FROM trem_passageiro order by nome";
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

        public Passageiro selectPassageiroByCPF(string cpf)
        {
            try
            {
                String sql = "SELECT nome, email FROM trem_passageiro WHERE cpf = @cpf";
                _conexaoBD = new SqlConnection(_cadeiaConexao);
                SqlCommand cmd = new SqlCommand(sql, _conexaoBD);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                _conexaoBD.Open();

                SqlDataReader dr;

                Passageiro passageiroLido = new Passageiro();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.Read())
                {
                    passageiroLido.Nome = Convert.ToString(dr["nome"]);
                    passageiroLido.Email = dr["email"].ToString();

                }
                else
                    passageiroLido.Nome = ""; // indica que não achou o cpf procurado
                return passageiroLido;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
