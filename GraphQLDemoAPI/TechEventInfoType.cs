﻿using GraphQL.Types;
using GraphQLDemoAPI.Infrastructure.DBContext;
using GraphQLDemoAPI.Repositories;

namespace GraphQLDemoAPI {
    public class TechEventInfoType : ObjectGraphType<TechEventInfo> {
        public TechEventInfoType(ITechEventRepository repository) {
            Field(x => x.EventId).Description("Event id.");
            Field(x => x.EventName).Description("Event name.");
            Field(x => x.Speaker).Description("Speaker name.");
            Field(x => x.EventDate).Description("Event date.");

            Field<ListGraphType<ParticipantType>>(
              "participants",
              arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "eventId" }),
              resolve: context => repository.GetParticipantInfoByEventId(context.Source.EventId)
           );
        }
    }
}