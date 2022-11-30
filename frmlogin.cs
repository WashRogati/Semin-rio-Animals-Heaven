using Seminário_Animals_Heaven;
using System;
using tela;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tela
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textEmail.Text == "Ana Rosa" && textSenha.Text == "1234")
            {
                menu frmmenu;
                frmmenu = new menu();
                frmmenu.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou Senha invalidos!!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastro frmcadastro;
            frmcadastro = new cadastro();
            frmcadastro.Show();


            this.Hide();
        }
    }
}
