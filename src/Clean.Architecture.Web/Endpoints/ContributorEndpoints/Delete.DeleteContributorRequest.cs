namespace Clean.Architecture.Web.Endpoints.ContributorEndpoints;

public class DeleteContributorRequest
{
    public const string Route = "/Contributors/{ContributorId:int}";
    public int ContributorId { get; set; }

    public static string BuildRoute(int contributorId)
    {
        return Route.Replace("{ContributorId:int}", contributorId.ToString());
    }
}
