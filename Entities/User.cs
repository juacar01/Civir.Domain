using Civir.Domain.Common;

namespace Civir.Domain.Entities
{
    public class User: BaseDomainModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}