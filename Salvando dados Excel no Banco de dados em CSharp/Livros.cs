using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvando_dados_Excel_no_Banco_de_dados_em_CSharp
{
    public class Livros
    {
        public string Titulo { get; set; }
        public string Isbn { get; set; }
        public string Autores { get; set; }
        public string Assuntos { get; set; }
        public decimal Unitario { get; set; }

        public Livros() { }//construtor padrão

        public Livros(string titulo, string isbn, string autores, string assunto, decimal unitario)//construtor
        {//propriedades = parâmetros
            Titulo = titulo;
            Isbn = isbn;
            Autores = autores;
            Assuntos = assunto;
            Unitario = unitario;

        }
        public DataTable GetLivros()
        {
            return Excel.GetLivros();//classe excel é static por isso nao precisa instanciar
        }

        public bool AdicionarLivros()
        {
            return true;
        }
    }
}
