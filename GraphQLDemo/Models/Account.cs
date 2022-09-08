using GraphQLDemo.Enums;
using System.ComponentModel.DataAnnotations;

namespace GraphQLDemo.Models
{
    public class Account
    {
        public int Id { get; set; }
        public TypeOfAccount Type { get; set; }
        [Required]
        public int OwnerId { get; init; }
    }
}
