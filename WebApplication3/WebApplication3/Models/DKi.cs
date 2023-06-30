using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class DKi
    {
        [Required(ErrorMessage ="Không được để trống")]
        [EmailAddress(ErrorMessage ="Địa chỉ email không hợp lệ")]
        public string email { get; set; }
    }
}