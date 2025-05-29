using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System;

namespace WebBanHang.Models
{
    public class KhachHang : IdentityUser
    {
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
       
    }
}
