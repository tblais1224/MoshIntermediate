namespace MoshIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\Users\\tomal\\Documents\\c#Code\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
