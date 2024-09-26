using atividade_contabancaria;

var conta = new Conta("12323-6", "Yuri Alberto");

conta.Depositar(500.0m);

try
{
    conta.Sacar(600.0m);
}
catch (SaldoInsuficienteException e)
{
    Console.WriteLine(e.Message);
}

try
{
    conta.Sacar(200.0m);
}
catch (SaldoInsuficienteException e)
{
    Console.WriteLine(e.Message);
}