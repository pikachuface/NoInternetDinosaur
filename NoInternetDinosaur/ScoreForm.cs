using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NoInternetDinosaur
{
    public partial class ScoreForm : Form
    {
        private string filename = "score";

        private List<Person> people = new List<Person>();
        private int newScore;

        public ScoreForm(int score)
        {
            InitializeComponent();
            this.newScore = score;
            getScoreBoard();
            
        }

        private void getScoreBoard()
        {
            if (File.Exists(filename))
            {
                using (var fs = new FileStream(filename, FileMode.Open))
                {
                    using (var sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] input = sr.ReadLine().Split('~');
                            if (Int32.TryParse(input[1], out int parsedScore))
                            {
                                string name = input[0];
                                int score = parsedScore;
                                people.Add(new Person(name, parsedScore));
                            }
                            else
                            {
                                File.Delete(filename);
                            }
                        }
                    }
                }
            }
        }

        private void WriteScoreBoard()
        {
            using (var fs = new FileStream(filename, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    for (int i = 0; i < 10 && i < people.Count; i++)
                    {
                        sw.WriteLine($"{people[i].Name}~{people[i].Score}");
                    }
                }
            }
        }

        private void SetScore()
        {
            if (people.Count< 9)
            {
                GoToNewBest();
            }
            else
            {
                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].Score < newScore)
                    {
                        GoToNewBest();
                    }
                }
            }

        }

        private void GoToNewBest()
        {
            this.Size = newScorePanel.Size;
            newScorePanel.Visible = true;
        }

        private void outputScore()
        {
            for (int i = 0; i < 10 && i < people.Count; i++)
            {
                outputBox.Text += $"{i + 1}. {people[i].Name} {people[i].Score}";
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void newScoreClosebtn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(296, 342);
            newScorePanel.Visible = false;
        }
    }


}
