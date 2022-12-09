//Abstração é uma maneira de se dimunuir a complexidade do código ocultando os detalhes desnecessários da
// implementação de algo.
//Podemos ocultar esses de detalhes da seguinte forma:

//EXEMPLO:

//Classes abstratas

//Um banco possui diversos tipos de contas. Nesse caso teremos uma classe mãe Conta, que possui os atributos e 
//métodos gerais de todos os tipos de contas e as classes filhas de cada tipo de conta, como por exemplo, conta 
//poupança, conta corrente, etc.

class Conta {

    public string Titular { get; set; }
    public int NumeroConta { get; set; }
    public int Agencia { get; set; }
    protected double Saldo;

    public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

    public void Saca(double valor)
        {
            this.Saldo += valor;
        }

}

class contaPoupanca : Conta {
    
     public void AcresceJuros()
        {
            this.Saldo += 0.5;
        }
}

class contaCorrente : Conta {

    private void DescontaTarifa()
        {
            this.Saldo -= 0.1;

        }
}

//Nesse caso para cada tipo de conta criaremos um objeto

//EXEMPLO 
class contasCorrentes {
    
    static void NovoCliente(){
        contaCorrente cc = new contaCorrente();

        cc.Titular = "Titular 1";
        cc.Agencia = 001;
    }

}

class contasPoupancas {
    
        static void NovoCliente(){
        contaPoupanca cp = new contaPoupanca();

        cp.Titular = "Titular 1";
        cp.Agencia = 001;
    }
}

//Porém existe a superclasse Conta, e nada nos impede de ela ser instanciada. Porém isso não seria correto,
//afinal não exite somente "Conta" no banco, essa classe não é suficiente para respresentar uma conta. 
//Nesse caso teremos que impor uma restrição nessa classe, definindo ela como abstrata, 
//colocando o modifcador "abstract".


abstract class Conta {

    public string Titular { get; set; }
    public int NumeroConta { get; set; }
    public int Agencia { get; set; }
    protected double Saldo;

    public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

    public void Saca(double valor)
        {
            this.Saldo += valor;
        }

}
 //Desta forma o compilador irá emitir um erro caso seja criada uma instância de objeto para essa classe.


 //MÉTODOS ABSTRATOS
 

 //No banco foi necessário implementar uma nova funcionalidade que envolve a emissão de extratos detalhados
 //que variam de acordo com cada tipo de conta. 
 //Nesse caso olhando de maneira superficial, não seria necessário criar um método na classe Mãe, afinal
 //ele teria que ser reescrito em todas as classes e não haveria aproveitamento algum do código. 
 //Porém, o que iria garantir que essa funcionalidade seria certamente implementada em todas as classes filhas 
 // e que manteriam a mesma assinatura? Poderia cada subclasse implementar a sua maneira ou nem implementar,
 //gerando um problema na demanda. Nesse caso podemos criar um método abstrato na classe Mãe. 
 //Esse por sua vez não possui corpo porém obrigará que todas as classes derivadas implementem o método
 //reescrevendo. 

//Exemplo: 


abstract class Conta1 {

    public string Titular { get; set; }
    public int NumeroConta { get; set; }
    public int Agencia { get; set; }
    protected double Saldo;

    public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

    public void Saca(double valor)
        {
            this.Saldo += valor;
        }

    public abstract void imprimeExtratoDetalahado();

}

class contaPoupanca1 : Conta1 {
    
     public void AcresceJuros()
        {
            this.Saldo += 0.5;
        }

    public override void imprimeExtratoDetalahado()
    {
        throw new System.NotImplementedException();
    }
}

class contaCorrente1 : Conta1 {

    private void DescontaTarifa()
        {
            this.Saldo -= 0.1;

        }

        public override void imprimeExtratoDetalahado()
    {
        throw new System.NotImplementedException();
    }
}

//As duas classes filhas estão obrigatóriamente implementando o método abstrato.