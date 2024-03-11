using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies
{
    public partial class FormAddMovie : Form
    {
        public Movie movie;
        public FormAddMovie()
        {
            InitializeComponent();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Името не смее да биде празно");
            }
            else
            {
                errorProvider1.SetError(tbName,null);
            }
        }

        private void tbYear_Validating(object sender, CancelEventArgs e)
        {
            int year = 0;
            int.TryParse(tbYear.Text, out year);
            if (year <= 0 || year>2022)
            {
                e.Cancel= true;
                errorProvider1.SetError(tbYear, "Мора да биде внесена валидна година");
            }
            else
            {
                errorProvider1.SetError(tbYear,null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                string name=tbName.Text;
                string year=tbYear.Text;
                movie= new Movie(name,year);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
