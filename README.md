Create a database.
Run the sql script (attached) with file name as "SQL Script".
Change the database path in web.config file in solution.
<connectionStrings>
    <add name="EntityModel" connectionString="data source=.\SQLExpress;initial catalog=TestDb;persist security info=True;user id=sa;password=Passwd@12;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />
</connectionStrings>
