public class Poo
    {
        
        #region Herança

        //O conceito de herança é a idéia de reutilização do código, onde uma classe pode herdar os atributos e métodos de outra classe que possui
        //os mesmos atributos e métodos de modo a facilitar a divisão das resposabilidades da classe. Isso evita a repetição de código,
        //facilitando o desenvolvimento e facilitando a manutenção pois o código fica muito mais organizado, além de promover uma melhor performance
        //no código, pois no caso de precisar de apenas um serviço em especifico, o código não precisará passar por
        //por outros desnecessáriamente. 



        //EXEMPLO: 


        //Um banco que possui vários serviços.


        class Servico1
        {
            //Geral
            public Cliente1 Contratante { get; set; }
            public Funcionario Resposnsavel { get; set; }
            public string DataDeContratacao { get; set; }

            //Empréstimo
            public double Valor { get; set; }
            public double Taxa { get; set; }

            //Seguro de veículos
            public Veiculo veiculo { get; set; }
            public double ValorDoSeguroDoVeiculo { get; set; }
            public double Franquia { get; set; }

        }


        //Nesse caso o mais correto é se ter uma classe para cada serviço, porém exitem métodos e propriedadade que são padrão para todos os serviços.
        //No conceito de herança temos as classes genéricas, que abrigam métodos e propriedades que são padrão para vários serviços,
        //no caso, para várias classes, ou seja, todas essas classes específicas de cada serviço herderão atributos e métodos dessa classe genérica.
        //Essas classes genéricas são chamadas de Super classe, classe base ou classe mãe, e as classes específicas são chamadas
        //de sub classes, classes derivadas ou classes filhas.



        //EXEMPLO CORRETO: 

        class ServicoGeral
        {
            public Cliente1 Contratante { get; set; }
            public Funcionario Resposnsavel { get; set; }
            public string DataDeContratacao { get; set; }
        }

        class Emprestimo : ServicoGeral //isso indica que a classe Empréstimo herda de ServicoGeral
        {
            public double Valor { get; set; }
            public double Taxa { get; set; }

        }

        class SeguroDeVeiculos : ServicoGeral
        {
            public Veiculo veiculo { get; set; }
            public double ValorDoSeguroDoVeiculo { get; set; }
            public double Franquia { get; set; }
        }

        //Utilizando os atributos de classes herdadas:

        class Emprestimo1
        {

            public static void Main()
            {
                Emprestimo e = new Emprestimo();

                e.DataDeContratacao = "26/04/2022"; //atributo da classe ServicoGeral
                e.Valor = 10000.00;//atributo da classe Emprestimo


            }


        }



        #endregion



    }