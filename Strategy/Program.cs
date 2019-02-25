using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Defina una familia de algoritmos, encapsule cada uno y hágalos intercambiables. La estrategia permite que el algoritmo varíe independientemente de los clientes que lo utilizan.
/// </summary>
namespace Strategy
{
    /// <summary>
    /// Este código del mundo real demuestra el patrón de estrategia que encapsula los algoritmos de clasificación en forma de objetos de clasificación. Esto permite a los clientes cambiar dinámicamente las estrategias de clasificación, incluyendo Quicksort, Shellsort y Mergesort.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Two contexts following different strategies

            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>

    /// The 'Strategy' abstract class

    /// </summary>

    abstract class SortStrategy

    {
        public abstract void Sort(List<string> list);
    }

    /// <summary>

    /// A 'ConcreteStrategy' class

    /// </summary>

    class QuickSort : SortStrategy

    {
        public override void Sort(List<string> list)
        {
            list.Sort(); // Default is Quicksort

            Console.WriteLine("QuickSorted list ");
        }
    }

    /// <summary>

    /// A 'ConcreteStrategy' class

    /// </summary>

    class ShellSort : SortStrategy

    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented

            Console.WriteLine("ShellSorted list ");
        }
    }

    /// <summary>

    /// A 'ConcreteStrategy' class

    /// </summary>

    class MergeSort : SortStrategy

    {
        public override void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented

            Console.WriteLine("MergeSorted list ");
        }
    }

    /// <summary>

    /// The 'Context' class

    /// </summary>

    class SortedList

    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortstrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this._sortstrategy = sortstrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortstrategy.Sort(_list);

            // Iterate over list and display results

            foreach (string name in _list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}