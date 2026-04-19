# C# Fundamentals

## Learn resources

- [Tour of Csharp]
-

## Dotnet

- In VSCode, you can use .NET Install Tool extension to install a new dotnet version
- After installing a new dotnet version, ensure you run this command to update workloads (think feature packs for specialized development like maui, aspire, wasm-tools etc)

```shell
sudo dotnet workload update
```

Check if workload is insalled using

```shell
dotnet workload list
```

- Alternatively, you can go to [dotnet site] and download the version of the SDK that you require

> If you want to develop apps using .NET, download **SDK** or if you only want to run existing code, use **Runtime**

## Setup

To start a new console app

```shell
dotnet new console
```

To run a single file, this is possible since C# 14 and .NET 10 with file based apps

```shell
dotnet run Program.cs
```

To install [xunit]

```shell
dotnet new install xunit.v3.templates
```

To create a new unit test project, with below hierarchy, change dir to tests directory and then run `dotnet new xunit3`

```text
MySolution/
├── MySolution.sln
├── src/
│   └── MyProject/
│       ├── MyProject.csproj
│       └── Calculator.cs
└── tests/
    └── MyProject.Tests/
        ├── MyProject.Tests.csproj  <-- Created with 'dotnet new xunit3'
        ├── CalculatorTests.cs
        └── xunit.runner.json       <-- Configuration for xUnit v3
```

```shell
dotnet new xunit3
```

To create a new solution, cd to it

```shell
# Create a new solution
dotnet new sln -n Fundamentals
# Add a project to a solution
dotnet sln Fundamentals.slnx add src/Fundamentals/Fundamentals.csproj
# Add tests folder to the solution
dotnet sln Fundamentals.slnx add tests/Fundamentals.Tests/Fundamentals.Tests.csproj
# Link tests folder to src folder
dotnet add tests/Fundamentals.Tests/Fundamentals.Tests.csproj reference src/Fundamentals/Fundamentals.csproj
```

To build

```shell
dotnet build
```

To build and run

```shell
dotnet run
```

To run tests within a specific project

```shell
dotnet run --project tests/Fundamentals.Tests/Fundamentals.Tests.csproj
```

[Tour of Csharp]: https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/overview
[xunit]: https://xunit.net/docs/getting-started/v3/getting-started
