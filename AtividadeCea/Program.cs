using System;


namespace AtividadeCea
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            //Variáveis da Questão 1:
            double peso;
            double altura;
            double imc;
            //Variáveis da Questão 2:
            double salarioMin;
            double salarioFunc;
            double quantidade;
            //Variáveis da Questão 3:
            double volume;
            double raio;
            //Variáveis da Questão 4:
            double nota1;
            double nota2;
            double nota3;
            double media;
            double nota4;
            //Variáveis da Questão 5:


            Console.WriteLine("Exércicios C# // C&A Fashion Devs");
            Console.WriteLine("Qual exercício deseja fazer?");
            Console.WriteLine("(1) Leitura de IMC");
            Console.WriteLine("(2) Salário Mínimo");
            Console.WriteLine("(3) Calcular o volume de uma esfera");
            Console.WriteLine("(4) Média das notas");
            Console.WriteLine("(5) Cachorros, Gatos & Peixes");

            Console.WriteLine("Digite sua opção de atividade: ");
            opcao = Convert.ToInt32(Console.ReadLine());


            switch (opcao) {

                case 1:
                    Console.WriteLine("### Vamos fazer uma avaliação do seu peso? ###");

                    Console.WriteLine("Qual o seu peso em Kg: ");
                    peso = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("Digite sua Altura em Cm: ");
                    altura = (Convert.ToDouble(Console.ReadLine()) /100) ;

                    Console.WriteLine(peso);
                    Console.WriteLine(altura);


                    imc = (peso / (altura*altura));

                    if (imc < 20)
                    {
                        Console.WriteLine("Você está abaixo do peso!");
                    } else if((imc >= 20) && (imc < 25)) 
                    {
                        Console.WriteLine("Você está no peso ideal!");
                    } else if(imc >= 25)
                    {
                        Console.WriteLine("Você está acima do peso!");
                    }
                    break;

                 case 2:
                    Console.WriteLine("### Sextou!!! E o salário caiu na conta! ###");

                    Console.WriteLine("Digite o valor do salário mínimo (R$1.192.40): ");
                    salarioMin = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite o valor do seu salário: ");
                    salarioFunc = Convert.ToDouble(Console.ReadLine());

                    quantidade = salarioFunc / salarioMin;
                    
                    if ( quantidade < salarioMin)
                    {
                        Console.WriteLine("O funcionário recebe menos que um salário mínimo");
                    } else
                    {
                        Console.WriteLine("O funcionário recebe " + Math.Round(quantidade) + " salários mínimos");
                    }
                    break;

                 case 3:
                    Console.WriteLine("### Vamos calcular o raio de uma esfera ###");

                    Console.WriteLine("Qual o valor do raio?");
                    raio = Convert.ToDouble(Console.ReadLine());

                    volume = 3 * (3.14 * Math.Pow(raio, 3)) / 4;

                    Console.WriteLine("O valor do volume é " + volume);
                    break;

                 case 4:
                    Console.WriteLine(" ### Olá aluno vamos calcular sua média? ###");

                    Console.WriteLine("Qual a sua primeira nota ( 0 a 10 )?");
                    nota1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Qual a sua segunda nota ( 0 a 10 )?");
                    nota2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Qual a sua terceira nota ( 0 a 10 )?");
                    nota3 = Convert.ToDouble(Console.ReadLine());


                    media = (nota1 + nota2 + nota3) / 3;

                    Console.WriteLine(media);
 

                    if (media >= 7) {
                        Console.WriteLine("Parabéns!! Você foi aprovado");
                    } else
                    {
                        Console.WriteLine("Você ficou de recuperação, qual a sua quarta nota ( 0 a 10 )?");
                        nota4 = Convert.ToDouble(Console.ReadLine());
                        double novaMedia = (nota4 + media) / 2;

                        Console.WriteLine(novaMedia);

                        if (novaMedia >= 5)
                        {
                            Console.WriteLine("Você passou na recuperação, foi por pouco né?!?");
                        } else {
                            Console.WriteLine("Infelizmente você foi reprovado, estude mais!");
                        }
                    } 
            
                    break;

                   case 5:
                    Animal animal1 = new Animal();
                    Animal animal2 = new Animal();
                    Animal animal3 = new Animal();
                    Animal animal4 = new Animal();
                    Animal animal5 = new Animal();

                    int countCachorro = 0, countGato = 0, countPeixe = 0;


                    Console.WriteLine("### Cadastro de pets ###");
                    
                    Console.WriteLine("Informe o nome do 1° animal a ser cadastrado");
                    animal1.Nome = Console.ReadLine();
                    Console.WriteLine("Informe o nome do animal (Sendo Gato, Cachorro ou Peixe)");
                    animal1.Type = Console.ReadLine();
                    if (animal1.Type == "Cachorro") countCachorro++;
                    if (animal1.Type == "Gato") countGato++;
                    if (animal1.Type == "Peixe") countPeixe++;
                    
                    Console.WriteLine("Informe o nome do 2° animal a ser cadastraado");
                    animal2.Nome = Console.ReadLine();
                    Console.WriteLine("Informe o nome do animal (Sendo Gato, Cachorro ou Peixe)");
                    animal1.Type = Console.ReadLine();
                    if (animal2.Type == "Cachorro") countCachorro++;
                    if (animal2.Type == "Gato") countGato++;
                    if (animal2.Type == "Peixe") countPeixe++;
                    
                    Console.WriteLine("Informe o nome do 3° animal a ser cadastrado");
                    animal3.Nome = Console.ReadLine();
                    Console.WriteLine("Informe o nome do animal (Sendo Gato, Cachorro ou Peixe)");
                    animal3.Type = Console.ReadLine();
                    if (animal3.Type == "Cachorro") countCachorro++;
                    if (animal3.Type == "Gato") countGato++;
                    if (animal3.Type == "Peixe") countPeixe++;
                    
                    Console.WriteLine("Informe o nome do 4° animal a ser cadastrado");
                    animal4.Nome = Console.ReadLine();
                    Console.WriteLine("Informe o nome do animal (Sendo Gato, Cachorro ou Peixe)");
                    animal4.Type = Console.ReadLine();
                    if (animal4.Type == "Cachorro") countCachorro++;
                    if (animal4.Type == "Gato") countGato++;
                    if (animal4.Type == "Peixe") countPeixe++;
                    
                    Console.WriteLine("Informe o nome do 5° animal a ser cadastrado");
                    animal5.Nome = Console.ReadLine();
                    Console.WriteLine("Informe o nome do animal (Sendo Gato, Cachorro ou Peixe)");
                    animal5.Type = Console.ReadLine();
                    if (animal5.Type == "Cachorro") countCachorro++;
                    if (animal5.Type == "Gato") countGato++;
                    if (animal5.Type == "Peixe") countPeixe++;

                    Console.WriteLine("Animais ao todo:");
                    Console.WriteLine("Cachorros: "+ countCachorro + " \nGatos: " + countGato + " \nPeixe: " + countPeixe);

                    break;

                default:
                    Console.WriteLine("Opção inválida por favor digite um número correspondente no menu.");
                    Console.ReadKey();
                    break;

            }
        }
    }
}
