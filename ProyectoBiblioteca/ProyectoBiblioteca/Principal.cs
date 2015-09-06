using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBiblioteca
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autor frm = new Autor();
            frm.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorias frm = new Categorias();
            frm.Show();
        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editorial frm = new Editorial();
            frm.Show();
        }
    }
}
