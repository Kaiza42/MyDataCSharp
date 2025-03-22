# ici seras noté des therme "utilitaire" 


### range 

Pour suprimer par exemple La premiere lettre d'une string Ou la derniere lettre d'une string 

```cs

string Bonjour = "hello"
Console.WriteLine(Bonjour[1..^1]);
// dans cette exemple on surpime la premiere et la derniere lettre 
// sa peu etre utiliser dans des array et des string 

```
### parse 

dans l'idée je souhaite convertir une string en nombre 

```cs 

string mesChiffre = "125896";

int mesVraiChiffre = int.Parse(MesChiffre);
// sa peu marcher avec float double decimal 
```

### TryParse

Dans l'idée  c'est la meme choses que parse mais cette fois tu a un retour si la conversion est reussi ou non 
l'enxemple utiliser a était fait dans un exo 
```cs
int conversionSaisie;
int trouveMoi = 0;
int result = 0;

do
{
  // la saisie utilisateur Qui doit etre dans la boucle Pour continuer la saisie utilisateur 
    string saisie = Console.ReadLine();

// Tryparse permet la conversion de la saisie de  String a Int et out peut renvoyer true ou false et fait le resultat demander.
    if (int.TryParse(saisie, out conversionSaisie))
    {
      // si conversionSaisie est différent de trouveMoi Alors affiche la Console 
        if (conversionSaisie != trouveMoi)
        {
            Console.WriteLine("hey c'est pas compliquer .. un chiffre entre 0 et 9 ");

        }
        else
        {
          // Sinon bah bravo.
            Console.WriteLine("Bravo.");

        }
        // le resultat de toute les saisie utilisateur 
        result += conversionSaisie;
        Console.WriteLine("le resultat de toute tes saisie donne sa " + result);

    }
    la condition pour continuer la boucle 
} while (conversionSaisie != trouveMoi);


```
### Split 

transformer ta string en array 

```cs
string hello = "hello jpp c'est simple a comprendre";

Console.WriteLine(hello.Split(' '));

```

### Replace 

permet de remplacer un élément par un autre 

```cs
string hello = "hello";

Console.Write(hello.Replace("h", "p"));
// dans les parenthese de replace le "h" et remplacer par "p" ce qui donne "pello"
```

### string.Empty 

```cs

string vide = string.Empty;
// permet que la chainne sois vide donc le contenue est "" 

```

### ToUpper & ToLower

```cs
string name = "NAME";

//ToLower pour passer tout le texte en minuscule 
Console.WriteLine(name.ToLower());

string Name = "name";
//ToUpper pur passer tout le texte en majuscule
Console.WriteLine(Name.ToUpper());
```

### IndexOf

IndexOf va chercher le premier élément demander 
```cs
string texte = "Bonjour tout le monde";
int index = texte.IndexOf("t"); // 8 car le premier T est a la place 8
Console.WriteLine(index);

// on peut comencer l'index of apartir d'un endroit precis 
string texte = "Bonjour tout le monde";
int index = texte.IndexOf('o', 5); ici 
Console.WriteLine(index);
```


### Sort

dans cette exemple ``Sort();`` va changer l'ordre de la liste pour mettre un ordre alphabetique 
```cs
var names = new List<string> {"yes","no","myabe", "idon't know"  };
names.Sort();
foreach (var name in names)
{
  Console.WriteLine($"Hello {name}!");
}
```

### Trim
Trim va suprimer les espace avant et apres 

```cs
Console.WriteLine($"{value.Trim()}");
```

### contains 
verifie si une chaine de caractère contient l'élément demander 

```cs
// je declare ma chaine de caractère 
string fruit = "amande";

ma variable verifications va vérifier grace a Contains si "a" est dans la chaine de caractère de la variable "fruit"
bool verifications = fruit.Contains("a");

Console.WriteLine(verifications);
```

### ToString
En sois ToString change une variable double pour l'exemple en chaine de caractère 

```cs
double n = 25.25; 

Console.WriteLine(n.ToString(""));
sa afficheras 25.25
//maintenant imaginons que nous ne souhaitons pas afficher la décimal
double n = 25.25; 

Console.WriteLine(n.ToString("0"));
// maintenant uniquement le premier chiffre de la virgule 
double n = 25.25; 

Console.WriteLine(n.ToString("0.0"));
// Sa afficheras 25.3 sa arrondis au supérieur 
//évidament on peut faire sa pour afficher autant de nombre en decimal qu'on veut 
double n = 25.25; 

Console.WriteLine(n.ToString("0.00"));
//sa afficheras 25.25
// ect
```
### Random 

