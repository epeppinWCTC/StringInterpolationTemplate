using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        var date = _date.Now;
        var answer = $"{date:yyyy}.{date:MM}.{date:dd}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number03()
    {
        var date = _date.Now;
        var answer = $"Day {date:dd} of {date:MMMM}, {date:yyyy}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number04()
    {
        var date = _date.Now;
        var answer = $"Year: {date:yyyy}, Month: {date:MM}, Day: {date:dd}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number05()
    {
        var date = _date.Now;
        var answer = $"{date, 10:dddd}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number06()
    {
        var date = _date.Now;
        var answer = $"{date, 10:t}{date, 10:dddd}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number07()
    {
        var date = _date.Now;
        var answer = $"h:{date:hh}, m:{date:mm}, s:{date:ss}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number08()
    {
        var date = _date.Now;
        var answer = $"{date:yyyy}.{date:MM}.{date:dd}.{date:hh}.{date:mm}.{date:ss}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number09()
    {
        var pi = Math.PI;
        var answer = $"{pi:c2}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number10()
    {
        var pi = Math.PI;
        var answer = $"{pi, 10:n3}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number11()
    {
        var answer = $"{Convert.ToInt32(Math.Sqrt(2)):X2}";
        Console.WriteLine(answer);

        return answer;
    }

    //2.2019.01.22
}
