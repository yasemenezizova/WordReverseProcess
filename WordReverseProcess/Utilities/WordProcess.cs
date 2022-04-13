using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace WordReverseProcess.Utilities
{
    public static class WordProcess
    {
        public static string ReverseItem(string word)
        {
            StringBuilder builder = new StringBuilder(word.Length);
            for (int i = word.Length - 1; i >= 0; i--)
            {
                builder.Append(word[i]);
            }

            return builder.ToString();
        }
    }
}