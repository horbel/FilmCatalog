using FilmsCatalog.Model;
namespace FilmsCatalog.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Film_list = new System.Windows.Forms.ListBox();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.sort_btn = new System.Windows.Forms.Button();
            this.sort_combobox = new System.Windows.Forms.ComboBox();
            this.online_btn = new System.Windows.Forms.Button();
            this.upload_lbl = new System.Windows.Forms.Label();
            this.year_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.category_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.infopanel_panel = new System.Windows.Forms.Panel();
            this.description_lbl = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Film_pictbox = new System.Windows.Forms.PictureBox();
            this.cler_btn = new System.Windows.Forms.Button();
            this.AddFiml_bnt = new System.Windows.Forms.Button();
            this.cancelDelete_btn = new System.Windows.Forms.Button();
            this.showAll_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.infopanel_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Film_pictbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Film_list
            // 
            this.Film_list.AllowDrop = true;
            this.Film_list.BackColor = System.Drawing.Color.Chocolate;
            this.Film_list.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Film_list.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Film_list.FormattingEnabled = true;
            this.Film_list.ItemHeight = 22;
            this.Film_list.Location = new System.Drawing.Point(68, 67);
            this.Film_list.Name = "Film_list";
            this.Film_list.Size = new System.Drawing.Size(384, 422);
            this.Film_list.TabIndex = 0;
            this.Film_list.SelectedIndexChanged += new System.EventHandler(this.Film_list_SelectedIndexChanged);
            // 
            // search_textbox
            // 
            this.search_textbox.BackColor = System.Drawing.Color.LightSalmon;
            this.search_textbox.Location = new System.Drawing.Point(163, 14);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(289, 20);
            this.search_textbox.TabIndex = 10;
            this.search_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_textbox_KeyDown);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Chocolate;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_btn.Location = new System.Drawing.Point(68, 15);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(74, 20);
            this.search_btn.TabIndex = 11;
            this.search_btn.Text = "Поиск :";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // sort_btn
            // 
            this.sort_btn.BackColor = System.Drawing.Color.Chocolate;
            this.sort_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sort_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sort_btn.Location = new System.Drawing.Point(476, 15);
            this.sort_btn.Name = "sort_btn";
            this.sort_btn.Size = new System.Drawing.Size(127, 20);
            this.sort_btn.TabIndex = 13;
            this.sort_btn.Text = "Сортировать по ";
            this.sort_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sort_btn.UseVisualStyleBackColor = false;
            this.sort_btn.Click += new System.EventHandler(this.sort_btn_Click);
            // 
            // sort_combobox
            // 
            this.sort_combobox.BackColor = System.Drawing.Color.RosyBrown;
            this.sort_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sort_combobox.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sort_combobox.FormattingEnabled = true;
            this.sort_combobox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sort_combobox.ItemHeight = 14;
            this.sort_combobox.Items.AddRange(new object[] {
            "Названию",
            "Году выпуска",
            "Дате добавления"});
            this.sort_combobox.Location = new System.Drawing.Point(613, 14);
            this.sort_combobox.Name = "sort_combobox";
            this.sort_combobox.Size = new System.Drawing.Size(147, 22);
            this.sort_combobox.TabIndex = 15;
            // 
            // online_btn
            // 
            this.online_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.online_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.online_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.online_btn.Location = new System.Drawing.Point(476, 538);
            this.online_btn.Name = "online_btn";
            this.online_btn.Size = new System.Drawing.Size(283, 32);
            this.online_btn.TabIndex = 25;
            this.online_btn.Text = "Смотреть онлайн!";
            this.online_btn.UseVisualStyleBackColor = false;
            this.online_btn.Click += new System.EventHandler(this.online_btn_Click);
            // 
            // upload_lbl
            // 
            this.upload_lbl.BackColor = System.Drawing.Color.Transparent;
            this.upload_lbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upload_lbl.Location = new System.Drawing.Point(70, 190);
            this.upload_lbl.Name = "upload_lbl";
            this.upload_lbl.Size = new System.Drawing.Size(203, 13);
            this.upload_lbl.TabIndex = 9;
            this.upload_lbl.Text = "upload";
            // 
            // year_lbl
            // 
            this.year_lbl.BackColor = System.Drawing.Color.Transparent;
            this.year_lbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_lbl.Location = new System.Drawing.Point(133, 30);
            this.year_lbl.Name = "year_lbl";
            this.year_lbl.Size = new System.Drawing.Size(108, 25);
            this.year_lbl.TabIndex = 8;
            this.year_lbl.Text = "year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Год выпуска :";
            // 
            // category_lbl
            // 
            this.category_lbl.BackColor = System.Drawing.Color.Transparent;
            this.category_lbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.category_lbl.Location = new System.Drawing.Point(116, 2);
            this.category_lbl.Name = "category_lbl";
            this.category_lbl.Size = new System.Drawing.Size(153, 28);
            this.category_lbl.TabIndex = 5;
            this.category_lbl.Text = "category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Содержание :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Категория :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Обновлён :";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(-3, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 1);
            this.label6.TabIndex = 28;
            this.label6.Text = "label5";
            // 
            // infopanel_panel
            // 
            this.infopanel_panel.BackColor = System.Drawing.Color.Sienna;
            this.infopanel_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infopanel_panel.Controls.Add(this.description_lbl);
            this.infopanel_panel.Controls.Add(this.label6);
            this.infopanel_panel.Controls.Add(this.label1);
            this.infopanel_panel.Controls.Add(this.upload_lbl);
            this.infopanel_panel.Controls.Add(this.year_lbl);
            this.infopanel_panel.Controls.Add(this.label4);
            this.infopanel_panel.Controls.Add(this.label2);
            this.infopanel_panel.Controls.Add(this.category_lbl);
            this.infopanel_panel.Controls.Add(this.label3);
            this.infopanel_panel.Location = new System.Drawing.Point(477, 304);
            this.infopanel_panel.Name = "infopanel_panel";
            this.infopanel_panel.Size = new System.Drawing.Size(283, 205);
            this.infopanel_panel.TabIndex = 21;
            // 
            // description_lbl
            // 
            this.description_lbl.BackColor = System.Drawing.Color.Sienna;
            this.description_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description_lbl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.description_lbl.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description_lbl.Location = new System.Drawing.Point(5, 81);
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.ReadOnly = true;
            this.description_lbl.Size = new System.Drawing.Size(273, 104);
            this.description_lbl.TabIndex = 28;
            this.description_lbl.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FilmsCatalog.UI.Properties.Resources.back_film;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Film_pictbox);
            this.panel1.Location = new System.Drawing.Point(477, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 236);
            this.panel1.TabIndex = 27;
            // 
            // Film_pictbox
            // 
            this.Film_pictbox.BackColor = System.Drawing.Color.Transparent;
            this.Film_pictbox.Location = new System.Drawing.Point(60, 3);
            this.Film_pictbox.Name = "Film_pictbox";
            this.Film_pictbox.Size = new System.Drawing.Size(162, 230);
            this.Film_pictbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Film_pictbox.TabIndex = 4;
            this.Film_pictbox.TabStop = false;
            // 
            // cler_btn
            // 
            this.cler_btn.BackColor = System.Drawing.Color.Transparent;
            this.cler_btn.BackgroundImage = global::FilmsCatalog.UI.Properties.Resources.database_red1;
            this.cler_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cler_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cler_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cler_btn.Location = new System.Drawing.Point(420, 538);
            this.cler_btn.Name = "cler_btn";
            this.cler_btn.Size = new System.Drawing.Size(32, 32);
            this.cler_btn.TabIndex = 23;
            this.cler_btn.UseVisualStyleBackColor = false;
            this.cler_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // AddFiml_bnt
            // 
            this.AddFiml_bnt.BackColor = System.Drawing.Color.Transparent;
            this.AddFiml_bnt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFiml_bnt.BackgroundImage")));
            this.AddFiml_bnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddFiml_bnt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddFiml_bnt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddFiml_bnt.Location = new System.Drawing.Point(68, 538);
            this.AddFiml_bnt.Name = "AddFiml_bnt";
            this.AddFiml_bnt.Size = new System.Drawing.Size(32, 32);
            this.AddFiml_bnt.TabIndex = 1;
            this.AddFiml_bnt.UseVisualStyleBackColor = false;
            this.AddFiml_bnt.Click += new System.EventHandler(this.AddFiml_bnt_Click);
            this.AddFiml_bnt.MouseEnter += new System.EventHandler(this.AddFiml_bnt_MouseEnter);
            // 
            // cancelDelete_btn
            // 
            this.cancelDelete_btn.BackColor = System.Drawing.Color.Transparent;
            this.cancelDelete_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelDelete_btn.BackgroundImage")));
            this.cancelDelete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelDelete_btn.Enabled = false;
            this.cancelDelete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelDelete_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelDelete_btn.Location = new System.Drawing.Point(308, 538);
            this.cancelDelete_btn.Name = "cancelDelete_btn";
            this.cancelDelete_btn.Size = new System.Drawing.Size(32, 32);
            this.cancelDelete_btn.TabIndex = 22;
            this.cancelDelete_btn.UseVisualStyleBackColor = false;
            this.cancelDelete_btn.Click += new System.EventHandler(this.cancelDelete_btn_Click);
            // 
            // showAll_btn
            // 
            this.showAll_btn.BackColor = System.Drawing.Color.Transparent;
            this.showAll_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showAll_btn.BackgroundImage")));
            this.showAll_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showAll_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showAll_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showAll_btn.Location = new System.Drawing.Point(188, 538);
            this.showAll_btn.Name = "showAll_btn";
            this.showAll_btn.Size = new System.Drawing.Size(32, 32);
            this.showAll_btn.TabIndex = 17;
            this.showAll_btn.UseVisualStyleBackColor = false;
            this.showAll_btn.Click += new System.EventHandler(this.showAll_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Transparent;
            this.delete_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete_btn.BackgroundImage")));
            this.delete_btn.Enabled = false;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_btn.Location = new System.Drawing.Point(248, 538);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(32, 32);
            this.delete_btn.TabIndex = 14;
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Transparent;
            this.edit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit_btn.BackgroundImage")));
            this.edit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit_btn.Enabled = false;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_btn.Location = new System.Drawing.Point(128, 538);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(32, 32);
            this.edit_btn.TabIndex = 3;
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.EnabledChanged += new System.EventHandler(this.edit_btn_EnabledChanged);
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::FilmsCatalog.UI.Properties.Resources.back_panel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cler_btn);
            this.Controls.Add(this.AddFiml_bnt);
            this.Controls.Add(this.cancelDelete_btn);
            this.Controls.Add(this.showAll_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.online_btn);
            this.Controls.Add(this.infopanel_panel);
            this.Controls.Add(this.sort_combobox);
            this.Controls.Add(this.sort_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.Film_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог фильмов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.infopanel_panel.ResumeLayout(false);
            this.infopanel_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Film_pictbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Film_list;
        private System.Windows.Forms.Button AddFiml_bnt;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button sort_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.ComboBox sort_combobox;
        private System.Windows.Forms.Button showAll_btn;
        private System.Windows.Forms.Button cancelDelete_btn;
        private System.Windows.Forms.Button cler_btn;
        private System.Windows.Forms.Button online_btn;
        private System.Windows.Forms.PictureBox Film_pictbox;
        private System.Windows.Forms.Label upload_lbl;
        private System.Windows.Forms.Label year_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label category_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel infopanel_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox description_lbl;
    }
}

