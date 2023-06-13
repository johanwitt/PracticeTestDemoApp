using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PracticeTestDemo
{
    public partial class GradeEntry : Form
    {
        public GradeEntry()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PracticeDB23;Integrated Security=True");

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

        private void button2_Click(object sender, EventArgs e)
        {
            int[] studGrades = new int[stud_gradesDataGridView.Rows.Count];
            conn.Open();
            string query = "Select grade from Stud_grades";
            SqlDataReader dr = new SqlDataReader.Read(query, conn);
            da.F
            //[] data = new decimal[10];
            //da.Fill(studGrades);
            conn.Close();

            //dataGridView1.DataSource = data.Tables[0];

            MessageBox.Show("Awesome Job");

        }

        private void button1_Click(object sender, EventArgs e) // submit button
        {
            conn.Open();

            //DateTime date_obj = Convert.ToDateTime(textBox4.Text);

            Decimal grade_obj = Convert.ToDecimal(textBox3.Text);

            string comm = "Insert into Stud_grades values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + grade_obj + "')";
            SqlCommand objcomm = new SqlCommand(comm, conn);
            objcomm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data entry successful");

        }
    }
}
