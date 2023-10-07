// See https://aka.ms/new-console-template for more information
using NewTalents;

Calculadora calc = new Calculadora();

calc.Somar(1,2);
calc.Dividir(4,2);
calc.Multiplicar(2,5);
calc.Subtrair(6,1);

List<string> list;

list = calc.Historico();

foreach (var item in list)
{
  Console.WriteLine(item);
};

Console.WriteLine(list.Count());
