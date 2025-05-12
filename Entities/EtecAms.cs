class EtecAms : Instituicao 
{
    public int HorasObrigatorias {get; private set;}
    public EtecAms (string nomeAluno, int anoMatricula, int horasCurso, int horasObrigatorias)
    {
        NomeAluno = nomeAluno;
        AnoMatricula = anoMatricula;
        HorasCurso = horasCurso;
        HorasObrigatorias = horasObrigatorias;
    }
}