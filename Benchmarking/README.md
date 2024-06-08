## Running a console app with Benchmark.NET

Benchmarking efficiency of processing strings.
```
// ***** BenchmarkRunner: Finish  *****

// * Export *
  BenchmarkDotNet.Artifacts\results\StringBenchmarks-report.csv
  BenchmarkDotNet.Artifacts\results\StringBenchmarks-report-github.md
  BenchmarkDotNet.Artifacts\results\StringBenchmarks-report.html

// * Detailed results *
StringBenchmarks.StringConcatenationTest: DefaultJob
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI; GC = Concurrent Workstation
Mean = 294.605 ns, StdErr = 1.310 ns (0.44%), N = 13, StdDev = 4.724 ns
Min = 285.705 ns, Q1 = 292.589 ns, Median = 294.308 ns, Q3 = 298.081 ns, Max = 303.137 ns
IQR = 5.493 ns, LowerFence = 284.349 ns, UpperFence = 306.321 ns
ConfidenceInterval = [288.948 ns; 300.262 ns] (CI 99.9%), Margin = 5.657 ns (1.92% of Mean)
Skewness = -0.13, Kurtosis = 2.17, MValue = 2
-------------------- Histogram --------------------
[283.068 ns ; 292.723 ns) | @@@@
[292.723 ns ; 304.234 ns) | @@@@@@@@@
---------------------------------------------------

StringBenchmarks.StringBuilderTest: DefaultJob
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI; GC = Concurrent Workstation
Mean = 210.033 ns, StdErr = 0.858 ns (0.41%), N = 15, StdDev = 3.322 ns
Min = 205.758 ns, Q1 = 207.531 ns, Median = 209.204 ns, Q3 = 212.729 ns, Max = 216.095 ns
IQR = 5.198 ns, LowerFence = 199.735 ns, UpperFence = 220.525 ns
ConfidenceInterval = [206.481 ns; 213.585 ns] (CI 99.9%), Margin = 3.552 ns (1.69% of Mean)
Skewness = 0.47, Kurtosis = 1.73, MValue = 2
-------------------- Histogram --------------------
[203.990 ns ; 210.145 ns) | @@@@@@@@@
[210.145 ns ; 216.930 ns) | @@@@@@
---------------------------------------------------

// * Summary *

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3593/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.300
  [Host]     : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


| Method                  | Mean     | Error   | StdDev  | Ratio |
|------------------------ |---------:|--------:|--------:|------:|
| StringConcatenationTest | 294.6 ns | 5.66 ns | 4.72 ns |  1.00 |
| StringBuilderTest       | 210.0 ns | 3.55 ns | 3.32 ns |  0.71 |

// * Hints *
Outliers
  StringBenchmarks.StringConcatenationTest: Default -> 4 outliers were removed (332.23 ns..671.55 ns)

// * Legends *
  Mean   : Arithmetic mean of all measurements
  Error  : Half of 99.9% confidence interval
  StdDev : Standard deviation of all measurements
  Ratio  : Mean of the ratio distribution ([Current]/[Baseline])
  1 ns   : 1 Nanosecond (0.000000001 sec)

// ***** BenchmarkRunner: End *****
Run time: 00:00:43 (43.96 sec), executed benchmarks: 2

Global total time: 00:00:54 (54.28 sec), executed benchmarks: 2
// * Artifacts cleanup *
Artifacts cleanup is finished
```