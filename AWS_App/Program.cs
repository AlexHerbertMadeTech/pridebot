using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;
using System.Collections.Specialized;
using SlackApp;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
  
     SlackClient client = new SlackClient(Configuration.WebhookUrl);  
  
     client.PostMessage(username: "test-rachel",  
                text: "THIS IS A TEST MESSAGE!!",  
                channel: "#general");  