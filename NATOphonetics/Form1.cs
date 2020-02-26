using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NATOphonetics
{
    public partial class Form1 : Form
    {
        List<String> phoneticList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void NatoP(string word)
        {
            phoneticList.Clear();
            Debug.WriteLine(word);
            foreach (char ca in word)
            {
                string phoneticString;

                switch (ca)
                {
                    case 'a':
                        phoneticString = "a = Alpha";
                        break;
                    case 'A':
                        phoneticString = "A = Alpha";
                        break;
                    case 'b':
                        phoneticString = "b = Bravo";
                        break;
                    case 'B':
                        phoneticString = "B = Bravo";
                        break;
                    case 'c':
                        phoneticString = "c = Charlie";
                        break;
                    case 'C':
                        phoneticString = "C = Charlie";
                        break;
                    case 'd':
                        phoneticString = "d = Delta";
                        break;
                    case 'D':
                        phoneticString = "D = Delta";
                        break;
                    case 'e':
                        phoneticString = "e = Echo";
                        break;
                    case 'E':
                        phoneticString = "E = Echo";
                        break;
                    case 'f':
                        phoneticString = "f = Foxtrot";
                        break;
                    case 'F':
                        phoneticString = "F = Foxtrot";
                        break;
                    case 'g':
                        phoneticString = "g = Golf";
                        break;
                    case 'G':
                        phoneticString = "G = Golf";
                        break;
                    case 'h':
                        phoneticString = "h = Hotel";
                        break;
                    case 'H':
                        phoneticString = "H = Hotel";
                        break;
                    case 'i':
                        phoneticString = "i = India";
                        break;
                    case 'I':
                        phoneticString = "I = India";
                        break;
                    case 'j':
                        phoneticString = "j = Juliett";
                        break;
                    case 'J':
                        phoneticString = "J = Juliett";
                        break;
                    case 'k':
                        phoneticString = "k = Kilo";
                        break;
                    case 'K':
                        phoneticString = "K = Kilo";
                        break;
                    case 'l':
                        phoneticString = "l = Lima";
                        break;
                    case 'L':
                        phoneticString = "L = Lima";
                        break;
                    case 'm':
                        phoneticString = "m = Mike";
                        break;
                    case 'M':
                        phoneticString = "M = Mike";
                        break;
                    case 'n':
                        phoneticString = "n = November";
                        break;
                    case 'N':
                        phoneticString = "N = November";
                        break;
                    case 'o':
                        phoneticString = "o = Oscar";
                        break;
                    case 'O':
                        phoneticString = "O = Oscar";
                        break;
                    case 'p':
                        phoneticString = "p = Papa";
                        break;
                    case 'P':
                        phoneticString = "P = Papa";
                        break;
                    case 'q':
                        phoneticString = "q = Quebec";
                        break;
                    case 'Q':
                        phoneticString = "Q = Quebec";
                        break;
                    case 'r':
                        phoneticString = "r = Romeo";
                        break;
                    case 'R':
                        phoneticString = "R = Romeo";
                        break;
                    case 's':
                        phoneticString = "s = Sierra";
                        break;
                    case 'S':
                        phoneticString = "S = Sierra";
                        break;
                    case 't':
                        phoneticString = "t = Tango";
                        break;
                    case 'T':
                        phoneticString = "T = Tango";
                        break;
                    case 'u':
                        phoneticString = "u = Uniform";
                        break;
                    case 'U':
                        phoneticString = "U = Uniform";
                        break;
                    case 'v':
                        phoneticString = "v = Victor";
                        break;
                    case 'V':
                        phoneticString = "V = Victor";
                        break;
                    case 'w':
                        phoneticString = "w = Whiskey";
                        break;
                    case 'W':
                        phoneticString = "W = Whiskey";
                        break;
                    case 'x':
                        phoneticString = "x = Xray";
                        break;
                    case 'X':
                        phoneticString = "X = Xray";
                        break;
                    case 'y':
                        phoneticString = "y = Yankee";
                        break;
                    case 'Y':
                        phoneticString = "Y = Yankee";
                        break;
                    case 'z':
                        phoneticString = "z = Zulu";
                        break;
                    case 'Z':
                        phoneticString = "Z = Zulu";
                        break;
                    case '1':
                        phoneticString = "1 = One";
                        break;
                    case '2':
                        phoneticString = "2 = Two";
                        break;
                    case '3':
                        phoneticString = "3 = Three";
                        break;
                    case '4':
                        phoneticString = "4 = Four";
                        break;
                    case '5':
                        phoneticString = "5 = Five";
                        break;
                    case '6':
                        phoneticString = "6 = Six";
                        break;
                    case '7':
                        phoneticString = "7 = Seven";
                        break;
                    case '8':
                        phoneticString = "8 = Eight";
                        break;
                    case '9':
                        phoneticString = "9 = Nine";
                        break;
                    case '0':
                        phoneticString = "0 = Zero";
                        break;
                    default:
                        phoneticString = "";
                        break;
                }
                phoneticList.Add(phoneticString);
            }
            showPhonetics();
        }

        private void showPhonetics()
        {
            richTextBox1.Clear();
            richTextBox1.Lines = phoneticList.ToArray();
        }

        // Copy
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.Copy();
        }
        // Exit
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        // Generate the result while typed
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NatoP(textBox1.Text);
        }
    }
}
