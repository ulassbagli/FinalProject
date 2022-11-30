using Core.Entities.Concrete;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user, SigningCredentials signingCredentials, List<OperationClaim> operationClaims);
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
