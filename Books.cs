using System;
using System.Collections.Generic;
using System.Text;

namespace PTFourthLabWork
{
    public class Book
    {

    }
    public class Dictionary : Book
    {
        public int pageCount = 250;
        public int wordCount = 1000;
        public string language_pair = "Английский-Русский";
    }

    public class RecipeBook : Book
    {
        public int pageCount = 250;
        public int recipeCount = 200;
        public string cuisine = "Китайская";
    }
    
    public enum BiographiesType {autobiography, memoir, groupBiography, biography};
    public class Biography : Book
    {
        public int pageCount = 400;
        public string person = "Стив Джобс";
        public BiographiesType biographyType = BiographiesType.biography;
    }
}
