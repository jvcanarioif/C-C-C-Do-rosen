#include <stdio.h>

int main()
{
    int cel, far;
    printf("digite a temperatura em Fahrenheit :");
    scanf("%d", &far);
    cel = (far - 32) * 5 / 9;
    printf("%d graus Fahrenheit é aproximadamente %d graus Celcius", far,cel);
}