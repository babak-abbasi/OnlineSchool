namespace OnlineSchool.Domain.Factories;

using OnlineSchool.Domain.Domains;
using OnlineSchool.Domain.Interfaces;

public static class Factory
{
    public static ITeacher CreateTeacher()
    {
        return new Teacher();
    }

    public static ITeacher CreateTeacher(string firstName, string lastName, DateTime birthDate, string nationalId)
    {
        return new Teacher()
        {
            FirstName = firstName,
            LastName = lastName,
            BirthDate = birthDate,
            NationalId = nationalId,
        };
    }

    public static IStudent CreateStudent()
    {
        return new Student();
    }

    public static IStudent CreateStudent(string firstName, string lastName, DateTime birthDate, string nationalId)
    {
        return new Student()
        {
            FirstName = firstName,
            LastName = lastName,
            BirthDate = birthDate,
            NationalId = nationalId,
        };
    }
}