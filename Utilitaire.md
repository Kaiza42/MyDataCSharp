# ici seras noté des themre "utilitaire" 


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


