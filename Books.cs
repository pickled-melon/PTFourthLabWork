using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PTFourthLabWork
{
    public class Book
    {
        public static Random rnd = new Random();
        public int pageCount = rnd.Next() % 1001;

        public virtual String GetInfo()
        {
            var str = String.Format("Количество страниц: {0}\n", this.pageCount);
            return str;
        }
    }
    public class Dictionary : Book
    {
        public int pageCount;
        public int wordCount;
        public string language_pair;
 
        public override string GetInfo()
        {
            var str = String.Format("Словарь {0}, состоящий из {1} слов.\n", this.language_pair, this.wordCount);
            str += base.GetInfo();

            return str;
        }

        public static Dictionary Generate()
        {
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
        public int pageCount;
        public int recipeCount;
        public string cuisine;

        public override string GetInfo()
        {
            var str = String.Format("Книга про {0} кухню, состоящая из {1} рецептов.\n", this.cuisine, this.recipeCount);
            str += base.GetInfo();

            return str;
        }

        public static RecipeBook Generate()
        {
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
        public int pageCount;
        public string person;
        public BiographiesType biographyType;

        public override string GetInfo()
        {
            var str = String.Format("Биография {0} типа {1}.\n", this.person, this.biographyType);
            str += base.GetInfo();

            return str;
        }

        public static Biography Generate()
        {
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
