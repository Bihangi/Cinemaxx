namespace CinemaxxDuplicate.Forms
{
    partial class MoviesFormAdmin
    {

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviesFormAdmin));
            this.movieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaxxDataSetMovie = new CinemaxxDuplicate.CinemaxxDataSetMovie();
            this.labelMovieName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.dateTimePickerMovieDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxMovie = new System.Windows.Forms.TextBox();
            this.BtnAddNewColumn2 = new System.Windows.Forms.Button();
            this.BtnUpdateTable2 = new System.Windows.Forms.Button();
            this.BtnDeleteTable2 = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.buttonLogout2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelAvailability = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxAvailability = new System.Windows.Forms.TextBox();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.movieTableAdapter1 = new CinemaxxDuplicate.CinemaxxDataSetMovieTableAdapters.MovieTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.movieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaxxDataSetMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // movieBindingSource1
            // 
            this.movieBindingSource1.DataMember = "Movie";
            this.movieBindingSource1.DataSource = this.cinemaxxDataSetMovie;
            // 
            // cinemaxxDataSetMovie
            // 
            this.cinemaxxDataSetMovie.DataSetName = "CinemaxxDataSetMovie";
            this.cinemaxxDataSetMovie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelMovieName
            // 
            this.labelMovieName.AutoSize = true;
            this.labelMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovieName.Location = new System.Drawing.Point(48, 192);
            this.labelMovieName.Name = "labelMovieName";
            this.labelMovieName.Size = new System.Drawing.Size(66, 24);
            this.labelMovieName.TabIndex = 0;
            this.labelMovieName.Text = "Movie";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(50, 337);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 24);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(50, 407);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(57, 24);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Time";
            // 
            // dateTimePickerMovieDate
            // 
            this.dateTimePickerMovieDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerMovieDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerMovieDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerMovieDate.Location = new System.Drawing.Point(231, 338);
            this.dateTimePickerMovieDate.Name = "dateTimePickerMovieDate";
            this.dateTimePickerMovieDate.Size = new System.Drawing.Size(220, 21);
            this.dateTimePickerMovieDate.TabIndex = 38;
            // 
            // textBoxMovie
            // 
            this.textBoxMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMovie.Location = new System.Drawing.Point(231, 197);
            this.textBoxMovie.Name = "textBoxMovie";
            this.textBoxMovie.Size = new System.Drawing.Size(220, 21);
            this.textBoxMovie.TabIndex = 35;
            this.textBoxMovie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnAddNewColumn2
            // 
            this.BtnAddNewColumn2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnAddNewColumn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddNewColumn2.Font = new System.Drawing.Font("Aachen BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNewColumn2.Location = new System.Drawing.Point(52, 587);
            this.BtnAddNewColumn2.Name = "BtnAddNewColumn2";
            this.BtnAddNewColumn2.Size = new System.Drawing.Size(74, 33);
            this.BtnAddNewColumn2.TabIndex = 40;
            this.BtnAddNewColumn2.Text = "ADD";
            this.BtnAddNewColumn2.UseVisualStyleBackColor = false;
            this.BtnAddNewColumn2.Click += new System.EventHandler(this.BtnAddNewColumn2_Click);
            // 
            // BtnUpdateTable2
            // 
            this.BtnUpdateTable2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnUpdateTable2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateTable2.Font = new System.Drawing.Font("Aachen BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateTable2.Location = new System.Drawing.Point(152, 587);
            this.BtnUpdateTable2.Name = "BtnUpdateTable2";
            this.BtnUpdateTable2.Size = new System.Drawing.Size(74, 33);
            this.BtnUpdateTable2.TabIndex = 41;
            this.BtnUpdateTable2.Text = "UPDATE";
            this.BtnUpdateTable2.UseVisualStyleBackColor = false;
            this.BtnUpdateTable2.Click += new System.EventHandler(this.BtnUpdateTable2_Click);
            // 
            // BtnDeleteTable2
            // 
            this.BtnDeleteTable2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnDeleteTable2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteTable2.Font = new System.Drawing.Font("Aachen BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteTable2.Location = new System.Drawing.Point(254, 587);
            this.BtnDeleteTable2.Name = "BtnDeleteTable2";
            this.BtnDeleteTable2.Size = new System.Drawing.Size(74, 33);
            this.BtnDeleteTable2.TabIndex = 42;
            this.BtnDeleteTable2.Text = "DELETE";
            this.BtnDeleteTable2.UseVisualStyleBackColor = false;
            this.BtnDeleteTable2.Click += new System.EventHandler(this.BtnDeleteTable2_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClear2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear2.Font = new System.Drawing.Font("Aachen BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear2.Location = new System.Drawing.Point(357, 587);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(74, 33);
            this.btnClear2.TabIndex = 45;
            this.btnClear2.Text = "CLEAR";
            this.btnClear2.UseVisualStyleBackColor = false;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // buttonLogout2
            // 
            this.buttonLogout2.BackColor = System.Drawing.Color.Chocolate;
            this.buttonLogout2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout2.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonLogout2.FlatAppearance.BorderSize = 3;
            this.buttonLogout2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLogout2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout2.Font = new System.Drawing.Font("Aachen BT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout2.Location = new System.Drawing.Point(1243, 629);
            this.buttonLogout2.Name = "buttonLogout2";
            this.buttonLogout2.Size = new System.Drawing.Size(90, 34);
            this.buttonLogout2.TabIndex = 46;
            this.buttonLogout2.Text = "LOGOUT";
            this.buttonLogout2.UseVisualStyleBackColor = false;
            this.buttonLogout2.Click += new System.EventHandler(this.buttonLogout2_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1266, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 29);
            this.button2.TabIndex = 47;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Aachen BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(615, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(523, 59);
            this.label3.TabIndex = 49;
            this.label3.Text = "MOVIE MANAGEMENT";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.Location = new System.Drawing.Point(48, 262);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(68, 24);
            this.labelGenre.TabIndex = 50;
            this.labelGenre.Text = "Genre";
            // 
            // labelAvailability
            // 
            this.labelAvailability.AutoSize = true;
            this.labelAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailability.Location = new System.Drawing.Point(48, 480);
            this.labelAvailability.Name = "labelAvailability";
            this.labelAvailability.Size = new System.Drawing.Size(108, 24);
            this.labelAvailability.TabIndex = 51;
            this.labelAvailability.Text = "Availability";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGenre.Location = new System.Drawing.Point(231, 267);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(220, 21);
            this.textBoxGenre.TabIndex = 53;
            this.textBoxGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAvailability
            // 
            this.textBoxAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvailability.Location = new System.Drawing.Point(231, 485);
            this.textBoxAvailability.Name = "textBoxAvailability";
            this.textBoxAvailability.Size = new System.Drawing.Size(220, 21);
            this.textBoxAvailability.TabIndex = 54;
            this.textBoxAvailability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(231, 411);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerTime.TabIndex = 56;
            // 
            // movieTableAdapter1
            // 
            this.movieTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieIDDataGridViewTextBoxColumn,
            this.movieNameDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.availabilityDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.movieBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(539, 127);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(768, 304);
            this.dataGridView1.TabIndex = 57;
            // 
            // movieIDDataGridViewTextBoxColumn
            // 
            this.movieIDDataGridViewTextBoxColumn.DataPropertyName = "MovieID";
            this.movieIDDataGridViewTextBoxColumn.HeaderText = "MovieID";
            this.movieIDDataGridViewTextBoxColumn.Name = "movieIDDataGridViewTextBoxColumn";
            // 
            // movieNameDataGridViewTextBoxColumn
            // 
            this.movieNameDataGridViewTextBoxColumn.DataPropertyName = "MovieName";
            this.movieNameDataGridViewTextBoxColumn.HeaderText = "MovieName";
            this.movieNameDataGridViewTextBoxColumn.Name = "movieNameDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // availabilityDataGridViewTextBoxColumn
            // 
            this.availabilityDataGridViewTextBoxColumn.DataPropertyName = "Availability";
            this.availabilityDataGridViewTextBoxColumn.HeaderText = "Availability";
            this.availabilityDataGridViewTextBoxColumn.Name = "availabilityDataGridViewTextBoxColumn";
            // 
            // MoviesFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CinemaxxDuplicate.Properties.Resources.AdminSubPage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.textBoxAvailability);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.labelAvailability);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonLogout2);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.BtnDeleteTable2);
            this.Controls.Add(this.BtnUpdateTable2);
            this.Controls.Add(this.BtnAddNewColumn2);
            this.Controls.Add(this.dateTimePickerMovieDate);
            this.Controls.Add(this.textBoxMovie);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelMovieName);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoviesFormAdmin";
            this.Text = "Cinemaxx Movies";
            this.Load += new System.EventHandler(this.MoviesFormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaxxDataSetMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMovieName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerMovieDate;
        private System.Windows.Forms.TextBox textBoxMovie;
        private System.Windows.Forms.Button BtnAddNewColumn2;
        private System.Windows.Forms.Button BtnUpdateTable2;
        private System.Windows.Forms.Button BtnDeleteTable2;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Button buttonLogout2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelAvailability;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxAvailability;
        //private System.Windows.Forms.DataGridViewTextBoxColumn noOfBookingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private CinemaxxDataSetMovie cinemaxxDataSetMovie;
        private System.Windows.Forms.BindingSource movieBindingSource1;
        private CinemaxxDataSetMovieTableAdapters.MovieTableAdapter movieTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availabilityDataGridViewTextBoxColumn;
    }
}