# Pridebot

## Prerequisites

Make sure you have installed all of the following prerequisites on your development machine:
* [.NET](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.300-macos-x64-installer).
* [VS Code](https://code.visualstudio.com/download).
* C# Intellisense Package - install from VS code extensions.
* [LambdaSharp.Tool](https://github.com/LambdaSharp/LambdaSharpTool) - install running `dotnet tool install -g LambdaSharp.Tool`, read what it says and run the command it gives you to add the tool to your `PATH` varible.
* AWS account.

## Work in progress
1. Run `lash init --quick-start` to initialise your [LambdaSharp setup](https://lambdasharp.net/articles/Setup.html).
2. Run `lash new module MySampleModule`.
3. Run `lash new function MyFunction --type generic`.
4. Run `lash deploy`.

## Running
Run `dotnet run` in the VS Code terminal.

## Known issues

### Installing .NET on Mac
1. Download `.Net 6 sdk (Mac, x64)` from [this link](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.300-macos-x64-installer).
2. This should install a console app called dotnet to `usr/local/share/dotnet/x64` to see this folder in finder, use Cmd+shift+period
3. You should be able to double-click on this, and it should return output, but do nothing else.
4. Once that’s installed, in a terminal you will need to change user to an admin user using `su -l 'your-admin-username'` - this will ask you for a password.
5. Go to the root folder and then run dotnet using the following: `usr/local/share/dotnet/x64/dotnet --version` to confirm that it's installed corectly.
6. Run `ln -s /usr/local/share/dotnet/x64/dotnet /usr/local/bin/` to build a shortcut for you in that local user bin folder, which is (usually) in your `$PATH` variable, so you can invoke with just dotnet.
7. Switch back to your user using `su -l 'your-username'`.
8. You should be able to invoke dotnet.
9. Create a new folder `mkdir test`.
10. Run `dotnet new console` in the folder. This will build a basic console project that you should be able to compile and run in VS code with `dotnet build` then `dotnet run` in the VS Code terminal.
11. Delete the folder after the test.