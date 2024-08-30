using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using Microsoft.AspNetCore.Mvc;
using SimpleImageDetector.Models;

namespace SimpleImageDetector.Controllers
{
    public class ImageController : Controller
    {
        private readonly IAmazonRekognition _amazonRekognition;

        public ImageController(IAmazonRekognition amazonRekognition)
        {
            _amazonRekognition = amazonRekognition;
        }

        [HttpPost]
        public async Task<IActionResult> UploadImage(ImageUploadViewModel model)
        {
            if (model.ImageFile != null && model.ImageBase64 != null && model.ImageFile.Length > 0)
            {
                var imageBytes = Convert.FromBase64String(model.ImageBase64);

                var detectLabelsRequest = new DetectLabelsRequest
                {
                    Image = new Image
                    {
                        Bytes = new MemoryStream(imageBytes)
                    },
                    MaxLabels = 10,
                    MinConfidence = 75F
                };

                var detectLabelsResponse = await _amazonRekognition.DetectLabelsAsync(detectLabelsRequest);

                model.Labels = detectLabelsResponse.Labels
                    .Select(label => new Models.Label
                    {
                        Name = label.Name,
                        Confidence = label.Confidence
                    })
                    .ToList();
            }
                        
            return PartialView("_ImageAndLabelsPartial", model);
        }        
    }
}
