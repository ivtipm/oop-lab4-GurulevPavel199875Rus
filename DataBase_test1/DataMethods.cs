using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace DataBase_test1
{
    public class DataMethods
    {
        // массив из строк с данными о фильмах
        public ArrayList FilmFile { get; } = new ArrayList();

        // Добавить новую строку в файл
        public void AddRow(FilmRow filmRow)
        {
            FilmFile.Add(filmRow);
        }

        // Удалить определённую строку из массива
        public void DeleteRow(int number)
        {
            FilmFile.RemoveAt(number);
        }

        // Удалить все строки из массива
        public void DeleteAllRows()
        {
            FilmFile.Clear();
        }

        // Изменить название фильма
        public void EditFilmTitle(string title, int index)
        {
            FilmRow film = (FilmRow)FilmFile[index];
            film.FilmTitle = title;
        }

        // Изменить жанр фильма
        public void EditFilmGenre(string genre, int index)
        {
            FilmRow film = (FilmRow)FilmFile[index];
            film.FilmGenre = genre;
        }

        // Изменить режисёра фильма
        public void EditFilmDirector(string director, int index)
        {
            FilmRow film = (FilmRow)FilmFile[index];
            film.FilmDirector = director;
        }

        // Изменить страну фильма
        public void EditFilmCountry(string country, int index)
        {
            FilmRow film = (FilmRow)FilmFile[index];
            film.FilmCountry = country;
        }

        // Изменить язык фильма
        public void EditFilmLanguage(string language, int index)
        {
            FilmRow film = (FilmRow)FilmFile[index];
            film.FilmLanguage = language;
        }

        // Изменить год фильма
        public void EditYearRelease(ushort year, int index)
        {
            FilmRow film = (FilmRow)FilmFile[index];
            if ((year < 1895) || (year > (DateTime.Now.Year) + 10))
            {
                throw new Exception("Год премьеры должен быть не раньше 1895 и не позднее " + (DateTime.Now.Year) + 10);
            }
            film.YearRelease = year;
        }

        // Сохранить массив в файл
        public void SaveToFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.Unicode))
            {
                foreach (FilmRow s in FilmFile)
                {
                    sw.WriteLine(s.ToString());
                }
            }
        }

        // Загрузить массив из файла
        public void OpenFile(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new Exception("Файл не существует");
            }
                
            if (FilmFile.Count != 0)
            {
                DeleteAllRows();
            }
                
            using (StreamReader sw = new StreamReader(filename))
            {
                while (!sw.EndOfStream)
                {
                    string str = sw.ReadLine();
                    string[] dataFromFile = str.Split(new String[] { "|" }, StringSplitOptions.RemoveEmptyEntries);

                    ushort id = (ushort)Convert.ToInt32(dataFromFile[0]);
                    string title = dataFromFile[1];
                    string genre = dataFromFile[2];
                    string director = dataFromFile[3];
                    ushort year = (ushort)Convert.ToInt32(dataFromFile[4]);
                    string country = dataFromFile[5];
                    string language = dataFromFile[6];

                    FilmRow filmRow = new FilmRow(id, title, genre, director, year, country, language);
                    AddRow(filmRow);
                }
            }
        }

        // Поиск совпадений по базе, и получение ID всех найденных записей        
        // Возвращает -1, если совпадений не найдено
        public List<int> SearchRows(string query)
        {
            List<int> count = new List<int>();

            //Проверяются ID и год премьеры
            if (ushort.TryParse(query, out ushort num_query))
            {
                for (int i = 0; i < FilmFile.Count; i++)
                {
                    FilmRow filmRow = (FilmRow)FilmFile[i];

                    if (filmRow.FilmID == num_query)
                    {
                        count.Add(i);
                        break; // Если нашли запись по уникальному ID, то закончить поиск
                    }
                    else 
                    {
                        if (filmRow.YearRelease == num_query)
                        {
                            count.Add(i);
                        }                            
                    }
                }

                if (count.Count == 0)
                {
                    count.Add(-1);
                }
                return count;
            }

            // Поиск по текстовым полям записи
            query = query.ToLower(); // перевод в нижний регистр
            query = query.Replace(" ", "");

            for (int i = 0; i < FilmFile.Count; i++)
            {
                FilmRow filmRow = (FilmRow)FilmFile[i];

                if (filmRow.FilmTitle.ToLower().Replace(" ", "").Contains(query))
                {
                    count.Add(i);
                }

                else
                if (filmRow.FilmGenre.ToLower().Replace(" ", "").Contains(query))
                {
                    count.Add(i);
                }

                else
                if (filmRow.FilmDirector.ToLower().Replace(" ", "").Contains(query))
                {
                    count.Add(i);
                }

                else
                if (filmRow.FilmCountry.ToLower().Replace(" ", "").Contains(query))
                {
                    count.Add(i);
                }

                else
                if (filmRow.FilmLanguage.ToLower().Replace(" ", "").Contains(query))
                {
                    count.Add(i);
                }
            }

            if (count.Count == 0)
            {
                count.Add(-1);
            }
            return count;
        }

        // Сортировка по году премьеры
        public void Sort(SortDirection direction)
        {
            FilmFile.Sort(new YearComparer(direction));
        }
    }

    // Сортировка по возрастанию/убыванию
    public enum SortDirection
    {
        Ascending, // возрастание
        Descending // убывание
    }

    public class YearComparer : IComparer
    {
        private SortDirection m_direction = SortDirection.Ascending;

        public YearComparer() : base() { }

        public YearComparer(SortDirection direction)
        {
            m_direction = direction;
        }

        int IComparer.Compare(object x, object y)
        {
            FilmRow filmRow1 = (FilmRow)x;
            FilmRow filmRow2 = (FilmRow)y;

            return (m_direction == SortDirection.Ascending) ? 
                filmRow1.YearRelease.CompareTo(filmRow2.YearRelease) :
                filmRow2.YearRelease.CompareTo(filmRow1.YearRelease);
        }
    }
}
