
#include<iostream>
#include<stdlib.h>
#include<conio.h>
#include <iomanip>
using namespace std;


void ingresadatos(int* n, float* vecNumeros)
{
	for (int i = 0; i < *n; i++)
	{
		cout << "ingresa peso " << i + 1 << ":";
		cin >> vecNumeros)[i];
	}
}

void salidadatos(int* n, float* vecNumeros)
{
	for (int i = 0; i < *n; i++)
	{
		cout <<vecNumeros[i] <<" ";
		
	}
}

void desvEstandarPoblacional(int* n, float* vecNumeros)
{
	//calculando el promedio
	float suma = 0, prom;
	for (int i = 0; i < *n; i++)
		suma = suma + vecNumeros[i];
	prom = suma / (*n);


	//calculando el suma (xi-prom)al cuadrado
	double suma2 = 0;
	double prome2;
	double desviacion;

	for (int i = 0; i < *n; i++)
		suma2 = suma2 + pow((vecNumeros[i]-prom),2);
	prome2 = suma2 / (*n);

	desviacion = sqrt(prome2);

	cout << "desviacion standar: " << desviacion << endl;

}



int main()
{
	int n;
	cout << "ingrese la cantidad de numeros" << endl;
	cin >> n;
	
	float* vectorNumeros;
	vectorNumeros = new float[n];
	ingresadatos(&n, vectorNumeros);
	salidadatos(&n,vectorNumeros);
	desvEstandarPoblacional(&n, vectorNumeros);
	delete vectorNumeros;
	_getch();

}


