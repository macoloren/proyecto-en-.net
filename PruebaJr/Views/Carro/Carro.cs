using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaJr.Models;
using PruebaJr.Views;


namespace PruebaJr
{
    public partial class frmCarro : Form
    {
        //atributo para usarlo al editar
        public int? carroId;

        //ATRIBUTO DE LA INSTANCIA DE LA CLASE CARRO
        Models.Carro oCarro = null;

        //constructor
        public frmCarro(int? carroId = null)
        {
            InitializeComponent();
            //MarcaId
            listarMarcas();
            //CarroId
            listarClientes();

            this.carroId = carroId;

            //si no trae id se carga limpio para crear uno nuevo
            if (carroId != null)
            {
                CargarDatos();
            }
        }


        //cargando datos en el frm para editarlos
        public void CargarDatos()
        {
            using (baseDBEntities db = new baseDBEntities())
            {
                oCarro = db.Carro.Find(carroId);
                txtPlaca.Text = oCarro.Placa;
                txtModelo.Text = oCarro.Modelo.ToString();
                cmbMarca.SelectedValue = oCarro.MarcaId;
                cmbCliente.SelectedValue = oCarro.ClienteId;
                txtActivo.Text = oCarro.Activo.ToString();
            }
        }


        //cargando datos en la vista al abrir la vista
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        //LISTAR MARCAS EN EL COMBOBOX
        public void listarMarcas()
        {
            using (baseDBEntities db = new baseDBEntities())
            {
                var lts = from d in db.Marca
                          select d;
                cmbMarca.DataSource = lts.ToList();
                cmbMarca.DisplayMember = "Nombre";
                cmbMarca.ValueMember = "MarcaId";
            }
        }


        //LISTAR CLIENTES EN EL COMBOBOX
        public void listarClientes()
        {
            using (baseDBEntities db = new baseDBEntities())
            {
                var lts = from d in db.Cliente
                          select d;
                cmbCliente.DataSource = lts.ToList();
                cmbCliente.DisplayMember = "NombreCompleto";
                cmbCliente.ValueMember = "ClienteId";
            }
        }

        
        //methodo para crear CARRO
        private void button1_Click(object sender, EventArgs e)
        {
                //parceando los int que bienen en las cajas de texto
                int Modelo = 0; 
                int Activo = 0; 

                int.TryParse(txtModelo.Text, out Modelo);
                int.TryParse(txtActivo.Text, out Activo);

            //validando para guardar al editar
            if (carroId == null)
                
                    oCarro = new Models.Carro();
                oCarro.Placa = txtPlaca.Text;
                oCarro.Modelo = Modelo;
                oCarro.MarcaId = (int)cmbMarca.SelectedValue;
                oCarro.ClienteId = (int)cmbCliente.SelectedValue;
                oCarro.Activo = Activo;
                oCarro.FechaCreacion = DateTime.Now;

            agregar(oCarro);


                //usando el metodo para inactivar
                //oCarro.Activo = 0;

                //inactivar(oCarro);


                this.Close();
        }


        //metodo eliminar
        public void inactivar (Models.Carro carro )
        {
            using (baseDBEntities db = new baseDBEntities())
            {
                db.Entry(carro).State = EntityState.Modified;
                db.SaveChanges();
            }
        }


        //methodo para guardar carro a la db
        public void agregar (Models.Carro carro)
        {
            if (!ValidPlacas(carro))
            {
                MessageBox.Show("PLACA YA EXISTENTE");
            } 
            else
            {
                using (baseDBEntities db = new baseDBEntities())
                {
                    //validando al editar 
                    if (carroId == null)
                    {
                        db.Carro.Add(carro);
                    }
                    else
                    {
                        db.Entry(oCarro).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
        }


        //validando placas ya existentes
        public bool ValidPlacas (Carro oCarro)
        {
            bool valid = true;
            using (baseDBEntities db = new baseDBEntities())
            {
                var lts = db.Carro.Where(a => a.Placa == oCarro.Placa).ToList();
                if (lts.Count > 0)
                {
                    valid = false;
                }
                /*foreach (var carro in lts)
                {
                    if (oCarro.Placa == carro.Placa)
                    {
                        valid = false;
                        break;
                    }
                }*/
            }
            return valid;
        }


        //metodo para listar tabla carro
        public static List<Models.Carro> listar()
        {
            using (baseDBEntities db = new baseDBEntities())
            {
                var lts = from d in db.Carro
                          select d;
                return lts.ToList();
            }
        }


        //llamando la vista donde se muestran los registros de Carros Guardados
        private void btnRegistros_Click(object sender, EventArgs e)
        {
            AllData allData = new AllData();
            allData.ShowDialog(this);
        }
    }
}


