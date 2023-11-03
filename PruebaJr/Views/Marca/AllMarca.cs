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

namespace PruebaJr.Views.Marca
{
    public partial class AllMarca : Form
    {
        public AllMarca()
        {
            InitializeComponent();
        }

        private void AllMarca_Load(object sender, EventArgs e)
        {
            using (baseDBEntities db = new baseDBEntities())
            {
                var lts = from a in db.Marca
                          select a;
                dgvDatos.DataSource = lts.ToList();

            }
        }
    }
}
