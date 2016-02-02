using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmsCatalog.Model.Entities;
using FilmsCatalog.Model.Repository;


namespace FilmsCatalog.UI
{
    public partial class EditForm : Form
    {
        private Film filmForEdit;
        public EditForm(ref Film filmParam)
        {
            filmForEdit = filmParam;
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            title_textbox.Text = filmForEdit.Title;
            year_textbox.Text = filmForEdit.Year.ToString();
            description_textbox.Text = filmForEdit.Description;
            category_combobox.Text = filmForEdit.Category;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (title_textbox.Text == "" ||
                new Regex(@"^\s+$").IsMatch(title_textbox.Text))
            {
                MessageBox.Show("Название фильма не может быть пустым", "Ошибка");
            }
            else
            {
                filmForEdit.Title = title_textbox.Text;
                filmForEdit.Year = year_textbox.Text.ToString();
                filmForEdit.Description = description_textbox.Text;
                filmForEdit.Category = category_combobox.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }    
                   
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
