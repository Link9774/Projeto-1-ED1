
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
    
    static DoubleLinkedList listaMesas = new DoubleLinkedList();
    static LinkedList listaClientes = new LinkedList();
    static LinkedList listaStatus = new LinkedList();
    static LinkedList listaItem = new LinkedList();
    static DoubleLinkedList listaQuantidade = new DoubleLinkedList();
    static DoubleLinkedList listaValor = new DoubleLinkedList();
    
    static LinkedList listaEventos = new LinkedList();
    static CircularLinkedList listaDataEvento = new CircularLinkedList();
    static LinkedList listaLocal = new LinkedList();
    static LinkedList listaCapacidade = new LinkedList();
    
    static LinkedList listaParticipantes = new LinkedList();
    static DoubleLinkedList listNumParticipante = new DoubleLinkedList();
    static LinkedList listParticipanteEvento = new LinkedList();
    static Dictionary<int, string> participantesEventos = new Dictionary<int, string>();
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
       
        while(!idadeValida)
        {
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
        Console.WriteLine("Digite 2 para mostrar mesas");
        Console.WriteLine("Digite 3 para registrar conta");
        Console.WriteLine("Digite 4 para fechar conta");
        Console.WriteLine("Digite 0 para voltar ao menu");
        Console.WriteLine("\nDigite sua opção ");
        string opcaoEscolhida = Console.ReadLine();
        int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaNum){
           case 1: GerenciarMesa();
                break;
            case 2: MostrarMesas();
                break;    
            case 3: RegistrarConta();
                break;
            case 4: FecharConta();
                break;
            case 0: Menu();
                break;
        
        }
  static void GerenciarMesa()
  {
        Console.Clear();
        int numMesa; 
        bool numvalido = false;
       
        while(!numvalido){
        Console.WriteLine("Digite o numero da mesa");    
        string numMesaS = Console.ReadLine();
        
            if(int.TryParse(numMesaS, out numMesa))
            {
                numvalido = true;
                listaMesas.Add(numMesaS);
                Console.WriteLine($"Mesa {numMesaS} foi registrada");
            }else{
                Console.WriteLine("Digite um numero valida");
            }
        }
        Console.WriteLine("Digite o nome e sobrenome do cliente");

        string nomeCliente = Console.ReadLine();
        listaClientes.Add(nomeCliente);
        Console.WriteLine($"O cliente {nomeCliente} foi registrado");
    
        Console.WriteLine("Digite o status da mesa");

        string status = Console.ReadLine();
        listaStatus.Add(status);
        Console.WriteLine($"Status {status} registrado");
        MenuRestaurante();
  }
    static void MostrarMesas()
    {
        Console.Clear();
        Console.WriteLine("*****************");
        Console.WriteLine("Exibindo Mesas");
        Console.WriteLine("*****************");
    
        for(int i = 0; i < listaMesas.Count();i++){
            Console.WriteLine($"Mesa: {listaMesas.GetAt(i)} | Cliente: {listaClientes.GetAt(i)} | Status: {listaStatus.GetAt(i)}");
        }
        Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu do restaurante");
        Console.ReadKey();
        MenuRestaurante();    
    }
    static void RegistrarConta()
{
    Console.Clear();

    Console.WriteLine("Digite o número da mesa para registrar o pedido:");
    string numMesa = Console.ReadLine();

    int indexMesa = listaMesas.IndexOf(numMesa);
    if (indexMesa == -1)
    {
        Console.WriteLine("Mesa não encontrada.");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu do restaurante");
        Console.ReadKey();
        MenuRestaurante();
        return;
    }

    Console.WriteLine("Digite o nome do item");
    string nomeItem = Console.ReadLine();
    listaItem.Add(nomeItem);

    int quantidadeItem;
    bool quantidadeValida = false;
    while (!quantidadeValida)
    {
        Console.WriteLine("Digite a quantidade do item");
        string quantidadeItemS = Console.ReadLine();
        if (int.TryParse(quantidadeItemS, out quantidadeItem))
        {
            quantidadeValida = true;
            listaQuantidade.Add(quantidadeItemS);
        }
        else
        {
            Console.WriteLine("Digite uma quantidade válida.");
        }
    }

    double valorItem;
    bool valorValido = false;
    while (!valorValido)
    {
        Console.WriteLine("Digite o valor unitário do item:");
        string valorItemS = Console.ReadLine();
        if (double.TryParse(valorItemS, out valorItem))
        {
            valorValido = true;
            listaValor.Add(valorItemS);
        }
        else
        {
            Console.WriteLine("Digite um valor válido.");
        }
    }

    Console.WriteLine($"O item {nomeItem} foi registrado para a mesa {numMesa}.");
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu do restaurante");
    Console.ReadKey();
    MenuRestaurante();
}

    static void FecharConta()
{
    Console.Clear();
    Console.WriteLine("Digite o número da mesa que deseja fechar a conta:");
    string numeroMesa = Console.ReadLine();

    if (string.IsNullOrEmpty(numeroMesa))
    {
        Console.WriteLine("Número da mesa inválido. Por favor, tente novamente.");
        FecharConta();
        return;
    }

    if (!int.TryParse(numeroMesa, out int numMesa))
    {
        Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
        FecharConta();
        return;
    }

    int indexMesa = listaMesas.IndexOf(numeroMesa);
    if (indexMesa == -1)
    {
        Console.WriteLine("Mesa não encontrada.");
        FecharConta();
        return;
    }

    Console.Clear();
    Console.WriteLine($"Fechando a conta para a mesa {numeroMesa}");

    double valorTotal = 0;
    bool encontrouItens = false;

    for (int i = 0; i < listaMesas.Count(); i++)
    {
        string mesaAtual = listaMesas.GetAt(i);

        if (mesaAtual == numeroMesa)
        {
            string item = listaItem.GetAt(i);
            string quantidadeStr = listaQuantidade.GetAt(i);
            string valorStr = listaValor.GetAt(i);

            if (string.IsNullOrEmpty(item) || string.IsNullOrEmpty(quantidadeStr) || string.IsNullOrEmpty(valorStr))
            {
                Console.WriteLine("Dados inválidos encontrados. Verifique se todas as informações da mesa estão corretas.");
                FecharConta();
                return;
            }

            if (!double.TryParse(quantidadeStr, out double quantidade) || !double.TryParse(valorStr, out double valor))
            {
                Console.WriteLine("Erro ao processar os valores de quantidade ou preço. Verifique os dados.");
                FecharConta();
                return;
            }
            valorTotal += quantidade * valor;
            encontrouItens = true;

            Console.WriteLine($"Item: {item} | Quantidade: {quantidade} | Valor Unitário: {valor}");
            Console.WriteLine($"Mesa {numeroMesa} | Valor total {valorTotal}");
        }
    }

    if (!encontrouItens)
    {
        Console.WriteLine($"Nenhum item encontrado para a mesa {numeroMesa}.");
        FecharConta();
        return;
    }
   Console.WriteLine("\nPressione qualquer tecla para fechar a conta e remover a mesa.");
    Console.ReadKey();

    listaMesas.RemoveAt(indexMesa);
    listaClientes.RemoveAt(indexMesa);
    listaStatus.RemoveAt(indexMesa);
    listaItem.RemoveAt(indexMesa);
    listaQuantidade.RemoveAt(indexMesa);
    listaValor.RemoveAt(indexMesa);

    Console.WriteLine($"Conta da mesa {numeroMesa} fechada e mesa removida com sucesso.");

    Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
    Console.ReadKey();

    MenuRestaurante();
}

}  
   
   static void MenuEventos()
   {
Console.Clear();
        Console.WriteLine("Digite 1 para registrar um evento");
        Console.WriteLine("Digite 2 para inscrever participante");
        Console.WriteLine("Digite 3 para mostrar eventos");
        Console.WriteLine("Digite 4 para mostrar participantes");
        Console.WriteLine("Digite 5 para cancelar inscrição");
        Console.WriteLine("Digite 6 para cancelar evento");
        Console.WriteLine("Digite 0 para voltar ao menu");
        Console.WriteLine("\nDigite sua opção ");
        string opcaoEscolhida = Console.ReadLine();
        int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);
   
    switch (opcaoEscolhidaNum){
            case 1: RegistrarEvento();
                break;
            case 2: RegistrarParticipante();
                break;
            case 3: MonstrarEventos();    
                break;
            case 4: MostrarParticipantes();
                break;
            case 5: RemoverParticipante();
               break;
            case 6: CancelarEvento();    
                break;
            case 0:
                Menu();
                break; 
        }
    static void RegistrarEvento()
    {
        Console.Clear();
        Console.WriteLine("Digite o nome do evento");
        string nomeEvento = Console.ReadLine();
        listaEventos.Add(nomeEvento);
        Console.WriteLine($"Evento {nomeEvento} registrado");

           bool dataValida = false;
        DateTime dataEvento;

    while (!dataValida)
    {
    
        Console.WriteLine("Digite a data do Evento (dd/MM/yyyy)");        
        string dataEventoS = Console.ReadLine();

        if (DateTime.TryParseExact(dataEventoS, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataEvento)){
        
            dataValida = true;
            listaDataEvento.Add(dataEventoS);
            Console.WriteLine($"{dataEventoS} foi registrado");
        }
        else{
            Console.WriteLine("Digite uma data válida no formato dd/MM/yyyy");
            
        }
        
    }
     Console.WriteLine("Digite o nome do local do evento");
        string local = Console.ReadLine();
        listaLocal.Add(local);
        Console.WriteLine($"Local {local} registrado");

        int capacidade;
    bool capacidadeValida = false;
    while (!capacidadeValida)
    {
        Console.WriteLine("Digite a capacidade");
        string capacidadeS = Console.ReadLine();
        if (int.TryParse(capacidadeS, out capacidade))
        {
            capacidadeValida = true;
            listaCapacidade.Add(capacidadeS);
        }
        else
        {
            Console.WriteLine("Digite uma capacidade válida.");
            
        }
        
    }
    MenuEventos();
    }
   static void RegistrarParticipante()
{
    Console.Clear();
    Console.WriteLine("Digite o nome do participante");
    string nomeParticipante = Console.ReadLine();

    listaParticipantes.Add(nomeParticipante);
    Console.WriteLine($"Participante {nomeParticipante} registrado");

      int numParticipante;
    bool NumValida = false;
    while (!NumValida)
    {
        Console.WriteLine("Digite o número do participante");
        string numParticipanteS = Console.ReadLine();
        if (int.TryParse(numParticipanteS, out numParticipante))
        {
            NumValida = true;
            listNumParticipante.Add(numParticipanteS);
            Console.WriteLine($"Número {numParticipante} registrado");
        }
        else
        {
            Console.WriteLine("Digite um número válido.");
            
        }
}
        Console.WriteLine("Digite o evento que o participante se inscreveu");
        string participanteEvento = Console.ReadLine();
        listParticipanteEvento.Add(participanteEvento);
        Console.WriteLine($"Evento {participanteEvento} registrado");
        Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu de eventos");
        Console.ReadKey();
        MenuEventos();
    }    
   static void MonstrarEventos()
   {
        Console.Clear();
        Console.WriteLine("*****************************");
        Console.WriteLine("Exibindo registro de eventos");
        Console.WriteLine("*****************************");

        for(int i = 0; i < listaEventos.Count();i++){
            Console.WriteLine($"Evento: {listaEventos.GetAt(i)} | Local: {listaLocal.GetAt(i)} | Capacidade: {listaCapacidade.GetAt(i)} | Data: {listaDataEvento.GetAt(i)}");
        }
        Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu de eventos");
        Console.ReadKey();
        MenuEventos();
   }
   static void MostrarParticipantes()
{
    Console.Clear();
    Console.WriteLine("***********************");
    Console.WriteLine("Exibindo Participantes");
    Console.WriteLine("***********************");

    for (int i = 0; i < listaParticipantes.Count(); i++)
    {
        Console.WriteLine($"Nome do participante: {listaParticipantes.GetAt(i)} | Número do participante: {listNumParticipante.GetAt(i)} | Evento: {listParticipanteEvento.GetAt(i)}");  
        }
        Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu de eventos");
        Console.ReadKey();
        MenuEventos();
}
   
   static void RemoverParticipante()
{
    Console.Clear();
    Console.WriteLine("Digite o número do participante que deseja remover:");
    string numeroInscricaoInput = Console.ReadLine();

    if (int.TryParse(numeroInscricaoInput, out int numeroInscricao))
    {
        int index = numeroInscricao - 1;

        if (index >= 0 && index < listaParticipantes.Count())
        {
            string nomeParticipante = listaParticipantes.GetAt(index);

            listaParticipantes.RemoveAt(index);
            Console.WriteLine($"Participante {nomeParticipante} removido.");

            listNumParticipante.RemoveAt(index);
            Console.WriteLine($"Número de inscrição {numeroInscricao} removido.");

            if (index < listParticipanteEvento.Count())
            {
                listParticipanteEvento.RemoveAt(index);
                Console.WriteLine($"Inscrição no evento removida.");
            }

            Console.WriteLine("Remoção concluída.");
        }
        else
        {
            Console.WriteLine("Número de inscrição inválido.");
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor, insira um número.");
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de eventos");
    Console.ReadKey();
    MenuEventos();
}
   static void CancelarEvento()
{
    Console.Clear();
    Console.WriteLine("Digite o nome do evento que deseja cancelar:");
    string nomeEvento = Console.ReadLine();

    if (listaEventos.Contains(nomeEvento))
    {
        int indexEvento = listaEventos.IndexOf(nomeEvento);

        listaEventos.RemoveAt(indexEvento);
        listaDataEvento.RemoveAt(indexEvento);
        listaLocal.RemoveAt(indexEvento);
        listaCapacidade.RemoveAt(indexEvento);

        Console.WriteLine($"Evento {nomeEvento} cancelado e removido.");
    }
    else
    {
        Console.WriteLine("Evento não encontrado.");
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de eventos");
    Console.ReadKey();
    MenuEventos();
}
   
   }
   
    static void Main(string[] args)
    {
        ExibirLogo();
        Menu();
    }
}