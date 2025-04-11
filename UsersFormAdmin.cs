using System;
using System.Data;
using System.Windows.Forms;
using CinemaxxDuplicate.Classes;

namespace CinemaxxDuplicate.Forms
{
    public partial class UsersFormAdmin : Form
    {
        private Admin _admin; 
        private dbUserHelper _userHelper; 

        // Constructor updated to receive an Admin object
        public UsersFormAdmin(Admin admin)
        {
            InitializeComponent();
            _userHelper = new dbUserHelper(); 
            LoadUserData();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged; 
        }

        private void UsersFormAdmin_Load(object sender, EventArgs e)
        {
            LoadUserData(); 
        }

        private void LoadUserData()
        {
            try
            {
                DataTable dataTable = _userHelper.GetAllUsers(); 
                dataGridView1.DataSource = dataTable; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}"); 
            }
        }



        // Add User Button logic
        private void BtnAddNewColumn_Click(object sender, EventArgs e)
        {
            if (ValidateInputs()) 
            {
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                string email = textBoxEmail.Text;
                string contactNo = textBoxContactNo.Text;
                string role = textBoxRole.Text;

                try
                {
                    Admin admin = new Admin(0, "", "", "", "", "");
                    admin.CreateUser(username, password, email, contactNo, role); 
                    ClearInputs();
                    LoadUserData(); 
                }
                catch (Exception ex)
                {

                }
            }
        }


        // Update User Button
        private void BtnUpdateTable_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() && dataGridView1.SelectedRows.Count > 0) 
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int userID = Convert.ToInt32(selectedRow.Cells[0].Value); 
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                string email = textBoxEmail.Text;
                string contactNo = textBoxContactNo.Text;
                string role = textBoxRole.Text;

                try
                {
                    Admin admin = new Admin(0, "", "", "", "", "");
                    admin.UpdateUser(userID, username, password, email, contactNo, role); 
                    ClearInputs();
                    LoadUserData(); 
                }
                catch (Exception ex)
                {

                }
            }
        }


        // Delete User Button
        private void BtnDeleteTable_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int userID = Convert.ToInt32(selectedRow.Cells[0].Value); 

                try
                {
                    Admin admin = new Admin(0, "", "", "", "", "");
                    admin.DeleteUser(userID); 
                    ClearInputs();
                    LoadUserData(); 
                }
                catch (Exception ex)
                {

                }
            }
        }


        // Validation of Data
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxContactNo.Text) ||
                string.IsNullOrWhiteSpace(textBoxRole.Text))
            {
                MessageBox.Show("All fields must be filled!");
                return false;
            }

            if (!textBoxEmail.Text.Contains("@"))
            {
                MessageBox.Show("Invalid email format!"); 
                return false;
            }

            if (textBoxContactNo.Text.Length != 10 || !long.TryParse(textBoxContactNo.Text, out _))
            {
                MessageBox.Show("Invalid contact number format!"); 
                return false;
            }

            return true; 
        }

        private void ClearInputs()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxEmail.Clear();
            textBoxContactNo.Clear();
            textBoxRole.Clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                textBoxUsername.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                textBoxPassword.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                textBoxEmail.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                textBoxContactNo.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                textBoxRole.Text = selectedRow.Cells[5].Value?.ToString() ?? string.Empty;
            }
        }

        // Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs(); 
        }

        // Logout Button
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogoutAndRedirect();
        }

        private void LogoutAndRedirect()
        {
            this.Hide(); 
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close(); 
        }

        // Back Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminDashboardForm clickBack = new AdminDashboardForm();
            clickBack.Show(); 
            this.Hide(); 
            this.Close(); 
        }

        private void UsersFormAdmin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
