using Microsoft.AspNetCore.Mvc;
using OnlineSchool.Domain;
using OnlineSchool.Domain.Factories;
using OnlineSchool.Domain.Interfaces;

namespace OnlineSchool.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TeacherController : ControllerBase
{
    private readonly IList<ITeacher> _teachers;

    public TeacherController()
    {
        _teachers = new List<ITeacher>();

        var babakAbbasi = Factory.CreateTeacher();
        babakAbbasi.Id = 1;
        babakAbbasi.FirstName = "Babak";
        babakAbbasi.FirstName = "Abbasi";
        babakAbbasi.BirthDate = new DateTime(1988, 09, 20);
        babakAbbasi.NationalId = "0084150947";

        _teachers.Add(babakAbbasi);
    }

    [HttpGet]
    public async Task<ITeacher?> FetchTeacherAsync(string nationalId)
    {
        return _teachers.Where<ITeacher>(w => w.NationalId == nationalId).FirstOrDefault();
    }
}
