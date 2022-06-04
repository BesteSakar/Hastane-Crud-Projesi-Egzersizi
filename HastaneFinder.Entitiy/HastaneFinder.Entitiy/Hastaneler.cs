using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.Entitiy
{
    public class Hastaneler
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(30)]
        public string Isım { get; set; }

        [StringLength(30)]
        public string Sehir { get; set; }
        public  int yatakSayısı { get; set; }

        [StringLength(30)]
        public string kurucusu { get; set; }
    }
}
