namespace SilverScreen.Forms
{
    partial class FormAddMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddMovie));
            this.label_name = new DevExpress.XtraEditors.LabelControl();
            this.textedit_movie_name = new DevExpress.XtraEditors.TextEdit();
            this.label_type = new DevExpress.XtraEditors.LabelControl();
            this.label_duration = new DevExpress.XtraEditors.LabelControl();
            this.label_release_time = new DevExpress.XtraEditors.LabelControl();
            this.textedit_movie_type = new DevExpress.XtraEditors.TextEdit();
            this.button_add = new DevExpress.XtraEditors.SimpleButton();
            this.numeric_up_down_duration = new System.Windows.Forms.NumericUpDown();
            this.dateEdit_release_time = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_movie_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_movie_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_up_down_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_release_time.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_release_time.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Appearance.Options.UseFont = true;
            this.label_name.Location = new System.Drawing.Point(167, 10);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(107, 25);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Movie Name";
            // 
            // textedit_movie_name
            // 
            this.textedit_movie_name.Location = new System.Drawing.Point(296, 7);
            this.textedit_movie_name.Name = "textedit_movie_name";
            this.textedit_movie_name.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textedit_movie_name.Properties.Appearance.Options.UseFont = true;
            this.textedit_movie_name.Size = new System.Drawing.Size(411, 32);
            this.textedit_movie_name.TabIndex = 1;
            // 
            // label_type
            // 
            this.label_type.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_type.Appearance.Options.UseFont = true;
            this.label_type.Location = new System.Drawing.Point(177, 80);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(97, 25);
            this.label_type.TabIndex = 2;
            this.label_type.Text = "Movie Type";
            // 
            // label_duration
            // 
            this.label_duration.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_duration.Appearance.Options.UseFont = true;
            this.label_duration.Location = new System.Drawing.Point(143, 150);
            this.label_duration.Name = "label_duration";
            this.label_duration.Size = new System.Drawing.Size(131, 25);
            this.label_duration.TabIndex = 3;
            this.label_duration.Text = "Movie Duration";
            // 
            // label_release_time
            // 
            this.label_release_time.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_release_time.Appearance.Options.UseFont = true;
            this.label_release_time.Location = new System.Drawing.Point(107, 220);
            this.label_release_time.Name = "label_release_time";
            this.label_release_time.Size = new System.Drawing.Size(167, 25);
            this.label_release_time.TabIndex = 4;
            this.label_release_time.Text = "Movie Release Time";
            // 
            // textedit_movie_type
            // 
            this.textedit_movie_type.Location = new System.Drawing.Point(296, 76);
            this.textedit_movie_type.Name = "textedit_movie_type";
            this.textedit_movie_type.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textedit_movie_type.Properties.Appearance.Options.UseFont = true;
            this.textedit_movie_type.Size = new System.Drawing.Size(411, 32);
            this.textedit_movie_type.TabIndex = 5;
            // 
            // button_add
            // 
            this.button_add.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_add.Appearance.Options.UseFont = true;
            this.button_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_add.ImageOptions.Image")));
            this.button_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.button_add.Location = new System.Drawing.Point(296, 279);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(148, 55);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Save new movie";
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // numeric_up_down_duration
            // 
            this.numeric_up_down_duration.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_up_down_duration.Location = new System.Drawing.Point(296, 145);
            this.numeric_up_down_duration.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numeric_up_down_duration.Name = "numeric_up_down_duration";
            this.numeric_up_down_duration.Size = new System.Drawing.Size(411, 33);
            this.numeric_up_down_duration.TabIndex = 9;
            // 
            // dateEdit_release_time
            // 
            this.dateEdit_release_time.EditValue = null;
            this.dateEdit_release_time.Location = new System.Drawing.Point(296, 215);
            this.dateEdit_release_time.Name = "dateEdit_release_time";
            this.dateEdit_release_time.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit_release_time.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_release_time.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_release_time.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_release_time.Size = new System.Drawing.Size(411, 32);
            this.dateEdit_release_time.TabIndex = 10;
            // 
            // FormAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 442);
            this.Controls.Add(this.dateEdit_release_time);
            this.Controls.Add(this.numeric_up_down_duration);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textedit_movie_type);
            this.Controls.Add(this.label_release_time);
            this.Controls.Add(this.label_duration);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.textedit_movie_name);
            this.Controls.Add(this.label_name);
            this.Name = "FormAddMovie";
            this.Text = "Add a new movie";
            ((System.ComponentModel.ISupportInitialize)(this.textedit_movie_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_movie_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_up_down_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_release_time.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_release_time.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl label_name;
        private DevExpress.XtraEditors.TextEdit textedit_movie_name;
        private DevExpress.XtraEditors.LabelControl label_type;
        private DevExpress.XtraEditors.LabelControl label_duration;
        private DevExpress.XtraEditors.LabelControl label_release_time;
        private DevExpress.XtraEditors.TextEdit textedit_movie_type;
        private DevExpress.XtraEditors.SimpleButton button_add;
        private System.Windows.Forms.NumericUpDown numeric_up_down_duration;
        private DevExpress.XtraEditors.DateEdit dateEdit_release_time;
    }
}