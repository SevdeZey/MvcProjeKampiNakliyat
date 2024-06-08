using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Employee
    {

        [Key]
        public int EmpID { get; set; } //Emp=Employee'nin kısaltması

        [StringLength(50)]
        public string EmpName { get; set; }

        [StringLength(50)]
        public string EmpSurname { get; set; }

        [StringLength(100)]
        public string EmpEmail { get; set; }

        [StringLength(20)]
        public string EmpPassword { get; set; }

        //public string EmpRole { get; set; }

        [StringLength(100)]
        public string EmpImage { get; set; }


        [StringLength(15)]
        public string EmpPhone { get; set; }

        [StringLength(200)]
        public string EmpAddress { get; set; }







        public ICollection<BusinessArea> BusinessAreas { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }






        //public int EmpDetailsID { get; set; }
        //public virtual EmpDetails EmDetails { get; set; } //biri em"p", biri em. farkı fark et

        //public ICollection<Vehicle> Vehicles { get; set; }
    }
}
