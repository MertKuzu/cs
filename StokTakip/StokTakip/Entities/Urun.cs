using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities
{
    public class Urun
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int KategoriId { get; set; }

        public Kategori Kategori { get; set; }
    }
}
