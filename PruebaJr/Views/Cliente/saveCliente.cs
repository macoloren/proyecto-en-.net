using PruebaJr.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaJr.Views.Cliente
{
    public partial class saveCliente : Form
    {
        public saveCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllClientes allClientes = new AllClientes();
            allClientes.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (baseDBEntities db = new baseDBEntities())
            {
                int Activo = 0; int.TryParse(txtActivo.Text, out Activo);
                int TelefonoCelular = 0; int.TryParse(txtTelefonoCelular.Text, out TelefonoCelular);


                Models.Cliente oCliente = new Models.Cliente();
                oCliente.NombreCompleto = txtNombreCompleto.Text;
                oCliente.TelefonoCelular = TelefonoCelular;
                oCliente.Activo = Activo;
                oCliente.FechaCreacion = DateTime.Now;

                db.Cliente.Add(oCliente);
                db.SaveChanges();

                this.Close();

            }
        }
    }
}
