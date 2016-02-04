namespace FilmsCatalog.UI
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.category_combobox = new System.Windows.Forms.ComboBox();
            this.title_textbox = new System.Windows.Forms.TextBox();
            this.description_textbox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.year_textbox = new System.Windows.Forms.TextBox();
            this.savePic_btn = new System.Windows.Forms.Button();
            this.filmPicture_picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.filmPicture_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категория";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание";
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Salmon;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_btn.Location = new System.Drawing.Point(613, 309);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(96, 43);
            this.cancel_btn.TabIndex = 3;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_btn.Location = new System.Drawing.Point(12, 309);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(585, 43);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Сохранить изменения";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // category_combobox
            // 
            this.category_combobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.category_combobox.AutoCompleteCustomSource.AddRange(new string[] {
            "Комедия",
            "Боевик",
            "Триллер",
            "Драма",
            "Документальный",
            "Вестерн ",
            "Исторический "});
            this.category_combobox.BackColor = System.Drawing.Color.LightBlue;
            this.category_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_combobox.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.category_combobox.Items.AddRange(new object[] {
            "Не выбрано",
            "Комедия",
            "Боевик",
            "Триллер",
            "Драма",
            "Документальный",
            "Вестерн ",
            "Исторический ",
            "Фантастика ",
            "Мультфильм"});
            this.category_combobox.Location = new System.Drawing.Point(94, 48);
            this.category_combobox.Name = "category_combobox";
            this.category_combobox.Size = new System.Drawing.Size(192, 22);
            this.category_combobox.TabIndex = 5;
            // 
            // title_textbox
            // 
            this.title_textbox.BackColor = System.Drawing.Color.LightBlue;
            this.title_textbox.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_textbox.Location = new System.Drawing.Point(89, 20);
            this.title_textbox.Name = "title_textbox";
            this.title_textbox.Size = new System.Drawing.Size(291, 22);
            this.title_textbox.TabIndex = 6;
            // 
            // description_textbox
            // 
            this.description_textbox.BackColor = System.Drawing.Color.LightBlue;
            this.description_textbox.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description_textbox.Location = new System.Drawing.Point(12, 132);
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(375, 158);
            this.description_textbox.TabIndex = 7;
            this.description_textbox.Text = "";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Год выпуска";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // year_textbox
            // 
            this.year_textbox.BackColor = System.Drawing.Color.LightBlue;
            this.year_textbox.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_textbox.Location = new System.Drawing.Point(112, 76);
            this.year_textbox.Name = "year_textbox";
            this.year_textbox.Size = new System.Drawing.Size(213, 22);
            this.year_textbox.TabIndex = 10;
            // 
            // savePic_btn
            // 
            this.savePic_btn.BackColor = System.Drawing.Color.SandyBrown;
            this.savePic_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savePic_btn.Location = new System.Drawing.Point(396, 267);
            this.savePic_btn.Name = "savePic_btn";
            this.savePic_btn.Size = new System.Drawing.Size(313, 23);
            this.savePic_btn.TabIndex = 11;
            this.savePic_btn.Text = "Загрузить картинку";
            this.savePic_btn.UseVisualStyleBackColor = false;
            this.savePic_btn.Click += new System.EventHandler(this.savePic_btn_Click);
            // 
            // filmPicture_picturebox
            // 
            this.filmPicture_picturebox.BackColor = System.Drawing.Color.LightBlue;
            this.filmPicture_picturebox.Location = new System.Drawing.Point(396, 19);
            this.filmPicture_picturebox.Name = "filmPicture_picturebox";
            this.filmPicture_picturebox.Size = new System.Drawing.Size(313, 242);
            this.filmPicture_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filmPicture_picturebox.TabIndex = 8;
            this.filmPicture_picturebox.TabStop = false;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FilmsCatalog.UI.Properties.Resources.back3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 367);
            this.Controls.Add(this.savePic_btn);
            this.Controls.Add(this.year_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filmPicture_picturebox);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.title_textbox);
            this.Controls.Add(this.category_combobox);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Карточка фильма";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmPicture_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.ComboBox category_combobox;
        private System.Windows.Forms.TextBox title_textbox;
        private System.Windows.Forms.RichTextBox description_textbox;
        private System.Windows.Forms.PictureBox filmPicture_picturebox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox year_textbox;
        private System.Windows.Forms.Button savePic_btn;
    }
}