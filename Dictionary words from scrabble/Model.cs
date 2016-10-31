using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_words
{
    static class Model
    {
        public static async Task LoadDict()
        {
            //a great way of loading each line of a file into your program

            string dictpath = Application.StartupPath + @"\\dict1.txt";
            //need to run a Task to get the load to be async
            await Task.Run(() => LoadToDictionary(dictpath));


        }

        private static void LoadToDictionary(string dictpath)
        {
            foreach (string line in File.ReadLines(dictpath)) {
                //if the dictionary doesn't have the word then load it. Otherwise it crashes when it finds a conflict with an existing word
                if (AnagramDTO.DictionaryWords.ContainsKey(line) == false) {
                    //add key / value with both the same word
                    AnagramDTO.DictionaryWords.Add(line.ToLower(), line);
                    AnagramDTO.ListOfDictWords.Add(line.ToLower());
                }
            }
        }
    }
}
