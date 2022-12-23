namespace PassGen.Models;
using System.ComponentModel.DataAnnotations;
using System;

public class PassGener
{
    public static string RandomPassword()
    {
    Random random = new Random();
    // dataset parameter  list 
    string[] PasswordCharacters=new[] {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","l","s","t","u","v","w","x","y","z","1","2","3","4","5","6","7","8","9","0","!","@","#","$","%","^","&","*","(",")"};

    while(true)
    {
        //Console.Write("\n PasswordLength");
        int passwordLength  = 16; //Convert.ToInt32(Console.ReadLine());
    
        //Console.WriteLine(); 
        string NewPass="";
        for (int i = 0; i < passwordLength; i++)
        {
            NewPass += PasswordCharacters[random.Next(PasswordCharacters.Length)];
            Console.WriteLine(NewPass);
        }
        return  NewPass;
    }
    }
}
