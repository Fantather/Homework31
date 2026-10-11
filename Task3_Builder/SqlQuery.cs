public class SqlQuery
{
    public string Table { get; set; } = "";
    public List<string> Columns { get; } = new();
    public List<string> WhereConditions { get; } = new();
    public string? OrderBy { get; set; }
}
