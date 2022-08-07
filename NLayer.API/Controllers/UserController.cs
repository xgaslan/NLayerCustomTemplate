using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Service.Services.User;

namespace NLayer.API.Controllers
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

        [HttpPost("create")]
        public async Task<IActionResult> Create(UserCreateViewModel userCreateViewModel,
            CancellationToken cancellationToken)
        {
            var userViewModelToEntity = this._mapper.Map<UserCreateViewModel, Entity.User>(userCreateViewModel);
            var userModel = await this._userService.AddAsync(userViewModelToEntity, cancellationToken);
            var userModelToView = _mapper.Map<UserModel, UserViewModel>(userModel);
            return Ok(userModelToView);
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
            var userModelToView = this._mapper.Map<List<UserModel>, List<UserViewModel>>(getUsersModel);
            return Ok(userModelToView);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            var deleteUser = await this._userService.Delete(id, cancellationToken);
            return Ok(deleteUser);
        }

    }
}
