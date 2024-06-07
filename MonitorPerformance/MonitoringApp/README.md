## Monitor time and memory resource usage 

 Measure efficiency of processing strings

StringBuilder is more than 1,700 times faster and about 10 times more memory-efficient when concatenating text:
```
*
* Using StringBuilder
*
557,056 physical bytes used.
131,072 virtual bytes used.
00:00:00.0034762 time span elapsed.
3 total milliseconds elapsed.

*
* Using string with +
*
10,690,560 physical bytes used.
1,835,008 virtual bytes used.
00:00:01.6035832 time span elapsed.
1,603 total milliseconds elapsed.
```