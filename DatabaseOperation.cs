﻿
using hulom_client_crud;
using hulom_client_crud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace complete_csharp_crud
{
    internal class DatabaseOperation
    {
        private readonly hulomdbEntities _context = new hulomdbEntities();
        private readonly BindingSource _bindingSource;

        public DatabaseOperation() { }

        public DatabaseOperation(BindingSource _bindingSource)
        {
            this._bindingSource = _bindingSource;
        }

        public hulomdbEntities _con
        {
            get
            {
                return _context;
            }
        }

        public void addClient()
        {
            AddClient _addClient = new AddClient();
            _addClient.ShowDialog();

            string fname = _addClient.GetAddText[0];
            string lname = _addClient.GetAddText[1];
            string residency = _addClient.GetAddText[2];
            DateTime date = _addClient.dateValue;


            Client addClient = new Client();

            addClient.Firstname = fname;
            addClient.Lastname = lname;
            addClient.Residency = residency;
            addClient.Birthday = date;

            _context.Clients.Add(addClient);
            _context.SaveChanges();

            _bindingSource.DataSource = _context.Clients.ToList();
        }

        public void updateCategory(int _id)
        {
            //UpdateCategory _updateCategory = new UpdateCategory(_id);
            //_updateCategory.ShowDialog();

            //string getText = _updateCategory.GetUpdateText;

            //if (!(string.IsNullOrEmpty(getText)))
            //{
            //    var selectedCategory = _context.Categories.Where(q => q.Id == _id).FirstOrDefault();

            //    selectedCategory.Name = getText;

            //    _context.SaveChanges();

            //    _bindingSource.DataSource = _context.Categories.ToList();
            //}
        }

        public void deleteCategory(int _id)
        {
            //var itemToDelete = _context.Categories.Where(q => q.Id == _id).FirstOrDefault();

            //_context.Categories.Remove(itemToDelete);
            //_context.SaveChanges();

            //_bindingSource.DataSource = _context.Categories.ToList();
        }
    }
}