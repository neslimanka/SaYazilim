using Entities.Abstract;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Bakiye_Banka:IEntity
    {
        public int Id { get; set; }
        public int BankaId { get; set; }
        public string ParaBirimi { get; set; }
        public int Bakiye { get; set; }
    }

}
