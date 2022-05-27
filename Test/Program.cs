using System.Transactions;
using Test;
List<Fornecedor> lforn = new List<Fornecedor>();
List<Empregado> lemp = new List<Empregado>();
List<Administrador> ladmin = new List<Administrador>();

menuinicio:
Console.Clear();
Console.WriteLine("\t****MENU****");
Console.WriteLine("1- Fornecedores\n" +
                  "2- Empregados\n" +
                  "3- Administradores\n" +
                  "4- Resumo Todos\n" +
                  "0- Sair");
var m = Int16.Parse(Console.ReadLine());

if (m < 0 || m > 4)
{
    Console.Clear();
    goto menuinicio;
}
else
{
    switch (m)
    {
        case 0:
            Console.WriteLine("*ADEUS*");
            Environment.Exit(0);
            break;
        case 1:
            goto menufornecedor;
        case 2:
            goto menuempregado;
        case 3:
            goto menuadministrador;
        case 4:
            goto menutodos;
    }
    goto menuinicio;
}
menutodos://--------------------------------------------------------------------
Console.Clear();
string esp = "     ";

Console.WriteLine("\t***Todas as Pessoas***");
Console.WriteLine("\nFornecedores:");
if (lforn.Count > 0)
{
    foreach (var f in lforn)
    {
        Console.WriteLine(esp+f.Nome+"; Saldo: €"+(f.CreditoMaximo-f.ValoremDivida));
    }
}
else {Console.WriteLine(esp+"Sem Fornecedores");}

Console.WriteLine("\nEmpregados:");
if (lemp.Count > 0)
{
    foreach (var e in lemp)
    {
        Console.WriteLine(esp+e.Nome+"; Salario: €"+e.Salario);
    }
}
else {Console.WriteLine(esp+"Sem Empregados");}

Console.WriteLine("\nAdministradores:");
if (ladmin.Count > 0)
{
    foreach (var a in ladmin)
    {
        Console.WriteLine(esp+a.Nome+"; Salario: €"+a.Salario+"; Ajudas: €"+a.AjudasdeCusto);
    }
}
else {Console.WriteLine(esp+"Sem Administradore");}

Console.WriteLine("\n\t** PRIMA ENTER PARA REGRESSAR AO MENU INICIAL **");
Console.ReadLine();
goto menuinicio;

menufornecedor://---------------------------------------------------------------------------
Console.Clear();
Console.WriteLine("\t***Fornecedores***");
Console.WriteLine("1- Criar\n" +
                  "2- Pesquisar/Alterar\n" +
                  "3- Ver Todos\n" +
                  "4- Saldo Negativo\n" +
                  "0- Sair");
m = Int16.Parse(Console.ReadLine());
string nomef = "";
string nf1;
char sn;
int posicao=-1;

if (m < 0 || m > 3)
{
    Console.Clear();
    goto menufornecedor;
}
else
{
    switch (m)
    {
        case 0:
            goto menuinicio;
        case 1:
            goto criarf;
        case 2:
            goto alterarf;
        case 3:
            Console.Clear();
            break;
        case 4:
            Console.Clear();
            break;
    }
}
criarf://**********************************
posicao = -1;
Console.Clear();
Console.WriteLine("\t**Novo Fornecedor**");
Console.WriteLine("Nome: ");
nomef=Console.ReadLine();
nf1 = nomef.ToUpper();

