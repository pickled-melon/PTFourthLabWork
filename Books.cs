using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PTFourthLabWork
{
    public class Book
    {
        public int pageCount = 1000;
        public virtual String GetInfo()
        {
            var str = String.Format("Количество страниц: {0}\N", this.pageCount);
            return str;
        }
    }
    public class Dictionary : Book
    {
        public int pageCount = 250;
        public int wordCount = 1000;
        public string language_pair = "Английский-Русский";
 

        public override string GetInfo()
        {
            var str = String.Format("Словарь {0}, состоящий из {1} слов.", this.language_pair, this.wordCount);
            str += base.GetInfo();

            return str;
        }

        public static Dictionary Generate()
        {
            var rnd = new Random();
            string[] languagePairs = { "Английский-Русский", "Немецкий-Русский", "Китайский-Русский" };

            return new Dictionary
            {
                pageCount = rnd.Next() % 1001,
                wordCount = 500 + rnd.Next() % 500,
                language_pair = languagePairs[rnd.Next() % languagePairs.Length],
            };
        }
    }

    public class RecipeBook : Book
    {
        public int pageCount = 250;
        public int recipeCount = 200;
        public string cuisine = "Китайская";

        public override string GetInfo()
        {
            var str = String.Format("Книга про {0} кухню, состоящая из {1} рецептов.", this.cuisine, this.recipeCount);
            str += base.GetInfo();

            return str;
        }

        public static RecipeBook Generate()
        {
            var rnd = new Random();
            string[] cuisines = { "Русская", "Немецкая", "Китайская" };

            return new RecipeBook
            {
                pageCount = rnd.Next() % 1001,
                recipeCount = 100 + rnd.Next() % 500,
                cuisine = cuisines[rnd.Next() % cuisines.Length],
            };
        }
    }
    
    public enum BiographiesType {autobiography, memoir, groupBiography, biography};
    public class Biography : Book
    {
        public int pageCount = 400;
        public string person = "Стив Джобс";
        public BiographiesType biographyType = BiographiesType.biography;

        public override string GetInfo()
        {
            var str = String.Format("Биография {0} типа {1}.", this.person, this.biographyType);
            str += base.GetInfo();

            return str;
        }

        public static Biography Generate()
        {
            var rnd = new Random();
            string[] persons = { "Стив Джобс", "Стив Возняк", "Эдвард Сноуден", "Линус Торвальдс" };
            BiographiesType[] values = (BiographiesType[])Enum.GetValues(typeof(BiographiesType));

            return new Biography
            {
                pageCount = rnd.Next() % 1001,
                person = persons[rnd.Next() % persons.Length],
                biographyType = values[rnd.Next() % values.Length]
            };
        }
    }
}
