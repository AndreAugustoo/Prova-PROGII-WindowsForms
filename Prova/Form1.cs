using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class frmPrincipal : Form
    {

        public struct Animal
        {
            public string nome;
            public string dono;
            public char sexo;
            public int tipo;

        }

        List<Animal> listaAnimal = new List<Animal>();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Animal a = new Animal();

            a.nome = txtNome.Text;
            a.dono = txtDono.Text;

            switch (cbTipo.SelectedItem)
            {
                case "Cachorro":
                    a.tipo = 1;
                    break;
                case "Gato":
                    a.tipo = 2;
                    break;
                case "Outros":
                    a.tipo = 3;
                    break;
            }

            if (rbMasculino.Checked)
            {
                a.sexo = 'M';
            }
            else if (rbFeminino.Checked)
            {
                a.sexo = 'F';
            }

            listaAnimal.Add(a);
            listAnimais.Items.Add("Nome: " + a.nome + " / Dono: " + a.dono + " / Tipo: " + a.tipo + " / Sexo: " + a.sexo);

            txtNome.Text = "";
            txtDono.Text = "";
            cbTipo.Text = "";
            rbMasculino.Checked = false;
            rbFeminino.Checked = false;
            txtNome.Focus();

        }

        private void btCancelarCadastrar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtDono.Text = "";
            cbTipo.Text = "";
            rbMasculino.Checked = false;
            rbFeminino.Checked = false;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            int contador = 0;

            foreach (Animal item in listaAnimal)
            {
                if(item.nome == txtExcluir.Text)
                {
                    listaAnimal.RemoveAt(contador);
                    listAnimais.Items.RemoveAt(contador);
                    goto Excluiu;
                }
                else
                {
                    contador++;
                }
            }

            Excluiu:
            txtExcluir.Text = "";
            txtExcluir.Focus();
        }

        private void btCancelarExcluir_Click(object sender, EventArgs e)
        {
            txtExcluir.Text = "";
            txtExcluir.Focus();
        }
    }
}
