using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BusinessArea
    {
        [Key]
        public int BA_ID { get; set; }

        [StringLength(50)]
        public string B_AreaName { get; set; }

        [StringLength(200)]
        public string BA_Description { get; set; }





        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }


        public int EmpID { get; set; }
        public virtual Employee Employee { get; set; }  

    }
}
