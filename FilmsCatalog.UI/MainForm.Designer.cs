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
            this.delete_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.showAll_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Film_pictbox)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.category_lbl.Location = new System.Drawing.Point(118, 9);
            this.category_lbl.Name = "category_lbl";
            this.category_lbl.Size = new System.Drawing.Size(153, 21);
            this.category_lbl.TabIndex = 5;
            this.category_lbl.Text = "category";
            // 
            // description_lbl
            // 
            this.description_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.description_lbl.Location = new System.Drawing.Point(3, 93);
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.Size = new System.Drawing.Size(300, 127);
            this.description_lbl.TabIndex = 6;
            this.description_lbl.Text = "description";
            // 
            // year_lbl
            // 
            this.year_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.year_lbl.Location = new System.Drawing.Point(118, 40);
            this.year_lbl.Name = "year_lbl";
            this.year_lbl.Size = new System.Drawing.Size(153, 18);
            this.year_lbl.TabIndex = 8;
            this.year_lbl.Text = "year";
            // 
            // upload_lbl
            // 
            this.upload_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.upload_lbl.Location = new System.Drawing.Point(118, 225);
            this.upload_lbl.Name = "upload_lbl";
            this.upload_lbl.Size = new System.Drawing.Size(107, 23);
            this.upload_lbl.TabIndex = 9;
            this.upload_lbl.Text = "upload";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 10;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(353, 10);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(74, 23);
            this.search_btn.TabIndex = 11;
            this.search_btn.Text = "Найти";
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
            // delete_btn
            // 
            this.delete_btn.Enabled = false;
            this.delete_btn.Location = new System.Drawing.Point(1, 213);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(99, 53);
            this.delete_btn.TabIndex = 14;
            this.delete_btn.Text = "Удалить фильм";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(433, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Расширенный";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // showAll_btn
            // 
            this.showAll_btn.Location = new System.Drawing.Point(106, 524);
            this.showAll_btn.Name = "showAll_btn";
            this.showAll_btn.Size = new System.Drawing.Size(182, 26);
            this.showAll_btn.TabIndex = 17;
            this.showAll_btn.Text = "Показать все";
            this.showAll_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Категория :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Год выпуска :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Содержание :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.category_lbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.year_lbl);
            this.panel1.Controls.Add(this.description_lbl);
            this.panel1.Controls.Add(this.upload_lbl);
            this.panel1.Location = new System.Drawing.Point(543, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 251);
            this.panel1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Обновлён :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.showAll_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Film_pictbox);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.AddFiml_bnt);
            this.Controls.Add(this.Film_list);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Film_pictbox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button showAll_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}

