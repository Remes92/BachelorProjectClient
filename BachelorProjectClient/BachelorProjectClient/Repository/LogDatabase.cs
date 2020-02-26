using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachelorProjectClient.Repository
{
    public class LogDatabase
    {
        public static void insertToLogDb(int clientId, long totalTime, long requestHeaderSize, long? requestContentSize, long responseHeaderSize, long? responseContentSize,int executionNO, int iteration, string dbName, string testCase,string api)
        {
            //TODO: Läggtill insert logik
        }
    }
}
