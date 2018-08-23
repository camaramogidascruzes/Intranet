using System.ComponentModel.DataAnnotations;
using Intranet.Domain.Entities.Geral;

namespace Intranet.Domain.ViewModels.Geral
{
    public class SetorViewModel : BasicViewModel
    {
        public SetorViewModel()
        {
            Id = 0;
        }

        public Setor ToSetor()
        {
            return new Setor()
            {
                Id = this.Id,
                Nome = this.Nome

            };
        }

        public Setor UpdateSetor(Setor setor)
        {
            setor.Nome = this.Nome;
            return setor;
        }

        [Required]
        public string Nome { get; set; }

        public static SetorViewModel SetorToViewModel(Setor setor)
        {
            return new SetorViewModel()
            {
                Id = setor.Id,
                Nome = setor.Nome
            };
        }
    }
}