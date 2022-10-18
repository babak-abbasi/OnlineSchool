namespace OnlineSchool.Domain.Domains;

using OnlineSchool.Domain.Interfaces;

internal class Teacher: ITeacher
{
    public long Id {get;set;}
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public DateTime BirthDate {get;set;}
    public string NationalId {get;set;}
    public byte Age {get;set;}
}