
using System;

namespace CoinFlipChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Ask for the user's name
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            // 2. Ask if they want to participate
            Console.Write($"{userName}, do you want to play the COIN FLIP CHALLENGE? (Yes/No): ");
            string playResponse = Console.ReadLine()?.Trim().ToLower();

            // Validate response
            while (playResponse != "yes"
