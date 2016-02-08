using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmsCatalog.Model.Entities;
using FilmsCatalog.Model.Repository;
using System.Drawing.Drawing2D;

namespace FilmsCatalog.UI
{
    public partial class EditForm : Form
    {
        private Film filmForEdit;
        public EditForm(ref Film filmParam)
        {
            filmForEdit = filmParam;
            InitializeComponent();
            category_combobox.SelectedIndex = 0;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            title_textbox.Text = filmForEdit.Title;
            year_textbox.Text = filmForEdit.Year.ToString();
            description_textbox.Text = filmForEdit.Description;
            category_combobox.Text = filmForEdit.Category;
            filmPicture_picturebox.ImageLocation = filmForEdit.PictureLocation;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (CheckFieldsValues())
            {
                filmForEdit.Title = title_textbox.Text;
                filmForEdit.Year = year_textbox.Text.ToString();
                filmForEdit.Description = description_textbox.Text;
                filmForEdit.Category = category_combobox.Text;
                filmForEdit.PictureLocation = destin;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
        //защита от дурака
        private bool CheckFieldsValues()
        {
            bool flag = true;

            if (title_textbox.Text == "" ||
            new Regex(@"^\s+$").IsMatch(title_textbox.Text))
            {
                MessageBox.Show("Название фильма не может быть пустым", "Ошибка");
                flag = false;
            }
            if (!(new Regex(@"^\d{4}$").IsMatch(year_textbox.Text) || (year_textbox.Text == "Не задан")))
            {
                MessageBox.Show("Введён некорректный год выпуска", "Ошибка");
                flag = false;
            }
            return flag;
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        ////функция для копирования картинок в корень проекта
        //private void CopyFile(string sourcefn, string destinfn)
        //{
        //    FileInfo fn = new FileInfo(sourcefn);
        //    fn.CopyTo(destinfn, true);
        //}

        //function for resize pict
        private Image ResizeOrigImg(Image image, int nWidth, int nHeight)
        {
            int newWidth, newHeight;
            var coefH = (double)nHeight / (double)image.Height;
            var coefW = (double)nWidth / (double)image.Width;
            if (coefW >= coefH)
            {
                newHeight = (int)(image.Height * coefH);
                newWidth = (int)(image.Width * coefH);
            }
            else {
                newHeight = (int)(image.Height * coefW);
                newWidth = (int)(image.Width * coefW);
            }

            Image result = new Bitmap(newWidth, newHeight);
            using (var g = Graphics.FromImage(result))
            {
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(image, 0, 0, newWidth, newHeight);
                g.Dispose();
            }
            return result;
        }

        private string destin;
        private void savePic_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Jpg Files|*.jpg|Jpeg Files|*.jpeg|Gif Files|*.gif|Bmp Files|*.bmp|Png Files|*.png";
            if(fileDialog.ShowDialog()==DialogResult.OK)
            {                
                string location = fileDialog.FileName.ToString();
                destin = Application.StartupPath + "\\pictures\\" + filmForEdit.Title + "_pic";
                var newImage = ResizeOrigImg((Image.FromFile(location)), 500, 300);
                newImage.Save(destin);
                //CopyFile(location, destin);
                filmPicture_picturebox.ImageLocation = destin;
                
            }

        }
    }
}
