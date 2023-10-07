using NewTalents;

namespace TestNewTalents;

public class CalculadoraTest
{

    public Calculadora construirClasse(){
        Calculadora calc = new Calculadora();

        return calc;
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (5, 4, 9)]
    public void TesteSomar(int num1, int num2, int resultado)
    {
       Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.Somar(num1,num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (5, 4, 20)]
    public void TesteMultiplicar(int num1, int num2, int resultado)
    {
       Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.Multiplicar(num1,num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (5, 2, 3)]
    [InlineData (5, 4, 1)]
    public void TesteSubtracao(int num1, int num2, int resultado)
    {
       Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.Subtrair(num1,num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (10, 2, 5)]
    [InlineData (8, 4, 2)]
    [InlineData (10, 5, 2)]
    [InlineData (20, 10, 2)]
    public void TesteDivisao(int num1, int num2, int resultado)
    {
       Calculadora calc = construirClasse();



        int resultadoCalculadora = calc.Dividir(num1,num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TesteDivisaoPorZero()
    {
       Calculadora calc = construirClasse();

        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
    }

     [Fact]
    public void TesteHistorico()
    {
       Calculadora calc = construirClasse();

        calc.Somar(1,2);
        calc.Somar(1,3);
        calc.Somar(1,4);
        calc.Somar(1,5);

        List<string> lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }


}