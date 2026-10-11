using System.Text;

public class SqlQueryBuilder
{
    private readonly SqlQuery _query = new();

    public SqlQueryBuilder SetTable(string table)
    {
        _query.Table = table;
        return this;
    }

    public SqlQueryBuilder AddColumn(string column)
    {
        _query.Columns.Add(column);
        return this;
    }

    public SqlQueryBuilder AddWhereCondition(string condition)
    {
        _query.WhereConditions.Add(condition);
        return this;
    }

    public SqlQueryBuilder SetOrderBy(string orderBy)
    {
        _query.OrderBy = orderBy;
        return this;
    }

    public string Build()
    {
        if (string.IsNullOrWhiteSpace(_query.Table))
            throw new InvalidOperationException("Table is not set.");

        var columns = _query.Columns.Count > 0 ? string.Join(", ", _query.Columns) : "*";
        var sql = new StringBuilder($"SELECT {columns} FROM {_query.Table}");

        if (_query.WhereConditions.Count > 0)
            sql.Append(" WHERE ").Append(string.Join(" AND ", _query.WhereConditions));

        if (!string.IsNullOrWhiteSpace(_query.OrderBy))
            sql.Append(" ORDER BY ").Append(_query.OrderBy);

        return sql.Append(';').ToString();
    }
}
