using System;
using System.ComponentModel.DataAnnotations;

namespace Query_Logs_DCA.Models
{
    public class Query
    {
        public int Id { get; set; }
        public string? Title_of_Query { get; set; } = string.Empty;

        [Display(Name = "Time Query was Released")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Category_of_Query { get; set; } = string.Empty;
        //public decimal Price { get; set; }

        public string? Rating_Complexity { get; set; } = string.Empty;


    }
}

