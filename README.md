# Target System Challange


## Questão 1

```cs
    Console.WriteLine("SOMA: " + Enumerable.Range(0, 14).Aggregate(0, (initial, current) => initial + current));
    // Output 91
```

## Questão 2

```cs
// Question 2
static IEnumerable<int> FibonnaciSequence(int number) {
    if (number <= 0) throw new ArgumentException("O número não pode ser menor ou igual a zero");
    for (int previous = -1, future = 1, term = 0, i = 1; i <= number; previous = future, future = term, i += 1) {
        term = previous + future;
        yield return term;
    } 
}

var number = 34;

if (FibonnaciSequence(number).Any(x => x == number))
    Console.WriteLine("- O número está dentro da sequência");
else 
    Console.WriteLine("- O número não está dentro da sequência");
```


## Questão 3

a) 1, 3, 5, 7, [9]

b) 2, 4, 8, 16, 32, 64, [128]

c) 0, 1, 4, 9, 16, 25, 36, [49]

d) 4, 16, 36, 64, [100]

e) 1, 1, 2, 3, 5, 8, [13]

f) 2,10, 12, 16, 17, 18, 19, [20]

## Questão 4

Eu faria assim: primeiro, acenderia o primeiro interruptor e esperaria um tempinho. Daí, desligaria o primeiro e acenderia o segundo interruptor. Aí, entraria na sala pra ver como cada lâmpada tá. Se a lâmpada estiver acesa, é porque o segundo interruptor controla ela. Se tiver apagada, mas ainda quente, é o primeiro interruptor. E se estiver apagada e fria, aí é o terceiro interruptor. Com isso, só precisaria de duas idas pra descobrir qual interruptor liga cada lâmpada.

## Questão 5


```cs
var phrase = "GABRIEL QUER UM PLAYSTATION";

static StringBuilder Reverse(string phrase, int size) 
{
    if (size <= 0) return new StringBuilder();
    return Reverse(phrase, size - 1).Append(phrase[^size]);
}

Console.WriteLine("REVERSO: " + Reverse(phrase, phrase.Length).ToString());
```