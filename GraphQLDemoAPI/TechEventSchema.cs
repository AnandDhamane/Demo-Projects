using System.Web.Http.Dependencies;
//using System.Web.Mvc;
using GraphQL.Types;

namespace GraphQLDemoAPI {
    public class TechEventSchema : Schema {
        public TechEventSchema(IDependencyResolver resolver) {
            Query = resolver.Resolve<TechEventQuery>();
            DependencyResolver = resolver;
        }

    }
}