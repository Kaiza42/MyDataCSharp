# ici on va comencer du tout debut déclaration de variable ect 

Evidament les operateur <br> ``*`` Multiplication ou ``*=`` <br>
                         ``+`` Addition ou ``+=``<br>
                         ``-`` Soustraction ou ``-=``<br>
                         ``/`` Division Ou ``/=``<br>
                         ``%`` Modulo ou ``%=``<br>
                         
 le type ``string`` c'est une chaine de caractere 

 le type ``Integer`` racourci par ``int`` prends en compte les nombre entier

le type ``float`` 32bit precision 6 a 7 chiffre / l'ecriture c'est `` 3.24f`` ou `` 3.24F``<br>
Pour l'apelation l'exemple : ``float age = 14.8f``

le type ``double`` 64bit precision 15 a 16 chiffre / lecriture mais non obligatoire c'est `` 3.24d`` ou `` 3.24D`` généralement utilisé <br>
Pour l'apellation l'exemple : ``double age = 14.8d`` ou ``double age = 14.8``

le type ``decimal`` 128bit precision 28 a 29 chiffre / lecriture c'est ``3.24m`` ou ``3.24M`` <br>
Pour l'apellation l'exemple : ``decimal age = 14.8m``

le type ``bool`` vrai ou faux <br>
par convetion nous utiliserons pour déclarer une variable ``bool`` nous utiliserons ``is``  donc exemple :<br> ``bool isMajeur = true``

le type ``char`` 16bit  se déclare comme ceci ```char test = 'a'``` les apostrophe son a respect les valeurs char sont des valeurs unicodes

Le type ``null`` représente une absence de valeur


```cs
// tous sa se sont des Variable 

// J'ai 18 ans 
int monAge = 18;

// imaginon que j'ai 18 ans et demi donc jecrais 

double monVraiAge = 18.5

// Je m'appel JEAN 
string myName = "Jean";

// Maintenant imaginons je souhaite modifier ses varibale 
// plusieur ecriture possible 

// Maintenant mon age a 19 
monAge = monAge + 1; 

// Maintenant mon age a 20 
monAge += 1; 
// en sois c'est la meme choses MAIS c'est plus simple plus court  

monAge -= 1
monAge *= 1 
monAge /= 1

// Maintenant Voyons l'ecriture des constante 

// en sois suffit de rajouter const Pour que cela devienne une constante 
const int age = 18; 

// Une constante peut prendre la valeur d'une autre constante exemple 

const int jaiPasDage = age; 
// ce cas est possible Mais je ne peut pas donner la valeur d'une variable a une constante exemple 

int maSoeur = 20; 

const int  ageSoeur = maSoeur; // sa ne pourras pas fonctionner 

// la version contraire fonctionne donner la valeur d'une constante a une variable  exemple 

const int monAutreSoeur = 20;

int deuxAnsPlusTard += monAutreSoeur + 2;  // Sa afficheras 22 

```

## afficher 


```Console.WriteLine``` va sauter une ligne APRES l'affichage <br>
Alors que  ```Console.Write``` va afficher la suite
```cs
Console.WriteLine(maVariable + monAutreVariable + "tout sa était des varibale");
Console.WriteLine($"{maVariable} {monAutreVariable} tout sa était des variable");

Console.Write(maVariable + monAutreViable + "tout sa était des variable");
Console.Write($"{maVariable} {monAutreVariable} Tout sa était des variable");
```
## saisie utilisateur 
```cs
string saisie = Console.ReadLine();
```

## les array (tableau)

Imaginons que je souhaite compter le nombre de ciguarette par jour 

