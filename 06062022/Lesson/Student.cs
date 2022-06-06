using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Student
    {
        //static Student()
        //{
        //    _totalCount = 100;
        //}
        public Student()
        {
            _totalCount++;
            No = _totalCount;
        }
        private static int _totalCount;
        public static int TotalCount => _totalCount;

        //public readonly int No;
        public int No { get; }
        public string FullName;
        private string _groupNo;

        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (CheckGroupNo(value))
                    _groupNo = value;
            }
        }

        public static bool CheckGroupNo(string groupNo)
        {
            if(!string.IsNullOrWhiteSpace(groupNo) && groupNo.Length == 4)
            {
                if (char.IsLetter(groupNo[0]))
                {
                    for (int i = 1; i < groupNo.Length; i++)
                    {
                        if (!char.IsDigit(groupNo[i]))
                            return false;
                    }

                    return true;
                }
            }
            return false;
        }


    }
}
