using Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entity.Concrete
{
    public class Question:IEntity
    {
        public int QuestionId { get; set; }
        public string Email { get; set; }
        public string Soru { get; set; }
        public string Cevap { get; set; }
    }
}


