using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyValidation.Models
{
    public class Ninja
    {

        private string name;
        private string location;
        private string language;
        private string comment;

        [Required]
        [MinLength(2)]
        public string Name
        {
            get; set;
        }
        [Required]
        public string Location
        {
            get; set;
        }
        [Required]
        public string Language
        {
            get; set;
        }
        [MinLength(20)]
        public string Comment
        {
            get; set;
        }
    }
}
