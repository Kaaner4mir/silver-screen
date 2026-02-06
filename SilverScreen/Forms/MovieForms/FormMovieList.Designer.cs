namespace SilverScreen
{
    partial class FormMovieList
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
            if (disposing)
            {
                _context?.Dispose();
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.grid_control_movies = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_control_movies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_control_movies
            // 
            this.grid_control_movies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_control_movies.Location = new System.Drawing.Point(0, 0);
            this.grid_control_movies.MainView = this.gridView1;
            this.grid_control_movies.Name = "grid_control_movies";
            this.grid_control_movies.Size = new System.Drawing.Size(800, 450);
            this.grid_control_movies.TabIndex = 0;
            this.grid_control_movies.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_control_movies;
            this.gridView1.Name = "gridView1";
            // 
            // FormMovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid_control_movies);
            this.Name = "FormMovieList";
            this.Text = "List of Movies";
            this.Load += new System.EventHandler(this.FormMovieList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_control_movies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_control_movies;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}