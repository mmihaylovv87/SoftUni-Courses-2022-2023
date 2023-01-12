using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowBalls = int.Parse(Console.ReadLine());
            BigInteger snowBallValue = 0;
            BigInteger snowBallSnow = 0;
            BigInteger snowBallTime = 0;
            int snowBallQuantity = 0;
            BigInteger bestSnowBall = int.MinValue;

            string bestSnowBallFormula = "";

            for (int i = 0; i < snowBalls; i++)
            {
                snowBallSnow = BigInteger.Parse(Console.ReadLine());
                snowBallTime = BigInteger.Parse(Console.ReadLine());
                snowBallQuantity = int.Parse(Console.ReadLine());

                BigInteger currentSnowBallValue = snowBallSnow / snowBallTime;
                snowBallValue = BigInteger.Pow(currentSnowBallValue, snowBallQuantity);
                if (snowBallValue > bestSnowBall)
                {
                    bestSnowBall = snowBallValue;
                    bestSnowBallFormula = $"{snowBallSnow} : {snowBallTime} = {snowBallValue} ({snowBallQuantity})";
                }
            }

            Console.WriteLine(bestSnowBallFormula);
        }
    }
}