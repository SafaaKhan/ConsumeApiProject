using ComsumeApiProject_DataAccess.Services.IServices;
using ComsumeApiProject_Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ConsumeApiProject.Controllers
{
    public class ActivityController : Controller
    {
        private readonly IActivityService _activityService;
        private readonly IAccountService _accountService;

        public ActivityController(IActivityService activityService, IAccountService accountService)
        {
            _activityService = activityService;
            _accountService = accountService;
        }

        private async Task<string> Login()
        {
            LoginDto loginDto = new LoginDto()
            {
                Email= "Bob@hotmail.com",
                Password= "Test@12test"
            };

            var res=await _accountService.LoginAsync<ResponseDto>(loginDto);
            if (res != null && res.IsSeccuss)
            {
                var userDto= JsonConvert.DeserializeObject<UserDto>(Convert.ToString(res.Value));
                return userDto.Token;
            }
            return null;
        }

        public async Task<IActionResult> ActivityIndex()
        {
            var accessToken = await Login();
            List<ActivityDto> activityDtos= new List<ActivityDto>();
            var response = await _activityService.GetActivitesAsync<ResponseDto>(accessToken);
            if (response != null && response.IsSeccuss)
            {
                activityDtos=JsonConvert.DeserializeObject<List<ActivityDto>>(Convert.ToString(response.Value));
            }

            return View(activityDtos);
        }

        public async Task<IActionResult> GetActivityById(string id)
        {
            var accessToken = await Login();
            ActivityDto activityDto= new ActivityDto();
            var response = await _activityService.GetActivityByIdAsync<ResponseDto>(id, accessToken);
            if (response != null && response.IsSeccuss)
            {
                activityDto = JsonConvert.DeserializeObject<ActivityDto>(Convert.ToString(response.Value));
            }

            return View(activityDto);
        }

        [HttpGet]
        public IActionResult CreateActivity()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateActivity(PostActivityDto postActivityDto)
        {
            if (ModelState.IsValid)
            {
                var accessToken = await Login();

                PostActivityDto activityDto = new PostActivityDto();
                var response = await _activityService.CreateActivityAsync<ResponseDto>(postActivityDto, accessToken);
                if (response != null && response.IsSeccuss)
                {
                    activityDto = JsonConvert.DeserializeObject<PostActivityDto>(Convert.ToString(response.Value));
                }
                return RedirectToAction(nameof(ActivityIndex));
            }
            return View(postActivityDto);
        }
    }
}
