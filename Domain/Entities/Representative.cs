
using TrueRepApis.Domain.ValueObjects;

namespace TrueRepApis.Domain.Entities;

public sealed class Representative(
    Id id,
    FirstName firstName,
    LastName lastName,
    Age age,
    Gender gender,
    PartyName partyName,
    DateOfBirth dateOfBirth,
    ImageUrl? imageUrl,
    MaritalStatus maritalStatus,
    Qualification qualification,
    Profession profession,
    State state,
    Constituency constituency)
{
    public Id Id { get; } = id ?? throw new ArgumentNullException(nameof(id));
    public FirstName FirstName { get; } = firstName ?? throw new ArgumentNullException(nameof(firstName));
    public LastName LastName { get; } = lastName ?? throw new ArgumentNullException(nameof(lastName));
    public Age Age { get; } = age ?? throw new ArgumentNullException(nameof(age));
    public Gender Gender { get; } = gender ?? throw new ArgumentNullException(nameof(gender));
    public PartyName PartyName { get; } = partyName ?? throw new ArgumentNullException(nameof(partyName));
    public DateOfBirth DateOfBirth { get; } = dateOfBirth ?? throw new ArgumentNullException(nameof(dateOfBirth));
    public ImageUrl? ImageUrl { get; } = imageUrl; // Optional field
    public MaritalStatus MaritalStatus { get; } = maritalStatus ?? throw new ArgumentNullException(nameof(maritalStatus));
    public Qualification Qualification { get; } = qualification ?? throw new ArgumentNullException(nameof(qualification));
    public Profession Profession { get; } = profession ?? throw new ArgumentNullException(nameof(profession));
    public State State { get; } = state ?? throw new ArgumentNullException(nameof(state));
    public Constituency Constituency { get; } = constituency ?? throw new ArgumentNullException(nameof(constituency));

    public string FullName => $"{FirstName} {LastName}";
    public int CurrentAge => Age.Value;
}