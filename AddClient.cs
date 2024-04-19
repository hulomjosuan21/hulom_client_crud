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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }
        public string[] GetAddText { get; set; } = new string[3];
        public DateTime dateValue { get; set; }
        private void addBtn_Click(object sender, EventArgs e)
        {
            GetAddText[0] = fname_val.Text.Trim();
            GetAddText[1] = lname_val.Text.Trim();
            GetAddText[2] = res_val.Text.Trim();
            dateValue = date_val.Value;

            this.Close();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {

        }
    }
}
