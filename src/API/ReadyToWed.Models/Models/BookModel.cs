using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadyToWed.Models
{
    public class BookModel : Model
    {

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
