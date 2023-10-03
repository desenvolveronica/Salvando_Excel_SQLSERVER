using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Salvando_dados_Excel_no_Banco_de_dados_em_CSharp
{
    public class DataBase
    {
        //Data Source = VERONICAPC\SQLSERVER1993;Initial Catalog = Livraria; Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False

        private static string server = @"VERONICAPC\SQLSERVER1993";
        private static string dataBase = "Livraria";

        public static string MsgErro { get; private set; }

        public static string StrCon
        {
            get { return @"Data Source=VERONICAPC\SQLSERVER1993;Initial Catalog=Livraria;Integrated Security=True"; }
        }

        public static bool AdicionarLivros(Livros livro)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(StrCon))
                {
                    cn.Open();
                    var sql = "INSERT INTO Livros (Titulo, Isbn, Autores,Assuntos, Unitario) values (@Titulo, @Isbn, @Autores, @Assuntos, @Unitario)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Titulo", livro.Titulo);
                        cmd.Parameters.AddWithValue("@Isbn", livro.Isbn);
                        cmd.Parameters.AddWithValue("@Autores", livro.Autores);
                        cmd.Parameters.AddWithValue("@Assuntos", livro.Assuntos);
                        cmd.Parameters.AddWithValue("@Unitario", livro.Unitario.ToString().Replace(",","."));

                        cmd.ExecuteNonQuery();
                    }

                }
                    MsgErro = "";
                return true;
            }
            catch (Exception ex)
            {

                MsgErro = ex.Message;
                return false;
            }
        }
    }
}
