
// Question 1
// Valor da soma 91
Console.WriteLine("SOMA: " + Enumerable.Range(0, 14).Aggregate(0, (initial, current) => initial + current));
Console.WriteLine();

// Question 2
static IEnumerable<int> FibonnaciSequence(int number) {
    if (number <= 0) throw new ArgumentException("O número não pode ser menor que zero");
    for (int previous = -1, future = 1, term = 0, i = 1; i <= number; previous = future, future = term, i += 1) {
        term = previous + future;
        Console.Write($" {term} ");
        yield return term;
    } 
}

var number = 34;

if (FibonnaciSequence(number).Any(x => x == number))
    Console.WriteLine("- O número está dentro da sequência");
else 
    Console.WriteLine("- O número não está dentro da sequência");


// Question 5
var phrase = "GABRIEL QUER UM PLAYSTATION";

static string Reverse(string phrase, int size) 
{
    if (size == 0) return "";
    var concat = Reverse(phrase, size - 1);
    concat += phrase[^size];
    return concat;
}

Console.WriteLine();
Console.WriteLine("REVERSO: " + Reverse(phrase, phrase.Length));