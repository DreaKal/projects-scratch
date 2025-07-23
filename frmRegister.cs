using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace EmploymentManagement
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-FUJITSU;Initial Catalog=Register;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string insertQuery = "INSERT INTO register VALUES (@fName, @lName, @gender, @email, @phone, @username, @password)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@fName", txtfName.Text);
            cmd.Parameters.AddWithValue("@lName", txtlName.Text);
            cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registration Successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form frm = new frmLogin();
            frm.Show();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
