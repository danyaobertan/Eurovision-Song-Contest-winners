using System;
using System.ComponentModel.DataAnnotations;


namespace EUMusic.Models
{
    public class Winner
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string HostCity { get; set; }

        public string WinnerCountry { get; set; }

        public string SongTitle { get; set; }

        public string Performer { get; set; }

        public string Language { get; set; }

        public int Points { get; set; }
    }
}
