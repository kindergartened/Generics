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
    }
}