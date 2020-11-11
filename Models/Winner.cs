using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EUMusic.Models
{
    public class Winner
    {
        public int ID { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Display(Name = "Host City")]
        public string HostCity { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Display(Name = "Winner Country")]
        public string WinnerCountry { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Display(Name = "Song Title")]
        public string SongTitle { get; set; }

        [StringLength(120, MinimumLength = 1)]
        [Display(Name = "Performer")]
        public string Performer { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), StringLength(30)]
        [Display(Name = "Language")]
        public string Language { get; set; }

        [Range(0, 1000)]
        [Display(Name = "Points")]
        public int Points { get; set; }
    }
}
