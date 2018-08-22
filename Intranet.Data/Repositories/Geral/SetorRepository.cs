using System;
using System.Data.Entity;
using Intranet.Data.Context;
using Intranet.Domain.Entities.Geral;

namespace Intranet.Data.Repositories.Geral
{
    public class SetorRepository : RepositoryBase<Setor>
    {
        private readonly GeralContext _context;

        public SetorRepository(GeralContext context) : base(context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            _context = context;
        }
    }
}