using System;
using System.Net.Http;
using System.Threading.Tasks;

Console.WriteLine("Fetching data...");


try{

    int start = 1;
    int end = 5;
    using HttpClient client = new HttpClient();    

    for(int i = start; i <= end; i++)
    {
        string url = $"https://jsonplaceholder.typicode.com/todos/{i}";
        string result = await client.GetStringAsync(url);
        Console.WriteLine($"Data fetched successfully: {url}");
        Console.WriteLine(result);
    }
}

catch(Exception e)
{
    Console.WriteLine($"An error occurred: {e.Message} ");
}

Console.WriteLine("Data fetching completed.");