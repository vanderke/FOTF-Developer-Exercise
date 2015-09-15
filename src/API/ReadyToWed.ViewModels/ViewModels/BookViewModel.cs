using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadyToWed.ViewModels
{
    public class BookViewModel : ViewModel
    {

        public BookViewModel(int id)
        {
            this.Id = id;
        }

        public int Id { get; }

    }
}
