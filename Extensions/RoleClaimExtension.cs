using DemoLogin.Models;
using System.Security.Claims;

namespace DemoLogin.Extensions
{
    public static class RoleClaimExtension
    {
        public static IEnumerable<Claim> GetClaims(this Usuario usuario)
        {
            var result = new List<Claim>
            {
                new(ClaimTypes.Name, usuario.Email),
                new(ClaimTypes.Role, usuario.Role)
            };

            return result;

        }
    }
}
