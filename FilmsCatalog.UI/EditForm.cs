using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filmForEdit.Title = title_textbox.Text;
            filmForEdit.Year = int.Parse(year_textbox.Text);
            filmForEdit.Description = description_textbox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
                
        }
    }
}
