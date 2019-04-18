namespace POCOLazyLoadingEx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        public int? Salary { get; set; }

        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
