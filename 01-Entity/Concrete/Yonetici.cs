using System;
using _01_Entity.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Entity.Abstract;

namespace _01_Entity.Concrete
{
    public class Yonetici : IEntity
    {
        public int Id { get; set; }
        public string YoneticiAdi { get; set; }
        public string YoneticiSoyadi { get; set; }
        public string EMail { get; set; }
        public string Sifre { get; set; }
    }
}
