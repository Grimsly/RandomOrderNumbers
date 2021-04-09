``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4300.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.8 (4.8.4300.0), X86 LegacyJIT


```
|            Method |     Mean |    Error |   StdDev | Ratio |   Gen 0 |   Gen 1 | Gen 2 | Allocated |
|------------------ |---------:|---------:|---------:|------:|--------:|--------:|------:|----------:|
| CreateIntLinqList | 73.39 μs | 1.456 μs | 1.557 μs |  1.00 | 68.9697 | 17.2119 |     - | 128.51 KB |
|  CreateIntForList | 31.79 μs | 0.459 μs | 0.359 μs |  0.43 | 68.9697 | 17.2119 |     - | 128.51 KB |
