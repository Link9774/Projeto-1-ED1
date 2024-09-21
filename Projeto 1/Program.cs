//Projeto-1
string welcome = "Bem vindo ao HealthMax, nosso aplicativo de gestão clínica";
List<string> listaMedicos = new List<string> { "Marcelo Silva", "Josuke Higashikata", "Giorno Giovanna" };
List<string> listaEspecializacao = new List<string> { "Cardiologista", "Cirurgião", "Clinico Geral" };
List<string> listaDisponibilidade = new List<string> { "Segunda,Terça, Quarta, Quinta, Sexta", "Quarta,Quinta e Sexta", "Terça, Quarta e Quinta" };

void ExibirLogo()
{
    Console.WriteLine(@" ＨｅａｌｔｈＭａｘ");
    Console.WriteLine(welcome);
}
void Menu()
{
    ExibirLogo();
    Console.WriteLine("Digite 1 para Médicos");
    Console.WriteLine("Digite 2 para Pacientes");
    Console.WriteLine("Digite 3 para Restaurante");
    Console.WriteLine("Digite 4 para Eventos");
    Console.WriteLine("Digite 0 para Sair");

    Console.Write("\nDigite sua opção ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNum)
    {
        case 1:
            RegistroMedicos();
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 0:
            Console.WriteLine("Obrigado pela preferencia, até breve");
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        default:
            Console.WriteLine("Opcão invalida, escolha uma opção valida");
            break;
    }
}
void RegistroMedicos()
{
    Console.WriteLine("Digite 1 para registrar um médico");
    Console.WriteLine("Digite 2 para mostrar registro médico");
    Console.WriteLine("Digite 3 para remover um médico");
    Console.WriteLine("Digite 0 para voltar ao menu");

    Console.WriteLine("\nDigite sua opção ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNum)
    {
        case 1:
            RegistrarMédicos();
            break;
        case 2:
            MostrarListaDeMedicos();
            break;
        case 3:
              RemoverMedico();


            break;
        case 0:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            Console.Clear();
            Menu();
            break;
    }
    void RegistrarMédicos()
    {

        Console.Clear();
        Console.WriteLine("Registro dos Médicos");
        Console.Write("Digite o nome e o sobrenome do médico: ");

        string nomeDoMedico = Console.ReadLine()!;
        listaMedicos.Add(nomeDoMedico);

        Console.WriteLine($"O médico {nomeDoMedico} foi registrado");
        Thread.Sleep(2000);
        Console.Write("Digite a especialidade do médico: ");
        string especialidade = Console.ReadLine()!;
        listaEspecializacao.Add(especialidade);
        Console.WriteLine($"Especialização {especialidade} registrada");

        Thread.Sleep(2000);

        Console.Write("Digite a disponibilidade do médico: ");
        string disponibilidade = Console.ReadLine()!;
        listaDisponibilidade.Add(disponibilidade);
        Console.WriteLine($"Disponibilidade {disponibilidade} registrada");
        Thread.Sleep(2000);
        Console.Clear();
        RegistroMedicos();
    }
    void MostrarListaDeMedicos()
    {
        Console.Clear();
        Console.WriteLine("**************************");
        Console.WriteLine("Exibindo registro médico");
        Console.WriteLine("**************************");
        for (int i = 0; i < listaMedicos.Count; i++){
        
             Console.WriteLine($"Médico: \n{listaMedicos[i]} | Especialidade: {listaEspecializacao[i]} | Disponibilidade: {listaDisponibilidade[i]}");  
        }
        Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu de médicos");
        Console.ReadKey();
        RegistroMedicos();
    }
    void RemoverMedico(){
        Console.Clear();
        Console.WriteLine("Digite o nome do médico que deseja remover");
        string nomeDoMedico = Console.ReadLine()!;
    
        int index = listaMedicos.IndexOf(nomeDoMedico);
    if(index != -1){
        listaMedicos.RemoveAt(index);
        listaEspecializacao.RemoveAt(index);
        listaDisponibilidade.RemoveAt(index);
        Console.WriteLine($"\nMédico {nomeDoMedico} removido com sucesso");
    }else{
        Console.WriteLine("\nMédico {nomeDoMedico} não encontrado");
    }
    
    }
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu de médicos");
    Console.ReadKey();
    RegistroMedicos();
}

ExibirLogo();
Menu();
