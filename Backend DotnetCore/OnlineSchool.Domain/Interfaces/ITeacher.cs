using System.ComponentModel.DataAnnotations;

namespace   OnlineSchool.Domain.Interfaces;

public interface ITeacher
{
    public long Id {get;set;}
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public DateTime BirthDate {get;set;}
    [StringLengthAttribute(10, ErrorMessage = "طول کد ملی باید 10 رقم باشد.")]
    public string NationalId {get;set;}
}