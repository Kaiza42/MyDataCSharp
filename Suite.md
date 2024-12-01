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
## while 

meme choses qu'en js 

```cs
// int no = 0; ma variable

while(no <= 10) //ma condition  
{
    no += 1; //mon itération 
    Console.WriteLine("aplaus");
}
```

## do while 
```cs
int n = 0;

do 
{
    n += 1;
    Console.WriteLine("Envie de canner");
}while (n < 10);

```

## enum 

a enumérer des cas precis apres je peut m'en servir en fesant une appellation de Direction 

```cs
enum Direction 
{
    nord,
    est,
    sud,
    ouest
}

// pour l'appel de enum exemple 


Direction direction = Direction.nord;

// comment m'en servir sa peu etre dans des switch des if/else vue que des enum c'est des cas precis switch et plus avisé 

```

## switch 
 un exemple de case c'est la meme choses qu'en Js 

 ```cs
switch (couleurChoisie)
{
    case Couleur.Bleu :
    Console.WriteLine("La couleur est bleue");
    break;
    case Couleur.Vert :
    Console.WriteLine("La couleur est vert");
    break;
    case Couleur.Rouge :
    Console.WriteLine("La couleur est rouge");
    break;
    case Couleur.Jaune :
    Console.WriteLine("La couleur est jaune");
    break;
    default:
    Console.WriteLine("Cette couleur n'est pas connue !");
}

 ```

## try - catch 
 try et catch son interessant car quand tu va faire du code dans le block try quand le code s'execute le block catch va varifier si il y a une erreure exemple <br>
 le code de pase ne va pas s'executer c'est juste un exemple

```cs
try {
    int number = 18;
    int number2 = 0;

    int divide = number / number2 ; // en gros je divise par 0 ce qui n'est pas recomander de faire 
}

catch(DivideByZeroExeption)
{
 Console.Write("Je ne divise pas par 0") // ici cela pas "catch" l'erreur donc la division par 0
 Environment.Exit(-1); // et sa cela va arreter le code 
}

// le catch général 
 
catch(Exeption ex)
{
    Console.Write("l'erreur c'est : " + ex.Message)
}

```