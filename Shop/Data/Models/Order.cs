using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]

        public int id { get; set; }

        [Display(Name = "Введіть ім'я")]
        [MinLength(5)]
        [Required(ErrorMessage ="Обов'язкове поле для заповнення")]
        
        public string name { get; set; }

        [Display(Name = "Прізвище")]
        [MinLength(5)]
        [Required(ErrorMessage = "Обов'язкове поле для заповнення")]
        public string surname { get; set; }

        [Display(Name = "Адреса")]
        [Required(ErrorMessage = "Обов'язкове поле для заповнення")]

        public string adress { get; set; }

        [Display(Name = "Номер телефона")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Обов'язкове поле для заповнення")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Обов'язкове поле для заповнення")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }



    }
}
