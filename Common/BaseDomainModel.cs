using System.ComponentModel.DataAnnotations;

namespace Civir.Domain.Common
{
    public abstract class BaseDomainModel
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }    
}

