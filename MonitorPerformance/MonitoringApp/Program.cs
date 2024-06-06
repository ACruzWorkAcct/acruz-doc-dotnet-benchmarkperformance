using Packt.Shared;

WriteLine("Processing please wait...");

Recorder.Start();

// Simulate process that requires some memory resources...
int[] largeArrayOfInts = Enumerable.Range(start: 1, count: 10_000).ToArray();

// ...and takes some time to complete
Thread.Sleep(new Random().Next(5, 10) * 1000);

Recorder.Stop();