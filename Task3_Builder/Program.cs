SqlQueryBuilder builder = new SqlQueryBuilder();
string query = builder
    .SetTable("Employees")
    .AddColumn("Name")
    .AddColumn("Position")
    .AddWhereCondition("Salary > 50000")
    .SetOrderBy("Name ASC")
    .Build();
Console.WriteLine(query);
