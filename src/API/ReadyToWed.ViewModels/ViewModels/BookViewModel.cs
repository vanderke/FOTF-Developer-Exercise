using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadyToWed.ViewModels
{
    public class BookViewModel : ViewModel
    {

        public BookViewModel(Models.BookModel book)
        {
            if (book == null)
            {
                throw new ArgumentNullException("book");
            }
            this.Book = book;
        }

        public Models.BookModel Book { get; }

    }
}
