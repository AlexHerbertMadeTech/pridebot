namespace My.MySampleModule.HelloSlack;

using LambdaSharp;
using LambdaSharp.Slack;

public sealed class Function : ALambdaSlackCommandFunction {

    //--- Methods ---
    public override async Task InitializeAsync(LambdaConfig config) {

        // TO-DO: add function initialization and reading configuration settings
    }

    protected override async Task ProcessSlackRequestAsync(SlackRequest request) {

        // TO-DO: add business logic

        Console.WriteLine("Hello world!");
    }
}
