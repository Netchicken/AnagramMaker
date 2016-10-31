using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_words
{
    class AnagramDTO
    {
        public static Dictionary<string, string> DictionaryWords = new Dictionary<string, string>();
        public static List<string> ListOfDictWords = new List<string>();
        public static bool IsFoundWord = false;
        public static string OldAnagram = "";

       public static ListBox ListboxAnagramPhrases = new ListBox();
        public static string AnagramPhrases = null;
    }
}
