using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Anos_7
{
    public partial class Form2 : Form
    {
        AhmedEntities db = new AhmedEntities();
        public Form2()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.Students.ToList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            Student std = new Student
            {
                Name = name,
                Phone = phone,
                Email = email,
                Password = password
            };
            db.Students.Add(std);
            db.SaveChanges();


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.Students.ToList();
            txtEmail.Clear();
            txtName.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            int id = int.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());
            Student std = db.Students.FirstOrDefault(i => i.Id == id);
            txtID.Text = std.Id + "";
            txtName.Text = std.Name;
            txtEmail.Text = std.Email;
            txtPhone.Text = std.Phone;
            txtPassword.Text = std.Password;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            Student std = db.Students.FirstOrDefault(i => i.Id == id);
            std.Name = txtName.Text;
            std.Email = txtEmail.Text;
            std.Phone = txtPhone.Text;
            std.Password = txtPassword.Text;
            db.SaveChanges();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.Students.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            Student std = db.Students.FirstOrDefault(i => i.Id == id);
            db.Students.Remove(std);
            db.SaveChanges();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.Students.ToList();
        }
    }
}
