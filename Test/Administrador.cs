namespace Test;

public class Administrador: Empregado
{
    private double ajudasdecusto;
    public Administrador(string nome, int idade, double altura, char sexo, double salario,double ajudasdecusto) : base(nome, idade, altura, sexo, salario)
    {
        this.ajudasdecusto = ajudasdecusto;
    }
    public double AjudasdeCusto
    {
        get => ajudasdecusto;
        set => ajudasdecusto = value;
    }
    override public double ObterLucros()
    {
        return(salario+ajudasdecusto);
    }
}