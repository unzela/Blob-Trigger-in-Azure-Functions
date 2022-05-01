using ImageResizeFunction.Services;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;
using System.IO;

namespace ImageResizeFunction
{
    class ImageResizer : IImageResizer
    {
        public void Resize(Stream input, Stream output)
        {
            using (Image image = Image.Load(input))
            {
                image.Mutate(x => x.Resize(image.Width / 2, image.Height / 2));
                image.Save(output, new JpegEncoder());
            }
        }
    }
}
