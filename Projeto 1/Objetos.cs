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
public class Itens
{
    public string NomeItem { get; set; }
    public int Quantidade { get; set; }
    public float Valor{ get; set; }

    public Itens(string nomeItem, int quantidade,float valor)
    {
        NomeItem = nomeItem;
        Quantidade = quantidade;
        Valor = valor;
    }

}
public class Eventos
{
public string NomeEvento { get; set; }
public string LocalEvento { get; set; }
public DateTime DataEvento { get; set; }
public int Capacidade { get; set; }
public Eventos(string nomeEvento,string localEvento,DateTime dataEvento,int capacidade)
{
    NomeEvento = nomeEvento;
    LocalEvento = localEvento;
    DataEvento = dataEvento;
    Capacidade = capacidade;
}
}
public class Participantes
{
public string NomeParticipante { get; set; }
public int NumInscricao { get; set; }
public string EventoPartipando { get; set; }

public Participantes(string nomeParticipante,int numInscricao,string eventoPartipando)
{
    NomeParticipante = nomeParticipante;
    NumInscricao = numInscricao;
    EventoPartipando = eventoPartipando;
}
}