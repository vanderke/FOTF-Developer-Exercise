using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FocusOnTheFamily;

namespace FocusOnTheFamily.Data.Interfaces
{
    public interface IImageRepository
    {
        List<Models.Image> GetImages();
    }
}
