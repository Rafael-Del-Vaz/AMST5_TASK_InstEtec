abstract class Instituicao{
    public void ShowAMS(){
    Console.WriteLine($"Nome do aluno: {NomeAluno}");
    Console.WriteLine($"Ano da matrícula: {AnoMatricula}");
    Console.WriteLine($"Horas do curso: {HorasCurso}");
    }
    public void ShowTecnico(){
    Console.WriteLine($"Nome do aluno: {NomeAluno}");
    Console.WriteLine($"Ano da matrícula: {AnoMatricula}");
    Console.WriteLine($"Horas do curso: {HorasCurso}");
    }
    
    public string? NomeAluno {get; protected set;}
    public int AnoMatricula {get; protected  set;}
    public int HorasCurso {get; protected set;}
}

