#include <stdio.h>

int main()
{
    int dia, ano;
    printf("Esscreva quantos cigarros o individuo fumaPdia :");
    scanf("%d", &dia);
    printf("Escreva quantos anos o individuo ja fumou :");
    scanf("%d", &ano);
    
    ano = (dia * 365) * ano;
    dia = (ano * 10) / 1440;

    printf("o individuo perdeu %d dias de sua vida por fumar", dia);

}
