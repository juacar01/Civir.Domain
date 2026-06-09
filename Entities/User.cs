using Microsoft.EntityFrameworkCore;
using Civir.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Civir.Domain.Entities
{
    [Table("Users")]
    [Index(nameof(Email), IsUnique = true)] 
    public class User: BaseDomainModel
    {
        [Required]
        [Column("nombre", TypeName = "varchar(250)")]
        public string Nombre { get; set; } = string.Empty;
        
        [Required]
        [Column("apellidos", TypeName = "varchar(250)")]
        public string Apellidos { get; set; } = string.Empty;
        
        [Required]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        [Column("email", TypeName = "varchar(250)")]
        public string Email { get; set; } = string.Empty;
        public string? PasswordHash { get; set; }

        public string? Provider { get; set; }
        public string? ProviderUserId { get; set; }
        public string? Avatar { get; set; }
 

        
    }
}