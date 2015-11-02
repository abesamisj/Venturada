using System;
using System.ComponentModel.DataAnnotations;

namespace Venturada.UI.ViewModels
{
    public class CarouselsViewModels
    {
        [Display(Name = "Carousel Id")]
        public int CarouselId { get; set; }

        [Range(0, 15, ErrorMessage = "Can only be between 0 .. 15")]
        [Required(ErrorMessage = "Please enter your image sequence here")]
        [Display(Name = "Sequence")]
        public int Sequence { get; set; }

        [Required(ErrorMessage = "Please upload your image here")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Image URL must be between 3 and 200 characters!")]
        [Display(Name = "Upload Image here")]
        public string CarouselImageString { get; set; }

        [Display(Name = "Date Created")]
        public DateTime CarouselDateCreated { get; set; }
    }
}