using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourDay.DAL.Dtos
{
    public class HistoryDto
    {
        public int Id { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime DateTime { get; set; }

        [MaxLength(4000)]
        public string Comment { get; set; }

        public OrderDto? Order { get; set; }
    }
}