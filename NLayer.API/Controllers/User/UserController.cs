using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Service.Services.User;

namespace NLayer.API.Controllers.User
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
        {
            var getUserByIdModel = await this._userService.GetByIdAsync(id, cancellationToken);
            var userModelToView = _mapper.Map<UserModel, UserViewModel>(getUserByIdModel);
            return Ok(userModelToView);
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var getUsersModel = await this._userService.GetAll(cancellationToken);
            var userModelToView = _mapper.Map<List<UserModel>, List<UserViewModel>>(getUsersModel);
            return Ok(userModelToView);
        }
    }
}
