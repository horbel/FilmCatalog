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
            this.Film_list = new System.Windows.Forms.ListBox();
            this.AddFiml_bnt = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.Film_pictbox = new System.Windows.Forms.PictureBox();
            this.category_lbl = new System.Windows.Forms.Label();
            this.description_lbl = new System.Windows.Forms.Label();
            this.year_lbl = new System.Windows.Forms.Label();
            this.upload_lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Film_pictbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Film_list
            // 
            this.Film_list.AllowDrop = true;
            this.Film_list.FormattingEnabled = true;
            this.Film_list.Location = new System.Drawing.Point(106, 38);
            this.Film_list.Name = "Film_list";
            this.Film_list.Size = new System.Drawing.Size(425, 472);
            this.Film_list.TabIndex = 0;
            this.Film_list.SelectedIndexChanged += new System.EventHandler(this.Film_list_SelectedIndexChanged);
            // 
            // AddFiml_bnt
            // 
            this.AddFiml_bnt.Location = new System.Drawing.Point(1, 38);
            this.AddFiml_bnt.Name = "AddFiml_bnt";
            this.AddFiml_bnt.Size = new System.Drawing.Size(100, 75);
            this.AddFiml_bnt.TabIndex = 1;
            this.AddFiml_bnt.Text = "Добавить новый фильм";
            this.AddFiml_bnt.UseVisualStyleBackColor = true;
            this.AddFiml_bnt.Click += new System.EventHandler(this.AddFiml_bnt_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Enabled = false;
            this.edit_btn.Location = new System.Drawing.Point(1, 120);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(100, 75);
            this.edit_btn.TabIndex = 3;
            this.edit_btn.Text = "Редактировать";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // Film_pictbox
            // 
            this.Film_pictbox.Location = new System.Drawing.Point(540, 38);
            this.Film_pictbox.Name = "Film_pictbox";
            this.Film_pictbox.Size = new System.Drawing.Size(309, 207);
            this.Film_pictbox.TabIndex = 4;
            this.Film_pictbox.TabStop = false;
            // 
            // category_lbl
            // 
            this.category_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.category_lbl.Location = new System.Drawing.Point(537, 256);
            this.category_lbl.Name = "category_lbl";
            this.category_lbl.Size = new System.Drawing.Size(153, 23);
            this.category_lbl.TabIndex = 5;
            this.category_lbl.Text = "category";
            // 
            // description_lbl
            // 
            this.description_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.description_lbl.Location = new System.Drawing.Point(537, 324);
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.Size = new System.Drawing.Size(290, 150);
            this.description_lbl.TabIndex = 6;
            this.description_lbl.Text = "description";
            // 
            // year_lbl
            // 
            this.year_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.year_lbl.Location = new System.Drawing.Point(537, 293);
            this.year_lbl.Name = "year_lbl";
            this.year_lbl.Size = new System.Drawing.Size(153, 18);
            this.year_lbl.TabIndex = 8;
            this.year_lbl.Text = "year";
            // 
            // upload_lbl
            // 
            this.upload_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.upload_lbl.Location = new System.Drawing.Point(537, 487);
            this.upload_lbl.Name = "upload_lbl";
            this.upload_lbl.Size = new System.Drawing.Size(290, 23);
            this.upload_lbl.TabIndex = 9;
            this.upload_lbl.Text = "upload";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 20);
            this.textBox1.TabIndex = 10;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(426, 10);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(105, 23);
            this.search_btn.TabIndex = 11;
            this.search_btn.Text = "Найти фильм";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сортировать по ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 53);
            this.button2.TabIndex = 14;
            this.button2.Text = "Удалить фильм";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Названию",
            "Году выпуска",
            "Дате добавления"});
            this.comboBox1.Location = new System.Drawing.Point(410, 524);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 557);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.upload_lbl);
            this.Controls.Add(this.year_lbl);
            this.Controls.Add(this.description_lbl);
            this.Controls.Add(this.category_lbl);
            this.Controls.Add(this.Film_pictbox);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.AddFiml_bnt);
            this.Controls.Add(this.Film_list);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Film_pictbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Film_list;
        private System.Windows.Forms.Button AddFiml_bnt;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.PictureBox Film_pictbox;
        private System.Windows.Forms.Label category_lbl;
        private System.Windows.Forms.Label description_lbl;
        private System.Windows.Forms.Label year_lbl;
        private System.Windows.Forms.Label upload_lbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

