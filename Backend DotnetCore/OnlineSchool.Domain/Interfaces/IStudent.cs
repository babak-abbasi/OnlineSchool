namespace OnlineSchool.Domain.Interfaces;

public interface IStudent
{
    public long Id {get;set;}
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public DateTime BirthDate {get;set;}
    public string NationalId {get;set;}
}