```cs 
int[] mesCiguaretteParJour;
// déclaration de la variable de type int avec une array vide 

// apres je lui donne le nombre d'emplacement que je souhaite dans ce cas la 7 
 mesCiguaretteParJour = new int [7];
// faut prendre en compte que le tableau comence par 0 
// une autre façon de l'ecrire : 

 int[] mesCiguaretteParJour = new int[7]

// ensuite ajoutons lui des information a ce tableau ? 
// Imaginons que j'ai fumer 20 ciguarette le 2e jour donc je vais ecrire 
mesCiguaretteParJour[1] = 20; 
// donc 2e emplacement contient 20 

//maintenant je souhaiterais l'afficher 

console.WhriteLine(mesCiguaretteParJour[1]);

// Mais ajouter une valeur emplacement par emplacement c'est long en vrai nan ? 

// Je vais créer un tableau et le remplir 
string[] lesCiguaretteParJour;

lesCiguaretteParJour = new int[] {6,2,5,4,9,7,5};

// Apres on peu créer un tableau multi dimensionel 
// pour resumé sa c'est comme si t'avais un apartement donc un bâtiment avec 8 apartement Mais 4 etage

int [,] apartement = new int[4,2];
// Expliquons un peu Comment on sais que c'est un tableau multi-dimensionel ? il y a le [,] sa fait un tableau en 2D mais par
// exemple on pourais [,,] faire sa et sa deviendrais un tableau en 3D sa peu continuer indéfiniment 

```


## les list 

```cs
// Donc on déclare comme ceci 
IList<string> testList = new List<string>();

// du coup on va ajouter du contenue a ma liste 
testList.Add("test1");
testList.Add("test2");
testList.Add("test3");
// on peut ajouter un élément a un emplacement précis
testList.Insert(2, "test8");
// le premier seras l'emplacement et ensuite le contenue 

// Ensuite on peu suprimer un élément 
testList.RemoveAt(2)

// Apres il faut l'afficher 
foreach (string testLists in testlist)
{
   console.WhriteLine(testLists)
}

// on peut verifier si une liste est vide 

// le count va compter chaque élément de la liste et si il est strictement égale a 0 alors la liste et vide 
if(testList.Count == 0){
    Console.WriteLine("la liste est vide");
}
// sinon la liste n'est pas vide 
else
{
Console.WriteLine("La list n'est pas vide")
}
```

## le dictionnaire

```cs

// on déclaire un dictionaire comme ceci Sa ressemble a une liste

IDictionary<string, int> mesEleve = new Dictionary<string, int>();

//mais ici on va déclarer String puis Int String étant la clé et int la valeur

// mes eleve s'appel comment et ils ont quel age ? 

mesEleve.Add("Jean", 24);
mesEleve.Add("justin", 21);
mesEleve.Add("jean", 18);

// Deux jean ? pas vraiment vue que la clé c'est la string si elle n'est pas écrit exactement de la meme manière majusculte compris ce n'est pas la meme clé donc dans ce cas pas le meme Eleve

// Pour l'afficher 

console.WriteLine(mesEleve["Jean"]); // sa afficheras 24
console.WriteLine(mesEleve["jean"]); // sa afficheras 18 

// on peut aussi le faire différament 
//a noté que toute les clé utiliser doivent etre du meme type cet a dire que si j'utilise une constante en premiere alors je devrais 
//utiliser une contante a chaque fois la clé peut etre de type int string constante 

const string jeanne = "jeanne";

mesEleve.Add(jeanne , 36);

console.WriteLine(mesEleve[jeanne]); // sa afficheras 36

// on peut surpimer aussi en rentrant la clé 

mesEleve.Remove("jean")

// on peut utiliser count pour voir tous les élement du dictionaire 

console.WriteLine(mesEleve.Count);

```


## collection non ordonné 

```cs
// la déclaration 
Iset<string> ingredient = new HashSet<string>();

// Pour ajouter 

ingredient.Add("Patate");
ingredient.Add("Oeuf");
ingredient.Add("Patte");

// Pour suprimer 
ingredient.Remove("Patate");

// Pour afficher le nombre délement  

console.WriteLine(ingredient.Count);

// pour tout afficher 

foreach (string ingredients in ingredient)
{
    console.WriteLine(ingredients);
}

```
## les niveau d'acces 


### Public 

