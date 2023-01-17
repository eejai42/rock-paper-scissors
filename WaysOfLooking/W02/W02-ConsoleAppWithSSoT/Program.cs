﻿using Newtonsoft.Json.Linq;
using System;
using System.Linq;

class RockPaperScissors
{
    private static JObject _phaserShieldKlingonBorg;

    static RockPaperScissors()
    {
        string jsonString = File.ReadAllText("../../../../../../SSoT/rps.json");
        var jo = JObject.Parse(jsonString);
        _phaserShieldKlingonBorg = JObject.Parse(jo["rock-paper-scissors"].ToString());
    }

    static void Main(string[] args)
    {
        string strategyGuide = GetStrategyGuide();
        int totalScore = CalculateGameScore(strategyGuide);
        Console.WriteLine("Total score: " + totalScore);
    }

    static int CalculateGameScore(string strategyGuide)
    {
        int totalScore = 0;
        for (int i = 0; i < strategyGuide.Length; i += 5)
        {
            char opponentChoice = strategyGuide[i];
            char playerChoice = strategyGuide[i + 2];
            int roundScore = CalculateRoundScore(opponentChoice, playerChoice);
            totalScore += roundScore;
        }
        return totalScore;
    }
    private static int CalculateRoundScore(char opponentChoice, char playerChoice)
    {
        var outcomes = _phaserShieldKlingonBorg["rules"]["outcomes"];
        var shapes = _phaserShieldKlingonBorg["rules"]["shapes"];
        var opponentShape = shapes.FirstOrDefault(s => $"{s["code"]}" == opponentChoice.ToString());
        var playerShape = shapes.First(s => s["player_code"].ToString() == playerChoice.ToString());

        if (playerShape["defeats"].ToString() == opponentShape["code"].ToString())
        {
            return (int)outcomes["win"] + (int)playerShape["score"];
        }
        else if (opponentShape["defeats"].ToString() == playerShape["code"].ToString())
        {
            return (int)outcomes["loss"] + (int)playerShape["score"];
        }
        else return (int)outcomes["draw"] + (int)playerShape["score"];
    }



    private static string GetStrategyGuide()
    {
        var games = _phaserShieldKlingonBorg["rules"]["games"];
        var rounds = games["rounds"];
        var strategyGuide = "";
        foreach (var round in rounds)
        {
            strategyGuide += round["opponent_code"].ToString() + " " + round["player_code"].ToString() + "\r\n";
        }
        return strategyGuide;
    }

}