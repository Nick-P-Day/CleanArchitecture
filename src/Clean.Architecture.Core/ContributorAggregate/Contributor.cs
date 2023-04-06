using Ardalis.GuardClauses;
using Clean.Architecture.SharedKernel;
using Clean.Architecture.SharedKernel.Interfaces;

namespace Clean.Architecture.Core.ContributorAggregate;

public class Contributor : EntityBase, IAggregateRoot
{
    public Contributor(string name)
    {
        Name = Guard.Against.NullOrEmpty(name, nameof(name));
    }

    public string Name { get; private set; }

    public void UpdateName(string newName)
    {
        Name = Guard.Against.NullOrEmpty(newName, nameof(newName));
    }
}
