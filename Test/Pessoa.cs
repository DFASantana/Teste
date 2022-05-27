namespace Test;

public class Pessoa
{
    private string nome;
    private int idade;
    private double altura;
    private char sexo;
    
    public Pessoa(string nome,int idade,double altura,char sexo)
    {
        this.nome = nome;
        this.idade = idade;
        this.altura = altura;
        this.sexo = sexo;
    }
    public string Nome
    {
        get => nome;
        set => nome = value;
    }
    public int Idade
    {
        get => idade;
        set => idade = value;
    }
    public double Altura
    {
        get => altura;
        set => altura = value;
    }
    public char Sexo
    {
        get => sexo;
        set => sexo = value;
    }
    
}