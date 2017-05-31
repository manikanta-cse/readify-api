using System;
using System.Collections.Generic;
using System.Data.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Web;

namespace Readify_API.Services
{
    public class ReverseWordsService
    {
        
        public  static string ReverseString(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                s = string.Empty;
                return s;
            }
            return ReverseStringInSentence(s);

        }

        private static string ReverseStringInSentence(string text)
        {
            text += " ";

            string retval = string.Empty;
            int pos = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    string tmp = text.Substring(pos, i - pos);
                    retval += new string(tmp.Reverse().ToArray()) + " ";
                    pos = i + 1;
                }
            }

            return retval.Trim();

        }
        
    }
}