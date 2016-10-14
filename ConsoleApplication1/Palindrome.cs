using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    public class Palindrome
    {
        public List<string> GetPalindromes(string text)
        {
            var matches = Regex.Split(text, @"(\w)\1+?");
            var pairwise = this.GetPairWise(matches);
            var formatted = this.Format(pairwise);

            List<string> palindromes = new List<string>();
            string word = string.Empty;
            formatted.ForEach(x =>
            {
                char[] keys = x.Key.ToCharArray();
                char[] values = x.Value.ToCharArray();
                var length = keys.Length > values.Length ? values.Length : keys.Length;
                Enumerable.Range(0, length).ToList().ForEach(i =>
                {

                    if (keys[i] == values[i])
                        word = word + keys[i].ToString();
                });
                if(word!=string.Empty)
                    palindromes.Add(word.Reverse() + word);
                word = string.Empty;
            });

            return palindromes;
        }

        public List<string> GetPairWise(string [] matches)
        {
            return matches.ToList().Zip(matches.Skip(1), (a, b) => a + b).ToList();
        }

        public List<KeyValuePair<string, string>> Format(IEnumerable<string> pairWise)
        {
            return pairWise.Zip(pairWise.Skip(1), (a, b) => new KeyValuePair<string, string>(a.Reverse(), b)).ToList();
        }
    }
}
