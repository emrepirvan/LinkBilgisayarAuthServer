using LinBilgisayarAuthServer.Core.Configuration;
using LinBilgisayarAuthServer.Core.Dtos;
using LinBilgisayarAuthServer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinBilgisayarAuthServer.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userApp);
        ClientTokenDto CreateTokenByClient(Client client);
    }
}
