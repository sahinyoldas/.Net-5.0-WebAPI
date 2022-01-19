using Business.Abstract;
using Business.Unitilities;
using Castle.Core.Configuration;
using Entities.DBClasses;
using Entities.DTOClasses;
using Entities.DTOClasses.ReturnResultsEntities;
using Entities.JWT;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;
using Business.Constants;

namespace Business.Concrete
{
    public class AuthServiceManager : IAuthService
    {
        private IUserService _userService;
        public IConfiguration Configuration { get; }

        private TokenOptions _tokenOptions = new TokenOptions();
        public AuthServiceManager(IConfiguration configuration, IUserService userService)
        {
            Configuration = configuration;
            _userService = userService;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();

        }
        public async Task<AccessToken> CreateAccessToken(User user)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim("username", user.Email));
            claims.Add(new Claim("displayname", user.Name));

            claims.Add(new Claim(ClaimTypes.Role, "admin"));

            //foreach (var role in user.UserRoles)
            //{
            //    claims.Add(new Claim(ClaimTypes.Role, role.Role));
            //}

            // create a new token with token helper and add our claim
            // from `Westwind.AspNetCore`  NuGet Package
            var token = JwtHelper.GetJwtToken(
                user.Email,
                _tokenOptions.SecurityKey,
                _tokenOptions.Issuer,
                _tokenOptions.Audience,
                TimeSpan.FromMinutes(_tokenOptions.AccessTokenExpiration),
                claims.ToArray());

            return new AccessToken()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = token.ValidTo
            };
        }

        public async Task<IDataResult<User>> Login(UserLoginDto userLoginDto)
        {
            var user = await _userService.GetUserByEmailAndPassword(userLoginDto);
            if (user == null)
            {
                return new ErrorDataResult<User>(ConstantMessages.UserNotFound);
            }

            return new SuccessDataResult<User>(user, ConstantMessages.LoginSuccessful);
        }

    }
}
