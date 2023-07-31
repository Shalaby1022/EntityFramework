using System;
using System.Linq;
using System.Windows.Forms;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        private EFContext dbContext;
        private int selectedAuthorId = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbContext = new EFContext();

            LoadData();
            ButtonsDisplay(true);
        }

        private void LoadData()
        {
            var authors = dbContext.Authors.ToList();
            dgv_Employees.DataSource = authors.Select(a => new
            {
                a.Id,
                a.Name,
                a.Age,
                a.Email,
                a.Address,
                a.Password
            }).ToList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Author author = new Author
                {
                    Name = txt_name.Text,
                    Age = (int)nud_age.Value,
                    Email = txt_email.Text,
                    Password = txt_password.Text,
                    Address = textBox1.Text
                };
                dbContext.Authors.Add(author);
                dbContext.SaveChanges();
                MessageBox.Show("Author data has been added");

                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong\n {ex}");
            }
        }

        private void dgv_Employees_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedAuthorId = (int)dgv_Employees.SelectedRows[0].Cells[0].Value;
            var selectedAuthor = dbContext.Authors.Find(selectedAuthorId);

            if (selectedAuthor != null)
            {
                txt_name.Text = selectedAuthor.Name;
                nud_age.Value = selectedAuthor.Age;
                txt_email.Text = selectedAuthor.Email;
                txt_password.Text = selectedAuthor.Password;
                textBox1.Text = selectedAuthor.Address;
            }
            ButtonsDisplay(false);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedAuthor = dbContext.Authors.Find(selectedAuthorId);

                if (selectedAuthor != null)
                {
                    selectedAuthor.Name = txt_name.Text;
                    selectedAuthor.Age = (int)nud_age.Value;
                    selectedAuthor.Email = txt_email.Text;
                    selectedAuthor.Password = txt_password.Text;
                    selectedAuthor.Address = textBox1.Text;

                    dbContext.SaveChanges();
                    MessageBox.Show("Author data has been updated");

                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong\n {ex}");
            }
            ButtonsDisplay(true);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedAuthor = dbContext.Authors.Find(selectedAuthorId);

                if (selectedAuthor != null)
                {
                    dbContext.Authors.Remove(selectedAuthor);
                    dbContext.SaveChanges();
                    MessageBox.Show("Author data has been deleted");

                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong\n {ex}");
            }
            ButtonsDisplay(true);
        }

        void ClearInputs()
        {
            txt_name.Text = txt_email.Text = txt_password.Text = textBox1.Text = "";
            nud_age.Value = 0;
            selectedAuthorId = 0;
        }

        void ButtonsDisplay(bool visible)
        {
            btn_add.Visible = visible;
            btn_delete.Visible = !visible;
            btn_update.Visible = !visible;
        }

    }
}
