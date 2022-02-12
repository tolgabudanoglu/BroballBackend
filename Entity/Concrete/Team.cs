using Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Team: IEntity
    {

        [Key]public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int Won { get; set; }
        public int Drawn { get; set; }
        public int Lost { get; set; }
        public int Points { get; set; }
        public string oyuncu1 { get; set; }
        public string oyuncu2 { get; set; }
        public string oyuncu3 { get; set; }
        public string oyuncu4 { get; set; }
        public string oyuncu5 { get; set; }
        public string oyuncu6 { get; set; }
        public string oyuncu7 { get; set; }
        public string oyuncu8 { get; set; }
        public string city { get; set; }
        public int LeagueId { get; set; }

    }
}
