namespace PTFourthLabWork
{
    public partial class Form1 : Form
    {
        List<Book> booksList = new List<Book>();
        public Form1()
        {
            InitializeComponent();

            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.booksList.Clear();

            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.booksList.Add(Dictionary.Generate());
                        break;
                    case 1:
                        this.booksList.Add(RecipeBook.Generate());
                        break;
                    case 2:
                        this.booksList.Add(Biography.Generate());
                        break;
                }
            }

            ShowInfo();
        }

        private void ShowInfo()
        {
            int dictionariesCount = 0;
            int recipeBooksCount = 0;
            int biographiesCount = 0;

            txtQueue.Text = "Очередь:\n";

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
                
                txtQueue.Text += book.GetInfo() + "\n";
            }

            txtInfo.Text = "Словари\tРецепты \tБиографии";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t\t{1}\t\t{2}", dictionariesCount, recipeBooksCount, biographiesCount);

            
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.booksList.Count == 0)
            {
                txtOut.Text = "Пусто! Выросла капуста!";
                return;
            }

            var book = this.booksList[0];
            this.booksList.RemoveAt(0);

            txtOut.Text = book.GetInfo();

            ShowInfo();
        }
    }
}
