using System;
namespace LeetSpeak
{
  public class Leet
  {
    public string ConvertLeet(string sentence)
    {
      char[] array = sentence.ToCharArray();
      int size = array.Length;
      for(int i = 0; i<size;i++)
      {
        bool firstLetter = true;
        if(i != 0 && array[i-1] != ' ')
        {
          firstLetter = false;
        }
        array[i] = ConvertChar(array[i],firstLetter);
      }

      string result = string.Join("", array);
      return result;
    }

    private char ConvertChar(char c,bool firstLetter)
    {
      // Replace e with 3
      // * Replace o with 0
      // * Replace i with 1
      // * Replace t with 7
      // * Replace s with z if s is not first letter in word
      if(c == 'e' || c== 'E')
      {
        c = '3';
      }
      else if(c == 'o' || c== 'O')
      {
        c = '0';
      }
      else if(c == 'i' || c== 'I')
      {
        c = '1';
      }
      else if(c == 't' || c== 'T')
      {
        c = '7';
      }
      else if(c == 's' && (!firstLetter))
      {
        c = 'z';
      }
      return c;
    }
  }
}
