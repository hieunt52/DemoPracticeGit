public interface IAutomobile
{
    void Ignition();
    void Stop();
}

public class Jeep : IAutomobile
{
    #region IAutomobile Members
    public void Ignition()
    {
        Console.WriteLine("Jeep start");
    }

    public void Stop()
    {
        Console.WriteLine("Jeep stopped.");
    }
    #endregion
}

public class SUV : IAutomobile
{
    #region IAutomobile Members
    public void Ignition()
    {
        Console.WriteLine("SUV start");
    }

    public void Stop()
    {
        Console.WriteLine("SUV stopped.");
    }
    #endregion
}


public class AutomobileController
{
    IAutomobile m_Automobile;

    public AutomobileController(IAutomobile automobile)
    {
        this.m_Automobile = automobile;
    }

    public void Ignition()
    {
        m_Automobile.Ignition();
    }

    public void Stop()
    {
        m_Automobile.Stop();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IAutomobile automobile = new Jeep();
        AutomobileController automobileController = new AutomobileController(automobile);
        automobile.Ignition();
        automobile.Stop();

        Console.Read();
    }
}

// Các module cấp cao không nên phụ thuộc vào các modules cấp thấp. Cả 2 nên phụ thuộc vào abstraction.
// Interface (abstraction) không nên phụ thuộc vào chi tiết, mà ngược lại.
// Các class giao tiếp với nhau thông qua interface, không phải thông qua implementation.