``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-10610U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.200
  [Host]     : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT


```
|     Method |     Mean |   Error |  StdDev |
|----------- |---------:|--------:|--------:|
|   Sincrono | 109.2 ms | 1.22 ms | 1.14 ms |
| Assincrono | 109.3 ms | 1.45 ms | 1.36 ms |
