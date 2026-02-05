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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateMovie));
            this.button_update = new DevExpress.XtraEditors.SimpleButton();
            this.textedit_movie_type = new DevExpress.XtraEditors.TextEdit();
            this.label_release_time = new DevExpress.XtraEditors.LabelControl();
            this.label_duration = new DevExpress.XtraEditors.LabelControl();
            this.label_type = new DevExpress.XtraEditors.LabelControl();
            this.textedit_movie_name = new DevExpress.XtraEditors.TextEdit();
            this.label_name = new DevExpress.XtraEditors.LabelControl();
            this.label_select = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit_release_time = new DevExpress.XtraEditors.DateEdit();
            this.numeric_up_down_duration = new System.Windows.Forms.NumericUpDown();
            this.comboBox_select_movie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_movie_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_movie_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_release_time.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_release_time.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_up_down_duration)).BeginInit();
            this.SuspendLayout();
            // 
            // button_update
            // 
            this.button_update.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_update.Appearance.Options.UseFont = true;
            this.button_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_update.ImageOptions.Image")));
            this.button_update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.button_update.Location = new System.Drawing.Point(275, 323);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(134, 48);
            this.button_update.TabIndex = 17;
            this.button_update.Text = "Update movie";
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textedit_movie_type
            // 
            this.textedit_movie_type.Location = new System.Drawing.Point(275, 149);
            this.textedit_movie_type.Name = "textedit_movie_type";
            this.textedit_movie_type.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textedit_movie_type.Properties.Appearance.Options.UseFont = true;
            this.textedit_movie_type.Size = new System.Drawing.Size(411, 32);
            this.textedit_movie_type.TabIndex = 14;
            // 
            // label_release_time
            // 
            this.label_release_time.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_release_time.Appearance.Options.UseFont = true;
            this.label_release_time.Location = new System.Drawing.Point(82, 282);
            this.label_release_time.Name = "label_release_time";
            this.label_release_time.Size = new System.Drawing.Size(167, 25);
            this.label_release_time.TabIndex = 13;
            this.label_release_time.Text = "Movie Release Time";
            // 
            // label_duration
            // 
            this.label_duration.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_duration.Appearance.Options.UseFont = true;
            this.label_duration.Location = new System.Drawing.Point(118, 219);
            this.label_duration.Name = "label_duration";
            this.label_duration.Size = new System.Drawing.Size(131, 25);
            this.label_duration.TabIndex = 12;
            this.label_duration.Text = "Movie Duration";
            // 
            // label_type
            // 
            this.label_type.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_type.Appearance.Options.UseFont = true;
            this.label_type.Location = new System.Drawing.Point(152, 156);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(97, 25);
            this.label_type.TabIndex = 11;
            this.label_type.Text = "Movie Type";
            // 
            // textedit_movie_name
            // 
            this.textedit_movie_name.Location = new System.Drawing.Point(275, 86);
            this.textedit_movie_name.Name = "textedit_movie_name";
            this.textedit_movie_name.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textedit_movie_name.Properties.Appearance.Options.UseFont = true;
            this.textedit_movie_name.Size = new System.Drawing.Size(411, 32);
            this.textedit_movie_name.TabIndex = 10;
            // 
            // label_name
            // 
            this.label_name.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Appearance.Options.UseFont = true;
            this.label_name.Location = new System.Drawing.Point(142, 93);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(107, 25);
            this.label_name.TabIndex = 9;
            this.label_name.Text = "Movie Name";
            // 
            // label_select
            // 
            this.label_select.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_select.Appearance.Options.UseFont = true;
            this.label_select.Location = new System.Drawing.Point(142, 30);
            this.label_select.Name = "label_select";
            this.label_select.Size = new System.Drawing.Size(107, 25);
            this.label_select.TabIndex = 18;
            this.label_select.Text = "Select Movie";
            // 
            // dateEdit_release_time
            // 
            this.dateEdit_release_time.EditValue = null;
            this.dateEdit_release_time.Location = new System.Drawing.Point(275, 275);
            this.dateEdit_release_time.Name = "dateEdit_release_time";
            this.dateEdit_release_time.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit_release_time.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_release_time.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_release_time.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_release_time.Size = new System.Drawing.Size(411, 32);
            this.dateEdit_release_time.TabIndex = 21;
            // 
            // numeric_up_down_duration
            // 
            this.numeric_up_down_duration.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_up_down_duration.Location = new System.Drawing.Point(275, 211);
            this.numeric_up_down_duration.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numeric_up_down_duration.Name = "numeric_up_down_duration";
            this.numeric_up_down_duration.Size = new System.Drawing.Size(411, 33);
            this.numeric_up_down_duration.TabIndex = 20;
            // 
            // comboBox_select_movie
            // 
            this.comboBox_select_movie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_select_movie.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_select_movie.FormattingEnabled = true;
            this.comboBox_select_movie.Location = new System.Drawing.Point(275, 22);
            this.comboBox_select_movie.Name = "comboBox_select_movie";
            this.comboBox_select_movie.Size = new System.Drawing.Size(411, 33);
            this.comboBox_select_movie.TabIndex = 22;
            this.comboBox_select_movie.SelectedIndexChanged += new System.EventHandler(this.comboBox_select_movie_SelectedIndexChanged);
            // 
            // FormUpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_select_movie);
            this.Controls.Add(this.dateEdit_release_time);
            this.Controls.Add(this.numeric_up_down_duration);
            this.Controls.Add(this.label_select);
            this.Controls.Add(this.button_update);
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
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_release_time.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_release_time.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_up_down_duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton button_update;
        private DevExpress.XtraEditors.TextEdit textedit_movie_type;
        private DevExpress.XtraEditors.LabelControl label_release_time;
        private DevExpress.XtraEditors.LabelControl label_duration;
        private DevExpress.XtraEditors.LabelControl label_type;
        private DevExpress.XtraEditors.TextEdit textedit_movie_name;
        private DevExpress.XtraEditors.LabelControl label_name;
        private DevExpress.XtraEditors.LabelControl label_select;
        private DevExpress.XtraEditors.DateEdit dateEdit_release_time;
        private System.Windows.Forms.NumericUpDown numeric_up_down_duration;
        private System.Windows.Forms.ComboBox comboBox_select_movie;
    }
}