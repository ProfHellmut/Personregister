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
    public partial class EditPerson : Form
    {
        Person person;
        public EditPerson(Person person)
        {
            InitializeComponent();
            this.person = person;

            InitailizeTextFields();
        }

        void InitailizeTextFields()
        {
            txtName.Text = person.Name;
            txtPnr.Text = person.Pnr.ToString();
            txtProfession.Text = person.Profession;

            txtPnr.Enabled = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            person.Name = txtName.Text;
            person.Profession = txtProfession.Text;
        }
    }
}
