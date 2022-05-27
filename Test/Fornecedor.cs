namespace Test;

public class Fornecedor: Pessoa
{
    private double creditomaximo;
    private double valoremdivida;

    public Fornecedor(string nome, int idade, double altura, char sexo,double creditomaximo,double valoremdivida) : base(nome, idade, altura, sexo)
    {
        this.creditomaximo = creditomaximo;
        this.valoremdivida = valoremdivida;
    }
    public double CreditoMaximo
    {
        get => creditomaximo;
        set => creditomaximo = value;
    }
    public double ValoremDivida
    {
        get => valoremdivida;
        set => valoremdivida = value;
    }
    public double ObterSaldo()
    {
        return(creditomaximo-valoremdivida);
    }

    /*public void NovoF()
    {List<Fornecedor> lforn = new List<Fornecedor>();
        Console.WriteLine("Nome: ");
        string nomef=Console.ReadLine();
        Console.WriteLine("Idade: ");
        int idadef=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Altura: ");
        double alturaf=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Sexo: M/F");
        char sexof = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Maximo Credito: ");
        double creditof=Convert.ToDouble(Console.ReadLine());
        Fornecedor f = new Fornecedor(nomef, idadef, alturaf, sexof, creditof, 0);
        lforn.Add(f);
    }*/
}