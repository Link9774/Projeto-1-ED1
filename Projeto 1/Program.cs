//Projeto-1
string welcome = "Bem vindo ao HealthMax, nosso aplicativo de gestão clínica";
List<string> listaMedicos = new List<string>{ "Marcelo Silva", "Josuke Higashikata", "Giorno Giovanna"};
List<string> listaEspecializacao = new List<string>{ "Cardiologista", "Cirurgião", "Clinico Geral"};
List<string> listaDisponibilidade = new List<string>{ "Segunda,Terça, Quarta, Quinta, Sexta", "Quarta,Quinta e Sexta", "Terça, Quarta e Quinta"};

void ExibirLogo(){
    Console.WriteLine(@" ＨｅａｌｔｈＭａｘ");
    Console.WriteLine(welcome);
}
void Menu(){
    ExibirLogo();
    Console.WriteLine("Digite 1 para Médicos");
    Console.WriteLine("Digite 2 para Pacientes");
    Console.WriteLine("Digite 3 para Restaurante");
    Console.WriteLine("Digite 4 para Eventos");
    Console.WriteLine("Digite 0 para Sair");

    Console.Write("\nDigite sua opção ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNum){
        case 1:RegistroMedicos();
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 0:
            Console.WriteLine("Obrigado pela preferencia, até breve");
            Console.WriteLine("Você escolheu a opção "+ opcaoEscolhida);
            break;    
                 default: Console.WriteLine("Opcão invalida, escolha uma opção valida");
            break;
    }
}
void RegistroMedicos(){
    Console.WriteLine("Digite 1 para registrar um medico");
    Console.WriteLine("Digite 2 para mostrar medico e especialidade");
    Console.WriteLine("Digite 3 para mostrar disponibilidade");
    Console.WriteLine("Digite 0 para voltar ao menu");
    
    Console.WriteLine("\nDigite sua opção ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNum){
    case 1: RegistrarMedicos();
        break;
    case 2: MostrarListaDeMedicos();
        break;
    case 3:
        break;
    case 0:Console.WriteLine("Você escolheu a opção "+ opcaoEscolhida);
            Console.Clear();
            Menu();
        break;    
    }
    void RegistrarMedicos(){
        Console.Clear();
        Console.WriteLine("Registro dos Medicos");
        Console.Write("Digite o nome e o sobrenome do medico: ");
        string nomeDoMedico = Console.ReadLine()!;
        listaMedicos.Add(nomeDoMedico);
        Console.WriteLine($"O medico {nomeDoMedico} foi registrado");
        Thread.Sleep(2000);
        Console.Write("Digite a especialidade do medico: ");
        string especialidade = Console.ReadLine()!;
       listaEspecializacao.Add(especialidade);
       Console.WriteLine($"Especialização {especialidade} registrada") ;
        Thread.Sleep(2000);
         Console.Write("Digite a disponibilidade do medico: ");
        string disponibilidade = Console.ReadLine()!;
       listaDisponibilidade.Add(disponibilidade);
       Console.WriteLine($"Disponibilidade {disponibilidade} registrada") ;
        Thread.Sleep(2000);
        Console.Clear();
        RegistroMedicos();
    }
    void MostrarListaDeMedicos(){
        Console.Clear();
        Console.WriteLine("**************************");
        Console.WriteLine("Exibindo registro medico");
        Console.WriteLine("**************************");
        for (int i = 0;i <listaMedicos.Count; i++){
            Console.WriteLine($"Medico: {listaMedicos[i]}");
        }
        Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu de medicos");
        Console.ReadKey();
        RegistroMedicos();



    }



}

ExibirLogo();
Menu();