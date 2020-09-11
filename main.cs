using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    isPrime(10);
  }

  public static void isPrime (int i){
    int counter = 1;
    List<int> mods = new List<int>();
    while (counter <= i){
      if (i % counter == 0){
        mods.Add(counter);
      }
      counter++;
      
    }
    int len = mods.Count;
    foreach (int x in mods){
      WriteLine("Factor: {0}" , x);
    }
    if (len == 2){
      WriteLine("{0} is a prime number" , i);
    }
    else{
      WriteLine("{0} is not a prime number" , i);
    }
  }

}
