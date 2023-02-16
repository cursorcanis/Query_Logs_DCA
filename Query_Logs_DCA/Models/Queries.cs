using System.ComponentModel.DataAnnotations;

namespace Query_Logs_DCA.Models
{
    public class Queries
    {
        public int Id { get; set; }
        public string? Title_of_Query { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Category_of_Query { get; set; }
        //public decimal Price { get; set; }

    }
}
