using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvando_dados_Excel_no_Banco_de_dados_em_CSharp
{
    public static class Excel //static para não precisar instanciara classe
    {
        public static DataTable GetLivros() //vai retornar todos os dados da planilha excel
        {
            var arquivo = @"c:\dados\livros.xlsx";
            var planilha = "SELECT * FROM [livros$]";
            var strCon = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + arquivo + "; Extended Properties=\"Excel 12.0; HDR=Yes; IMEX=0\"";

            var dt = new DataTable();
            using (OleDbConnection con = new OleDbConnection(strCon))
            {
                using (OleDbDataAdapter da = new OleDbDataAdapter(planilha, con))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}
