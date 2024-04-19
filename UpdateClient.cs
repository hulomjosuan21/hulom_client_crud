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
    public partial class UpdateClient : Form
    {
        private readonly DatabaseOperation operation = new DatabaseOperation();
        private readonly int _id;
        public UpdateClient()
        {
            InitializeComponent();
        }

        public UpdateClient(int id) : this()
        {
            this._id = id;
        }
        public string[] GetAddText { get; set; } = new string[3];
        public DateTime dateValue { get; set; }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            GetAddText[0] = fname_val.Text.Trim();
            GetAddText[1] = lname_val.Text.Trim();
            GetAddText[2] = res_val.Text.Trim();
            dateValue = date_val.Value;
            this.Close();
        }

        private void UpdateClient_Load(object sender, EventArgs e)
        {
            var selectedClient = operation._con.Clients.Where(q => q.Id == _id).FirstOrDefault();

            fname_val.Text = selectedClient.Firstname;
            lname_val.Text = selectedClient.Lastname;
            res_val.Text = selectedClient.Residency;
            date_val.Value = (DateTime) selectedClient.Birthday;
        }
    }
}
