using System;
using System.Globalization;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    private static void Main(string[] args)
    {
        try
        {
            var startup = new Startup();
            var serviceProvider = startup.ConfigureServices();
            var service = serviceProvider.GetService<IMainService>();

            service?.Invoke();
            Console.WriteLine("Currency Symbol: {0}", NumberFormatInfo.CurrentInfo.CurrencySymbol);
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e);
        }
    }
}
