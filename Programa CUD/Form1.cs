using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Programa_CUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        List<TextBox> ListaTextbox = new List<TextBox>();
        string consulta = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            lblID.Hide(); txtId.Hide(); lblValor.Hide(); txtValor.Hide(); cbCampo.Hide(); lblCampos.Hide(); groupBox2.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nombreCampo = "";
            var valores = "";
            
            for (int i = 0; i < ListaTextbox.Count; i++)
            {
                if (i == ListaTextbox.Count - 1){nombreCampo += ListaTextbox[i].Name;}
                if (i != ListaTextbox.Count - 1){nombreCampo += ListaTextbox[i].Name + ", ";}
                }
            for (int i = 0; i < ListaTextbox.Count; i++)
            {
                if (i == ListaTextbox.Count - 1) { valores += "'"+ ListaTextbox[i].Text + "'"; }
                if (i != ListaTextbox.Count - 1) { valores += "'" + ListaTextbox[i].Text + "'" + ", "; }
            }

            switch (cbAcciones.Text)
            {
                case "Insertar Registro": 
                    consulta = "INSERT INTO " + cbTabla.Text + "(" + nombreCampo + ")" + "VALUES(" + valores + ");" 
                     + "SELECT * FROM " + cbTabla.Text + "; "; break;
                
                case "Mostrar Registros": consulta = "SELECT * FROM " + cbTabla.Text + "; "; break;

                case "Actualizar Registros": consulta = "UPDATE " + cbTabla.Text + " SET " + cbCampo.Text + " = " + "'" + txtValor.Text + "'" + " WHERE " + "id" + cbTabla.Text + " = " + txtId.Text + "; "
                        + "SELECT * FROM " + cbTabla.Text + "; "; break;
               
                case "Eliminar Registros": consulta = "DELETE FROM " + cbTabla.Text + " WHERE" + " id" + cbTabla.Text + " =" + txtId.Text + "; "
                        + "SELECT * FROM " + cbTabla.Text + "; "; break;
            }
            SqlConnection conexion = new SqlConnection(Datos.cadenaConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Connection = conexion;
            comando.CommandText = consulta;
            conexion.Close();

            Datos.AgrearDataTable(ds, consulta, cbTabla.Text); //ANTIGUO
            dataGridView1.DataSource = ds.Tables[cbTabla.Text];
            cbCampo.Items.Clear();
            for (int i = 0; i < ds.Tables[cbTabla.Text].Columns.Count; i++)
            {
                cbCampo.Items.Add(ds.Tables[cbTabla.Text].Columns[i].ColumnName);
            }
            ds.Tables.Clear(); //ANTIGUO
        }

        private void cbTabla_TextChanged(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
        }

        private void cbAcciones_TextChanged(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            ListaTextbox.Clear();
            int i = 1;
            switch (cbAcciones.Text)
            {
                case "Insertar Registro": txtId.Hide(); txtValor.Hide(); lblValor.Hide(); lblID.Hide(); cbCampo.Hide(); lblCampos.Hide(); groupBox2.Show();
                    Datos.AgrearDataTable(ds, "SELECT * FROM " + cbTabla.Text + "; ", cbTabla.Text); //ANTIGUO

                    for (; i < ds.Tables[cbTabla.Text].Columns.Count; i++)
                    {
                        Label lb = new Label();
                        lb.AutoSize = true;
                        lb.Location = new Point(16, 18 + i * 41);
                        lb.Name = "label" + i;
                        lb.Size = new Size(35, 13);
                        lb.Text = ds.Tables[cbTabla.Text].Columns[i].ColumnName;
                        groupBox2.Controls.Add(lb);

                        TextBox tb = new TextBox();
                        tb.Location = new Point(18, 35 + i * 40);
                        tb.Name = ds.Tables[cbTabla.Text].Columns[i].ColumnName;
                        tb.Size = new Size(158, 20);
                        tb.Text = "";
                        groupBox2.Controls.Add(tb); 
                        consulta = "SELECT * FROM ";
                        ListaTextbox.Add(tb);
                    }
                    ; break;
                case "Mostrar Registros": txtId.Hide(); txtValor.Hide(); lblValor.Hide(); lblID.Hide(); cbCampo.Hide(); lblCampos.Hide(); groupBox2.Hide(); ; break;
                case "Actualizar Registros": txtId.Show(); lblID.Show(); txtValor.Show(); lblValor.Show(); cbCampo.Show(); lblCampos.Show(); groupBox2.Hide(); ; break;
                case "Eliminar Registros": txtId.Show(); lblID.Show(); txtValor.Hide(); lblValor.Hide(); cbCampo.Hide(); lblCampos.Hide(); ; groupBox2.Hide(); break;
            }
            ds.Tables.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
