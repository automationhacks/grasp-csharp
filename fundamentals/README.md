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

To build

```shell
dotnet build
```

To build and run

```shell
dotnet run
```

[Tour of Csharp]: https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/overview
[xunit]: https://xunit.net/docs/getting-started/v3/getting-started
