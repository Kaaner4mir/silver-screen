namespace SilverScreen.Forms
{
    partial class FormUpdateMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateMovie));
            this.button_add = new DevExpress.XtraEditors.SimpleButton();
            this.textedit_movie_type = new DevExpress.XtraEditors.TextEdit();
            this.label_release_time = new DevExpress.XtraEditors.LabelControl();
            this.label_duration = new DevExpress.XtraEditors.LabelControl();
            this.label_type = new DevExpress.XtraEditors.LabelControl();
            this.textedit_movie_name = new DevExpress.XtraEditors.TextEdit();
            this.label_name = new DevExpress.XtraEditors.LabelControl();
            this.numeric_up_down_duration = new System.Windows.Forms.NumericUpDown();
            this.dateEdit_release_time = new DevExpress.XtraEditors.DateEdit();
            this.comboBox_select_movie = new System.Windows.Forms.ComboBox();
            this.label_selected_movie = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_movie_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_movie_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_up_down_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_release_time.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_release_time.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.button_add.Appearance.Options.UseFont = true;
            this.button_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_add.ImageOptions.Image")));
            this.button_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.button_add.Location = new System.Drawing.Point(570, 380);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(180, 50);
            this.button_add.TabIndex = 26;
            this.button_add.Text = "Update Movie";
            this.button_add.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textedit_movie_type
            // 
            this.textedit_movie_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textedit_movie_type.Location = new System.Drawing.Point(200, 137);
            this.textedit_movie_type.Name = "textedit_movie_type";
            this.textedit_movie_type.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.textedit_movie_type.Properties.Appearance.Options.UseFont = true;
            this.textedit_movie_type.Size = new System.Drawing.Size(550, 28);
            this.textedit_movie_type.TabIndex = 25;
            // 
            // label_release_time
            // 
            this.label_release_time.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_release_time.Appearance.Options.UseFont = true;
            this.label_release_time.Location = new System.Drawing.Point(50, 260);
            this.label_release_time.Name = "label_release_time";
            this.label_release_time.Size = new System.Drawing.Size(150, 21);
            this.label_release_time.TabIndex = 24;
            this.label_release_time.Text = "Movie Release Time";
            // 
            // label_duration
            // 
            this.label_duration.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_duration.Appearance.Options.UseFont = true;
            this.label_duration.Location = new System.Drawing.Point(50, 200);
            this.label_duration.Name = "label_duration";
            this.label_duration.Size = new System.Drawing.Size(120, 21);
            this.label_duration.TabIndex = 23;
            this.label_duration.Text = "Movie Duration";
            // 
            // label_type
            // 
            this.label_type.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_type.Appearance.Options.UseFont = true;
            this.label_type.Location = new System.Drawing.Point(50, 140);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(86, 21);
            this.label_type.TabIndex = 22;
            this.label_type.Text = "Movie Type";
            // 
            // textedit_movie_name
            // 
            this.textedit_movie_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textedit_movie_name.Location = new System.Drawing.Point(200, 77);
            this.textedit_movie_name.Name = "textedit_movie_name";
            this.textedit_movie_name.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.textedit_movie_name.Properties.Appearance.Options.UseFont = true;
            this.textedit_movie_name.Size = new System.Drawing.Size(550, 28);
            this.textedit_movie_name.TabIndex = 21;
            // 
            // label_name
            // 
            this.label_name.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_name.Appearance.Options.UseFont = true;
            this.label_name.Location = new System.Drawing.Point(50, 80);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(94, 21);
            this.label_name.TabIndex = 20;
            this.label_name.Text = "Movie Name";
            // 
            this.numeric_up_down_duration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numeric_up_down_duration.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.numeric_up_down_duration.Location = new System.Drawing.Point(200, 197);
            this.numeric_up_down_duration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_up_down_duration.Name = "numeric_up_down_duration";
            this.numeric_up_down_duration.Size = new System.Drawing.Size(550, 29);
            this.numeric_up_down_duration.TabIndex = 27;
            // 
            // dateEdit_release_time
            // 
            this.dateEdit_release_time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEdit_release_time.EditValue = null;
            this.dateEdit_release_time.Location = new System.Drawing.Point(200, 257);
            this.dateEdit_release_time.Name = "dateEdit_release_time";
            this.dateEdit_release_time.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.dateEdit_release_time.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_release_time.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_release_time.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_release_time.Size = new System.Drawing.Size(550, 28);
            this.dateEdit_release_time.TabIndex = 28;
            // 
            // comboBox_select_movie
            // 
            this.comboBox_select_movie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_select_movie.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.comboBox_select_movie.FormattingEnabled = true;
            this.comboBox_select_movie.Location = new System.Drawing.Point(200, 17);
            this.comboBox_select_movie.Name = "comboBox_select_movie";
            this.comboBox_select_movie.Size = new System.Drawing.Size(550, 29);
            this.comboBox_select_movie.TabIndex = 29;
            this.comboBox_select_movie.SelectedIndexChanged += new System.EventHandler(this.comboBox_select_movie_SelectedIndexChanged);
            // 
            // label_selected_movie
            // 
            this.label_selected_movie.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_selected_movie.Appearance.Options.UseFont = true;
            this.label_selected_movie.Location = new System.Drawing.Point(50, 20);
            this.label_selected_movie.Name = "label_selected_movie";
            this.label_selected_movie.Size = new System.Drawing.Size(117, 21);
            this.label_selected_movie.TabIndex = 30;
            this.label_selected_movie.Text = "Selected Movie";
            // 
            // FormUpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_selected_movie);
            this.Controls.Add(this.comboBox_select_movie);
            this.Controls.Add(this.dateEdit_release_time);
            this.Controls.Add(this.numeric_up_down_duration);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textedit_movie_type);
            this.Controls.Add(this.label_release_time);
            this.Controls.Add(this.label_duration);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.textedit_movie_name);
            this.Controls.Add(this.label_name);
            this.Name = "FormUpdateMovie";
            this.Text = "Update movie";
            this.Load += new System.EventHandler(this.FormUpdateMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textedit_movie_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_movie_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_up_down_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_release_time.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_release_time.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton button_add;
        private DevExpress.XtraEditors.TextEdit textedit_movie_type;
        private DevExpress.XtraEditors.LabelControl label_release_time;
        private DevExpress.XtraEditors.LabelControl label_duration;
        private DevExpress.XtraEditors.LabelControl label_type;
        private DevExpress.XtraEditors.TextEdit textedit_movie_name;
        private DevExpress.XtraEditors.LabelControl label_name;
        private System.Windows.Forms.NumericUpDown numeric_up_down_duration;
        private DevExpress.XtraEditors.DateEdit dateEdit_release_time;
        private System.Windows.Forms.ComboBox comboBox_select_movie;
        private DevExpress.XtraEditors.LabelControl label_selected_movie;
    }
}