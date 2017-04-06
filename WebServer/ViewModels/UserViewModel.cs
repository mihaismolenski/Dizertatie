using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using DTOs.Attributes;

namespace WebServer.ViewModels
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public IList<UserAttributeDto> UserAttributes;
        public List<SelectListItem> AttributeTypes { get; set; }
        [Display(Name = "Attribute Type")]
        public string NewAttributeType { get; set; }
        [Display(Name = "Attribute Value")]
        [Required]
        public string NewAttributeValue { get; set; }
    }
}