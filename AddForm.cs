using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week3Assignment3._3
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            cmbAdmission.DataSource = Enum.GetValues(typeof(MonthOfAdmission));
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (txtStudentFName.Text != string.Empty && txtStudentLName.Text != string.Empty && txtStudentID.Text != string.Empty)
            {
                var newStudent = new Student();
                newStudent.StudentID = int.Parse(txtStudentID.Text);
                newStudent.FName = txtStudentFName.Text;
                newStudent.LName = txtStudentLName.Text;
                newStudent.Address = txtAddress.Text;
                newStudent.MonthOfAdmission = (MonthOfAdmission)(cmbAdmission.SelectedIndex + 1);
                newStudent.Grade = Char.Parse(txtGrade.Text);
                Data.Students.Add(newStudent);
                var result = MessageBox.Show("New student added, would you like to add another student?", "Message", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtStudentID.Clear();
                    txtStudentFName.Clear();
                    txtStudentLName.Clear();
                    txtAddress.Clear();
                    txtGrade.Clear();
                }
                else
                {
                    this.Hide();
                }
            }

        }

        private void txtStudentID_Validating(object sender, CancelEventArgs e)
        {
            if (txtStudentID.TextLength != 0)
            {
                int val;
                if (!int.TryParse(txtStudentID.Text, out val))
                {
                    MessageBox.Show("Please enter numbers only.");
                    e.Cancel = true;
                    txtStudentID.Clear();
                }
                else if (int.Parse(txtStudentID.Text) <= 0)
                {
                    MessageBox.Show("Please enter only non-negative numbers.");
                    e.Cancel = true;
                    txtStudentID.Clear();
                }
            }
        }
    }
}
