using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        Stack<Film> stackForCancelDelete;  //for delete_btn and cancelDelete_btn 

        public MainForm()
        {
            InitializeComponent();
            sort_combobox.SelectedIndex = 0;
            foreach (Control c in infopanel_panel.Controls)
            {
                c.Visible = false;
            }

            repository = new BinaryFilmRepository();
            stackForCancelDelete = new Stack<Film>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshCurrentList(repository.Films);
        }

        //формирует лист по заданной коллекции 
        public void RefreshCurrentList(IEnumerable<Film> filmParam)
        {
            Film_list.Items.Clear();
            foreach (Film f in filmParam)
            {
                Film_list.Items.Add(f.Title);
            }
            edit_btn.Enabled = false;
            delete_btn.Enabled = false;
            //Film_list.SelectedItem = null;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            repository.SerializeFilm();
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

                if(selectedFilm.PictureLocation != null)
                    Film_pictbox.ImageLocation = selectedFilm.PictureLocation;
                else
                    Film_pictbox.ImageLocation = Application.StartupPath + "\\pictures\\default";
                category_lbl.Text = selectedFilm.Category;
                year_lbl.Text = selectedFilm.Year.ToString();
                description_lbl.Text = selectedFilm.Description;
                upload_lbl.Text = selectedFilm.UploadDate.ToString(new CultureInfo("en-GB"));
            }
        }

        private void edit_btn_EnabledChanged(object sender, EventArgs e)
        {
            foreach (Control c in infopanel_panel.Controls)
            {
                c.Visible = !c.Visible;
            }
        }

        #region Button_Click_Events

        private void AddFiml_bnt_Click(object sender, EventArgs e)
        {

            Film newFilm = new Film();
            repository.AddFilm(newFilm);
            editForm = new EditForm(ref newFilm);
            DialogResult dr = editForm.ShowDialog();
            if (dr != DialogResult.OK)
                repository.RemoveFilm(newFilm.FilmID);
            RefreshCurrentList(repository.Films);
            Film_list.SetSelected(repository.Films.Count() - 1, true);

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
            //Film_list.SelectedItem = index;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            var selectedFilm = repository.Films
                .Where(f => f.Title == Film_list.SelectedItem.ToString())
                .Select(f => f).FirstOrDefault();

            stackForCancelDelete.Push(selectedFilm);
            repository.RemoveFilm(selectedFilm.FilmID);
            RefreshCurrentList(repository.Films);
            cancelDelete_btn.Enabled = true;

        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {
            RefreshCurrentList(repository.Films);
            Film_list.SelectedIndex = 0;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить все фильмы?",
                "Предупреждение", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                repository.RemoveAll();
                RefreshCurrentList(repository.Films);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {

            //
            //использовать regex
            //
            string tempString = search_textbox.Text;

            Regex regex = new Regex(tempString, RegexOptions.IgnoreCase |
                                                RegexOptions.IgnorePatternWhitespace |
                                                RegexOptions.Compiled);
            //var neededFilm = repository.Films
            //    .Where(f => f.Title == search_textbox.Text.ToString())
            //    .FirstOrDefault();
            List<Film> pointFilms = new List<Film>();

            foreach (Film film in repository.Films)
            {
                if (regex.IsMatch(film.Title))
                {
                    pointFilms.Add(film);
                }
            }

            if (pointFilms.Count != 0)
                RefreshCurrentList(pointFilms);

        }

        private void cancelDelete_btn_Click(object sender, EventArgs e)
        {

            repository.AddFilm(stackForCancelDelete.Pop());
            RefreshCurrentList(repository.Films);
            Film_list.SetSelected(Film_list.Items.Count - 1, true);

            if (stackForCancelDelete.Count == 0)
                (sender as Button).Enabled = false;
        }

        bool descending = false;
        private void sort_btn_Click(object sender, EventArgs e)
        {
            descending = !descending;

            switch (sort_combobox.SelectedIndex)
            {

                case 0: //by title

                    //List<string> tempFilms = new List<string>();
                    //List<string> tempFilms2 = new List<string>();
                    //foreach (string item in Film_list.Items)
                    //    tempFilms.Add(item.ToString());
                    //IEnumerable<string> sortedFimls =  tempFilms.OrderBy(s => s);
                    //Film_list.Items.Clear();
                    //Film_list.Items.AddRange(sortedFimls.ToArray<object>());
                    //break;

                    repository.SortByTitle(descending);
                    RefreshCurrentList(repository.Films);
                    break;
                case 1:
                    repository.SortByYear(descending);
                    RefreshCurrentList(repository.Films);
                    break;
                case 2:
                    repository.SortByUpload(descending);
                    RefreshCurrentList(repository.Films);
                    break;
            }
            
        }


        #endregion


    }
}
