
namespace SimpleImageDetector.Models
{
    public class Label
    {
        public string Name { get; set; }
        public float Confidence { get; set; }
    }

    public class ImageUploadViewModel
    {
        public string ImageBase64 { get; set; } 
        public IFormFile ImageFile { get; set; }
        public List<Label> Labels { get; set; }        
    }
}
