using System;
using System.Windows.Forms;
using static CinemaxxDuplicate.dbMovieHelper;

namespace CinemaxxDuplicate.Forms
{
    public partial class MoviesFormUser : Form
    {
        private readonly dbUserHelper userHelper = new dbUserHelper();

        public MoviesFormUser()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }



        // Load data for movies into the DataGridView when the form loads
        private void MoviesFormUser_Load(object sender, EventArgs e)
        {
            this.movieTableAdapter.Fill(this.cinemaxxDataSetMovie2.Movie);
        }



        // When a movie row is clicked in the DataGridView, auto-fill the details
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                FillTextBoxes(selectedRow, textBoxMovie, dateTimePickerMovieDate, dateTimePickerTime, textBoxAvailability);
            }
        }


        // Booking button 
        private void buttonBook_Click(object sender, EventArgs e)
        {
            if (dbMovieHelper.CanBookMovie(textBoxAvailability.Text, chkAgree.Checked))
            {
                int selectedMovieID = GetSelectedMovieID();
                DateTime selectedMovieTime = dateTimePickerMovieDate.Value.Date.Add(dateTimePickerTime.Value.TimeOfDay);

                using (BookingFormUser bookingForm = new BookingFormUser(selectedMovieID, selectedMovieTime))
                {
                    bookingForm.ShowDialog();
                }
                this.Hide();
            }
            
        }



        // Back button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (UserDashboardForm dashboardForm = new UserDashboardForm())
            {
                dashboardForm.ShowDialog();
            }
            this.Close();

        }


        // Logout button 
        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            LogoutAndRedirect();
        }


        private void LogoutAndRedirect()
        {
            this.Hide();
            using (LoginForm loginForm = new LoginForm())
            {
                loginForm.ShowDialog();
            }
            this.Close();
        }



        // Get the selected movie ID from the DataGridView
        private int GetSelectedMovieID()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                return int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            return 0; 
        }



        // Method to fill text boxes with the selected row's movie details
        private void FillTextBoxes(DataGridViewRow selectedRow, TextBox textBoxMovie, DateTimePicker dateTimePickerMovieDate, DateTimePicker dateTimePickerTime, TextBox textBoxAvailability)
        {
            textBoxMovie.Text = selectedRow.Cells[1].Value.ToString();
            dateTimePickerMovieDate.Text = Convert.ToDateTime(selectedRow.Cells[3].Value).ToString("MMMM dd, yyyy");
            dateTimePickerTime.Text = selectedRow.Cells[4].Value.ToString();
            textBoxAvailability.Text = selectedRow.Cells[5].Value.ToString();
        }

    }
}
