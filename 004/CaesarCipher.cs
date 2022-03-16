using System;
using System.Text;

namespace MyProject
{
    class CaesarCipher
    {
        string source;
        int shift;
     
        public CaesarCipher (int shift, string source)
        {
            this.source = source.ToLower();
            this.shift = shift % this.source.Length;
        }

        public string Encode(string text)
        {
            StringBuilder builder = new StringBuilder();
            
            foreach (char c in text.ToLower().ToCharArray())
            {
                if (source.Contains(c))
                {   
                    builder.Append(source[(source.IndexOf(c) + this.shift) % this.source.Length]);   
                } else
                {
                    builder.Append(c);
                }
            }

            return builder.ToString();
        }

        public string Decode(string text)
        {
            StringBuilder builder = new StringBuilder();
            
            foreach (char c in text.ToLower().ToCharArray())
            {
                if (source.Contains(c))
                {   
                    if (source.IndexOf(c) - this.shift < 0)
                    {
                        builder.Append(source[source.Length - Math.Abs(source.IndexOf(c) - this.shift)]);
                    } else
                    {
                        builder.Append(source[source.IndexOf(c) - this.shift]);
                    } 
                } else
                {
                    builder.Append(c);
                }
                
            }

            return builder.ToString();
        }
    }
}