using eAppointmentServer.WebAPI.Abstractions; //İsimlerde hata var ??
using eAppointmentServer.Application.Features.Auth.Login; //İsimlerde hata var ??
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace E_AppointmentServer.WebAPI.Controllers
{
    [AllowAnonymous]

    [Route("api/[controller]/[action]")]
    [ApiController]
    public sealed class AuthController : ApiController
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
    }
}
