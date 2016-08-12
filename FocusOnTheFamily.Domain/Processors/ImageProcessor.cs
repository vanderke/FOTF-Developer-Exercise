using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FocusOnTheFamily.Domain.Interfaces;
using FocusOnTheFamily.Data.Interfaces;
using FocusOnTheFamily.Models;

namespace FocusOnTheFamily.Domain.Processors
{
    public class ImageProcessor : IImageProcessor
    {
        private IImageRepository _imageRepository;

        public ImageProcessor(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public List<Models.Image> GetImages()
        {
            return _imageRepository.GetImages();
        }
    }
}
