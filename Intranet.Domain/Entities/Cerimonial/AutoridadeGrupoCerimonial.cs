namespace Intranet.Domain.Entities.Cerimonial
{
    public class AutoridadeGrupoCerimonial
    {
        public AutoridadeGrupoCerimonial()
        {
            Autoridade = new Autoridade();
            GrupoCerimonial = new GrupoCerimonial();
        }

        public int IdAutoridade { get; set; }
        public Autoridade Autoridade { get; set; }

        public int IdGrupoCerimonial { get; set; }
        public GrupoCerimonial GrupoCerimonial { get; set; }
    }
}
