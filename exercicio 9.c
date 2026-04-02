#include <stdio.h>

int main()
{
    int kms, dias, preco;
    printf("digite por quantos dias o carro foi alugado :");
    scanf("%d", &dias);
    printf("digite quantos quilometros o carro andou :");
    scanf("%d", &kms);
    preco = (dias * 60) + (kms * .15);
    printf("o valor total do aluguel é R$%d", preco);
}