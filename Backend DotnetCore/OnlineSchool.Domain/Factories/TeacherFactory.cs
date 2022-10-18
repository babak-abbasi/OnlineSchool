namespace OnlineSchool.Domain.Factories;

using OnlineSchool.Domain.Interfaces;
using OnlineSchool.Domain.Domains;

public class TeacherFactory : Factory
{
    public ITeacher Create()
    {
        return new Teacher();
    }
}