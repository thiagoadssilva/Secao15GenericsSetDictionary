# Generics, Set, Dictionary

Generics, Set e Dictionary são conceitos importantes na programação de computadores, especialmente no campo das estruturas de dados e algoritmos. Vamos dar uma olhada mais de perto em cada um deles:
Generics
Generics permitem escrever código que pode trabalhar com diferentes tipos de dados sem saber o tipo específico antecipadamente. Isso é particularmente útil ao lidar com coleções ou algoritmos que podem trabalhar com qualquer tipo de dado. Por exemplo, podemos querer criar uma lista de inteiros ou uma lista de strings, mas não queremos escrever código separado para cada tipo.
Em linguagens de programação que suportam generics, podemos definir um tipo genérico ou método que pode receber qualquer tipo como parâmetro. O parâmetro de tipo é então usado em todo o código para especificar o tipo de dados sendo usado.

    Exemplo de Generics
    using System;

    public class Example<T>
    {
        private T[] array;

        public Example(int size)
        {
            array = new T[size];
        }

        public void Set(int index, T value)
        {
            array[index] = value;
        }

        public T Get(int index)
        {
            return array[index];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Example<int> intExample = new Example<int>(5);
            intExample.Set(0, 1);
            intExample.Set(1, 2);
            intExample.Set(2, 3);
            intExample.Set(3, 4);
            intExample.Set(4, 5);

            Console.WriteLine(intExample.Get(0)); // Output: 1

            Example<string> stringExample = new Example<string>(3);
            stringExample.Set(0, "foo");
            stringExample.Set(1, "bar");
            stringExample.Set(2, "baz");

            Console.WriteLine(stringExample.Get(1)); // Output: bar
        }
    }



Um Set é uma coleção de elementos distintos. Em outras palavras, não contém duplicatas. Sets são comumente usados na ciência da computação por suas eficientes capacidades de pesquisa e teste de associação. Em muitas linguagens de programação, Sets são implementados usando uma tabela hash, que permite busca e inserção em tempo constante na média.
Sets são úteis quando precisamos armazenar uma coleção de elementos que não queremos repetir, ou quando precisamos testar se um elemento está presente em uma coleção.

    Exemplo de Set
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(2); // Adding duplicate element, will be ignored

            Console.WriteLine(set.Contains(2)); // Output: True
            Console.WriteLine(set.Contains(4)); // Output: False
        }
    }


# Dictionary

Um Dictionary é uma coleção de pares chave-valor. Cada chave no Dictionary é única e é usada para procurar o valor correspondente. Dicionários são comumente usados para armazenamento e recuperação de dados, bem como para implementar matrizes associativas e tabelas hash.
Em linguagens de programação que suportam dicionários, podemos definir um tipo de chave e um tipo de valor, e então usar as chaves para acessar os valores correspondentes. Dicionários fornecem acesso rápido a dados, pois a busca pela chave é tipicamente feita em tempo constante.
No geral, Generics, Sets e Dictionaries são conceitos importantes na programação de computadores e são amplamente utilizados em muitas linguagens de programação e estruturas.

    Exemplo de Dictionary
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("foo", 1);
            dict.Add("bar", 2);
            dict.Add("baz", 3);

            Console.WriteLine(dict["bar"]); // Output: 2

            dict["qux"] = 4;
            Console.WriteLine(dict["qux"]); // Output: 4

            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
    }

# type safety

Type safety (ou segurança de tipos, em português) é um conceito importante na programação de computadores que se refere à capacidade do compilador de garantir que os tipos de dados usados no código sejam consistentes e corretos. Isso ajuda a evitar erros de programação que podem levar a comportamentos inesperados ou erros em tempo de execução.
Em linguagens de programação com forte segurança de tipos, como C# e Java, o compilador verifica se os tipos de dados usados no código são compatíveis antes de permitir a compilação. Isso significa que, se houver um erro de tipo, ele será detectado e relatado pelo compilador, em vez de resultar em um erro em tempo de execução.
Por exemplo, se tentarmos atribuir uma variável do tipo inteiro a uma variável do tipo string em C#, o compilador gerará um erro, pois esses tipos não são compatíveis. Isso ajuda a evitar erros comuns, como tentar realizar operações aritméticas com strings, que podem causar comportamentos inesperados ou falhas no programa.
A segurança de tipos também ajuda a tornar o código mais legível e fácil de manter, pois os tipos de dados usados são explícitos e claros. Isso é especialmente útil em grandes projetos de software, onde várias pessoas podem trabalhar em partes diferentes do código.
Em resumo, a segurança de tipos é um recurso importante na programação de computadores que ajuda a garantir a consistência e a corretude do código, além de torná-lo mais legível e fácil de manter.

# Restrições para generics

