using HackathonBackend.Data;
using HackathonBackend.Models;
using HackathonBackend.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace HackathonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private readonly UserInfoRepository _repository;

        public UserInfoController(UserInfoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserInfo>>> GetAll()
        {
            var userInfos = await _repository.GetAll();
            return Ok(userInfos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserInfo>> GetById(int id)
        {
            var userInfo = await _repository.GetById(id);
            if (userInfo == null)
            {
                return NotFound();
            }
            return Ok(userInfo);
        }

        [HttpPost]
        public async Task<ActionResult<UserInfo>> Create(UserInfo userInfo)
        {
            var createdUserInfo = await _repository.Create(userInfo);
            return CreatedAtAction(nameof(GetById), new { id = createdUserInfo.Id }, createdUserInfo);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserInfo>> Update(int id, UserInfo userInfo)
        {
            if (id != userInfo.Id)
            {
                return BadRequest();
            }

            var updatedUserInfo = await _repository.Update(id, userInfo);
            if (updatedUserInfo == null)
            {
                return NotFound();
            }
            return Ok(updatedUserInfo);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var userInfo = await _repository.GetById(id);
            if (userInfo == null)
            {
                return NotFound();
            }

            await _repository.Delete(id);
            return NoContent();
        }

        [HttpGet("latest24hours")]
        public async Task<ActionResult<IEnumerable<UserInfo>>> GetLatest24Hours()
        {
            var userInfos = await _repository.GetLatest24Hours();
            return Ok(userInfos);
        }

        [HttpGet("hours")]
        public async Task<ActionResult<IEnumerable<IGrouping<DateTime, UserInfo>>>> GetUserInfosByHour()
        {
            var groupedByHour = await _repository.GetUserInfosByHour();
            return Ok(groupedByHour);
        }

        [HttpGet("days")]
        public async Task<ActionResult<IEnumerable<IGrouping<DateTime, UserInfo>>>> GetUserInfosByDay()
        {
            var groupedByDay = await _repository.GetUserInfosByDay();
            return Ok(groupedByDay);
        }

        [HttpGet("weeks")]
        public async Task<ActionResult<IEnumerable<IGrouping<int, UserInfo>>>> GetUserInfosByWeek()
        {
            var groupedByWeek = await _repository.GetUserInfosByWeek();
            return Ok(groupedByWeek);
        }
    }
}
