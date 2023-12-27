namespace Project.Domain.Models;
using Project.Domain.Primitives;

public class Venue(
    string? name,
    string? address,
    string? city,
    string? state,
    string? country,
    string? postalCode,
    string? phoneNumber,
    string? website) : Entity
{
    public string? Name { get; set; } = name;
    public string? Address { get; set; } = address;
    public string? City { get; set; } = city;
    public string? State { get; set; } = state;
    public string? Country { get; set; } = country;
    public string? PostalCode { get; set; } = postalCode;
    public string? PhoneNumber { get; set; } = phoneNumber;
    public string? Website { get; set; } = website;
}