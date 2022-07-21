using CSharpTutorial.Data;
using CSharpTutorial.Models;

namespace CSharpTutorial.Core
{
    public class UserService
    {
        public string Register(User user)
        {
            if(user == null) 
            { 
                throw new ArgumentNullException("You did not submit the correct credentials.");
            }

            var code = Guid.NewGuid().ToString();

            //WRT-4UT-64W

            var referral = new Referral()
            {
                ReferralCode = code,
                InviteUrl = $"https://www.abosede.com/register?referral={code}",
                UserId = user.Id,
                NumberInvites = 0
            };

            DataStore.Users.Add(user);
            DataStore.Referrals.Add(referral);

            return $"Congratulations {user.FullName}. \n Your Registration is now Complete! Please invite your friends with this link {referral.InviteUrl}";
        }
    }
}
