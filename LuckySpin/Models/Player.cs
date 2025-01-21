using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
namespace LuckySpin.Models
{
    public class Player //DONE: Annotate the Player properties as described in section 3.
    {
        [Required(ErrorMessage = "Please enter your Name")]
        // [StringLength(50, MinimumLength = 5, ErrorMessage = "Please enter your Name")]
        public string FirstName { get; set; }

        [Range(1,9, ErrorMessage = "Choose a number")]
        public int Luck { get; set; }
    }
}