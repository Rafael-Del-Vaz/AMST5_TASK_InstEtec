Console.WriteLine("Digite o seu nome");
string Nome = (Console.ReadLine());

Console.WriteLine("Digite o ano da sua matricula");
int Ano = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de horas que você tem");
int Horas = int.Parse(Console.ReadLine());

Instituicao AMS = new EtecAms(Nome, Ano, Horas, 200);
Instituicao TECNICO = new EtecTecnico(Nome, Ano, Horas);

Console.WriteLine("Escolha uma Etec (TECNICO ou AMS)");
string Etec = (Console.ReadLine());

if (Etec.ToLower() == "ams")
{
    Console.WriteLine("Nome dos alunos: " + AMS.NomeAluno);
    Console.WriteLine("Ano da matricula: " + AMS.AnoMatricula);
    Console.WriteLine("Horas do curso: " + AMS.HorasCurso);
    Console.WriteLine($"Apenas os alunos do AMS tem a obrigatoriadade de completar {AMS.HorasObrigatorias} horas no curso ");
}
else
if (Etec.ToLower() == "tecnico")
{
    Console.WriteLine("Nome dos alunos: " + TECNICO.NomeAluno);
    Console.WriteLine("Ano da matricula: " + TECNICO.AnoMatricula);
    Console.WriteLine("Horas do curso: " + TECNICO.HorasCurso);
}
else
{
    Console.WriteLine("Etec não identificada");
}


