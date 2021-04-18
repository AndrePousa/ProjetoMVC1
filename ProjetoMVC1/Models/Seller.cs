using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ProjetoMVC1.Models
{
    public class Seller

    {


        public int Id { get; set; }

        [Required(ErrorMessage ="{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Byrth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime  ByrthDate { get; set; }
        [DisplayFormat(DataFormatString ="{0:F2}")]
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Base Salary")]
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();


        public Seller() { } 
            
            
          

      

        public Seller(int id, string name, string email, DateTime byrthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;         
            ByrthDate = byrthDate;
            BaseSalary = baseSalary; 
            Department = department;
        }
        public void AddSales(SalesRecord sr) 
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
