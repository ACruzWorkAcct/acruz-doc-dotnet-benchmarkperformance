using Packt.Shared;
/*
WriteLine("Processing please wait...");

Recorder.Start();

// Simulate process that requires some memory resources...
int[] largeArrayOfInts = Enumerable.Range(start: 1, count: 10_000).ToArray();

// ...and takes some time to complete
Thread.Sleep(new Random().Next(5, 10) * 1000);

Recorder.Stop();
*/

int[] numbers = Enumerable.Range(start: 1, count: 50_000).ToArray();

SectionTitle("Using StringBuilder");

Recorder.Start();

System.Text.StringBuilder stringBuilder = new();

for  (int i = 0; i < numbers.Length; i++)
{
    stringBuilder.Append(numbers[i]);
    stringBuilder.Append(", ");
}

Recorder.Stop();
WriteLine();

SectionTitle("Using string with +");

Recorder.Start();

string s = string.Empty; // ""

for (int i = 0; i < numbers.Length; i++)
{
    s += numbers[i] + ", ";
}

Recorder.Stop();