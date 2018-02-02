﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personregister
{
    public partial class Form1 : Form
    {
        Register register;
        public Form1()
        {
            InitializeComponent();
            LoadData();
            UpdateList();
        }

        void LoadData()
        {
            SaveLoad sl = new SaveLoad();
            register = sl.LoadFromFile();
        }

        void UpdateList()
        {
            lbPersonLista.Items.Clear();
            List<Person> names = register.GetRegister();

            foreach (Person person in names)
            {
                lbPersonLista.Items.Add(person.Name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPerson ap = new AddPerson(register);
            ap.ShowDialog();

            UpdateList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveLoad sl = new SaveLoad();
            sl.SaveToFile(register);
        }
    }
}
