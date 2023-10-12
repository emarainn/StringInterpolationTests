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
        //2. 2019.01.22
        var date = $"{_date.Now:yyyy.MM.dd}";
        Console.WriteLine(date);
        return date;
    }

    public string Number03()
    {
        //3. Day 22 of January, 2019
        var date = $"Day{_date.Now: dd} of {_date.Now:MMMM}, {_date.Now:yyyy}";
        Console.WriteLine(date);
        return date;
    }

    public string Number04()
    {
        //4. Year: 2019, Month: 01, Day: 22
        var date = $"Year: {_date.Now:yyyy}, Month: {_date.Now:MM}, Day: {_date.Now:dd}";
        Console.WriteLine(date);
        return date;
    }

    public string Number05()
    {
        //5. Tuesday (10 spaces total, right aligned)
        var date = $"{_date.Now,10:dddd}";
        Console.WriteLine(date);
        return date;
    }

    public string Number06()
    {
        //6. 11:01 PM             Tuesday (10 spaces total for each including the day-of-week, both right-aligned)
        var date = $"{_date.Now,10: hh:mm tt}{_date.Now,10: dddd}";
        Console.WriteLine(date);
        return date;

    }

    public string Number07()
    {
        //7. h:11, m:01, s:27
        //Console.WriteLine($"h:{date:hh}, m:{date:mm}, s:{date:ss}");
        var date = $"h:{_date.Now:hh}, m:{_date.Now:mm}, s:{_date.Now:ss}";
        Console.WriteLine(date);
        return date;
    }

    public string Number08()
    {
        //8. 2019.01.22.11.01.27
        var date = $"{_date.Now:yyy}.{_date.Now:mm}.{_date.Now:dd}.{_date.Now:hh}.{_date.Now:mm}.{_date.Now:ss}";
        Console.WriteLine(date);
        return date;
    }

    public string Number09()
    {
        var pi = Math.PI;
        var ans = pi.ToString("C");
        Console.WriteLine(ans);
        return ans;
    }

    public string Number10()
    {
        //10.Output as right - aligned(10 spaces), number with 3 decimal places
        var pi = Math.PI;
        var value = String.Format($"{pi,10:f3}");
        Console.WriteLine(value);
        return value;

    }

    public string Number11()
    {
        //11.(2019) as a hexidecimal value
        var year = Convert.ToUInt32($"{_date.Now:yyyy}");
        var value = $"{year:X2}";
        Console.WriteLine(value);
        return value;
    }
}
