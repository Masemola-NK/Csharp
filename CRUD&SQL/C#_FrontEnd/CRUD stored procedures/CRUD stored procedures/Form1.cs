using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace CRUD_stored_procedures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("--Information retrive on a local server although sql schema is available__");

        private void button1_Click(object sender, EventArgs e)
        {
            int empID = int.Parse(textBox1.Text);
            string empName = textBox2.Text;
            string empSurname = textBox3.Text;
            string empDep = textBox4.Text;
            DateTime empJDate = DateTime.Parse(dateTimePicker1.Text);
            string sex = "";
            if (radioButton1.Checked == true) { sex = "Male"; } else { sex = "Female"; }
            con.Open();

            //Cocatination 
            //SqlCommand c = new SqlCommand("exec  AddEmp'" + empID + "','" + empName + "','" + empSurname + "','" + empDep + "','" + empJDate + "','" + sex + "'" + con);

            //As for below is the parameters approach 
            SqlCommand c = new SqlCommand("exec AddEmp @EmpID, @EmpName, @EmpSurname, @EmpDep, @EmpJDate, @EmpSex", con);

            c.Parameters.AddWithValue("@EmpID", empID);
            c.Parameters.AddWithValue("@EmpName", empName);
            c.Parameters.AddWithValue("@EmpSurname", empSurname);
            c.Parameters.AddWithValue("@EmpDep", empDep);
            c.Parameters.AddWithValue("@EmpJDate", empJDate);
            c.Parameters.AddWithValue("@EmpSex", sex);
            c.ExecuteNonQuery();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
			textBox4.Clear();

			MessageBox.Show("Record has been successfully installed ");

            getEmplist();
            con.Close();
        }

        void getEmplist()
        {
            SqlCommand a = new SqlCommand("exec LoadEmp", con);
            SqlDataAdapter da = new SqlDataAdapter(a);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getEmplist();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //load or refreshing the database table
            getEmplist();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update prevously existing information
            int empID = int.Parse(textBox1.Text);
            string empName = textBox2.Text;
            string empSurname = textBox3.Text;
            string empDep = textBox4.Text;
            DateTime empJDate = DateTime.Parse(dateTimePicker1.Text);
            string sex = "";
            if (radioButton1.Checked == true) { sex = "Male"; } else { sex = "Female"; }
            con.Open();

            //As for below is the parameters approach 
            SqlCommand c = new SqlCommand("exec UpdateEmp @EmpID, @EmpName, @EmpSurname, @EmpDep, @EmpJDate, @EmpSex", con);

            c.Parameters.AddWithValue("@EmpID", empID);
            c.Parameters.AddWithValue("@EmpName", empName);
            c.Parameters.AddWithValue("@EmpSurname", empSurname);
            c.Parameters.AddWithValue("@EmpDep", empDep);
            c.Parameters.AddWithValue("@EmpJDate", empJDate);
            c.Parameters.AddWithValue("@EmpSex", sex);
            c.ExecuteNonQuery();

            MessageBox.Show("Selected :" + empID + " record has been update succesfully" + " " + empID + " - " + empName);

            getEmplist();
            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
			//Removing a record throught the employee ID
			int empID = int.Parse(textBox1.Text);

            con.Open();
			//As for below is the parameters approach 
			SqlCommand c = new SqlCommand("exec DeleteEmp @EmpID", con);

			c.Parameters.AddWithValue("@EmpID", empID);
			c.ExecuteNonQuery();

			MessageBox.Show("Selected " + empID + " record has been deleted succesfully" + "" + empID);
            textBox1.Clear();
			getEmplist();
			con.Close();

		}
	}
}
