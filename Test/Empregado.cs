namespace Test;

public class Empregado: Pessoa
{
    protected double salario;

    public Empregado(string nome, int idade, double altura, char sexo, double salario) : base(nome, idade, altura, sexo)
    {
        this.salario = salario;
    }
    public double Salario
    {
        get => salario;
        set => salario = value;
    }
    public virtual double ObterLucros()
    {
        return(salario);
    }
}