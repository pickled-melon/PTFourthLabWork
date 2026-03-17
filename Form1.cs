namespace PTFourthLabWork
{
    public partial class Form1 : Form
    {
        List<Book> booksList = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.booksList.Clear();
            for (int i = 0; i < 10; i++)
            {
                this.booksList.Add(new Biography());
            }

            ShowInfo();
        }

        private void ShowInfo()
        {
            int dictionariesCount = 0;
            int recipeBooksCount = 0;
            int biographiesCount = 0;

            foreach (var book in this.booksList)
            {
                if (book is Dictionary)
                {
                    dictionariesCount += 1;
                }
                else if (book is RecipeBook)
                {
                    recipeBooksCount += 1;
                }
                else if (book is Biography)
                {
                    biographiesCount += 1;
                }
            }

            txtInfo.Text = "Словари\tРецепты \tБиографии";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t\t{1}\t\t{2}", dictionariesCount, recipeBooksCount, biographiesCount);
        }
    }
}