```cs



public class Voiture
{
    public string Marque;  // Champ public, accessible partout

    public void Demarrer()  // Méthode publique, accessible partout
    {
        Console.WriteLine("La voiture démarre.");
    }
}

class Program
{
    static void Main()
    {
        Voiture maVoiture = new Voiture();
        maVoiture.Marque = "Toyota";  // Accessible car "Marque" est public
        maVoiture.Demarrer();         // Accessible car "Demarrer" est public
    }
}
//  dans cette exemple on peut utiliser "Voiture"  et la sous class "Demarrer" dans une autre class car c'est "public"
```

### private 


que fait private concrètement ? 

il n'est pas visible en dehors de sa classe 

en gros si tu l'appel endehors de sa class il ne seras pas utilisable 
```cs
public class Voiture
{
    private string numeroDeSerie;  // Champ privé, inaccessible de l'extérieur

    public void SetNumeroDeSerie(string numero) // rend accecible "numeroDeSerie" dans program
    {
        numeroDeSerie = numero;  // Accessible dans la classe
    }
// Imaginons que nous mettons SetNumeroDeSerie en private sa renverrais "voiture.SetNumeroDeSerie(string) is inaccesible due to it's protection level" en gros le private block l'accecibilité en dehors de Voiture mais peut etre utiliser dans les sous class de Voiture et il est possible de le rendre accecible grace a une sous classe public 

    public void AfficherNumeroDeSerie()
    {
        Console.WriteLine($"Numéro de série : {numeroDeSerie}");
    }
}


class Program
{
    static void Main()
    {
        Voiture maVoiture = new Voiture();
        maVoiture.SetNumeroDeSerie("12345");  // Accessible via méthode publique
        maVoiture.AfficherNumeroDeSerie();    // Affiche le numéro
    }
}

```

### protected 

protected est accecible dans sa class et ses sous class

utiliser quand tu souhaite l'utiliser dans des sous class ou dans sa class mais reste cacher des autre class 

```cs

public class Voiture
{
    protected string couleur;  // Accessible dans les sous-classes

    public Voiture(string couleur)
    {
        this.couleur = couleur;
    }
}

public class VoitureDeCourse : Voiture
{
    public VoitureDeCourse(string couleur) : base(couleur) { }

    public void AfficherCouleur()
    {
        Console.WriteLine($"Couleur de la voiture de course : {couleur}");
    }
}

class Program
{
    static void Main()
    {
        VoitureDeCourse voitureDeCourse = new VoitureDeCourse("Rouge");
        voitureDeCourse.AfficherCouleur();  // Accède à la propriété protégée
        // dans cette exemple tu accede uniquement a la propriété de notre variable protected et non a la variable elle meme 
    }
}
```


### internal

Projet ou assemblage 

internal est accecible uniquement dans ton projet 
si tu créer un nouveau projet il ne seras pas accecible dans ce projet 

```cs 
internal class Moteur
{
    internal int Puissance;  // Accessible dans le même assemblage

    internal void Tourner()
    {
        Console.WriteLine("Le moteur tourne.");
    }
}

class Program
{
    static void Main()
    {
        Moteur moteur = new Moteur();
        moteur.Puissance = 200;
        moteur.Tourner();  // Fonctionne, car dans le même assemblage
    }
}
```


## fonction


exemple de fonction 

```cs
void Bienvenue(string prenom, string nom)
{
Console.WriteLine("Bonjour" + prenom + " " + nom);
}

Bienvenue("jean", claude);

```

## retour d'une fonction 


il est possible de renvoyez une valeur a l'aide d'un mot-clé 
**return**
le type de retour doit correspondre au type de déclaration

```cs
double additionner(double nombreUn, double nombreDeux)
{
double somme = nombreUn + nombreDeux;
return somme;
}

Additionner(1,2);

double resultat = Additionner(1,2) * 5;
```

## paramètres passés par référence 

par defaut, les paramètre sont passé par des valeurs
Mais il est possinle de les passer par réfférence a l'aide de ces mots:
``in`` : la lecture seule 
``out`` : écriture Obligatoire (la fonction doit imperativement 
atribuer une valeur)
```ref`` lecture et écriture obligatoire 

```cs
void ModifierNombre ( ref int nombre){
    nombre = nombre *2;
}
```