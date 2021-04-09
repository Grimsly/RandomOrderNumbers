``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4300.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.8 (4.8.4300.0), X86 LegacyJIT


```
|            Method |     Mean |    Error |   StdDev | Ratio | RatioSD |   Gen 0 |   Gen 1 | Gen 2 | Allocated |
|------------------ |---------:|---------:|---------:|------:|--------:|--------:|--------:|------:|----------:|
| CreateIntLinqList | 75.45 μs | 1.492 μs | 3.368 μs |  1.00 |    0.00 | 68.9697 | 17.2119 |     - | 128.51 KB |
|  CreateIntForList | 35.30 μs | 1.201 μs | 3.540 μs |  0.48 |    0.06 | 68.9697 | 17.2119 |     - | 128.51 KB |
