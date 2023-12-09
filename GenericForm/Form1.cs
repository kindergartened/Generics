using Generics;
using System.Collections.Generic;

namespace GenericForm
{
    public partial class Generics : Form
    {
        public dynamic list = new List<int>();
        public Generics()
        {
            InitializeComponent();
            LightTheme();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(N.Text);
                Random rnd = new();
                switch (listType.Text)
                {
                    case "Преподаватель":
                        list = new List<Teacher>();
                        for (int i = 0; i < n; i++)
                        {
                            list.Add(Teacher.Generate());
                        }
                        break;
                    case "Студент":
                        list = new List<Student>();
                        for (int i = 0; i < n; i++)
                        {
                            list.Add(Student.Generate());
                        }
                        break;
                    case "Умный дом":
                        list = new List<SmartHome<AssistantSpeaker, Lights, CleaningService, SecurityService>>();
                        for (int i = 0; i < n; i++)
                        {
                            list.Add(SmartHome<AssistantSpeaker, Lights, CleaningService, SecurityService>.Generate());
                        }
                        break;
                    case "bool":
                        list = new List<bool>();
                        for (int i = 0; i < n; i++)
                        {
                            list.Add(rnd.Next(0, 2) == 1 ? true : false);
                        }
                        break;
                    case "string":
                        list = new List<string>();
                        string сhars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                        for (int i = 0; i < n; i++)
                        {
                            list.Add(new string(Enumerable.Repeat(сhars, rnd.Next(10, 50)).Select(s => s[rnd.Next(s.Length)]).ToArray()));
                        }
                        break;
                    case "int":
                        list = new List<int>();
                        for (int i = 0; i < n; i++)
                        {
                            list.Add(rnd.Next(-10000, 10000));
                        }
                        break;
                    case "double":
                        list = new List<double>();
                        for (int i = 0; i < n; i++)
                        {
                            list.Add(rnd.NextDouble() + rnd.Next(-10000, 10000));
                        }
                        break;
                }

                first.Text = string.Join("\n", list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sort_Click(object sender, EventArgs e)
        {
            try
            {
                if (isQuick.Checked)
                {
                    result.Text = string.Join("\n", UniversalSortings.QuickSort(list));
                }
                if (isPartition.Checked)
                {
                    result.Text = string.Join("\n", UniversalSortings.Vstavka(list));
                }
                if (isBubble.Checked)
                {
                    result.Text = string.Join("\n", UniversalSortings.BubbleSort(list));
                }
                if (isMerge.Checked)
                {
                    result.Text = string.Join("\n", UniversalSortings.Sliyaniesort(list));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //THEMES MODES
        private void LightTheme()
        {
            //BACKGROUND COLORS
            this.BackColor = Color.FromArgb(240, 240, 240); groupBox1.BackColor = Color.FromArgb(225, 225, 225); groupBox2.BackColor = Color.FromArgb(225, 225, 225);
            result.BackColor = Color.FromArgb(225, 225, 225); first.BackColor = Color.FromArgb(225, 225, 225); listType.BackColor = Color.White;
            N.BackColor = Color.White; generate.BackColor = Color.FromArgb(41, 98, 255); sort.BackColor = Color.FromArgb(41, 98, 255);
            button1.BackColor = Color.FromArgb(220, 220, 220); button3.BackColor = Color.FromArgb(220, 220, 220);
            //FONT COLORS
            label1.ForeColor = Color.Black; qweqweqwe.ForeColor = Color.Black; resultqweqwe.ForeColor = Color.Black; groupBox1.ForeColor = Color.Black;
            groupBox2.ForeColor = Color.Black; result.ForeColor = Color.Black; first.ForeColor = Color.Black; listType.ForeColor = Color.Black;
            N.ForeColor = Color.Black;
            //STYLES (FLAT & BORDER)
            first.BorderStyle = BorderStyle.Fixed3D; result.BorderStyle = BorderStyle.Fixed3D;
            generate.FlatStyle = FlatStyle.Standard; sort.FlatStyle = FlatStyle.Standard;
        }

        private void DarkTheme()
        {
            //BACKGROUND COLORS
            this.BackColor = Color.FromArgb(41, 41, 41); groupBox1.BackColor = Color.FromArgb(52, 52, 52); groupBox2.BackColor = Color.FromArgb(52, 52, 52);
            result.BackColor = Color.FromArgb(52, 52, 52); first.BackColor = Color.FromArgb(52, 52, 52); listType.BackColor = Color.FromArgb(52, 52, 52);
            N.BackColor = Color.FromArgb(52, 52, 52); generate.BackColor = Color.FromArgb(68, 68, 68); sort.BackColor = Color.FromArgb(68, 68, 68);
            button1.BackColor = Color.FromArgb(110, 110, 110); button3.BackColor = Color.FromArgb(110, 110, 110);
            //FONT COLORS
            label1.ForeColor = Color.White; qweqweqwe.ForeColor = Color.White; resultqweqwe.ForeColor = Color.White; groupBox1.ForeColor = Color.White;
            groupBox2.ForeColor = Color.White; result.ForeColor = Color.White; first.ForeColor = Color.White;
            listType.ForeColor = Color.White; N.ForeColor = Color.White;
            //STYLES (FLAT & BORDER)
            first.BorderStyle = BorderStyle.None; result.BorderStyle = BorderStyle.None;
            generate.FlatStyle = FlatStyle.Flat; sort.FlatStyle = FlatStyle.Flat;
            button1.FlatStyle = FlatStyle.Flat; button3.FlatStyle = FlatStyle.Flat;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LightTheme(); button3.BackColor = Color.FromArgb(173, 213, 247);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DarkTheme(); button1.BackColor = Color.FromArgb(160, 160, 160);
        }
    }
}