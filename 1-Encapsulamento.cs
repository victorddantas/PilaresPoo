public class Poo
    {
        #region Encapsulamento

        //Encapsular de forma simples é o ato de eesconder a implementação dos objetos (atributos e métodos), que favorecem a manutenção e desenvolvimento do código.
        //A manutenção é favorecida pois quando o funcionamento de um objeto precisa ser alterado, é necessário apenas modicar a classe do objeto em questão. 
        //No desenvolvimento é favorecido pois conseguimos determinar de forma mais simples as responsabilidades de cada classe da aplicação.


        //A seguir exemplos de encapsulamento:




        //ATRIBUTOS PRIVADOS:



        //Um sistema de um banco possui uma classe funcionário que possui um atributo salário, na qual será guardado esse valor 


        //class Funcionario
        //{
        //    public double salario { get; set; }

        //}

        //O atributo salário pode ser acessado e modificado por qualquer outra classe, o que torna seu controle descentralizado, no caso de ocorre algum erro 
        //seria necessário passar por todas as classe que definaram a classe funcionario.
        //Para evitar esse problema podemos definir o atributo como "Private", e enetão apenas métodos definidos nessa classe poderam acessar e modificar seu valor.
        //quando não definimos nenhum modificador em um atributo o mesmo é definido como privado, porém é uma boa prática definir o modificador "Private"

        class Funcionario
        {
            private double Salario;


            public void AumentarSalario(double aumento)
            {
                this.Salario = +aumento;
            }
        }




        //MÉTODOS PRIVADOS:



        //Alguns métodos possuem o papel de auxiliar outros métodos da mesma classe, e muitas vezes não é correto chamar esses métodos "auxiliares" fora da classe.



        // EXEMPLO:



        // Uma classe conta possui os métodos Deposita, Saca e DescontaTarifa



        class Conta
        {
            private double Saldo;

            public void Deposita(double valor)
            {
                this.Saldo += valor;
                this.DescontaTarifa();
            }

            public void Saca(double valor)
            {
                this.Saldo += valor;
                this.DescontaTarifa();
            }


            private void DescontaTarifa()
            {
                this.Saldo -= 0.1;

            }
        }


        // O método DescontaTarifa é um exemplo de método auxiliar. Não é correto chamar ele fora da classe, pois sua função é descontar a tarifa no saque e no deposito
        // Para evitar esse problema definimos ele como "Private". 
        // Qualquer chamada do método DescontaTarifa fora da classe Conta, gera um erro de compilação.



        //IMPLEMENTAÇÃO E INTERFACE DE USO:

        //No exemplo anterior a classe conta realiza as operações de saque, deposito e de desconto de tarifa. Cada objeto vai realizar um conjunto de tarefas
        //de acordo com sua responsabilidade.
        //Para descobrir essas responsabilidades, verifique a assinatura do método, que é composta de pelo Nome e o seu respectivo parâmetro.
        //Esses por sua vez formam a interface de uso

        //Agora caso queira saber como o um objeto desse classe realiza suas operações, deve-se analisar o corpo dos métodos. Esse por sua vez são a Implementação
        //das operações dos objetos.


        //ACESSANDO OU MODIFICANDO ATRIBUTOS:


        //Ao encapsular um código, o mesmo não poderá ser acessado ou modificado fora de sua classe, contudo a vezes que será necessário essas alterções ou
        //modificações em outras partes de código. Por isso devemos criar métodos que permitam fazer essas tarefas, pois assim temos muito mais controle do código 
        //e de como os valores das propriedades vão ser consultados ou alterados, ao invés de se ter um atributo público


        //Exemplo 


        class Cliente1
        {
            private string nome;

            public string ConsultaNome()
            {
                return this.nome;
            }

            public void AlteraNome(string Nome)
            {
                this.nome = Nome;
            }
        }



        //PROPRIEDADES: 


        //As propridades são outra maneira de acessar atributos. Elas agrupam os métodos de consulta e alteração dos atributos 

        //Exemplo:

        class Cliente2
        {
            private string nome;

            public string Nome
            {
                get
                {
                    return this.nome;
                }

                set
                {
                    this.nome = value;
                }

            }

        }

        //Utilizando os atributos

        class Teste
        {

            static void NomeDoCliente()
            {
                Cliente2 cliente2 = new Cliente2();

                cliente2.Nome = "Victor";
            }


        }

        #endregion

    }