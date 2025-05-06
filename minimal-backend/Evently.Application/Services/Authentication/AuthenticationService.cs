using Evently.Application.Services.Authentication.Interface;
using Evently.Application.Services.Authentication.ViewModel;
using Evently.Domain.User.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evently.Application.Services.Authentication
{
    public class AuthenticationService(IUserRepository userRepository) : IAuthenticationService
    {
        private readonly IUserRepository _userRepository = userRepository;
        public async Task<AuthenticationResponse> LoginUserAsync(AuthenticationRequest authRequest)
        {
            var user = await _userRepository.GetUserByEmail(authRequest.Email);

            if (user == null)
            {
                return new AuthenticationResponse
                {
                    Success = false,
                    Message = "Usuário não encontrado"
                };
            }

            if (user.Password != authRequest.Password)
            {
                return new AuthenticationResponse
                {
                    Success = false,
                    Message = "Senha incorreta"
                };
            }

            return new AuthenticationResponse
            {
                Success = true,
                Message = "Login realizado com sucesso",
            };
        }
    }
}
