# Getting Started with C# in VS Code

## Install

1. If you haven't already done so, [install VS Code](https://code.visualstudio.com).
2. Next, install [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit) from the Visual Studio Marketplace.
3. Install [.NET SDK](https://dotnet.microsoft.com/en-us/download)

## Create a console app

The Terminal opens with the command prompt in the `Leetcode` folder.

```csharp
dotnet new console --framework net8.0 --use-program-main
dotnet run
```

## Create a unit test project

```csharp
dotnet new mstest -o LeetcodeTest
dotnet new nunit -o LeetcodeTest
dotnet new xunit -o LeetcodeTest
dotnet sln add ./LeetcodeTest/LeetcodeTest.csproj
dotnet add ./LeetcodeTest/LeetcodeTest.csproj reference ./Leetcode/Leetcode.csproj
dotnet test
```

Reference
- [C# in VS Code](https://code.visualstudio.com/docs/csharp/introvideos-csharp)
- [Tutorial: Create a .NET console application using Visual Studio Code](https://learn.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code)
- [Tutorial: Test a .NET class library using Visual Studio Code](https://learn.microsoft.com/en-us/dotnet/core/tutorials/testing-library-with-visual-studio-code)
- [Unit testing C# in .NET using dotnet test and xUnit](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test)
- [Unit testing C# with NUnit and .NET Core](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit)
- [Unit testing C# with MSTest and .NET](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest)