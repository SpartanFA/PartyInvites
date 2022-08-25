using System.ComponentModel.DataAnnotations;

namespace PartyInvites2.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your age")]

        public string Age { get; set; }

        [Required(ErrorMessage = "Please enter your arrival time")]
        public string ArrivalTime { get; set; }

        [Required(ErrorMessage = "Please specify whether you require parking assitance")]

        public bool? WillAttend { get; set; }
    }
}
