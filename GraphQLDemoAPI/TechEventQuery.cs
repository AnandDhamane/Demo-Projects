using GraphQL;
using GraphQL.Types;
using GraphQLDemoAPI.Repositories;

namespace GraphQLDemoAPI {
    public class TechEventQuery : ObjectGraphType<object> {
        public TechEventQuery(ITechEventRepository repository) {
            Name = "TechEventQuery";

            Field<TechEventInfoType>(
               "event",
               arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "eventId" }),
               resolve: context => repository.GetTechEventById(context.GetArgument<int>("eventId"))
            );

            Field<ListGraphType<TechEventInfoType>>(
             "events",
             resolve: context => repository.GetTechEvents()
          );
        }
    }
}