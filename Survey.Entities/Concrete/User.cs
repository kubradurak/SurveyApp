using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Survey.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "Tam isim")]
        [Required(ErrorMessage = "Boş bırakılamaz")]
        public string FullName { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Boş bırakılamaz")]
        public string UserName { get; set; }
        [Display(Name = "Mail adresi")]
        [Required(ErrorMessage = "Boş bırakılamaz")]
        [EmailAddress(ErrorMessage = "Eposta formatınız doğru değil!")]
        public string Email { get; set; }
        [Display(Name = "Parola")]
        [Required(ErrorMessage = "Boş bırakılamaz")]
        public string Password { get; set; }
        [EnumDataType(typeof(Role))]
        public Role Role { get; set; }
        public IList<UserPoll> UserPolls { get; set; }
    }

    public enum Role
    {
        User,
        Admin
    }
}