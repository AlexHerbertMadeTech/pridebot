using Newtonsoft.Json; 
//This class serializes into the Json payload required by Slack Incoming WebHooks  
namespace SlackApp {
public class Payload  
{  
    [JsonProperty("channel")]  
    public string Channel { get; set; }  
  
    [JsonProperty("username")]  
    public string Username { get; set; }  
  
    [JsonProperty("text")]  
    public string Text { get; set; }
}
}