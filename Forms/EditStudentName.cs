using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyExtendedSchoolDB;

namespace Forms
{
    public partial class EditStudentName : Form
    {
        public EditStudentName()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

    }
}
