using System;
using System.Net;

class Program
{
    static void Main()
    {
        string url = "https://example.com/nonexistentpage"; // Замените на адрес ресурса, который не существует

        try
        {
            WebClient client = new WebClient();
            string result = client.DownloadString(url);

            // Если запрос успешен, вы можете здесь обрабатывать полученные данные
            Console.WriteLine(result);
        }
        catch (WebException ex)
        {
            Console.WriteLine("Произошла ошибка при запросе к веб-ресурсу:");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла неизвестная ошибка:");
            Console.WriteLine(ex.Message);
        }
    }
}
