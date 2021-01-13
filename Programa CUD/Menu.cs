using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_CUD
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSqlServer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUSSqlServer frm1 = new CRUSSqlServer();
            frm1.Show();
        }

        private void btnMySql_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUDmySql frm1 = new CRUDmySql();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUDPostgre frm1 = new CRUDPostgre();
            frm1.Show();
        }
    }
}
