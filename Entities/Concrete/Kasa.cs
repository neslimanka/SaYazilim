using Entities.Abstract;

namespace Entities
{
    public class Kasa:IEntity
    {
        public int Id { get; set; }
        public int KasaKodu { get; set; }
        public int KasaAdi { get; set; }
    }

}
