using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusOnTheFamily.Domain.Interfaces
{
    public interface IImageProcessor
    {
        List<Models.Image> GetImages();
    }
}
