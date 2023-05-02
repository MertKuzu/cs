using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities
{
    public class Kategori
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Urun> Urunler { get; set; }
    }
}
