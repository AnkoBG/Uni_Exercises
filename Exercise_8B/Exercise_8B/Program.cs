using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8B
{
    class Program
    {
        static int count;
        static Student[] students;
        static void Main(string[] args)
        {
            students = new Student[100];
            count = 0;
            int choice;

            do
            {
                Console.WriteLine("\n1. Добавяне на студент");
                Console.WriteLine("2. Извеждане на среден успех");
                Console.WriteLine("3. Запис на файл");
                Console.WriteLine("4. Зареждане от файл");
                Console.WriteLine("5. Най-добър студент");
                Console.WriteLine("0. Изход");

                choice = ReadInt("Въведете команда: ");

                switch (choice)
                {
                    case 1:
                        Student st = new Student();
                        st.Name = ReadString("Име: ");
                        st.FacultyNumber = ReadString("Фак. номер: ");
                        int marksCount = ReadInt("Брой оценки: ");
                        st.Marks = new decimal[marksCount];
                        for (int i = 0; i < marksCount; ++i)
                            st.Marks[i] = ReadDecimal("Оценка " + (i + 1) + ": ");

                        students[count++] = st;
                        break;

                    case 2:
                        for (int i = 0; i < count; ++i)
                        {
                            decimal avg = 0;
                            foreach (var mark in students[i].Marks)
                                avg += mark;
                            if (students[i].Marks.Length > 0)
                                avg /= students[i].Marks.Length;
                            Console.WriteLine("Фак.номер: {0}\tИме: {1}\tСр. успех: {2}",
                                students[i].FacultyNumber, students[i].Name, Math.Round(avg, 2));
                        }
                        break;

                    case 3:
                        string[] lines = new string[count * 3];

                        for (int i = 0; i < count; ++i)
                        {
                            lines[3 * i + 0] = students[i].Name;
                            lines[3 * i + 1] = students[i].FacultyNumber;
                            lines[3 * i + 2] = "";
                            foreach (var mark in students[i].Marks)
                                lines[3 * i + 2] += mark + " ";
                        }

                        File.WriteAllLines("data.txt", lines);
                        Console.WriteLine("Файлът е записан успешно.");
                        break;

                    case 4:
                        if (!File.Exists("data.txt"))
                        {
                            Console.WriteLine("Файлът не съществува.");
                            break;
                        }

                        count = 0;

                        string[] fileLines = File.ReadAllLines("data.txt");
                        for (int i = 0; i < fileLines.Length; i+=3)
                        {
                            Student s = new Student();
                            s.Name = fileLines[i];
                            s.FacultyNumber = fileLines[i + 1];
                            var markTexts = fileLines[i + 2].Split(new char[] { ' ' },
                                StringSplitOptions.RemoveEmptyEntries);
                            s.Marks = new decimal[markTexts.Length];
                            for (int k = 0; k < s.Marks.Length; ++k)
                                s.Marks[k] = decimal.Parse(markTexts[k]);
                            students[count++] = s;
                        }

                        Console.WriteLine("Файлът е прочетен успешно.");
                        break;

                    case 5:
                        decimal bestGrade = 0;
                        int bestStudentIndex = 0;
                        for (int i = 0; i < count; ++i)
                        {
                            decimal avg = GetStudentAverage(i);
                            if (avg > bestGrade)
                                bestStudentIndex = i;
                        }
                        Console.WriteLine("Фак.номер: {0}\tИме: {1}\tСр. успех: {2}\n", students[bestStudentIndex].FacultyNumber, students[bestStudentIndex].Name, GetStudentAverage(bestStudentIndex));
                        int counter = 1;
                        foreach (var mark in students[bestStudentIndex].Marks)
                            Console.WriteLine("Оценка " + counter++ + ": " +mark);
                        break;
                }
            }
            while (choice != 0);
        }

        static int ReadInt(string prompt)
        {
            int input;
            bool success;
            do
            {
                Console.WriteLine(prompt);
                success = int.TryParse(Console.ReadLine(),out input);
                if (!success)
                {
                    Console.WriteLine("Моля въведете число!");
                }
            }
            while (!success);
            return input;
        }
        static decimal ReadDecimal(string prompt)
        {
            decimal input;
            bool success;
            do
            {
                Console.WriteLine(prompt);
                success = decimal.TryParse(Console.ReadLine(), out input);
                if (!success)
                {
                    Console.WriteLine("Моля въведете число!");
                }
            }
            while (!success);
            return input;
        }
        static string ReadString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
            
        }

        static decimal GetStudentAverage(int index)
        {
            decimal avg = 0;
            foreach (var mark in students[index].Marks)
                avg += mark;
            if (students[index].Marks.Length > 0)
                avg /= students[index].Marks.Length;
            return avg;
        }
    }
}
