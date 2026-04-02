#include <stdio.h>

int main()
{
    int vel, dist;
    printf("digite a distancia da viagem(km) : ");
    scanf("%d", &dist);
    printf("digite a sua velocidade media(km/h) : ");
    scanf("%d", &vel);
    int temp = dist / vel;
    printf("essa viagem ira demorar aproximadamente %d horas", temp);
}