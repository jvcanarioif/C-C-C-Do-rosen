// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Você está num mundo mágico. Um monstro misterioso está te atacando! Faça o que for preciso para sobreviver!");
Console.WriteLine("Escolha uma ação:");
Console.WriteLine("0 - Correr dele");
Console.WriteLine("1 - Atacar com um graveto do chão");
Console.WriteLine("2 - Usar magia arcana");
Console.WriteLine("3 - Defender");
Console.WriteLine("4 - Usar poção");
Console.WriteLine("5 - Chamar ajuda");
Console.WriteLine("6 - Jogar pedra");
Console.WriteLine("7 - Tentar Dialogo");
Console.WriteLine("8 - Usar arco e flecha");
Console.WriteLine("9 - Ataque especial");

int escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 0:
        Console.WriteLine("Você fugiu do monstro!");
        break;

    case 1:
        Console.WriteLine("Você atacou com um graveto porem não foi tão eficaz! O monstro te pegou!");
        break;

    case 2:
        Console.WriteLine("Você lançou uma magia poderosa! E derrotou o monstro com sucesso!");
        break;

    case 3:
        Console.WriteLine("Após utilizar seu escudo, você corre e sobrevive!");
        break;

    case 4:
        Console.WriteLine("Você usou uma poção de cura, o monstro fica com medo de você estar forte demais e foje!");
        break;

    case 5:
        Console.WriteLine("Você gritou por ajuda porem ninguem ouviu! -999 aura");
        break;

    case 6:
        Console.WriteLine("Você jogou uma pedra no monstro e ele te atacou de volta! (O que esperou que fosse acontecer com uma pedra?)");
        break;

    case 7:
        Console.WriteLine("Você tentou conversar com o monstro... porem ele não entende e te ataca!");
        break;

    case 8:
        Console.WriteLine("Você disparou uma flecha que acertou em cheio no monstro!");
        break;

    case 9:
        Console.WriteLine("Você usou um ataque especial, porem errou e morreu...");
        break;

    default:
        Console.WriteLine("Ação inválida! Por favor insira um numero entre 0 e 10");
        break;
}