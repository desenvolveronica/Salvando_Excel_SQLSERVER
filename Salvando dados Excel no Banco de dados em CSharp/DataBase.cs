using System;
using System.Collections.Generic;
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

        public static string StrCon
        {
            get { return $"Data Source = {server};Initial Catalog = {dataBase}; Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;ApplicationIntent = ReadWrite; MultiSubnetFailover=False";  }
        }

    }
}
