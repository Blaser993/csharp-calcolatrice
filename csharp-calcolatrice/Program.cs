// See https://aka.ms/new-console-template for more information
using csharp_calcolatrice;

Console.WriteLine("Hello, World!");

/*
Come visto a lezione, strutturare la classe in modo che non possa essere istanziata e che presenti i seguenti metodi static:
Somma di due numeri interi
Somma di due numeri double
Differenza tra due numeri interi
Differenza tra due numeri double
Moltiplicazione di due numeri interi
Moltiplicazione di due numeri double
Valore assoluto di un numero intero
Valore assoluto di un numero double
Minimo tra due numeri interi
Minimo tra due numeri double
Massimo tra due numeri interi
Massimo tra due numeri double
*/

int num = -567;
int primo = 2;
int secondo = -2;

double terzo = 34.6;
double quarto = 34.5;


int resultInt = CalcoliHelper.MaxInt(primo,secondo);
Console.WriteLine(resultInt);

double resultDec = CalcoliHelper.MaxDec(terzo, quarto);
Console.WriteLine(resultDec);

/*
BONUS:
Aggiungete il metodo per l’elevamento a potenza che prende come 
parametri due numeri interi (base ed esponente) e ritorna la base elevata all’esponente.
Occhio che sia la base che l’esponente potrebbero essere uguali a zero oppure numeri negativi!
(caso esponente = 0 e base = 0 anche se in matematica sarebbe un numero indefinito usiamo 
l’approccio informatico che lo calcola come 1)
*/


float potenzatInt = CalcoliHelper.PotenzaInt(primo, secondo);
Console.WriteLine(potenzatInt);