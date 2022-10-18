using Microsoft.AspNetCore.Mvc;
using OnlineSchool.Domain;

namespace OnlineSchool.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TeacherController : ControllerBase
{
    public TeacherController()
    {
        var x = new OnlineSchool.Domain.Domains.Teacher();
        x.FirstName = "Teacher";
    }

    // [HttpGet]
    // public async Task<Teacher> FetchTeacherAsync(string userName, string password)
    // {
    //     return "true";
    // }
}
