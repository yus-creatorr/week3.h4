    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"[+] Китоб илова шуд: {book.Title}");
        }

        public void RemoveBook(string title)
        {
            int removedCount = books.RemoveAll(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            
            if (removedCount > 0)
            {
                Console.WriteLine($"[-] Китоб бо унвони \"{title}\" хориҷ карда шуд.");
            }
            else
            {
                Console.WriteLine($"[!] Китоб бо унвони \"{title}\" ёфт нашуд.");
            }
        }

        public List<Book> SearchBookByAuthor(string author)
        {
            return books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public List<Book> SearchBookByYear(int year)
        {
            return books.Where(b => b.Year > year).ToList();
        }
        public List<Book> SearchBookByGenre(string genre)
        {
            return books.Where(b => b.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public int GetBoolCount()
        {
            return books.Count;
        }
    }