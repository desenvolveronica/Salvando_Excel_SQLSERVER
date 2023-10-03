using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salvando_dados_Excel_no_Banco_de_dados_em_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var livro = new Livros();
            var listaLivros = livro.GetLivros();

            foreach(var livroItem in listaLivros)
            {
                
                if (!livro.AdicionarLivros(livroItem))
                    MessageBox.Show(DataBase.MsgErro);
            }
            MessageBox.Show("Processo encerrado");
        }
    }
}
