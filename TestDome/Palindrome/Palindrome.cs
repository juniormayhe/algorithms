using System;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        word = word.ToLowerInvariant();
        char[] arr = word.ToCharArray();
        Array.Reverse(arr);
        return String.Join("",arr).Equals(word);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
    }
}