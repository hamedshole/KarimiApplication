using System.Windows.Forms;

namespace KarimiApp.Exceptions
{
    public static class ExtentionMethods
    {
        public static string ArrayToString(this string[] parameters)
        {
            string s= "";
            foreach (var item in parameters)
            {
                s = s + item + ",\n";
            }
            return s;
        }
      
    }
}
