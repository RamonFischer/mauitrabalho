using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Curso.Configurations
{
    internal class appConfigs
    {
        private static string databaseName = "database.db";
        private static string databaseDirectory = FileSystem.AppDataDirectory;
        public static string databasePath = Path.Combine(databaseDirectory, databaseName);
    }
}
