using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace работа_глав
{
    class pod
    {

        public pod()
        {

        }
        public string z1(string pt)
        {
            int k11 = 0, k12 = 0 ;
            string otv = "";
            string gg = "";
            if (pt != "")
            {
                FileInfo file = new FileInfo(pt);
                StreamReader file2 = new StreamReader(pt);
                string text = "";
                if (file.Exists)
                {
                    while (!file2.EndOfStream)
                    {
                        text = file2.ReadLine()+" ";
                        for (int i = 0; i < text.Length - 1; i++)
                        {
                            if ((text[i] != ' ' && text[i + 1] != ' ') || (text[i] != ' ') && (text[i + 1] == ' ')) { gg = gg + text[i]; }
                            if (text[i] != ' ' && text[i + 1] == ' ') { if (gg == "зачет") { k11++; gg = ""; } if (gg == "незачет") { k12++; gg = ""; } gg = ""; }

                        }
                    }
                    file2.Close();
                }
            }
            otv = "Кол. зачет= " + k11 + "\r\n" + "Кол. незачет= " + k12;
           
            return otv;

        }  //подсчет зачет и незачет

        public int a(string pt)
        {
            int k11 = 0;
            string gg = "";
            if (pt != "")
            {
                FileInfo file = new FileInfo(pt);
                StreamReader file2 = new StreamReader(pt);
                string text = "";
                if (file.Exists)
                {
                    while (!file2.EndOfStream)
                    {
                        text = file2.ReadLine() + " ";
                        for (int i = 0; i < text.Length - 1; i++)
                        {


                            if ((text[i] != ' ' && text[i + 1] != ' ') || (text[i] != ' ') && (text[i + 1] == ' ')) { gg = gg + text[i]; }
                            if (text[i] != ' ' && text[i + 1] == ' ') { if (gg == "зачет") { k11++; gg = ""; }  gg = ""; }

                        }
                    }
                    file2.Close();
                }

            }

            return k11;

        }       //зачет
                
        public int b(string pt)
        {
            int k12 = 0;
            string gg = "";
            if (pt != "")
            {
                FileInfo file = new FileInfo(pt);
                StreamReader file2 = new StreamReader(pt);
                string text = "";
                if (file.Exists)
                {
                    while (!file2.EndOfStream)
                    {
                        text = file2.ReadLine() + " ";
                        for (int i = 0; i < text.Length - 1; i++)
                        {


                            if ((text[i] != ' ' && text[i + 1] != ' ') || (text[i] != ' ') && (text[i + 1] == ' ')) { gg = gg + text[i]; }
                            if (text[i] != ' ' && text[i + 1] == ' ') { if (gg == "незачет") { k12++; gg = ""; } gg = ""; }

                        }
                    }
                    file2.Close();
                }

            }

            return k12;

        }           //незачет

        public string v(string pt)
        { 
            FileInfo file = new FileInfo(pt);
                StreamReader file2 = new StreamReader(pt);
                string text = "";
                if (file.Exists)
                {
                    while (!file2.EndOfStream)
                    {
                        text = text + file2.ReadLine() + "\r\n";
                    }
                    file2.Close();
                } 
            
            return text;


        }       //вывод

        public string yh(string pt) 
        {
            string text = "", text2 = ""; ;
            string gg = "",g2="";
            bool flag = false;
            int k1 = 0, l = 0; 
            if (pt != "")
            {
                FileInfo file = new FileInfo(pt);
                StreamReader file2 = new StreamReader(pt);
                
                if (file.Exists)
                {
                    while (!file2.EndOfStream)
                    {
                        text = file2.ReadLine() + " ";
                        string[] k11 = new string[text.Length];
                        for (int i = 0; i < text.Length - 1; i++)
                        {


                            if ((text[i] != ' ' && text[i + 1] != ' ') || (text[i] != ' ') && (text[i + 1] == ' ')) { gg = gg + text[i]; }
                            if (text[i] != ' ' && text[i + 1] == ' ') {  k11[k1] = gg; gg = ""; k1++; }

                        }
                        for (int i = 0; i < k11.Length; i++)
                        {
                            if (k11[i]=="зачет")
                            {
                                flag = true;
                            }
                            if (l < 2) { flag = false; }
                            l++;
                        }
                        if (flag == true) { g2 = k11[1]; text2 = text2 + k11[0] +" "+ g2[0]+" зачет \r\n"; g2 = ""; }
                        flag = false;
                        k1 = 0;
                        l = 0;

                    }
                    file2.Close();
                }

            }
            
            
            return text2;

        }           //

        public string prip(string pt)
        {
            string text = "", text2 = ""; ;
            if (pt != "")
            {
                FileInfo file = new FileInfo(pt);
                StreamReader file2 = new StreamReader(pt);

                if (file.Exists)
                {
                    while (!file2.EndOfStream)
                    {
                        text = file2.ReadLine() + " ";
                        string[] k11 = new string[text.Length];
                        for (int i = 0; i < text.Length; i++)
                        {
                            if ((text[i] == '.') || (text[i] == ',') || (text[i] == '!') || (text[i] == '?') || (text[i] == ':') || (text[i] == ';') || (text[i] == '(') || (text[i] == ')') || (text[i] == '-')) { text2 = text2 + text[i]; }  
                        }


                    }
                    file2.Close();
                }

            }


            return text2;

        }           //

        public string rus(string pt)
        {
            string text = "", text2 = "" ;
            int k1 = 0, k2 = 0;
            if (pt != "")
            {
                FileInfo file = new FileInfo(pt);
                StreamReader file2 = new StreamReader(pt);

                if (file.Exists)
                {
                    while (!file2.EndOfStream)
                    {
                        text = file2.ReadLine() + " ";
                        for (int i = 0; i < text.Length; i++)
                        {
                            if (Convert.ToInt32(text[i]) > 128 && text[i] != ' ') { k1++; } if (Convert.ToInt32(text[i]) <= 128 && text[i] != ' ') { k2++; }
                        }


                    }
                    file2.Close();
                }

            }

            text2 = "русскийх= " + k1 + "\r\n лат.= " + k2;
            return text2;

        }       //

        public int a1(string pt)
        {
            string text = "";
            int k1 = 0;
            if (pt != "")
            {
                FileInfo file = new FileInfo(pt);
                StreamReader file2 = new StreamReader(pt);

                if (file.Exists)
                {
                    while (!file2.EndOfStream)
                    {
                        text = file2.ReadLine() + " ";
                        for (int i = 0; i < text.Length; i++)
                        {
                            if (Convert.ToInt32(text[i]) > 128 && text[i] != ' ') { k1++; } 
                        }


                    }
                    file2.Close();
                }

            }


            return k1;
        }           //

        public int b1(string pt)
        {
            string text = "";
            int  k2 = 0;
            if (pt != "")
            {
                FileInfo file = new FileInfo(pt);
                StreamReader file2 = new StreamReader(pt);

                if (file.Exists)
                {
                    while (!file2.EndOfStream)
                    {
                        text = file2.ReadLine() + " ";
                        for (int i = 0; i < text.Length; i++)
                        {
                            if (Convert.ToInt32(text[i]) <= 128 && text[i]!=' ')  { k2++; }
                        }


                    }
                    file2.Close();
                }

            }


            return k2;
        }       //

    }
}
