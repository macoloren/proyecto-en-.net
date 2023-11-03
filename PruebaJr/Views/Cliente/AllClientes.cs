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
    public partial class AllClientes : Form
    {
        public AllClientes()
        {
            InitializeComponent();
        }

        private void AllClientes_Load(object sender, EventArgs e)
        {
            using (baseDBEntities db = new baseDBEntities()) 
            {
                var lts = from d in db.Cliente
                          select d;
                dgvClientes.DataSource = lts.ToList();
            }
        }
    }
}
