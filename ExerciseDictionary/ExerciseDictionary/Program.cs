Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies["user"] = "Maria";
cookies["email"] = "Maria@gmail.com";
cookies["phone"] = "12345667789";
cookies["phone2"] = "123456";

Console.WriteLine(cookies["user"]);
Console.WriteLine(cookies["email"]);

Console.WriteLine(cookies.ContainsKey("user"));
Console.WriteLine(cookies.ContainsValue("123456"));

cookies.Remove("user");

if (cookies.ContainsKey("user"))
{
    Console.WriteLine("Existe -->" + cookies.ContainsKey("user"));
}
else {
    Console.WriteLine("Não existe mais");
}

Console.WriteLine(cookies.Count);

foreach (KeyValuePair<string, string> item in cookies) {
    Console.WriteLine(item.Key);
    Console.WriteLine(item.Value);
}