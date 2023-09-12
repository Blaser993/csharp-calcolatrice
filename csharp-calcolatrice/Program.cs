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
int primo = 43;
int secondo = -42;

double terzo = 34.6;
double quarto = 34.5;


int resultInt = CalcoliHelper.MaxInt(primo,secondo);
Console.WriteLine(resultInt);

double resultDec = CalcoliHelper.MaxDec(terzo, quarto);
Console.WriteLine(resultDec);