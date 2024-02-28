int n, ant_d, suce_t, soma;

Console.WriteLine("Escreva um número:");
n= int.Parse(Console.ReadLine());

ant_d = (n * 2) - 1;
suce_t = (n * 3) + 1;
soma= ant_d + suce_t;

Console.WriteLine("Soma= {0}", soma);
