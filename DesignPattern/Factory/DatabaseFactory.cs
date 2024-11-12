﻿namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType dbType)
        {
            return dbType switch
            {
                DatabaseType.SqlServer => new SqlServerDatabase(),
                DatabaseType.Oracle => new OracleDatabase(),
                _ => throw new ArgumentException("Invalid database type")
            };
        }
    }
}