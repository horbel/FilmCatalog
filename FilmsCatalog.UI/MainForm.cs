using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmsCatalog.Model.Repository;
using FilmsCatalog.Model.Entities;

namespace FilmsCatalog.UI
{
    public partial class MainForm : Form
    {
        BinaryFilmRepository repository;
        EditForm editForm;

        public MainForm()
        {
            InitializeComponent();
            repository = new BinaryFilmRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshCurrentList(repository.Films);
        }

        //формирует лист по заданной коллекции 
        public void RefreshCurrentList(IEnumerable<Film> filmParam)
        {
            Film_list.Items.Clear();
            foreach(Film f in filmParam)
            {
                Film_list.Items.Add(f.Title);
            }
            edit_btn.Enabled = false;
            delete_btn.Enabled = false;
            Film_list.SelectedItem = null;
        }
        private void AddFiml_bnt_Click(object sender, EventArgs e)
        {          
            Film newFilm = new Film();
            repository.AddFilm(newFilm);
            editForm = new EditForm(ref newFilm);
            DialogResult dr = editForm.ShowDialog();
            if (dr != DialogResult.OK)
                repository.RemoveFilm(repository.Films.Count());
            RefreshCurrentList(repository.Films);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            repository.SerializeFilm();
        }
        
        private void edit_btn_Click(object sender, EventArgs e)
        {
            //запоминаем индекс выделенного элемента
            int index = Film_list.SelectedIndex;

            var filmForEdit = repository.Films
                .Where(f => f.Title == (string)Film_list.SelectedItem)
                .FirstOrDefault();

            editForm = new EditForm(ref filmForEdit);
            editForm.ShowDialog();
            RefreshCurrentList(repository.Films);
            //возвращаем фокус
            Film_list.SelectedIndex = index;
        }

        private void Film_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film selectedFilm = null;
            if (Film_list.SelectedItem != null)
            {
                edit_btn.Enabled = true;
                delete_btn.Enabled = true;

                selectedFilm = repository.Films
                .Where(f => f.Title == Film_list.SelectedItem.ToString())
                .FirstOrDefault();

                category_lbl.Text = selectedFilm.Category;
                year_lbl.Text = selectedFilm.Year.ToString();
                description_lbl.Text = selectedFilm.Description;
                upload_lbl.Text = selectedFilm.UploadDate.Value.ToShortDateString();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            

            var selectedFilm = repository.Films
                .Where(f => f.Title == Film_list.SelectedItem.ToString())
                .FirstOrDefault();
            repository.RemoveFilm(selectedFilm.FilmID);  

            RefreshCurrentList(repository.Films);

          
        }

        
    }
}
