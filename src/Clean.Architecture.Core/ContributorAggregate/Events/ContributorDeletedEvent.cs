using Clean.Architecture.SharedKernel;

namespace Clean.Architecture.Core.ContributorAggregate.Events;

public class ContributorDeletedEvent : DomainEventBase
{
    public ContributorDeletedEvent(int contributorId)
    {
        ContributorId = contributorId;
    }

    public int ContributorId { get; set; }
}