de ma compréhension ``Random`` est une classe sortie de la bibliothèque standard c# (system)
``bouleDeNoel`` est l'objet instancier par la classe ``Random``
```cs
// déclaration de la variable random 
Random bouleDeNoel = new Random();

// Plusieur façon de voir la suite de ma petite bouleDeNoel 
// ici boule de noel va générer un chiffre aléatoire entre 0 a 9 car la génération de chiffre fait 10 -1
int vraiBouleDeNoel = bouleDeNoel.Next(10);
// ici cela va générer un chiffre aléatoire entre 1 et 99 donc 1 a 100 -1
int fausseBouleDeNoel = bouleDeNoel.Next(1, 100);

// random a virgule 
double fractionUn = 0.010000;
double fractionDeux = 100.1000;
// cela peut générer un chiffre aléatoire en les deux variable 
double yesBouleDeNoel = bouleDeNoel.NextDouble(); * (fractionUn - fractionDeux);

// faire un booléan aléatoire 
//la logique dit que un  booléan un 0 et un 1 donc il va générer un chiffre entre 0 et 1 qui est un boolean aléatoire 
bool booleanAléatoire = bouleDenoel.Next(0,2) == 0; 

// On peut aussi faire 1 chance sur X pour gerer l'aléatoire 
int variable = bouleDeNeige.Next(0,101) < 25; // 1 chance sur 4 

int[] array = { 10, 20, 30, 40, 50 };
// generer un random d'un tableau 
int randomIndex = bouleDeNeige.Next(0, array.Length);
```
### les type signé 

###### sbyte 

taille 1 octect (8 byte) <br>
plage de valeur -128 a 127 <br>
```sbyte signedByte = -120;```


###### short 

taille 2 octects (16 bits)<br>
Plage de valeurs : -32 768 à 32 767.<br>
```short signedShort = -32000;```

###### long 

Taille : 8 octets (64 bits) <br>
Plage de valeurs : -9 223 372 036 854 775 808 à 9 223 372 036 854 775 807 <br>
```long signedLong = -100000000000;```

###### int, decimal, double, float en font partie 


### Min Max Average 

.Min prends la valeur minimal <br>
.Max prends la valeur maximal <br>
.Average prends la valeur Moyenne 

```cs
int[] numbers = { 3,7,1,9,5,4};

int minimal = numbers.Min(); // retourneras la valeur Minimum donc : 1 
int maximum = numbers.Max(); // retourneras la valeur Maximum donc : 9 
int millieu = numbers.Average(); // retourne la moyenne donc : 5 
```

### la couleur dans la console 

```cs
// background 
Console.Background = ConsolorColor.Red;
// donne la couleur rouge au text sa peu etre différente couleur 
Console.ForeGround = ConsoleColor.Red;
// va reset la couleur donc Blanc par default
Console.ResetColor();
```

### taduction de requete SQL Like / Startwith / EndWith / where / %
Donc je vais une recherche car la répétition de ligne ne me plais pas trop contexte je fait une api sur une bibliothèque
Le principe de ma recherche et de faire un filtre qui permet d'éviter de la répétition partout dans mon code et du coup de faire 
Une simple methode qui en fonction de la demande il affiche la demande dans le format que j'aurais décider 
Precision : je suis pas tres bon en SQL 
```cs 
// je suis tomber sur cette ligne qui ma fortement interesser
// EF.Functions.Like me permet d'utiliser des expression SQL pour faire ma recherche exemple : Si l'utilisateur va taper "Hello" Il va recherche un élément comme "Hello" donc tout ce qui contient Hello Seras afficher 
// ensuite EF.Property<string> dit juste que la propriété et une string 
// ensuite nous avons $"%{value.Trim()}%" donc % expresion SQL pour dire 1 ou plusieur et ensuite value => valeur afficher .Trim() pour suprimer les espace avant et apres.
livre = livre.Where(instanceDelivre => EF.Functions.Like(EF.Property<string>(instanceDelivre, property.Name), $"%{value.Trim()}%"));

// C'est a peu pres la meme sof que la ce n'est pas un Like mais un StartWith donc Comence avec Pourquoi pas de trim ? car sa comence avec 
livre = livre.Where(instanceDelivre => EF.Property<string>(instanceDelivre, property.Name).StartsWith(value.Trim()));
// C'est a peu pres la meme sof que la ce n'est pas un Like mais un EndsWith => termine avec, la pas de trim car sa termine avec 
livre = livre.Where(instanceDelivre => EF.Property<string>(instanceDelivre, property.Name).EndsWith(value.Trim()));

valeurClasse = valeurClasse.Where(e => EF.Property<DateTime>(e, property.Name).Date == dateValue.Date);
  
```
## StringBuilder

`StringBuilder` est une classe utilisée pour construire des chaînes de caractères de manière efficace, surtout quand tu dois faire plusieurs ajouts. Contrairement au `+`, il ne crée pas de nouvelles chaînes à chaque ajout, ce qui améliore les performances.

### Exemple simple : construire une phrase mot par mot

```csharp
using System.Text;

StringBuilder phrase = new StringBuilder();

phrase.Append("Bonjour");
phrase.Append(" ");
phrase.Append("le");
phrase.Append(" ");
phrase.Append("monde");
phrase.Append("!");

Console.WriteLine(phrase.ToString()); // Affiche : Bonjour le monde!
```






