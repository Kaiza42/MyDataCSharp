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

