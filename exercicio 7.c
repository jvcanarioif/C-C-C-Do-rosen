#include <stdio.h>

int main()
{
    int cel, far;
    printf("digite a temperatura em Celcius :");
    scanf("%d", &cel);
    far = 9 * cel/5 + 32;
    printf("%d graus Celcius é aproximadamente %d graus Fahrenheit", cel,far);
}