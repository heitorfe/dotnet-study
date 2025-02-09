public record Person(string FirstName, string LastName) // Declaração de um record chamado Person com dois campos: FirstName e LastName.
{
    public required string[] PhoneNumbers {get; init; } // Declaração de um campo PhoneNumbers que é obrigatório e somente leitura.
}

public class Program // Declaração da classe Program
{
    public static void Main()
    {
        Person person1 = new("Nancy", "Davolio") {PhoneNumbers = new string[1]}; // Criação de uma instância de Person com os valores "Nancy" e "Davolio".
        Console.WriteLine(person1);
        
        Person person2 = person1 with { FirstName = "Andrew" }; // Cria uma nova instância de Person com o valor de FirstName alterado para "Andrew".
        Console.WriteLine(person2);

        Console.WriteLine(person1 == person2); // Imprime "False" porque person1 e person2 são instâncias diferentes.

        person2 = person1 with { PhoneNumbers = new string[1]};
        Console.WriteLine(person2);

        Console.WriteLine(person1 == person2); // Imprime "False" porque person1 e person2 são instâncias diferentes.

        person2 = person1 with {};
        Console.WriteLine(person1 == person2); // Imprime "True" porque person1 e person2 são instâncias iguais.

    }
}
