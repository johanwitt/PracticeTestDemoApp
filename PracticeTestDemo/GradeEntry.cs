using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeTestDemo
{
    public partial class GradeEntry : Form
    {
        public GradeEntry()
        {
            InitializeComponent();
        }

        private void stud_gradesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stud_gradesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.practiceDB23DataSet);

        }

        private void GradeEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'practiceDB23DataSet.Stud_grades' table. You can move, or remove it, as needed.
            this.stud_gradesTableAdapter.Fill(this.practiceDB23DataSet.Stud_grades);

        }
    }
}
