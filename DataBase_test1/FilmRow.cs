using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_test1
{
    public class FilmRow
    {
        public FilmRow(
            ushort filmID, 
            string filmTitle, 
            string filmGenre, 
            string filmDirector, 
            ushort yearRelease, 
            string filmCountry, 
            string filmLanguage)
        {
            if ((filmTitle == "") ||(filmGenre == "") ||(filmDirector == "") ||(filmCountry == "") ||(filmLanguage == ""))
            {
                throw new Exception("Проверьте, всё ли вы заполнили. Все поля должны быть заполнены");                
            }
            FilmTitle = filmTitle;
            FilmGenre = filmGenre;
            FilmDirector = filmDirector;
            FilmCountry = filmCountry;
            FilmLanguage = filmLanguage;

            if ((yearRelease < 1895) || (yearRelease > (DateTime.Now.Year+10)))
            {
                throw new Exception("Год премьеры должен быть не раньше 1895 и не позднее 2030");
            }

            YearRelease = yearRelease;
            FilmID = filmID;
        }

        // Свойства для полей
        public string FilmTitle     { get; set; } // | Название фильма
        public string FilmGenre     { get; set; } // | Жанр фильма
        public string FilmDirector  { get; set; } // | Режисёр фильма
        public string FilmCountry   { get; set; } // | Страна фильма
        public string FilmLanguage  { get; set; } // | Язык фильма 
        public ushort YearRelease   { get; set; } // | Год премьеры фильма
        public ushort FilmID        { get; set; } // | ID записи в таблице
        
        public override string ToString()
        {
            return FilmID + " | " + FilmTitle + " | " + FilmGenre + " | " + FilmDirector + " | " + YearRelease + " | " + FilmCountry + " | " + FilmLanguage + " | " ;
            //return FilmID + " | " + FilmTitle + " | " + FilmGenre + " | " + FilmDirector + " | " + FilmCountry + " | " + FilmLanguage + " | " + YearRelease + " | ";
        }
    }
}
