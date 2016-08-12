using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FocusOnTheFamily.ViewModels
{
    public class EditContentVM
    {
        public Models.Content pageContent { get; set; }
        public List<Models.Product> Products { get; set; }
        public List<Models.Image> Images { get; set; }
    }
}