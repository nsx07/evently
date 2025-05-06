using Evently.Application.Services.Authentication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evently.Application.Services.Authentication.Interface
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponse> LoginUserAsync(AuthenticationRequest authRequest);
    }
}
