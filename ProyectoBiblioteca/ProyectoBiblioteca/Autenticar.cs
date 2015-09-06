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
    public partial class Autenticar : Form
    {
        public Autenticar()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Pasar();

        }
         private void Pasar()
        {
            Principal frm = new Principal();
            frm.Show();
          
        }

         private void btn_salir_Click(object sender, EventArgs e)
         {
             this.Close();
         }

    }
}
