// Using DateTime.Now property to get the current date and time
DateTime now = DateTime.Now;
Console.WriteLine(now);

// DateTime.Today gets just the current date with time set to 12:00:00 AM
DateTime today = DateTime.Today;
Console.WriteLine(today);

// Another type of classes: DateOnly and TimeOnly represent just dates and times
// DateOnly dt = DateOnly.FromDateTime(DateTime.Now);
// TimeOnly tm = TimeOnly.FromDateTime(DateTime.Now);
// Console.WriteLine(dt);
// Console.WriteLine(tm);


// Other properties of Date:
// Console.WriteLine(today.DayOfWeek);
// Console.WriteLine(today.DayOfYear);

// Dates also have methods to change their values
// now = now.AddDays(5);
// Console.WriteLine(now);
// now = now.AddHours(9);
// Console.WriteLine(now);
// now = now.AddMonths(1);
// Console.WriteLine(now);

// The TimeSpan class represents a duration of time
// DateTime AprilFools = new DateTime(now.Year, 4, 1);
// Console.WriteLine($"April's Fools: {AprilFools}");
// DateTime NewYears = new DateTime(now.Year, 1, 1);
// Console.WriteLine($"New Years: {NewYears}");
// TimeSpan interval = AprilFools - NewYears;
// Console.WriteLine($"The interval between the 2 dates is:  {interval}");

// Dates can be compared using regular operatorsdotnet run
// Console.WriteLine($"{NewYears < AprilFools}");
// Console.WriteLine($"{NewYears > AprilFools}");

DateTime micumple = new DateTime(now.Year, 12, 26);
Console.WriteLine(micumple);
DateTime newYear = new DateTime(now.Year, 1, 1);
Console.WriteLine(newYear);

TimeSpan diferencia = micumple - newYear;
Console.WriteLine(diferencia);

Console.WriteLine($"{micumple < newYear}");
Console.WriteLine($"{micumple > newYear}");