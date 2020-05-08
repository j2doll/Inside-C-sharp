using System;

class RankArrayApp
{
  int[] singleD;
  int[,] doubleD;
  int[,,] tripleD;
  
  protected RankArrayApp()
  {
    singleD = new int[6];
    doubleD = new int[6,7];
    tripleD = new int[6,7,8];
  }
  
  protected void PrintRanks()
  {
    Console.WriteLine("singleD Rank = {0}", singleD.Rank);
    Console.WriteLine("doubleD Rank = {0}", doubleD.Rank);
    Console.WriteLine("tripleD Rank = {0}", tripleD.Rank);
  }

  public static void Main()
  {
    RankArrayApp app = new RankArrayApp();
    app.PrintRanks();
  }
}


