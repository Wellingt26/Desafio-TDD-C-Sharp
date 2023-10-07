namespace NewTalents;

public class Calculadora
{

  private List<string>listaHistorico;

  public Calculadora(){
    listaHistorico = new List<string>();
  }

  public int Somar(int num1, int num2){
    int res = num1 + num2;
    listaHistorico.Insert(0, "Resultado da soma é: " + res);
    return res;
  }

  public int Subtrair(int num1, int num2){
    int res = num1 - num2;
    listaHistorico.Insert(0, "Resultado da subtração é: " + res);
    return res;
  }

  public int Multiplicar(int num1, int num2){
    int res = num1 * num2;
    listaHistorico.Insert(0, "Resultado da multiplicação: " + res);
    return res;
  }

  public int Dividir(int num1, int num2){
    int res = num1 / num2;
    listaHistorico.Insert(0, "Resultado da divisão: " + res);
    return res;
  }

  public List<string> Historico(){
    return listaHistorico.GetRange(0, 3);
  }
}
