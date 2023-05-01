HashSet<string> set = new HashSet<string>();

set.Add("Thiago");
set.Add("Dineia");
set.Add("Bento");

Console.WriteLine(set.Contains("Bento"));

foreach (string item in set) {
    Console.WriteLine(item);
}