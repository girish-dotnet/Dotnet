namespace POCOLazyLoadingEx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Department
    {
        
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
