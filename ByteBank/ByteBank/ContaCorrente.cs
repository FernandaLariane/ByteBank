using ByteBank;

namespace ByteBank{

    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 100;

        public double ObterSaldo()
        {
            return saldo;
        }    
        public void DefinirSaldo(double saldo)
        {
            if(saldo < 0)
            {

            }
            else
            {
                this.saldo = saldo;
            }
        }

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;

        }
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

            }
        }
    }