using Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class League:IEntity
    {
        
        public int LeagueId { get; set; }
        public string LeagueName { get; set; }
        public int TeamId { get; set; }
    }
}