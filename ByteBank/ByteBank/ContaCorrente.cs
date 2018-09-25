using ByteBank;

namespace ByteBank{

    public class ContaCorrente
    {
        private Cliente _titular;
        private double _saldo = 100;

        public Cliente Titular{ get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            return true;

        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this._saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

            }
        }

    }