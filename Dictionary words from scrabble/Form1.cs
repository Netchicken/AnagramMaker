using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_words
{
    public partial class Form1 : Form
    {
        // https://msdn.microsoft.com/en-us/magazine/mt620013.aspx
        public Form1()
        {
            InitializeComponent();
            Form_Load();
        }

        private async void Form_Load()
        {
            await Model.LoadDict();
            btnLoadWords.Text = "Words Loaded";
            btnLoadWords.BackColor = Color.DarkSeaGreen;

        }


        /// <summary>
        /// This isn't necessary, just a manual load button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnLoadWords_Click(object sender, EventArgs e)
        {
            await Model.LoadDict();
            btnLoadWords.Text = "Words Loaded";
            btnLoadWords.BackColor = Color.DarkSeaGreen;
        }


        private void txtInputWord_TextChanged(object sender, EventArgs e)
        {
            var SearchWord = txtInputWord.Text;
            var Answer = Business.SearchForWord(SearchWord);
            lbxRndWords.Items.Clear();
            //get all the random words
            // lbxRndWords.Items.Insert(0, RndWordSelection(Answer));

            try {
                lbxRndWords.Items.AddRange(Business.RndWordSelection(SearchWord).ToArray());
            } catch (Exception) {
                lbxRndWords.Items.Add("Failed search");
            }

            if ((Answer != null) && (SearchWord.Length > 1)) lbxWords.Items.Insert(0, Answer);

            if (AnagramDTO.IsFoundWord == false) txtInputWord.BackColor = Color.AliceBlue;
            else txtInputWord.BackColor = Color.GreenYellow;
        }


        private async void btnCreateAnagram_Click(object sender, EventArgs e)
        {
            lbxAnagramPhrases.Items.Clear();
            lbxAnagramPhrases.DataSource =  AnagramDTO.ListboxAnagramPhrases.DataSource;
          

            await CreateAnagrams(txtInputWord.Text.ToLower().Trim());

        }

        private async Task CreateAnagrams(string phrase)
        {
            //https://www.dotnetperls.com/async 
            var GeneratedAnagrams =
                 await Task.Run(() => phrase.Split(' ').CartesianProduct().Select(s => string.Join("", s)).ToList());

            AnagramDTO.ListboxAnagramPhrases.Items.Add("Inputting " + txtInputWord.Text);
            
            if (GeneratedAnagrams.Count == 0) {
                //if nothing then get out
                lbxAnagramPhrases.Items.Add("No words found");
            } else {
                //wait for it to complete

                //we or ro di ia sr if na           TEST WORDS
                btnCreateAnagram.BackColor = Color.DarkSeaGreen;
                lbxAnagramPhrases.Items.Add("Working .... ");

                var Output = new List<string>();
                Output.AddRange(await Task.Run(() => Business.GetDictWords(GeneratedAnagrams)));
                // Output.AddRange(GetDictWords(Result));


                lbxAnagramPhrases.Items.Add(await Task.Run(() => GeneratedAnagrams.Count + " Combinations found"));

                lbxAnagramPhrases.Items.Add(Output.Count + " Dict words found");

                foreach (var word in Output) lbxAnagramPhrases.Items.Add(word);

                lbxAnagramPhrases.Items.Add("Finished");
                btnCreateAnagram.BackColor = Color.Aquamarine;
            }
        }
    }
}