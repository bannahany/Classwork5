using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classwork5.Models
{

    [PrimaryKey ("ItemId", "UserId")]
    public class Cart

    {
        [ForeignKey("ItemId")]
        public int ItemId { get; set; }

        public Item Item { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }

        public IdentityUser  User { get; set; }

        public int Qty { get; set; }
    }
}
