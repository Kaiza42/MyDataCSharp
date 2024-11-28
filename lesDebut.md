# ici on va comencer du tout debut déclaration de variable ect 

Evidament les operateur  ``*`` Multiplication ou ``*=`` <br>
                         ``+`` Addition ou ``+=``<br>
                         ``-`` Soustraction ou ``-=``<br>
                         ``/`` Division Ou ``/=``<br>

 le type ``string`` c'est une chaine de caractere 

 le type ``Integer`` racourci par ``int`` prends en compte les nombre entier

le type ``float`` 32bit precision 6 a 7 chiffre / l'ecriture c'est `` 3.24f`` ou `` 3.24F``<br>
Pour l'apelation l'exemple : ``float age = 14.8f``

le type ``double`` 64bit precision 15 a 16 chiffre / lecriture mais non obligatoire c'est `` 3.24d`` ou `` 3.24D`` généralement utilisé <br>
Pour l'apellation l'exemple : ``double age = 14.8d`` ou ``double age = 14.8``

le type ``decimal`` 128bit precision 28 a 29 chiffre / lecriture c'est ``3.24m`` ou ``3.24M`` <br>
Pour l'apellation l'exemple : ``decimal age = 14.8m``




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

## les array 

Imaginons que je souhaite compter le nombre de ciguarette par jour 

```cs 

int[] mesCiguaretteParJour;
// déclaration de la variable de type int avec une array vide 

// apres je lui donne le nombre d'emplacement que je souhaite dans ce cas la 7 
 mesCiguaretteParJour = new int [7];
// faut prendre en compte que le tableau comence par 0 
// une autre façon de l'ecrire : 
// int [] mesCiguaretteParJour = new int[7]

// ensuite ajoutons lui des information a ce tableau ? 
// Imaginons que j'ai fumer 20 ciguarette le 2e jour donc je vais ecrire 
mesCiguaretteParJour[1] = 20; 
// donc 2e emplacement contient 20 

//maintenant je souhaiterais l'afficher 

console.WhriteLine(mesCiguaretteParJour[1]);

// Mais ajouter une valeur emplacement par emplacement c'est long en vrai nan ? 


// Je vais créer un tableau et remplir tout les emplacement 
string[] lesCiguaretteParJour;

lesCiguaretteParJour = new int[] {6,2,5,4,9,7,5};



// Apres on peu créer un tableau multi dimensionel 
// pour resumé sa c'est comme si t'avais un apartement donc un bâtiment avec 8 apartement Mais 4 etage

int [,] apartement = new int[4,2];
// Expliquons un peu Comment on sais que c'est un tableau multi-dimensionel ? il y a le [,] sa fait un tableau en 2D mais par
// exemple on pourais [,,] faire sa et sa deviendrais un tableau en 3D sa peu continuer indéfiniment 

```

