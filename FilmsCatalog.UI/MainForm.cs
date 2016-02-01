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
            RefreshList(repository.Films);
        }

        //  формирует лист по заданной коллекции 
        public void RefreshList(IEnumerable<Film> filmParam)
        {
            Film_list.Items.Clear();
            foreach(Film f in filmParam)
            {
                Film_list.Items.Add(f.Title);
            }
        }
        private void AddFiml_bnt_Click(object sender, EventArgs e)
        {          
            Film newFilm = new Film();
            repository.AddFilm(newFilm);
            editForm = new EditForm(ref newFilm);
            DialogResult dr = editForm.ShowDialog();
            if (dr != DialogResult.OK)
                repository.RemoveFilm(repository.Films.Count());
            RefreshList(repository.Films);
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
            RefreshList(repository.Films);
            //возвращаем фокус
            Film_list.SelectedIndex = index;
        }

        private void Film_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            edit_btn.Enabled = true;
            
            year_lbl.Text = repository.Films
                .Where(f => f.Title == Film_list.SelectedItem.ToString())
                .FirstOrDefault().Year.ToString();

            description_lbl.Text = repository.Films
                .Where(f => f.Title == Film_list.SelectedItem.ToString())
                .First().Description;
        }

       
    }
}
