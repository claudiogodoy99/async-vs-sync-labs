``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-10610U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.200
  [Host]     : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT
  DefaultJob : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT


```
|           Method | IterationCount |     Mean |    Error |    StdDev |
|----------------- |--------------- |---------:|---------:|----------:|
| GetAsyncEndpoint |            200 | 184.6 ms |  3.36 ms |   3.86 ms |
| GetAsyncEndpoint |            200 | 182.8 ms |  3.53 ms |   3.13 ms |
|  GetSyncEndpoint |            200 | 672.8 ms | 65.20 ms | 180.67 ms |
|  GetSyncEndpoint |            200 | 495.6 ms |  9.80 ms |  10.48 ms |
