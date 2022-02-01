using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LearnWord
{
    public partial class checkWords : Form
    {
        public checkWords()
        {
            InitializeComponent();
        }
        string english;
        string hebrew;
        int randomNum;
        double countdid=0;
        int countwithoutmistake=0;
        int recheck;
        int lastRandomNum=0;
        double correct;
        Word[] wordArray;
        int wordsInTest;
        int skippedWord = 0;


        private void wordsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {;
            this.Validate();
            this.wordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database41DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form load = new loading();
            load.Show();
            Thread.Sleep(5000);
            this.wordsTableAdapter1.Fill(this.database41DataSet1.words);
            wordArray = new Word[wordsDataGridView1.RowCount];
            for (int i = 0; i < wordsDataGridView1.RowCount; i++)
            {
                wordArray[i] = new Word(wordsDataGridView1.Rows[i].Cells[1].Value.ToString(), wordsDataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            wordsInTest = wordArray.Length;
            totalLabel.Text = "מילים במאגר: "+ wordArray.Length;
            load.Hide();
            process();

        }
        public int GetRandomNum()
        {
            Random r = new Random();
            return r.Next(0, wordArray.Length);
        }
        public bool checkIfCanBeSkipped(int index)
        {
            int rnd = new Random().Next(1, 100);
            if (wordArray.Length < 2)
                return false;
            char firstChar = (wordArray[index].getEgnlish().ToCharArray())[0];
            if (wordArray[index].getWere()==0 && (firstChar == 'a' || firstChar == 'b' || firstChar == 'c' || firstChar == 'd'))
            {
                if (wordArray[index].getWere() == 0 && rnd > 75)
                {
                    removeStuffFromWordArr(index);
                    Thread.Sleep(100);
                    skippedWord++;
                    skippedWordLabel.Text = "מילים שדולגו: " + skippedWord;
                    totalLabel.Text = "מילים במאגר: " + wordArray.Length.ToString();
                    
                    return true;
                }
            }
            return false;
        }
        public void process()
        {
            //  removeStuffFromWordArr(99);
            if (recheck == 0)
            {
                correctLabel.Text = "CORRECT: " + correct.ToString() + " COUNT: " + countdid.ToString();
                NoMistakeLabel.Text = "כמות מילים שעברו ללא טעויות: " + countwithoutmistake;
                DiduntillNowLabel.Text = "מילים שעברו עד כה: " + countdid;
                randomNum = GetRandomNum();
                gradeLabel.Text = countdid != 0 ? ((int)((correct / countdid) * 100)).ToString() : "0";
                gradeLabel.ForeColor = ((int)((correct / countdid) * 100)) > 89 ? Color.Green : ((int)((correct / countdid) * 100)) < 56 ? Color.Red : Color.Black;
                this.BackColor = countwithoutmistake > 9 ? Color.GreenYellow : countwithoutmistake > 4 ? Color.Yellow : Color.Cyan;
                while ((checkIfCanBeSkipped(randomNum)) || randomNum == lastRandomNum && wordArray.Length > 1)
                {
                    randomNum = GetRandomNum();
                }
                lastRandomNum = randomNum;
                if (wordArray.Length != 0)
                {
                    wordArray[randomNum].upWere();
                    english = wordArray[randomNum].getEgnlish();
                    hebrew = wordArray[randomNum].getHebrew();
                    EnglishLabel.Text = english;
                    wereStatusLabel.Text = "מילה זאת היית כבר " + wordArray[randomNum].getWere().ToString() + " והוצלחה " + wordArray[randomNum].getSucess().ToString() + " פעמים";
                }


            }
            else
            {
                recheck++;
                if (recheck == 4)
                {
                    recheck = 0;
                    wordArray[randomNum].minusSucess();
                }
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter && textBox1.Text!="")
            {
                if(wordArray.Length == 0)
                {
                    MessageBox.Show("מטורף! הצלחת את כל המילים במאגר! אש עליך! כל הכבוד!", "סחטיין עליך");
                    //this.ForeColor = Color.GreenYellow;
                    this.BackColor = Color.GreenYellow;
                    label2.Hide();
                    textBox1.Hide();
                    EnglishLabel.Text = "!עבודה טובה"
                        + "\n" + "הצלחת לפתור את כלל המילים במאגר ב" + countdid + " מהלכים"
                        + "\n" + "סך המילים שלא ידעת: " + (countdid - correct).ToString();
                    return;
                }
                if (checkifMatch(textBox1.Text,wordArray[randomNum].getHebrew()) && wordArray.Length != 0)
                {
                    if(textBox1.Text!=hebrew)
                    {
                        MessageBox.Show("בטוחים שהתכוונת למילה " + hebrew + " ולכן הפירוש התקבל", "שים לב", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (recheck==0)
                    {
                        this.BackColor = Color.Cyan;
                        EnglishLabel.ForeColor = Color.Black;
                        countdid++;
                        countwithoutmistake++;
                        correct++;
                        wordArray[randomNum].upSucess();
                    }
                    if (checkifkown(wordArray[randomNum]))
                    {
                        removeStuffFromWordArr(randomNum);
                        wordsInTest--;
                        totalLabel.Text = "מילים במאגר: " + wordArray.Length;
                        if (wordsInTest == 0)
                        {
                            MessageBox.Show("מטורף! הצלחת את כל המילים במאגר! אש עליך! כל הכבוד!", "סחטיין עליך");
                            //this.ForeColor = Color.GreenYellow;
                            this.BackColor = Color.GreenYellow;
                            label2.Hide();
                            textBox1.Hide();
                            EnglishLabel.Text = "!עבודה טובה"
                                + "\n" + "הצלחת לפתור את כלל המילים במאגר ב" + countdid + " מהלכים"
                                + "\n" + "סך המילים שלא ידעת: " + (countdid - correct).ToString();
                            return;

                        }
                    }
                    textBox1.Clear();
                    process();
                }
                else
                {
                    MessageBox.Show("פירוש המילה " + " היא: " + hebrew , "!טעות", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.BackColor = Color.Red;
                    EnglishLabel.ForeColor = Color.White;
                    textBox1.Clear();
                    countwithoutmistake = -1;
                    recheck = 1;
                    correct--;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            wordArray[randomNum].upSucess();
            wordArray[randomNum].upSucess();
            wordArray[randomNum].upSucess();
            textBox1.Clear();
            process();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (countwithoutmistake==70)
            {
                    textBox1.Focus();               
            }

        }
        private bool checkifkown(Word wordOn)
        {
            bool condition1 = (wordOn.getSucess() > 3) || (wordOn.getSucess()==wordOn.getWere() && wordOn.getWere()==1);
            //bool condition2 = (wordOn.getEgnlish().StartsWith("a") && (wordOn.getSucess() == 1) && wordOn.getSucess() == wordOn.getWere());
            //bool condition3 = (wordOn.getEgnlish().StartsWith("b") && (wordOn.getSucess() == 1) && wordOn.getSucess() == wordOn.getWere());
            //bool condition4 = (wordOn.getEgnlish().StartsWith("c") && (wordOn.getSucess() == 1) && wordOn.getSucess() == wordOn.getWere());
            //bool condition5 = (wordOn.getEgnlish().StartsWith("d") && (wordOn.getSucess() == 1) && wordOn.getSucess() == wordOn.getWere());
            //bool condition6 = (wordOn.getEgnlish().StartsWith("e") && (wordOn.getSucess() == 1) && wordOn.getSucess() == wordOn.getWere());
            //bool condition7 = (wordOn.getEgnlish().StartsWith("f") && (wordOn.getSucess() == 1) && wordOn.getSucess() == wordOn.getWere());


            return condition1 /*|| condition2 || condition3 || condition4 || condition5 || condition6 || condition7*/;
        }

        private void removeStuffFromWordArr(int index)
        {
            Word[] temp = new Word[wordArray.Length - 1];
            for (int i = 0; i < index; i++)
            {
                temp[i] = wordArray[i];
            }
            if (index != temp.Length)
            {
                temp[index] = wordArray[index + 1];
                for (int i = index + 1; i < wordArray.Length - 1; i++)
                {
                    temp[i] = wordArray[i + 1];
                }
            }
            wordArray = temp;
        }
        public string printArr(int []arr)
        {
            string txt="";
            for (int i = 0; i < arr.Length; i++)
            {
                txt += arr[i] + " ,";
            }
            return txt;
        }
        public bool checkifMatch(string entered, string translate)
        {
            if (entered.Length <2 && translate.Length >2)
            {
                return false;
            }
            if (entered.Contains(translate) || translate.Contains(entered))
            {

                return true;
            }
            int count = 0;
            char[] enteredArr = entered.ToCharArray();
            char[] translateArr = translate.ToCharArray();
            int runtill = (enteredArr.Length > translateArr.Length) ? translateArr.Length : enteredArr.Length;
            for (int i = 0; i < runtill; i++)
            {
                if (enteredArr[i]!=translateArr[i])
                {
                    count++;
                }
            }
            if (entered.Length < 3)
            {
                return count == 0;
            }
            return (count <= 1);
        }
    }
}
