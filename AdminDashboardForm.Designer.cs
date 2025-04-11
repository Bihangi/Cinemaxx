namespace CinemaxxDuplicate.Forms
{
    partial class AdminDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            this.labelAdmin = new System.Windows.Forms.Label();
            this.buttonBookings = new System.Windows.Forms.Button();
            this.buttonMovies = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelCinemaxx1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.Location = new System.Drawing.Point(39, 27);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(66, 20);
            this.labelAdmin.TabIndex = 0;
            this.labelAdmin.Text = "ADMIN";
            // 
            // buttonBookings
            // 
            this.buttonBookings.BackColor = System.Drawing.Color.Transparent;
            this.buttonBookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBookings.FlatAppearance.BorderSize = 0;
            this.buttonBookings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBookings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookings.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookings.Location = new System.Drawing.Point(43, 116);
            this.buttonBookings.Name = "buttonBookings";
            this.buttonBookings.Size = new System.Drawing.Size(89, 27);
            this.buttonBookings.TabIndex = 1;
            this.buttonBookings.Text = "Bookings";
            this.buttonBookings.UseVisualStyleBackColor = false;
            this.buttonBookings.Click += new System.EventHandler(this.buttonBookings_Click);
            // 
            // buttonMovies
            // 
            this.buttonMovies.BackColor = System.Drawing.Color.Transparent;
            this.buttonMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMovies.FlatAppearance.BorderSize = 0;
            this.buttonMovies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMovies.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMovies.Location = new System.Drawing.Point(43, 195);
            this.buttonMovies.Name = "buttonMovies";
            this.buttonMovies.Size = new System.Drawing.Size(80, 27);
            this.buttonMovies.TabIndex = 2;
            this.buttonMovies.Text = "Movies";
            this.buttonMovies.UseVisualStyleBackColor = false;
            this.buttonMovies.Click += new System.EventHandler(this.buttonMovies_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackColor = System.Drawing.Color.Transparent;
            this.buttonUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsers.Location = new System.Drawing.Point(52, 277);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(63, 26);
            this.buttonUsers.TabIndex = 3;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonLogout.FlatAppearance.BorderSize = 2;
            this.buttonLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Aachen BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(42, 332);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(1);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(73, 24);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelCinemaxx1
            // 
            this.labelCinemaxx1.AutoSize = true;
            this.labelCinemaxx1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCinemaxx1.Location = new System.Drawing.Point(246, 180);
            this.labelCinemaxx1.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelCinemaxx1.Name = "labelCinemaxx1";
            this.labelCinemaxx1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCinemaxx1.Size = new System.Drawing.Size(381, 57);
            this.labelCinemaxx1.TabIndex = 5;
            this.labelCinemaxx1.Text = "Cinemaxx, the Starview Club\'s exclusive movie booking platform, offers seamless t" +
    "icket reservations and personalized experiences for members.";
            this.labelCinemaxx1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCinemaxx1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CinemaxxDuplicate.Properties.Resources.Dashboard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 376);
            this.Controls.Add(this.labelCinemaxx1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.buttonMovies);
            this.Controls.Add(this.buttonBookings);
            this.Controls.Add(this.labelAdmin);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboardForm";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Button buttonBookings;
        private System.Windows.Forms.Button buttonMovies;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelCinemaxx1;
    }
}