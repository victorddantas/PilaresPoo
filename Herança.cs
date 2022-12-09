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


        //REESCRITA DE MÉTODO:

        //É quando definimos um método com a mesma assinatura na classe mãe e em alguma classe genérica.
        //Os métodos da classe filha sempre terão prioridade aos da classe pai.
        

        //EXEMPLO DE REESCRITA DE MÉTODOS: 

        //No sistema do banco, na classe mãe serviço existe o método calcularTaxa(), esse método por sua vez 
        //é utilizado  no serviço de empréstimo porém com uma taxa diferente.


        class Servico2 {

            public double calcularTaxa(){
                return 10;
            }
        }

        class Emprestimo2 : Servico2 {
            
            public  double calcularTaxaEmprestimo() {
                return this.Valor * 0.1;
           }


        }

        //No exemplo acima podemos utlizar tanto o método calcularTaxa da classe Mãe, quanto o método 
        //calcularTaxaEmprestimo da classe filha.
        //Porém há um problema nisso, pois podemos erroneamente invocar o método errado, afinal, no caso do
        //empréstimo não queremos o método da classe Servico. Para evitar isso o mais correto seria substituir
        //a implemetação do método calcularTaxa da classe mãe na classe filha. Por padrão as implemnetações dos
        //métodos de uma superclasse não podem ser modificados. Para alterar esse comportamento devemos utilizar
        //o modificador virtual.

        class Servico3 {

            public virtual double calcularTaxa(){
                return 10;
            }

        }


        //Depois disso estamos autorizados a modificar a implementação do método na classe filha. Para isso 
        //utilizamos o modificador override

        class Empréstimo3 : Servico3 {
            public override double calcularTaxa(){
                return this.Valor * 0.1;
            }
        }



        //Em outro caso, podemos ter como exemplo uma taxa de empréstimo onde temos um valor fixo de taxa mais um valor 
        //específico.
        //Se por ventura esse valor fixo for alterado teriamos que alterar em todas as classes que possuem ele.
        //Nesse  caso podemos criar mais um método com esse valor fixo na classe mãe e reutiliza-lo em todas as classes
        //filhas nos métodos reescritos. Assim se houver necessidade de alteração desse valor, será necessário apenas 
        //modicar na classe mãe.

        //EXEMPLO:

        class Servico4 {
           public virtual double calcularTaxa(){
                return 10;
            }

            public double taxaFixa(){
                return 5;
            }
        }

        class Emprestimo4 : Servico4{
            public override double calcularTaxa(){
                return base.taxaFixa() + this.Valor * 0.1;  //aqui ao invés de se utilizar o valor 5 utilizamos o método 
            }
        }

        #endregion


    }