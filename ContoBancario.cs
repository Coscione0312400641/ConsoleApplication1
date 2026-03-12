namespace ConsoleApplication1;

public class ContoBancario
{
    private decimal saldo;

    public decimal Saldo
    {
        get { return saldo; }

        private set { Saldo = value; }
    }

    public ContoBancario(decimal saldoIniziale)
    {
        saldo = saldoIniziale;
    }

    public void Deposita(decimal importo)
    {
        if (importo > 0)
            saldo += importo;
    }

    public void Preleva(decimal importo)
        {
            if (importo > 0 && importo<=saldo)
            
                saldo-= importo;
            
        }
}
