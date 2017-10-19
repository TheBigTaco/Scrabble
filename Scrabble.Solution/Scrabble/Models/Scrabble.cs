using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Scrabble.Models
{
  public class Game
  {
    private static Dictionary<char, int> _letterScores = new Dictionary<char, int> {
      {'a',1},
      {'b',3},
      {'c',3},
      {'d',2},
      {'e',1},
      {'f',4},
      {'g',2},
      {'h',4},
      {'i',1},
      {'j',8},
      {'k',5},
      {'l',1},
      {'m',3},
      {'n',1},
      {'o',1},
      {'p',3},
      {'q',10},
      {'r',1},
      {'s',1},
      {'t',1},
      {'u',1},
      {'v',4},
      {'w',4},
      {'x',8},
      {'y',4},
      {'z',10}
    };
    public static int WordScore(string userWord)
    {
      int score = 0;
      char[] letters = userWord.ToCharArray();
      for (int i = 0; i < letters.Length; i++)
      {
        char letter = Char.ToLower(letters[i]);
        score += _letterScores[letter];
      }
      return score;
    }
  }
}
