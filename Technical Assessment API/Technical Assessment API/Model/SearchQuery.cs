namespace Technical_Assessment_API.Model
{
    public class SearchQuery
    {
        public string Id { get; set; } = Guid.NewGuid().ToString()[..9];
        public string SearchParam { get; set; } = default!;
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
