using System.Threading;

// create a timer which will call back in 1 second
var timer = new PeriodicTimer(TimeSpan.FromSeconds(1));

// wait for call back
var target = 10;
var count = 0;

while (await timer.WaitForNextTickAsync()) {
    count++;
    Console.WriteLine($"Waited {count} second(s) | {target - count} second(s) remaining.");
    Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
    if (count == target)
        timer.Dispose();
}
Console.WriteLine("Timer is done.");
