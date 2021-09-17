using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaImg
{
    public partial class TelaImagem : Form
    {
        public TelaImagem()
        {
            InitializeComponent();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            openFileDialogBusca.Filter = "Arquivos bmp | *.bmp | Arquivos jpg | *.jpg";

            if (openFileDialogBusca.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImagem.ImageLocation = openFileDialogBusca.FileName; 
            }
        }
    }
}
