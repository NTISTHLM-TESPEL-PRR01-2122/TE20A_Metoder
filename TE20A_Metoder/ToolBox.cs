using System;

public class ToolBox
{
  public static void SayHello(int times)
  {
    int i = 0;
    while (i < times)
    {
      Console.WriteLine("Hello!");
      i++;
    }
  }

  public static bool DoesHit()
  {
    Random generator = new Random();
    int slumpTal = generator.Next(100);

    if (slumpTal < 30)
    {
      return true;
    }
    else 
    {
      return false;
    }
    
  }
}