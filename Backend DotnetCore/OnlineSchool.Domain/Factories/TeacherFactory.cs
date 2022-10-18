namespace OnlineSchool.Domain.Factories;

using OnlineSchool.Domain.Interfaces;
using OnlineSchool.Domain.Domains;

public class TeacherFactory
{
    public ITeacher Create()
    {
        return new Teacher();
    }
}