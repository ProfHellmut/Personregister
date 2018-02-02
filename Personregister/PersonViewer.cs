using System;
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
    public partial class PersonViewer : Form
    {
        public PersonViewer(Person person)
        {
            InitializeComponent();
            InitailizeText(person);
            DisableTextFields();
            
        }

        void InitailizeText(Person person)
        {
            lblName.Text = person.Name;
            txtPnr.Text = person.Pnr.ToString();
            txtProfession.Text = person.Profession;
        }

        void DisableTextFields()
        {
            txtPnr.Enabled = false;
            txtProfession.Enabled = false;
        }

        private void PersonViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
