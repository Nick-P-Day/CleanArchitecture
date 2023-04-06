namespace Clean.Architecture.Web.Endpoints.ProjectEndpoints;

public class ListIncompleteResponse
{
    public ListIncompleteResponse(int projectId, List<ToDoItemRecord> incompleteItems)
    {
        ProjectId = projectId;
        IncompleteItems = incompleteItems;
    }

    public List<ToDoItemRecord> IncompleteItems { get; set; }
    public int ProjectId { get; set; }
}
