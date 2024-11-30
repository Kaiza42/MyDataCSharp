 ### if/else/ else if 

 En sois pas grande différence avec Js 

 exemple 

```cs

string fizz = "fizz";

string buzz = "buzz";

int chiffre = 0;

if (chiffre % 2 == 0 && chiffre % 3 == 0)
{
    Console.WriteLine(fizz + buzz );
}
else 
{
    Console.WriteLine("nifizz nibuzz");
}

```

on va faire la meme boucle mais avec un else if donc sois fizz sois buzz 
 
```cs
string fizz = "fizz";

string buzz = "buzz";

int chiffre = 0;

if(chiffre % 2 == 0)
{
    Console.WriteLine(fizz);
}
else if (chiffre % 3 == 0)
{
    Console.WriteLine(buzz);
}
else
{
    Console.WriteLine("nifizz nibuzz");
}
```

## boucle for 

Tout pareil rien a changer par rapport au Js

Premier exemple 

```cs
for (int n = 0 ; n <= 28 ; n++)
{
    Console.WriteLine(n);
}
```
la boucle for va compter de 0 a 28 et les afficher 


deuxieme exemple 

```cs 
string fizz = "fizz";

string buzz = "buzz";

int chiffre = 0;


for(int n = chiffre ; n <= 40 ; n++)
if (n % 2 == 0 && n % 3 == 0)
{
    Console.WriteLine(fizz + buzz);
}
else 
{
    Console.WriteLine("ni" + fizz "ni" + buzz);
}
```