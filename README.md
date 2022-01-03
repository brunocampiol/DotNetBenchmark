## Net Core Benchmark

Using .NET Core 6
Xunit Tests

Goal of the project is to benchmark code

Using [https://benchmarkdotnet.org/](https://benchmarkdotnet.org/)

### Getting Started

Default .NET worker service application
Console app

From solution root:

Benchmark application
```
dotnet run -p .\DotNetBenchmark.WorkerService\DotNetBenchmark.WorkerService.csproj -c Release
```

Test application
```
dotnet test
```