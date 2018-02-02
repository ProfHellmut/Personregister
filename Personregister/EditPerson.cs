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
    public partial class EditPerson : Form
    {
        Register register;
        public EditPerson(Register register, int index)
        {
            InitializeComponent();
            this.register = register;

            InitailizeTextFields(index);
        }

        void InitailizeTextFields(int index)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
    }
}
