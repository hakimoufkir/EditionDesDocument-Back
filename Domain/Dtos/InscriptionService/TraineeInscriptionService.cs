﻿

using Domain.Enums;
using static Domain.Enums.ResponsStutusHandler;

namespace Domain.Dtos.Service1;

public class TraineeInscriptionService
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Nationality { get; set; }
    public string? UniqueIdentifier { get; set; }
    public DateTime? Birthdate { get; set; }
    public Gender? Gender { get; set; }
    public string? Birthplace { get; set; }
    public string? City { get; set; }
    public string? Address { get; set; }
    public string? PostalCode { get; set; }
    public string? Email { get; set; }
    public string? GSM { get; set; }
    public SchoolLevel? SchoolLevel { get; set; }
    public bool? Passerelle { get; set; }
    public Status? Status { get; set; }
    public string? MotherFirstName { get; set; }
    public string? MotherLastName { get; set; }
    public string? MotherGSM { get; set; }
    public string? MotherEmail { get; set; }
    public string? FatherFirstName { get; set; }
    public string? FatherLastName { get; set; }
    public string? FatherGSM { get; set; }
    public string? FatherEmail { get; set; }
    public string? ParentsAddress { get; set; }
    public string? FatherJob { get; set; }
    public bool? Baccalaureate { get; set; }
    public DateTime? BacYear { get; set; }
    public string? HighSchoolName { get; set; }
    public string? HighSchoolCity { get; set; }
    public string? HighSchoolCountry { get; set; }
    public Enums.Type? HighSchoolType { get; set; }
    public UniversityType? UniversityDegreeType { get; set; }
    public string? UniversityName { get; set; }
    public Enums.Type? UniversityType { get; set; }
    public string? UniversityCity { get; set; }
    public string? UniversityCountry { get; set; }
    public string? StudiesCompleted { get; set; }
    public int? NumberOfYearsOfStudy { get; set; }
    public string? DiscoveryOriginOfTheSchool { get; set; }
    public string? BirthCertificates { get; set; }
    public string? ScholarCertificates { get; set; }
    public string? Picture { get; set; }
    public string? CIN { get; set; }
    public DateTime? RegistrationDate { get; set; }
    public StatusInscription? RegistrationStatus { get; set; }
    public bool? IsWaitingList { get; set; }
    public Guid? IdFiliere { get; set; }
    public Guid? IdGroup { get; set; }
    public string? FieldJSON { get; set; }
    public AnneeScolaire? AnneeScolaire { get; set; }
}