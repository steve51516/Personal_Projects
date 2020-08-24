namespace Mumbling
{
    public class Accumul
    {
        public static string Accum(string s)
        {
            string final = "";
            int k = 1, j = k;

            for (int i = 0; i <= s.Length - 1; i++)
            {
                while (j > 0)
                {
                    if (j == k)
                        final += s.ToUpper()[i];
                    else
                        final += s.ToLower()[i];
                    j--;
                }
                    final += (char)45;
                k++;
                j = k;
            }
            final = final.Remove(final.Length - 1);
            return final;
        }
    }
}
