// This is a basic program on C#
//
// Try to modify and run it and check out
// the output in the terminal below.
//
// Happy coding! :-)

using System;

namespace HelloWorld {

  class MainClass {

    public static void Main (string[] args) {

      int a = 0;
      string adminpw = "123";
      bool admin = false;

      for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Password for User: Admin");
        string pw = Console.ReadLine();

       if (pw != adminpw) {
          Console.WriteLine("Login failed, try agim!"); 
            } else { 
         admin = true;
         break;
       }
      }
  
        if (a > 2) {
        Console.WriteLine("Login failure!"); } else if (admin == true) { 
        Console.WriteLine("Login successful"); } else { }
    }
  }
}