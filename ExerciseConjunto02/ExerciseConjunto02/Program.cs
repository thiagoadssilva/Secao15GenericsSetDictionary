SortedSet<int> a = new SortedSet<int>() {0, 2, 4, 5, 6, 8, 10};
SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10};
SortedSet<string> names = new SortedSet<string>() { "Thiago", "Dineia", "Bento" };

PrintCollection(a);
PrintCollection(b);
PrintCollection(names);

// Union
SortedSet<int> c = new SortedSet<int>(a);
c.UnionWith(b);
PrintCollection(c);

// intersection
SortedSet<int> d = new SortedSet<int>(a);
d.IntersectWith(b);
PrintCollection(d);

// Defference
SortedSet<int> e = new SortedSet<int>(a);
d.ExceptWith(b);
PrintCollection(e);

static void PrintCollection<T>(IEnumerable<T> collection) {
    foreach (T item in collection)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}