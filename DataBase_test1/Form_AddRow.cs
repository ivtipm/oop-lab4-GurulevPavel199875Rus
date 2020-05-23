using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_test1
{
    public partial class Form_AddRow : Form
    {
        public Form_AddRow()
        {
            InitializeComponent();
        }

        private void Form_AddRow_Load(object sender, EventArgs e)
        {
         
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm MF = new MainForm();
                this.Owner = MF;

                MF.FilmTitle = textBox_Title.Text;
                MF.FilmGenre = comboBox_Genre.Text;
                MF.FilmDirector = textBox_Director.Text;
                MF.FilmCountry = textBox_Country.Text;
                MF.FilmLanguage = textBox_Language.Text;
                MF.YearRelease = textBox_Year.Text;

                FilmRow film = new FilmRow(
                    (ushort)Convert.ToInt32(textBox_ID.Text),
                    textBox_Title.Text,
                    comboBox_Genre.Text,
                    textBox_Director.Text,
                    (ushort)Convert.ToInt32(textBox_Year.Text),
                    textBox_Country.Text,
                    textBox_Language.Text);

                MF.data.AddRow(film);
                int n = MF.data.FilmFile.Count;

                FilmRow film1 = (FilmRow)MF.data.FilmFile[n - 1];
                MF.dataGrid.Rows.Add(film1.FilmID,
                    textBox_Title.Text,
                    comboBox_Genre.Text,
                    textBox_Director.Text,
                    textBox_Year.Text,
                    textBox_Country.Text,
                    textBox_Language.Text);
                MF.BanChangeColumn(n - 1);
                if ((!MF.timer1.Enabled) && (MF.filename != ""))
                {
                    MF.timer1.Enabled = true;
                    MF.timer1.Start();
                }

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
