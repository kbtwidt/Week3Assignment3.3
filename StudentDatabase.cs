using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week3Assignment3._3
{
    public partial class StudentDatabase : Form
    {
        public StudentDatabase()
        {
            InitializeComponent();
        }

        private void StudentDatabase_Load(object sender, EventArgs e)
        {
            studentGrid.DataSource = Data.Students;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this Student?", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Data.Students.RemoveAt(studentGrid.CurrentRow.Index);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            studentGrid.DataSource = null;
            studentGrid.DataSource = Data.Students;
        }
    }
}