As restrições (ou constraints, em inglês) são usadas em generics para impor restrições aos tipos que podem ser usados como argumentos genéricos em uma classe ou método genérico. As restrições ajudam a garantir que os tipos genéricos atendam a certas condições, o que pode tornar o código mais seguro e mais fácil de usar.
Existem três tipos principais de restrições em C#:
Restrições de tipo: permitem que você restrinja o tipo genérico a um determinado tipo ou conjunto de tipos. Por exemplo, você pode restringir um tipo genérico a aceitar apenas tipos que implementam uma determinada interface ou que herdam de uma determinada classe. A restrição de tipo é definida usando a palavra-chave where.
Restrições de construtor: permitem que você restrinja o tipo genérico a tipos que tenham um determinado construtor ou conjunto de construtores. Isso é útil quando você precisa criar novas instâncias do tipo genérico dentro do método genérico. A restrição de construtor é definida usando a palavra-chave new().
Restrições combinadas: permitem que você combine várias restrições de tipo e/ou construtor em uma única restrição. Por exemplo, você pode restringir um tipo genérico a aceitar apenas tipos que implementam uma determinada interface e têm um construtor sem parâmetros. As restrições combinadas são definidas usando várias cláusulas where separadas por vírgulas.
Aqui está um exemplo de como usar uma restrição de tipo para restringir um tipo genérico a aceitar apenas tipos que implementam uma determinada interface:


    public class Example<T> where T : IComparable
    {
        public int CompareTo(T other)
        {
            // implementação da comparação aqui
        }
    }

Neste exemplo, a classe genérica Example é restrita a tipos que implementam a interface IComparable. Isso significa que o método CompareTo só pode ser chamado com argumentos que implementam a interface IComparable, garantindo que o código seja seguro em relação aos tipos.
As restrições em generics são uma ferramenta poderosa para tornar o código mais seguro e fácil de usar, permitindo que você restrinja os tipos genéricos de acordo com as suas necessidades específicas.

# GetHashCode e Equals

GetHashCode() e Equals() são métodos importantes em C# que são frequentemente usados para trabalhar com objetos em coleções, como HashSet, Dictionary e List. Eles permitem que você compare objetos entre si para determinar se eles são iguais ou não e também para armazená-los em uma tabela hash.
GetHashCode() é um método que retorna um valor numérico único para um objeto, com base em suas propriedades. Esse valor é usado para identificar o objeto em uma tabela hash. Se dois objetos são considerados iguais pelo método Equals(), eles devem ter o mesmo valor de hash. Se dois objetos têm valores de hash diferentes, eles são considerados diferentes, mesmo que seus valores de propriedade sejam os mesmos.
Equals() é um método que compara dois objetos para determinar se eles são iguais ou não. O método compara as propriedades dos objetos para verificar se elas têm o mesmo valor. Se todas as propriedades de dois objetos forem iguais, eles são considerados iguais pelo método Equals(). Você pode sobrescrever o método Equals() em sua própria classe para definir o que significa igualdade para essa classe específica.
A classe object inclui uma implementação padrão do método GetHashCode(), que retorna um valor de hash com base no endereço de memória do objeto. No entanto, você pode substituir esse método para fornecer sua própria implementação, se necessário.
Por exemplo, se você estiver trabalhando com uma classe de Person que inclui as propriedades Name e Age, poderá criar uma implementação personalizada do método GetHashCode() para gerar um valor de hash exclusivo com base no nome e idade de uma pessoa:

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + Name.GetHashCode();
            hash = hash * 23 + Age.GetHashCode();
            return hash;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Person))
                return false;

            var other = (Person)obj;
            return this.Name == other.Name && this.Age == other.Age;
        }
    }

Neste exemplo, o método GetHashCode() calcula um valor de hash único com base no nome e idade de uma pessoa. O método Equals() compara duas pessoas para verificar se seus nomes e idades são iguais.
É importante que, ao sobrescrever os métodos GetHashCode() e Equals(), você garanta que esses métodos sejam consistentes. Ou seja, se dois objetos são iguais pelo método Equals(), eles devem ter o mesmo valor de hash pelo método GetHashCode(). Se os dois métodos não estiverem consistentes, você poderá enfrentar problemas em tabelas hash ou outras coleções que usam esses métodos para comparar objetos.

 # Estrutura de dados 'Conjunto

