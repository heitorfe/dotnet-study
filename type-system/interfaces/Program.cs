using System;

public interface IPerson // Declaração da interface IPerson com duas propriedades
{
    string FirstName { get;} // Propriedade somente leitura para o primeiro nome
    string LastName { get;} // Propriedade somente leitura para o último nome
    string[] PhoneNumbers {get;} // Propriedade somente leitura para os números de telefone

    
}

public class Person : IPerson // A classe Person implementa a interface IPerson
{
    public string FirstName {get;}  // Implementação da propriedade FirstName
    public string LastName {get;} // Implementação da propriedade LastName
    public string[] PhoneNumbers {get;} // Implementação da propriedade PhoneNumbers


    public Person(string firstName, string lastName, string[] phoneNumbers)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumbers = phoneNumbers;
    }

    public override string ToString() => $"{FirstName} {LastName}"; // Sobrescreve o método ToString para retornar o nome completo
}

public class Program
{
    public static void Main()
    {
        IPerson person1 = new Person("Nancy", "Davolio", new string[1]); // Cria uma instância de Person através da interface IPerson
        Console.WriteLine(person1); // Imprime "Nancy Davolio"

        IPerson person2 = new Person("Andrew", "Fuller", new string[1]); // Cria uma instância de Person através da interface IPerson
        Console.WriteLine(person2); // Imprime "Andrew Fuller"

        Console.WriteLine(person1 == person2); // Imprime "False" porque person1 e person2 são instâncias diferentes

        person2 = person1;
        Console.WriteLine(person1 == person2); // Imprime "True" porque person1 e person2 são a mesma instância

    }
}