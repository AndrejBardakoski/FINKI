namespace Movies
{
    partial class Form1
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
            this.lbMovies = new System.Windows.Forms.ListBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnDeleteRatings = new System.Windows.Forms.Button();
            this.btnAddRating = new System.Windows.Forms.Button();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbMovieHighestRatings = new System.Windows.Forms.TextBox();
            this.tbMovieMostRatings = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMovies
            // 
            this.lbMovies.FormattingEnabled = true;
            this.lbMovies.ItemHeight = 16;
            this.lbMovies.Location = new System.Drawing.Point(13, 22);
            this.lbMovies.Name = "lbMovies";
            this.lbMovies.Size = new System.Drawing.Size(372, 372);
            this.lbMovies.TabIndex = 0;
            this.lbMovies.SelectedIndexChanged += new System.EventHandler(this.lbMovies_SelectedIndexChanged);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(13, 411);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(174, 23);
            this.btnAddMovie.TabIndex = 1;
            this.btnAddMovie.Text = "Додади филм";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnDeleteRatings
            // 
            this.btnDeleteRatings.Location = new System.Drawing.Point(13, 454);
            this.btnDeleteRatings.Name = "btnDeleteRatings";
            this.btnDeleteRatings.Size = new System.Drawing.Size(174, 23);
            this.btnDeleteRatings.TabIndex = 2;
            this.btnDeleteRatings.Text = "Избриши рејтинзи";
            this.btnDeleteRatings.UseVisualStyleBackColor = true;
            this.btnDeleteRatings.Click += new System.EventHandler(this.btnDeleteRatings_Click);
            // 
            // btnAddRating
            // 
            this.btnAddRating.Location = new System.Drawing.Point(422, 62);
            this.btnAddRating.Name = "btnAddRating";
            this.btnAddRating.Size = new System.Drawing.Size(133, 23);
            this.btnAddRating.TabIndex = 3;
            this.btnAddRating.Text = "Додади рејтинг";
            this.btnAddRating.UseVisualStyleBackColor = true;
            this.btnAddRating.Click += new System.EventHandler(this.btnAddRating_Click);
            // 
            // nudRating
            // 
            this.nudRating.Location = new System.Drawing.Point(422, 22);
            this.nudRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(120, 22);
            this.nudRating.TabIndex = 4;
            this.nudRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(419, 97);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(254, 16);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Информации за селектираниот филм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Година";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(422, 267);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(133, 22);
            this.tbYear.TabIndex = 7;
            this.tbYear.TextChanged += new System.EventHandler(this.tbYear_TextChanged);
            // 
            // tbMovieHighestRatings
            // 
            this.tbMovieHighestRatings.Location = new System.Drawing.Point(422, 372);
            this.tbMovieHighestRatings.Name = "tbMovieHighestRatings";
            this.tbMovieHighestRatings.ReadOnly = true;
            this.tbMovieHighestRatings.Size = new System.Drawing.Size(273, 22);
            this.tbMovieHighestRatings.TabIndex = 8;
            // 
            // tbMovieMostRatings
            // 
            this.tbMovieMostRatings.Location = new System.Drawing.Point(422, 441);
            this.tbMovieMostRatings.Name = "tbMovieMostRatings";
            this.tbMovieMostRatings.ReadOnly = true;
            this.tbMovieMostRatings.Size = new System.Drawing.Size(273, 22);
            this.tbMovieMostRatings.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Филм со највисок просечен рејтинг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Филм со најмногу рејтинзи";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 510);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMovieMostRatings);
            this.Controls.Add(this.tbMovieHighestRatings);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.nudRating);
            this.Controls.Add(this.btnAddRating);
            this.Controls.Add(this.btnDeleteRatings);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.lbMovies);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMovies;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnDeleteRatings;
        private System.Windows.Forms.Button btnAddRating;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbMovieHighestRatings;
        private System.Windows.Forms.TextBox tbMovieMostRatings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

