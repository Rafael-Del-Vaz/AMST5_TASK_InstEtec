Console.WriteLine("Digite o seu nome");
string? Nome = (Console.ReadLine());

Console.WriteLine("Digite o ano da sua matricula");
int Ano = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de horas que você tem");
int Horas = int.Parse(Console.ReadLine());

EtecAms AMS = new EtecAms(Nome, Ano, Horas, 200);
EtecTecnico TECNICO = new EtecTecnico(Nome, Ano, Horas);

Console.WriteLine("Escolha uma Etec (TECNICO ou AMS)");
string Etec = (Console.ReadLine());

if (Etec?.ToLower() == "ams")
{
    AMS.ShowAMS();
    Console.WriteLine($"Apenas os alunos do AMS têm a obrigatoriedade de completar {AMS.HorasObrigatorias} horas no curso.");

}
else
if (Etec?.ToLower() == "tecnico")
{
    TECNICO.ShowTecnico();
}
else
{
    Console.WriteLine("Etec não identificada");
}


