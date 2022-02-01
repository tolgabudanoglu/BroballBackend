using Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class User:IEntity
    {
        [Key] public int UserId { get; set; }
        public string NickName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Password { get; set; }
        public int Score { get; set; }
        public string Team { get; set; }
        public string Job { get; set; }
        public int Asist { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Tel { get; set; }
        public string ReasonforPenalty { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public int TeamId { get; set; }
        public int StarPoint { get; set; }
        public int CitiesId { get; set; }

        public int LeagueId { get; set; }
     

        public int SubscribeId { get; set; }

    }
}