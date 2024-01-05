using System;
using System.IO;
using System.Text;
using AherGame.Methods;

class AhercodeGame
{

    // Entry point of the program
    static void Main(string[] args)
    {
        GameLogic mainGameLogic = new();
        mainGameLogic.RunGame();
    }
}
