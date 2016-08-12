using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FocusOnTheFamily.ViewModels
{
    public class EditProductVM
    {
        public Models.Product product { get; set; }
        public List<Models.Image> images { get; set; }
    }
}