using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopNetCore.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }
        [Display(Name="Имя")]
        [StringLength(25)]
        [Required(ErrorMessage ="Длина имени не менее 5 символов")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина Фамилия не менее 5 символов")]
        public string Surname { get; set; }

        [Display(Name = "Адрес")]
        [DataType(DataType.PostalCode)]
        [StringLength(50)]
        [Required(ErrorMessage = "Длина Адрес не менее 5 символов")]
        public string Adress { get; set; }

        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина Номер телефона не менее 10 символов")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина Email не менее 15 символов")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        [BindNever]
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
