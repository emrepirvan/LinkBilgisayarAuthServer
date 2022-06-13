using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinBilgisayarAuthServer.Core.Models
{
    public class UserRefreshToken
    {
        public string UserId { get; set; }
        public string Code { get; set; } //Refresh Token
        public DateTime Expiration { get; set; }

    }
}
