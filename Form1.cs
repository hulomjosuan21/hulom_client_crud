using complete_csharp_crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hulom_client_crud
{
    public partial class Form1 : Form
    {
        private DatabaseOperation operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            operation.addClient();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            operation = new DatabaseOperation(clientBindingSource);
            clientBindingSource.DataSource = operation._con.Clients.ToList();
        }
    }
}
