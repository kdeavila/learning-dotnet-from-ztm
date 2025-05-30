﻿using CustomExceptionTypes;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your username: ");
        var userInput = Console.ReadLine();

        try
        {
            var username = GetNormalizedUsername(userInput);
            Console.WriteLine($"Hello, {username}!");
        }
        catch (InvalidUsernameException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static string GetNormalizedUsername(string username)
    {
        if (string.IsNullOrEmpty(username) || username.Length < 6)
        {
            throw new InvalidUsernameException(username);
        }

        return username.ToLower();
    }
}