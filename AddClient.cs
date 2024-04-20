﻿using System;
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
            string fname = fname_val.Text.Trim();
            string lname = lname_val.Text.Trim();
            string residency = res_val.Text.Trim();
            DateTime date = date_val.Value;

            if (!string.IsNullOrWhiteSpace(fname) &&
                !string.IsNullOrWhiteSpace(lname) &&
                !string.IsNullOrWhiteSpace(residency)){
                GetAddText[0] = fname;
                GetAddText[1] = lname;
                GetAddText[2] = residency;
                dateValue = date;

                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill out all fields with valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddClient_Load(object sender, EventArgs e)
        {

        }
    }
}
