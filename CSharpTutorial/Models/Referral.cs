using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.Models
{
    public class Referral
    {
        public string ReferralCode { get; set; } = null!;
        public string InviteUrl { get; set; } = null!;
        public int UserId { get; set; }
        public int NumberInvites { get; set; }
    }
}
