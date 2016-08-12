using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FocusOnTheFamily.Data.Interfaces;
using FocusOnTheFamily.Models;

namespace FocusOnTheFamily.Data.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private FocusOnTheFamilyEntities _dataContext;

        public ImageRepository()
        {
            _dataContext = new FocusOnTheFamilyEntities();
        }

        public List<Models.Image> GetImages()
        {
            List<Image> images = _dataContext.Images.ToList();
            List<Models.Image> modelImages = new List<Models.Image>();

            foreach(Image img in images)
            {
                modelImages.Add(new Models.Image()
                {
                    ImageID = img.ImageID,
                    ImagePath = img.ImagePath
                });
            }

            return modelImages;
        }
    }
}
