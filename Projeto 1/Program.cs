
 class Program
 {
    static string welcome = "Bem vindo ao HealthMax, nosso aplicativo de gestão clínica";

    static LinkedList listaMedicos = new LinkedList();
    static LinkedList listaEspecializacao = new LinkedList();
    static LinkedList listaDisponibilidade = new LinkedList();

    static LinkedList listaPacientes = new LinkedList();
    static LinkedList listaIdade = new LinkedList();
    static LinkedList listaHistorico = new LinkedList();
    static LinkedList listaUltimaConsulta = new LinkedList();
    
    static DoubleLinkedList lista
    
    
    
    
    
    
    
    
    static void ExibirLogo()
    {
        Console.WriteLine(@" ＨｅａｌｔｈＭａｘ");
        Console.WriteLine(welcome);
    }

    static void Menu()
    {
        ExibirLogo();
        Console.Clear();
        Console.WriteLine("Digite 1 para Médicos");
        Console.WriteLine("Digite 2 para Pacientes");
        Console.WriteLine("Digite 3 para Restaurante");
        Console.WriteLine("Digite 4 para Eventos");
        Console.WriteLine("Digite 0 para Sair");

        Console.Write("\nDigite sua opção ");
        string opcaoEscolhida = Console.ReadLine();
        int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);
        switch (opcaoEscolhidaNum)
        {
            case 1:
                RegistroMedicos();
                break;
            case 2:
                RegistroPacientes();
                break;
            case 3:
                MenuRestaurante();
                break;
            case 4:
                MenuEventos();
                break;
            case 0:
                Console.WriteLine("Obrigado pela preferencia, até breve");
                break;
            default:
                Console.WriteLine("Opcão invalida, escolha uma opção valida");
                break;
        }
    }

    static void RegistroMedicos()
    {
         Console.Clear();
        Console.WriteLine("Digite 1 para registrar um médico");
        Console.WriteLine("Digite 2 para mostrar registro médico");
        Console.WriteLine("Digite 3 para mostrar médicos especificos");
        Console.WriteLine("Digite 4 para remover um médico");
        Console.WriteLine("Digite 0 para voltar ao menu");
        Console.WriteLine("\nDigite sua opção ");
        string opcaoEscolhida = Console.ReadLine();
        int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaNum)
        {
            case 1:
                RegistrarMedicos();
                break;
            case 2:
                MostrarListaDeMedicos();
                break;
            case 3:
                MedicoEspecificos();
                break;
            case 4:          
                RemoverMedico();
                break;
            case 0:
                Menu();
                break;
        }
    }

    static void RegistrarMedicos()
    {
        Console.Clear();
        Console.Write("Digite o nome e o sobrenome do médico: ");

        string nomeDoMedico = Console.ReadLine();
        listaMedicos.Add(nomeDoMedico);

        Console.WriteLine($"O médico {nomeDoMedico} foi registrado");

        Console.Write("Digite a especialidade do médico: ");
        string especialidade = Console.ReadLine();
        listaEspecializacao.Add(especialidade);
        Console.WriteLine($"Especialização {especialidade} registrada");

        Console.Write("Digite a disponibilidade do médico: ");
        string disponibilidade = Console.ReadLine();
        listaDisponibilidade.Add(disponibilidade);
        Console.WriteLine($"Disponibilidade {disponibilidade} registrada");

        RegistroMedicos();
    }
    static void MostrarListaDeMedicos()
    {
        Console.Clear();
        Console.WriteLine("**************************");
        Console.WriteLine("Exibindo registro médico");
        Console.WriteLine("**************************");

        for (int i = 0; i < listaMedicos.Count(); i++)
        {
            Console.WriteLine($"Médico: {listaMedicos.GetAt(i)} | Especialidade: {listaEspecializacao.GetAt(i)} | Disponibilidade: {listaDisponibilidade.GetAt(i)}");
        }

        Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu de médicos");
        Console.ReadKey();
        RegistroMedicos();
    }

    static void RemoverMedico()
    {
        Console.Clear();
        Console.WriteLine("Digite o nome do médico que deseja remover");
        string nomeDoMedico = Console.ReadLine();

        int index = listaMedicos.IndexOf(nomeDoMedico);
        if (index != -1)
        {
            listaMedicos.Remove(nomeDoMedico);
            listaEspecializacao.Remove(listaEspecializacao.GetAt(index));
            listaDisponibilidade.Remove(listaDisponibilidade.GetAt(index));
            Console.WriteLine($"\nMédico {nomeDoMedico} removido com sucesso");
        }
        else
        {
            Console.WriteLine($"\nMédico {nomeDoMedico} não encontrado");
        }

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu de médicos");
        Console.ReadKey();
        RegistroMedicos();
    }
    static void MedicoEspecificos(){
        Console.Clear();
        Console.WriteLine("Digite a especilização que você procura");
        string especialidade = Console.ReadLine();
    
        bool medicoEncontrado = false;
        for (int i = 0;i < listaMedicos.Count();i++){
            if (listaEspecializacao.GetAt(i).Equals(especialidade,StringComparison.OrdinalIgnoreCase)){
                 Console.WriteLine($"Médico: {listaMedicos.GetAt(i)} | Especialidade: {listaEspecializacao.GetAt(i)} | Disponibilidade: {listaDisponibilidade.GetAt(i)}");
                medicoEncontrado = true;        
            }

        }
        if(!medicoEncontrado){
            Console.WriteLine("Nenhum médico encontrado com essa especialidade.");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu de médicos");
            Console.ReadKey();
            RegistroMedicos();
    }

    static void RegistroPacientes()
    {
        Console.Clear();
        Console.WriteLine("Digite 1 para registrar um paciente");
        Console.WriteLine("Digite 2 para mostrar registro de pacientes");
        Console.WriteLine("Digite 3 para agendar uma consulta");
        Console.WriteLine("Digite 4 para remover um paciente");
        Console.WriteLine("Digite 0 para voltar ao menu");
        Console.WriteLine("\nDigite sua opção ");
        string opcaoEscolhida = Console.ReadLine();
        int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaNum){
            case 1: RegistrarPaciente();
                break;
            case 2: RegistroPaciente();
                break;
            case 3: AgendarConsulta();    
                break;
            case 4: RemoverPaciente();
                break;
            case 0:
                Menu();
                break; 
        }
    void RegistrarPaciente(){
        Console.Clear();
        Console.WriteLine("Digite o nome e sobrenome do paciente");

        string nomePaciente = Console.ReadLine();
        listaPacientes.Add(nomePaciente);
        Console.WriteLine($"O paciente {nomePaciente} foi registrado");

        int idadePaciente; 
        bool idadeValida = false;
       
        while(!idadeValida){
        Console.WriteLine("Digite a idade do paciente");    
        string idadePacienteS = Console.ReadLine();
        
            if(int.TryParse(idadePacienteS, out idadePaciente)){
                idadeValida = true;
                listaIdade.Add(idadePacienteS);
                Console.WriteLine($"Idade {idadePacienteS} foi registrada");
            }else{
                Console.WriteLine("Digite uma idade valida");
            }
        }
        Console.WriteLine("Digite o historico medico do paciente");        
        string historicoMedico = Console.ReadLine();
        listaHistorico.Add(historicoMedico);
        Console.WriteLine($"{historicoMedico} foi registrado");
        
        bool dataValida = false;
    DateTime dataConsulta;

    while (!dataValida){
    
        Console.WriteLine("Digite a data da consulta (dd/MM/yyyy)");        
        string dataConsultaS = Console.ReadLine();

        if (DateTime.TryParseExact(dataConsultaS, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataConsulta)){
        
            dataValida = true;
            listaUltimaConsulta.Add(dataConsultaS);
            Console.WriteLine($"{dataConsultaS} foi registrado");
        }
        else{
            Console.WriteLine("Digite uma data válida no formato dd/MM/yyyy");
        }
        RegistroPacientes();
    }

    }
    static void RegistroPaciente(){
        Console.Clear();
        Console.WriteLine("*******************************");
        Console.WriteLine("Exibindo registro de pacientes");
        Console.WriteLine("*******************************");

        for(int i = 0; i < listaPacientes.Count();i++){
            Console.WriteLine($"Paciente: {listaPacientes.GetAt(i)} | Idade: {listaIdade.GetAt(i)} | Historico medico: {listaHistorico.GetAt(i)} | Ultima consulta: {listaUltimaConsulta.GetAt(i)}");
        }
        Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu de pacientes");
        Console.ReadKey();
        RegistroPacientes();
    }
    static void AgendarConsulta(){
        Console.Clear();
        Console.WriteLine("Digite o nome do paciente para agendar uma nova consulta:");
        string nomePaciente = Console.ReadLine();
        int index = listaPacientes.IndexOf(nomePaciente);
        if(index != -1){
            bool dataValida = false;
            DateTime novaDataConsulta;

            while (!dataValida){
                Console.WriteLine("Digite a nova data da consulta (dd/MM/yyyy:)");
                string novaDataConsultaS = Console.ReadLine();
                if(DateTime.TryParseExact(novaDataConsultaS, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out novaDataConsulta)){
                    dataValida = true;
                    listaUltimaConsulta.ReplaceAt(index, novaDataConsultaS);

                    Console.WriteLine($"A nova data da consulta para {nomePaciente} foi registrada");
                    RegistroPacientes();
                }else{
                    Console.WriteLine("Digite uma data válida no formato dd/MM/yyyy.");
                }
            }
        
        }else {
            Console.WriteLine($"Paciente {nomePaciente} não encontrado");
            AgendarConsulta();
        }

    }
    static void RemoverPaciente(){
        Console.Clear();
        Console.WriteLine("Digite o nome do paciente que deseja remover");
        string nomePaciente = Console.ReadLine();

        int index = listaPacientes.IndexOf(nomePaciente);
        if (index != -1)
        {
            listaPacientes.Remove(nomePaciente);
            listaIdade.Remove(listaIdade.GetAt(index));
            listaHistorico.Remove(listaHistorico.GetAt(index));
            listaUltimaConsulta.Remove(listaUltimaConsulta.GetAt(index));
            Console.WriteLine($"\nPaciente {nomePaciente} removido com sucesso");
        }
        else
        {
            Console.WriteLine($"\nPaciente {nomePaciente} não encontrado");
        }

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu de pacientes");
        Console.ReadKey();
        RegistroPacientes();
    }

    }
    static void MenuRestaurante()
    {
        Console.Clear();
        Console.WriteLine("Digite 1 para gerenciar mesas");
        Console.WriteLine("Digite 2 para mostrar registro de pacientes");
        Console.WriteLine("Digite 3 para agendar uma consulta");
        Console.WriteLine("Digite 4 para remover um paciente");
        Console.WriteLine("Digite 0 para voltar ao menu");
        Console.WriteLine("\nDigite sua opção ");
        string opcaoEscolhida = Console.ReadLine();
        int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaNum){
           // case 1: GerenciarMesas();
             //   break;
            case 2:
                break;    
        }
        //static void GerenciarMesas
    
    
    
    
    
    
    
    }
   
   
   
   
   
   
   
   
   static void MenuEventos()
   {
Console.Clear();
        Console.WriteLine("Digite 1 para registrar um paciente");
        Console.WriteLine("Digite 2 para mostrar registro de pacientes");
        Console.WriteLine("Digite 3 para agendar uma consulta");
        Console.WriteLine("Digite 4 para remover um paciente");
        Console.WriteLine("Digite 0 para voltar ao menu");
        Console.WriteLine("\nDigite sua opção ");
        string opcaoEscolhida = Console.ReadLine();
        int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);
   }
   
    static void Main(string[] args)
    {
        ExibirLogo();
        Menu();
    }
}