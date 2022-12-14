using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k.backend.core.Auth.Jwt.Abstact
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, string userName, string userRole);

        bool IsTokenValid(string key, string issuer, string token);
    }
}