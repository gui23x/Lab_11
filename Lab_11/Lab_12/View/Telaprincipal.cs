using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12.View
{
    public partial class Telaprincipal : Form
    {
        public Telaprincipal()
        {
            InitializeComponent();
        }

        private  void leitorTexto()
        {
            lbxInfo.Items.Clear();
            string endereco = @"C:\teste123.txt";

            try
            {
                if (!System.IO.File.Exists(endereco))
                {
                    throw new Exception("O arquivo teste.txt não foi localizado, ");
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            leitorTexto();
        }
    }
}
