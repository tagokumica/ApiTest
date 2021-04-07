using Application.Interface;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/usuario")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserValidate _iUserValidate;

        public UserController(IUserValidate iUserValidate)
        {
            _iUserValidate = iUserValidate;
        }


        [HttpPost("validar-senha")]
        public ActionResult<bool> Post(UserViewModel userViewModel)
        {

            var validate = _iUserValidate.IsValid(userViewModel.Password);

            return validate;

        }

    }
}
