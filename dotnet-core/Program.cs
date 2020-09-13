using System;
using System.Runtime.InteropServices;
using static System.Console;

public static class Program
{
    public static void Main(string[] args) 
    {
          WriteLine($"{GetMessage()}");

    }

    private static string GetMessage() 
    {
            
            return @"
 _____   ____   _____ _  ________ _____  
|  __ \ / __ \ / ____| |/ /  ____|  __ \ 
| |  | | |  | | |    | ' /| |__  | |__) |
| |  | | |  | | |    |  < |  __| |  _  / 
| |__| | |__| | |____| . \| |____| | \ \ 
|_____/ \____/ \_____|_|\_\______|_|  \_\
         
   _   _ ______ _______    _____ ____  _____  ______ 
  | \ | |  ____|__   __|  / ____/ __ \|  __ \|  ____|
  |  \| | |__     | |    | |   | |  | | |__) | |__   
  | . ` |  __|    | |    | |   | |  | |  _  /|  __|  
 _| |\  | |____   | |    | |___| |__| | | \ \| |____ 
(_)_| \_|______|  |_|     \_____\____/|_|  \_\______|                           
  ";
    }
}
