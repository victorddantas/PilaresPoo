//O Polimorfismo é a capacidade de se tratar objetos que foram criados a partir das classe filhas
//como objetos da classe mãe.
//É a capacidade  de se invocar métodos com a mesma assinatura porém com comportamentos diferentes para cada
//classe derivada, ou seja, duas ou mais classes derivadas de uma superclasse podem invocar métodos que tem 
//a mesma assinatura mas se comportando cada um de acordo com a sua necessidade.


// EXEMPLO:

//Um controle de gerenciamento de ponto de funcionário:


class ControleDePonto 
{
    public void RegistraEntrada (Gerente g){
        DateTime agora = DateTime.Now;
        string horario = string.Format("{0:d/M/yyyy HH:mm:ss}", agora);

        System.Console.WriteLine("Entrada: " + g.Codido);
        System.Console.WriteLine("Data: : " + horario);

    }

        public void RegistraSaida (Gerente g){
        DateTime agora = DateTime.Now;
        string horario = string.Format("{0:d/M/yyyy HH:mm:ss}", agora);

        System.Console.WriteLine("Entrada: " + g.Codido);
        System.Console.WriteLine("Saída: : " + horario);

    }
}

//No exemplo acima o codigo apresenta o registro de funcionario apenas para o gerente.
// seria necessário a criação de um registro de entrada e saída para cada funcionário. Isso se torna completamente 
//inviável ao desenvolvimento, acarretaria em um código extremamente extenso sem necessidade, pois o registro 
//de ponto dos funcionários é o mesmo para todos. 


//Para evitar isso podemos aplicar o conceito de herança 

//EXEMPLO:

class Funcionario {
    public int Codigo { get; set; }
}

class Gerente : Funcionario{
    public string Usuario { get; set; }
    public string Senha { get; set; }
}

class Telefonista : Funcionario{
    public int Ramal { get; set; }
}

class ControlePonto1 {


    public void RegistraEntrada (Funcionario g){
        DateTime agora = DateTime.Now;
        string horario = string.Format("{0:d/M/yyyy HH:mm:ss}", agora);

        System.Console.WriteLine("Entrada: " + g.Codido);
        System.Console.WriteLine("Data: : " + horario);

    }

        public void RegistraSaida (Funcionario g){
        DateTime agora = DateTime.Now;
        string horario = string.Format("{0:d/M/yyyy HH:mm:ss}", agora);

        System.Console.WriteLine("Entrada: " + g.Codido);
        System.Console.WriteLine("Saída: : " + horario);

    }
}

//Nesse caso o código de controle de ponto será aplicado para os Funcionarios e todas as classes que derivam dela.