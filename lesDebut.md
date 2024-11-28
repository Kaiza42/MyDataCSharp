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

