using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komposititon_und_Klassen
{
    public class DataMigrator
    {
        // create instance of Logger class
        Logger logger = new Logger();

        // Migrate method using "Log" method from Logger class
        public void Migrate()
        {
            logger.Log("Migrating...");
        }
    }
}
