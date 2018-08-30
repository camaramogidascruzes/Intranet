using Intranet.Domain.Entities.Geral;
using Microsoft.AspNet.Identity;

namespace Intranet.Infra.Identity
{
    public class IdentityRole : Grupo, IRole<int>
    {
        public string Name
        {
            get { return this.Nome; }
            set { this.Nome = value; }
        }
    }
}