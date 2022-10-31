using ByteBank.Entities;

var cc = new ContaCorrente(21, "1010-X", new Titular("Zeca da Quitanda", "123456", "Comerciante"));
var cc2 = new ContaCorrente(3, "2129-0", new Titular("Maria da Paz", "999666777", "Advogada"));

Console.WriteLine(cc);

cc.Depositar(1001.0);

if (cc.Sacar(5000.0))
{
    Console.WriteLine("Saque realizado!");
}
else
{
    System.Console.WriteLine("Hmmmmmm, algo deu errado. A operação de saque não foi realizada.");
};

if (cc.Transferir(2500.0, cc2))
{
    System.Console.WriteLine("Valor transferido com sucesso!");
}
else
{
    System.Console.WriteLine("Hmmmmmm, algo deu errado. A operação de transferência não foi realizada.");
};

System.Console.WriteLine(cc);
System.Console.WriteLine(cc2);

Console.WriteLine($"{ContaCorrente.TotalDeContasCriadas} contas");