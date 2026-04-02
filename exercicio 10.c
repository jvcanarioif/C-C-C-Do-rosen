#include <stdio.h>

int main()
{
    int dia, ano;
    printf("digite quantos cigarros o individuo fuma por dia :");
    scanf("%d", &dia);
    printf("digite quantos anos o individuo ja fumou :");
    scanf("%d", &ano);
    
    ano = (dia * 365) * ano;
    dia = (ano * 10) / 1440;

    printf("o individuo perdeu %d dias de sua vida", dia);

}