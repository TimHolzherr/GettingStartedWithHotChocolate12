using System.Threading.Tasks;
using HotChocolate.Execution;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Test;

public class MutationTest   
{
    [Fact]
    public async Task AddAuthor_PerformMutation_NoError()
    {
        // Arrange
        var query = @"mutation addAuthor {
                          addAuthor(input: { name: ""Schiller""}) {
                            record {
                              id
                              name
                            }
                            error
                          }
                        }";

        IReadOnlyQueryRequest request = QueryRequestBuilder.New()
            .SetQuery(query)
            .Create();

        var graphQlServer = new ServiceCollection()
            .AddSingleton<Repository>()
            .AddGraphQLServer()
            .AddQueryType<Query>()
            .AddMutationType<Mutation>();

        // Act
        var response = await graphQlServer.ExecuteRequestAsync(request);

        // Assert
        Assert.Null(response.Errors);
    }
}