Em C#, a estrutura de dados de conjunto é representada pela classe HashSet<T>, que implementa a interface ISet<T>. Um conjunto é uma coleção de elementos que não permite elementos duplicados e não possui uma ordem definida. Os elementos em um conjunto podem ser adicionados, removidos e verificados se existem no conjunto.
A classe HashSet<T> fornece métodos para trabalhar com conjuntos, como:
Add(T item): adiciona um item ao conjunto.
Clear(): remove todos os itens do conjunto.
Contains(T item): verifica se um item está presente no conjunto.
Remove(T item): remove um item do conjunto, se ele estiver presente.
UnionWith(IEnumerable<T> other): adiciona todos os elementos de outro conjunto ao conjunto atual.
IntersectWith(IEnumerable<T> other): remove todos os elementos do conjunto atual que não estão presentes em outro conjunto.
ExceptWith(IEnumerable<T> other): remove todos os elementos do conjunto atual que estão presentes em outro conjunto.
SymmetricExceptWith(IEnumerable<T> other): remove todos os elementos do conjunto atual que estão presentes em outro conjunto e adiciona todos os elementos do outro conjunto que não estão presentes no conjunto atual.
A classe HashSet<T> também fornece propriedades e métodos para trabalhar com o tamanho do conjunto, como:
Count: retorna o número de elementos no conjunto.
IsReadOnly: retorna um valor que indica se o conjunto é somente leitura.
CopyTo(T[] array, int arrayIndex): copia os elementos do conjunto para uma matriz, a partir do índice especificado na matriz.

    Exemplo de uso de um conjunto:

    var set = new HashSet<int>();
    set.Add(1);
    set.Add(2);
    set.Add(3);
    set.Add(2); // o conjunto não permite elementos duplicados, então esse elemento não será adicionado

    Console.WriteLine(set.Count); // saída: 3

    set.Remove(2);

    Console.WriteLine(set.Contains(2)); // saída: false

    var otherSet = new HashSet<int>() { 2, 3, 4 };

    set.UnionWith(otherSet);

    Console.WriteLine(string.Join(",", set)); // saída: 1,3,4

Neste exemplo, um conjunto de inteiros é criado usando a classe HashSet<int>. Alguns elementos são adicionados ao conjunto, e um elemento duplicado não é adicionado. O número de elementos no conjunto é exibido usando a propriedade Count. Um elemento é removido do conjunto usando o método Remove(). Em seguida, é verificado se um elemento está presente no conjunto usando o método Contains(). Um segundo conjunto é criado e é usada a função UnionWith() para combinar os dois conjuntos. Finalmente, os elementos do conjunto são exibidos usando o método string.Join().

# Dictionary e SortedDictionary

Em C#, a estrutura de dados de dicionário é representada pela classe Dictionary<TKey, TValue>. Um dicionário é uma coleção de pares de chave-valor, onde cada chave é única e mapeia para um valor. As chaves e valores podem ser de qualquer tipo e são definidos pelos tipos genéricos TKey e TValue.
A classe Dictionary<TKey, TValue> fornece métodos para trabalhar com dicionários, como:
Add(TKey key, TValue value): adiciona um par chave-valor ao dicionário.
Clear(): remove todos os pares chave-valor do dicionário.
ContainsKey(TKey key): verifica se uma chave está presente no dicionário.
ContainsValue(TValue value): verifica se um valor está presente no dicionário.
Remove(TKey key): remove um par chave-valor do dicionário, se a chave estiver presente.
TryGetValue(TKey key, out TValue value): tenta obter o valor associado a uma chave no dicionário.
A classe SortedDictionary<TKey, TValue> é semelhante à classe Dictionary<TKey, TValue>, mas mantém as chaves em ordem. A ordem é determinada pela implementação de IComparer<TKey> passada como um parâmetro opcional para o construtor da classe. Se nenhum IComparer<TKey> for especificado, a ordem padrão é a ordem crescente das chaves.

    Exemplo de uso de um dicionário:
    var dict = new Dictionary<string, int>();
    dict.Add("Alice", 25);
    dict.Add("Bob", 30);
    dict.Add("Charlie", 35);

    Console.WriteLine(dict["Bob"]); // saída: 30

    dict["Alice"] = 26; // a chave "Alice" já existe, então o valor é atualizado

    Console.WriteLine(dict.ContainsKey("Dave")); // saída: False

    int value;
    if (dict.TryGetValue("Charlie", out value))
    {
        Console.WriteLine(value); // saída: 35
    }

    dict.Remove("Bob");

    Console.WriteLine(dict.Count); // saída: 2

Neste exemplo, um dicionário é criado usando a classe Dictionary<string, int>. Três pares chave-valor são adicionados ao dicionário. O valor associado à chave "Bob" é exibido usando a sintaxe de índice. O valor associado à chave "Alice" é atualizado usando a sintaxe de índice. É verificado se uma chave não existente está presente no dicionário usando o método ContainsKey(). O valor associado à chave "Charlie" é obtido usando o método TryGetValue(). O par chave-valor "Bob" é removido usando o método Remove(). O número de pares chave-valor restantes é exibido usando a propriedade Count.

    Exemplo de uso de um SortedDictionary:
    var sortedDict = new SortedDictionary<int, string>();
    sortedDict.Add(3, "Charlie");
    sortedDict.Add(1, "Alice");
    sortedDict.Add(2, "Bob");

    foreach (var item in sortedDict)
    {
        Console.WriteLine(item.Key + " " + item.Value);
    }

    // saída:
    // 1 Alice
    // 2 Bob
    // 3 Charlie

Neste exemplo, um SortedDictionary<int, string> é criado, e três pares chave-valor são adicionados a ele. O dicionário é percorrido usando um loop
