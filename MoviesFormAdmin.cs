using CinemaxxDuplicate.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace CinemaxxDuplicate.Forms
{
    public partial class MoviesFormAdmin : Form
    {
        private dbMovieHelper _movieHelper;
        private Admin _currentAdmin;
        private int _selectedMovieID = -1;



        // Constructor that takes Admin as a parameter
        public MoviesFormAdmin(Admin admin)
        {
            InitializeComponent();
            _movieHelper = new dbMovieHelper();
            _currentAdmin = admin; 
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }

        private void MoviesFormAdmin_Load(object sender, EventArgs e)
        {
            RefreshMovieGrid();
        }



        // Method to refresh the movie grid
        private void RefreshMovieGrid()
        {

            DataTable moviesTable = _movieHelper.GetAllMovies();
            if (moviesTable != null)
            {
                dataGridView1.DataSource = moviesTable;
            }
        }


        // Add a new movie
        private void BtnAddNewColumn2_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var newMovie = new Movie(
                textBoxMovie.Text,
                textBoxGenre.Text,
                dateTimePickerMovieDate.Value,
                dateTimePickerTime.Value.TimeOfDay,
                textBoxAvailability.Text
            );

                if (_movieHelper.AddMovie(newMovie))
                {
                    MessageBox.Show("Movie added successfully!");
                    ClearInputs();
                    RefreshMovieGrid();
                }
                else
                {
                    MessageBox.Show("Failed to add the movie.");
                }
            }
                
        }



        // Update an existing movie
        private void BtnUpdateTable2_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() && dataGridView1.SelectedRows.Count > 0)
            {
                if (_selectedMovieID == -1)
                {
                    MessageBox.Show("Please select a movie to update.");
                    return;
                }

                var updatedMovie = new Movie(
                    _selectedMovieID,
                    textBoxMovie.Text,
                    textBoxGenre.Text,
                    dateTimePickerMovieDate.Value,
                    dateTimePickerTime.Value.TimeOfDay,
                    textBoxAvailability.Text
                );

                if (_movieHelper.UpdateMovie(updatedMovie))
                {
                    MessageBox.Show("Movie updated successfully!");
                    ClearInputs();
                    RefreshMovieGrid();
                }
                else
                {
                    MessageBox.Show("Failed to update the movie.");
                }
            }
                
        }



        // Delete a movie
        private void BtnDeleteTable2_Click(object sender, EventArgs e)
        {
            if (_selectedMovieID == -1)
            {
                MessageBox.Show("Please select a movie to delete.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this movie?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (_movieHelper.DeleteMovie(_selectedMovieID))
                {
                    MessageBox.Show("Movie deleted successfully!");
                    ClearInputs();
                    RefreshMovieGrid();
                }
                else
                {
                    MessageBox.Show("Failed to delete the movie.");
                }
            }
        }



        // Handle row selection and populate form fields
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                _selectedMovieID = Convert.ToInt32(row.Cells[0].Value);
                textBoxMovie.Text = row.Cells[1].Value.ToString();
                textBoxGenre.Text = row.Cells[2].Value.ToString();
                dateTimePickerMovieDate.Value = Convert.ToDateTime(row.Cells[3].Value);
                dateTimePickerTime.Value = DateTime.Today.Add((TimeSpan)row.Cells[4].Value);
                textBoxAvailability.Text = row.Cells[5].Value.ToString();
            }
        }


        // Validation of Data
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBoxMovie.Text) ||
                string.IsNullOrWhiteSpace(textBoxGenre.Text) ||
                string.IsNullOrWhiteSpace(dateTimePickerMovieDate.Text) ||
                string.IsNullOrWhiteSpace(dateTimePickerTime.Text) ||
                string.IsNullOrWhiteSpace(textBoxAvailability.Text))
            {
                MessageBox.Show("All fields must be filled!");
                return false;
            }

            return true;
        }


        private void ClearInputs()
        {
            textBoxMovie.Clear();
            textBoxGenre.Clear();
            textBoxAvailability.Clear();
            dateTimePickerMovieDate.Value = DateTime.Now;
            dateTimePickerTime.Value = DateTime.Now;
            _selectedMovieID = -1;
        }


        //Clear Button
        private void btnClear2_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }


        //Logout Button
        private void buttonLogout2_Click(object sender, EventArgs e)
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



        //Back Button
        private void button2_Click(object sender, EventArgs e)
        {
            AdminDashboardForm clickBack = new AdminDashboardForm();
            clickBack.Show();
            this.Hide();
            this.Close();
        }
    }
}
