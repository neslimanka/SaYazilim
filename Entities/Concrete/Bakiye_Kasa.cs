using Core.Entities;


namespace Entities
{
    public class Bakiye_Kasa:IEntity
    {
        public int Id { get; set; }
        public int KasaId { get; set; }
        public string ParaBirimi { get; set; }
        public int Bakiye { get; set; }
    }

}
