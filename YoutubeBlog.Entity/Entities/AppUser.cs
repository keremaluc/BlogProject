using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeBlog.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public IList<string> Role;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid ImageId { get; set; } = Guid.Parse("AED4065C-FFAB-4B86-8837-3858281A850F");
        public Image Image { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
