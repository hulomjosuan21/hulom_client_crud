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
            operation.updateClient(getSelectedId);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Do to you want to delete the client ID {getSelectedId}", "Delete Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                operation.deleteClients(getSelectedId);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            operation = new DatabaseOperation(clientBindingSource);
            clientBindingSource.DataSource = operation._con.Clients.ToList();
        }

        private int getSelectedId;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            getSelectedId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
        }
    }
}
