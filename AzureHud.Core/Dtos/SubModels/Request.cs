namespace AzureHud.Core.Dtos.SubModels
{
    public class Request
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public RequestedFor RequestedFor { get; set; }
    }
}
