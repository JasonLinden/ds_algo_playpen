using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertionSort
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var a = new SortIns(10);
            a.Insert(8812);
            a.Insert(45);
            a.Insert(33);
            a.Insert(88);
            a.Insert(567);
            a.Insert(142);
            a.Insert(6764);
            a.Insert(34);
            a.Insert(123);
            a.Insert(1212);

            a.SortArray();
        }
    }
}
