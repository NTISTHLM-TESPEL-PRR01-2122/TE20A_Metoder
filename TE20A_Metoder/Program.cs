using System;
using System.IO;

ToolBox.SayHello(4);

ToolBox.DoesHit();

while (true)
{
  bool didIHit = ToolBox.DoesHit();

  if (didIHit)
  {
    Console.WriteLine("HIT!");
  }
  else
  {
    Console.WriteLine("MISS!");
  }
  Console.ReadLine();
  
}