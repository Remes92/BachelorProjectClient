using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachelorProjectClient.Requests.GraphQLRequests
{
    public class GraphQlBodyQuerys
    {
        public static GraphQLQuery CreateGraphQLBodyTestCase1()
        {
            return new GraphQLQuery
            {
                Query = "{tests{id,persons {name}}}"
            };
        }
    }
}
