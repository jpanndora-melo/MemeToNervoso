string fraseDigitada, fraseMemeToNervoso;

Console.Write("Usuário, o que voce pensa a me respeito? ");
fraseDigitada = Console.ReadLine()!;

fraseMemeToNervoso = $"{fraseDigitada.Remove(10)} calma, espera ...To nervoso!";
Console.WriteLine(fraseMemeToNervoso);


