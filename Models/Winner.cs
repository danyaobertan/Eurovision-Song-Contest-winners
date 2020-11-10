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

        [Display(Name = "Host City")]
        public string HostCity { get; set; }

        [Display(Name = "Winner Country")]
        public string WinnerCountry { get; set; }

        [Display(Name = "Song Title")]
        public string SongTitle { get; set; }

        [Display(Name = "Performer")]
        public string Performer { get; set; }

        [Display(Name = "Language")]
        public string Language { get; set; }

        [Display(Name = "Points")]
        public int Points { get; set; }
    }
}