if (lforn.Count > 0)
{
    foreach (var f1 in lforn)
    {
        posicao++;
        string nf2 = f1.Nome.ToUpper();
        if (nf1 == nf2)
        {ask1:
            Console.WriteLine(f1.Nome," Já existe, Alterar??? (S/N)");
            sn = (Convert.ToChar(Console.ReadLine()));
            sn= Char.ToUpper(sn);
            if (sn!='S'&& sn!='N') {goto ask1;}
            else if (sn == 'N')
            {
                goto menufornecedor;
            }
            else
            {Console.Clear();
                Console.WriteLine("\t**Pesquisar/Alterar Fornecedor**");
                Console.WriteLine("Nome: "+f1.Nome);
                goto alterar;}
        };
    }
}
criar:
Console.WriteLine("Idade: ");
int idadef=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Altura: ");
double alturaf=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Sexo: M/F");
char sexof = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Maximo Credito: ");
double creditof=Convert.ToDouble(Console.ReadLine());
Fornecedor forn = new Fornecedor(nomef, idadef, alturaf, sexof, creditof, 0);
lforn.Add(forn);
ask:
Console.WriteLine("\t* Criar Outro? S/N *");
sn = (Convert.ToChar(Console.ReadLine()));
sn= Char.ToUpper(sn);
if (sn!='S'&& sn!='N') {goto ask;}
else if (sn == 'N')
{
    goto menufornecedor;
}
else
{ goto criarf;}
            
alterarf://*******************************************
bool boolpos = true;
posicao = -1;
Console.Clear();
Console.WriteLine("\t**Pesquisar/Alterar Fornecedor**");
Console.WriteLine("Nome: ");
nomef = Console.ReadLine();
nf1 = nomef.ToUpper();

if (lforn.Count > 0)
{
    foreach (var f2 in lforn)
    {
        posicao++;
        string nf2 = f2.Nome.ToUpper();
        if (nf1 == nf2)
        {
            boolpos = false;
            goto alterarf;
        }
    }
}
if (boolpos)
{
    ask2:
    Console.WriteLine(nomef, " Não existe, Criar Novo??? (S/N)");
    sn = (Convert.ToChar(Console.ReadLine()));
    sn = Char.ToUpper(sn);
    if (sn != 'S' && sn != 'N')
    {
        goto ask2;
    }
    else if (sn == 'N')
    {
        goto menufornecedor;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("\t**Novo Fornecedor**");
        Console.WriteLine("Nome: " + nomef);
        goto criar;
    } 
}
alterar:
string space = "                    ";//20
//int spi = Convert.ToString(lforn[posicao].Altura).Length -20;
Console.WriteLine("Idade: "+lforn[posicao].Idade+ space.Substring(0,Convert.ToString(lforn[posicao].Idade).Length -20)+
                  "| Escolha 1 para alterar.");
Console.WriteLine("Altura: "+lforn[posicao].Altura+ space.Substring(0,Convert.ToString(lforn[posicao].Altura).Length -20)+
                  "| Escolha 2 para alterar."););
Console.WriteLine("Sexo: "+lforn[posicao].Sexo);
Console.WriteLine("Limite Credito: "+lforn[posicao].CreditoMaximo+ space.Substring(0,Convert.ToString(lforn[posicao].CreditoMaximo).Length -20)+
                  "| Escolha 3 para alterar."););
Console.WriteLine("Valor em Divida: "+lforn[posicao].ValoremDivida+ space.Substring(0,Convert.ToString(lforn[posicao].ValoremDivida).Length -20)+
                  "| Escolha 4 para alterar."););
Console.WriteLine("Saldo: "+lforn[posicao].ObterSaldo());

Console.WriteLine("\n* Escolha o Campo a alterar ou 0 para SAIR*");
m = Int16.Parse(Console.ReadLine());
switch (m)
{
    case 0:
        goto menufornecedor;
    case 1:
        Console.WriteLine("Idade: ");
        lforn[posicao].Idade=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Nome: " + nomef);
        goto alterar;
    case 2:
        Console.WriteLine("Altura: ");
        lforn[posicao].Altura=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nome: " + nomef);
        goto alterar;
    case 3:
        Console.WriteLine("Credito Maximo: ");
        lforn[posicao].CreditoMaximo=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nome: " + nomef);
        goto alterar;
    case 4:
        Console.WriteLine("Valor da Divida :€"+lforn[posicao].ValoremDivida+" (adicione ou subtraia ao existente)");
        lforn[posicao].ValoremDivida+=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nome: " + nomef);
        goto alterar; 
    default:
        Console.WriteLine("Nome: " + nomef);
        goto alterar;
}
menuempregado://------------------------------------------------------------
goto menuinicio;

menuadministrador:
goto menuinicio;