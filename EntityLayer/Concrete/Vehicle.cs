using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Vehicle
    {
        [Key]
        public int VehicleID { get; set; }

        [StringLength(30)]
        public string VehicleModel { get; set; }

        [Range(1900, 2050)]
        public int VehicleYear { get; set; }

        [StringLength(100)]
        public string VehicleImage { get; set; }




        public int BA_ID { get; set; }
        public virtual BusinessArea BusinessArea { get; set; }


        public int? EmpID { get; set; } //nullable type anlamına gelen ? koyduk
        public virtual Employee Employee { get; set; }







        //public int EmpID { get; set; }
        //public virtual Employee Employee { get; set; }
    }

}
