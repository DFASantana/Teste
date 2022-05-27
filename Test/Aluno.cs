namespace Test;

public class Aluno: Pessoa
{
    public Aluno(string nome) : base(nome) {} //-> mantem variaveis e construçao da classe Mae

    override public void Oquesou() //-> Altera o metodo existente na Classe Mãe com overrride
    {
        Console.WriteLine(nome+" é um aluno");
    }
}