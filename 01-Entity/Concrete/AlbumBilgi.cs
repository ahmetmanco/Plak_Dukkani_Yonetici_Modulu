using System;
using _01_Entity.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Entity.Abstract;

namespace _01_Entity.Concrete
{
    public class AlbumBilgi:IEntity
    {
        public int Id { get; set; }
        public string AlbumAdi { get; set; }
        public string SanatciveyaGrup { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal Fiyat { get; set; }
        public float? IndirimOrani { get; set; }
        public bool SatisiVarMi { get; set; }      
    }
}


