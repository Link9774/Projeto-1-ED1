public class Medico
{
public string Nome { get; set; }
public string Especialidade { get; set; }
public string Disponibilidade { get; set; }

    public Medico(string nome, string especialidade, string disponibilidade)
    {
        Nome = nome;
        Especialidade = especialidade;
        Disponibilidade = disponibilidade;
    }
    public override string ToString()
    {
        return $"Nome: {Nome} | Especialidade: {Especialidade} | Disponibilidade: {Disponibilidade}";
    }
}
public class Paciente
{
    public string Nome { get; set;}
    public int Idade { get; set; }
    public string HistoricoMedico { get; set; }
    public DateTime DataConsulta{ get; set; }

    public Paciente(string nome, int idade, string historicoMedico, DateTime dataConsulta)
    {
        Nome = nome;
        Idade = idade;
        HistoricoMedico = historicoMedico;
        DataConsulta = dataConsulta;
    }
}
public class Mesa
{
    public int NumMesa { get; set; }
    public string NomeCliente { get; set; }
    public string Status { get; set; }
    
    public Mesa(int numMesa, string nomeCliente, string status)     
    {
        NumMesa = numMesa;
        NomeCliente = nomeCliente;
        Status = status;
    }
}