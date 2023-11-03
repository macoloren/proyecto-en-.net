using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaJr.Models;


namespace PruebaJr.Views
{
    public partial class AllData : Form
    {
        public AllData()
        {
            InitializeComponent();
        }

        private void AllData_Load(object sender, EventArgs e)
        {  
            dgvCarro.DataSource = frmCarro.listar();
        }


        //obtener el id de la grid
        private int? GetId()
        {
            try
            {
                return int.Parse(dgvCarro.Rows[dgvCarro.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch 
            {
                return null;
            }
        }


        //usando el methodo para obtener el id seleccionado en la grid
        private void button1_Click(object sender, EventArgs e)
        {
            int? carroId = GetId();

            if (carroId != null)
            {
                frmCarro ofrmCarro = new frmCarro(carroId);
                ofrmCarro.ShowDialog();

                Refrescar();
            }
        }


        //METODO PARA REFESCAR LA GRID
        public void Refrescar()
        {
            using (baseDBEntities db = new baseDBEntities())
            {
                var lts = from d in db.Carro
                          select d;
                dgvCarro.DataSource = lts.ToList();
            }
        }
    }
}
