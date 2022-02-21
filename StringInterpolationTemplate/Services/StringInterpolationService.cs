using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services
{
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
            var answer = date.ToString("yyyy.MM.dd");
            Console.WriteLine(answer);
            return answer;

        }

        public string Number03()
        {
            var date = _date.Now;
            var answer = $"Day{date: d} of {date:MMMM}, {date:yyyy}";
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
            var preAnswer = $"{date:dddd}";

            var answer = $"{preAnswer,10}";
            Console.WriteLine(answer);
            return answer;
            

            
            
        }

        public string Number06()
        {
            var date = _date.Now;
            var day = $"{date:hh:mm tt}";
            var weekday = $"{date:dddd}";
            
            var answer = $"{day,10}{weekday,10}";
            Console.WriteLine(answer);
            return answer;
        }

        public string Number07()
        {
            var date = _date.Now;
            var answer = String.Format("h:{0:hh}, m:{0:mm}, s:{0:ss}", date) ;
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
            const double pi = Math.PI;
            var answer = $"{pi:$#.##}";
            Console.WriteLine(answer);
            return answer;

        }

        public string Number10()
        {
            const double pi = Math.PI;
            var piform = $"{pi:#.###}";
            var answer = $"{piform,10}";
            Console.WriteLine(answer);
            return answer;
        }

        public string Number11()
        {
            var variable = Math.Sqrt(2);
            byte[] bytes = BitConverter.GetBytes(variable);
            var answer = BitConverter.ToString(bytes);
            Console.WriteLine(answer);
            return answer;
        }

        //2.2019.01.22
    }
}
