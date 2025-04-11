using CinemaxxDuplicate.Classes;
using CinemaxxDuplicate.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CinemaxxDuplicate
{
    public partial class BookingFormAdmin : Form
    {
        private dbBookingHelper dbHelper = new dbBookingHelper();
        private int selectedBookingID = -1;
        private Admin _currentAdmin;

        public BookingFormAdmin(Admin admin)
        {
            InitializeComponent();
            _currentAdmin = admin;
            dataGridViewBooking.CellClick += new DataGridViewCellEventHandler(dataGridViewBooking_CellClick);
        }

        private void BookingFormAdmin_Load(object sender, EventArgs e)
        {
            this.bookingTableAdapter.Fill(this.cinemaxxDataSetBooking.Booking);
            RefreshBookingGrid();
        }


        // Load booking data into the DataGridView
        private void RefreshBookingGrid()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(dbHelper.connectionString))
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT BookingID, UserID, MovieID, Username, MovieName, BookingDate, Status FROM [Booking] ORDER BY BookingID", conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewBooking.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading booking data: " + ex.Message);
            }
        }



        // Update selected booking's status
        private void BtnUpdateTable_Click_1(object sender, EventArgs e)
        {
            if (selectedBookingID == -1)
            {
                MessageBox.Show("Please select a booking to update.");
                return;
            }

            string status = textBoxStatus.Text;

            if (dbHelper.UpdateBookingStatus(selectedBookingID, status))
            {
                MessageBox.Show("Booking status updated successfully!");
                RefreshBookingGrid();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Failed to update the booking status.");
            }
        }


        // Delete selected booking
        private void BtnDeleteTable_Click(object sender, EventArgs e)
        {
            if (selectedBookingID == -1)
            {
                MessageBox.Show("Please select a booking to delete.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this booking?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (dbHelper.DeleteBooking(selectedBookingID))
                {
                    MessageBox.Show("Booking successfully deleted!");
                    RefreshBookingGrid();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Failed to delete the booking.");
                }
            }
        }


        // Event handler for DataGridView cell click
        private void dataGridViewBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridViewBooking.Rows[e.RowIndex];
                selectedBookingID = Convert.ToInt32(row.Cells[0].Value); 

                textBoxUserID.Text = row.Cells[1].Value.ToString();
                textBoxMovieID.Text = row.Cells[2].Value.ToString();
                textBoxUsername.Text = row.Cells[3].Value.ToString();
                textBoxMovie.Text = row.Cells[4].Value.ToString();
                dateTimePicker.Value = Convert.ToDateTime(row.Cells[5].Value);
                textBoxStatus.Text = row.Cells[6].Value.ToString();
            }
        }


        // Clear input fields
        private void ClearInputs()
        {
            textBoxUserID.Clear();
            textBoxMovieID.Clear();
            textBoxUsername.Clear();
            textBoxMovie.Clear();
            dateTimePicker.Value = DateTime.Now;
            textBoxStatus.Clear();
        }


        //Clear Button
        private void btnClear2_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }


        //Logout Button
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


        //Back Button
        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboardForm clickBack = new AdminDashboardForm();
            clickBack.Show();
            this.Hide();
        }

        
    }
}
