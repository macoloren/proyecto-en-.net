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
using PruebaJr.Views;

namespace PruebaJr.Views.Marca
{
    public partial class saveMarca : Form
    {
        public saveMarca()
        {
            InitializeComponent();
        }

        private void otro_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (baseDBEntities db = new baseDBEntities())
            {
                int Activo = 0; int.TryParse(txtActivo.Text, out Activo);

                Models.Marca oMarca = new Models.Marca();
                oMarca.Nombre = txtNombre.Text;
                oMarca.Activo = Activo;
                oMarca.FechaCreacion = DateTime.Now;

                db.Marca.Add(oMarca);
                db.SaveChanges();

                this.Close();
            }
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
           AllMarca allMarca = new AllMarca(); 
            allMarca.ShowDialog();
        }
    }
}
