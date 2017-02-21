using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadyToWed.Models
{
    public class BookModel : Model
    {

        public string Title { get; set; }
        public string Description { get; set; }

        private IList<BookPointModel> points;
        public IList<BookPointModel> Points
        {
            get
            {
                if (this.points == null)
                {
                    this.points = new List<BookPointModel>();
                }
                return this.points;
            }
        }

    }
}
