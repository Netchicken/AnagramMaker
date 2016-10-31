using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_words
{
    class Business
    {

        /// <summary>
        /// pulls a random word from the dictionary based ont eh first letter of the word in the phrase
        /// </summary>
        /// <param name="Answer"></param>
        /// <returns></returns>

        public static IEnumerable<string> RndWordSelection(string Answer)
        {
            List<string> Words = new List<string>();

            string[] WordsForLoop = Answer.Split(' ');


            List<string> FinalWords = new List<string>();
            Random MyRandom = new Random(); //geneate rnd to pick from the list of words
            try {

                foreach (var Letter in WordsForLoop) {
                    string firstletter = Letter.Substring(0, 1).ToLower();

                    foreach (var word in AnagramDTO.ListOfDictWords) {
                        if (word.StartsWith(firstletter)) {
                            Words.Add(word); //load all the words starting with the first letter
                        }

                    }
                    int rnd = MyRandom.Next(0, Words.Count);
                    FinalWords.Add(Words[rnd]); //get a random word out
                    Words.Clear(); //clear for the next set of words
                }
            } catch (Exception) {

                //  throw;
            }
            return FinalWords;
        }
        /// <summary>
        /// Returns words that match each the first letter word in phrase ie: "Try Another Time" returns "tat"
        /// </summary>
        /// <param name="Phrase"></param>
        /// <returns></returns>
        public static string SearchForWord(string Phrase)
        {
            //input the search word


            string[] SplitPhrase = Phrase.Split(' ');
            string anagram = "";

            try {
                foreach (var word in SplitPhrase) {
                    anagram += word.Substring(0, 1); //get the first letter of each word
                }
                if (anagram != AnagramDTO.OldAnagram) {
                    AnagramDTO.OldAnagram = anagram; //compare it with the last word that went through - stops repeated words
                    if (AnagramDTO.DictionaryWords.ContainsKey(anagram)) {
                        anagram += " is a word";
                        AnagramDTO.IsFoundWord = true;
                        return anagram;
                    } else {
                        anagram += " not a word";
                        AnagramDTO.IsFoundWord = false;
                        return anagram;
                    }
                }
            } catch (Exception) {

                //   throw;
            }

            return null;

        }
        public static IEnumerable<string> GetDictWords(IEnumerable<string> Result)
        {

            Dictionary<string, string> TrueWords = new Dictionary<string, string>();
            foreach (var word in Result) {
                //http://stackoverflow.com/questions/15445432/check-if-dictionary-contains-substring

                //  if (DictionaryWords.Any(kvp => kvp.Value.Contains(word))) {
                //   if (DictionaryWords.Values.Any(v => v.Contains(word))) {
                // if (word.Contains(DictionaryWords.Values.ToString())) {

                if (AnagramDTO.DictionaryWords.ContainsKey(word) && !TrueWords.ContainsKey(word + " - True")) {
                    TrueWords.Add(word + " - True", word + " - True");
                }
                //if (!TrueWords.ContainsKey(word)) {
                //    TrueWords.Add(word, word);
                //}
                //}

                //foreach (var dicword in ListOfDictWords) {
                //    if (word.Contains(dicword)) {
                //        TrueWords.Add(word + " - " + LoopForMatchingWords(word));

                //    }
                //}

                //if (word.Contains("word")) {
                //    TrueWords.Add(word +" from test");

                //}

            }
            return TrueWords.Keys;
        }


        #region Old Embarrasing code




        private List<string> CreateAnagrams(string phrase)
        {
            //Honouring God while keeping our heads above water
            phrase = phrase.ToLower();
            string[] GeneratedWords = phrase.Split(' ');

            List<string> AllGenWords = new List<string>();

            foreach (var letter0 in GeneratedWords[0]) {
                foreach (var letter1 in GeneratedWords[1]) {
                    foreach (var letter2 in GeneratedWords[2]) {
                        foreach (var letter3 in GeneratedWords[3]) {
                            foreach (var letter4 in GeneratedWords[4]) {
                                foreach (var letter5 in GeneratedWords[5]) {
                                    foreach (var letter6 in GeneratedWords[6]) {
                                        foreach (var letter7 in GeneratedWords[7]) {
                                            AllGenWords.Add(letter0.ToString() + letter1.ToString() + letter2.ToString() + letter3.ToString() + letter4.ToString() + letter5.ToString() + letter6.ToString() + letter7.ToString());
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
            return AllGenWords;
        }


        //==============================================================

        //todo Not replacing the word by getting every instanced of the word in there
        private string LoopForMatchingWords(string word)
        {
            string Wordlist = null;
            foreach (var dicword in AnagramDTO.ListOfDictWords) {


                //  while (word.Contains(dicword)) {


                if (word.Contains(dicword)) {

                    Wordlist += dicword + ", ";

                    //   word = word.Replace(dicword, "");

                }
                //   }
            }
            return Wordlist;
        }


        #endregion


    }
}
