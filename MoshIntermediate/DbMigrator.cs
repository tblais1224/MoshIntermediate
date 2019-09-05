using System;

namespace MoshIntermediate
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        //this is known as dependency injection
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("migration started at: " + DateTime.Now);

            //details of migrating the database

            _logger.LogInfo("migration finished  at: " + DateTime.Now);
        }
    }
}