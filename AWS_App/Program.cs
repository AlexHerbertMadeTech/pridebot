﻿using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;
using System.Collections.Specialized;
using SlackApp;
using MargieBot;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var slackbot = new Bot();
slackbot.RespondsTo("Hi").With("A nice response");
slackbot.Connect(Configuration.BotApiKey);
  
     SlackClient client = new SlackClient(Configuration.WebhookUrl);  
  
while (Console.ReadLine() != "close") { }

     client.PostMessage(username: "test-rachel",  
                text: "THIS IS A TEST MESSAGE!!",  
                channel: "#general");  