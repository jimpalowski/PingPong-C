using System;
using System.Collections.Generic;


namespace PingPong
{
  public class PingPong
  {

    private int _number;
    private static List<PingPong> _instances = new List <PingPong> {};

    public PingPong(int number)
    {
      _number = number;
    }

    public int GetNumber()
    {
      return _number;
    }

    public static List<PingPong> GetAll()
    {
      return _instances;
    }
    public static void Clear()
    {
      _instances.Clear();
    }
    public bool IsPingPong(int num)
    {
    if( num % 3 == 0 && num % 5 == 0){
      return true;
    }else{
      return false;
    }
    }
  }
}
