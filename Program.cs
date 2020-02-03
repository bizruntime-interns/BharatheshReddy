using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();
            list.Add("ram");
            list.Add("raj");
            list.Add("ravi");
            foreach (var lists in list)
            {
                Console.WriteLine(lists);
            }


            HashSet<string> hash = new HashSet<string> { "a", "b", "c","a" };
           foreach(var hashs in hash)
            {
                Console.WriteLine(hashs);
            }


            SortedSet<int> sorted = new SortedSet<int>() { 1, 2, 5, 8, 6, 9, 0 };
            foreach (var sorted1 in sorted) {
                Console.WriteLine(sorted1);
            }

            Stack<string> stack = new Stack<string>();
            {
                stack.Push("x");
                stack.Push("y");
                stack.Push("z");
                stack.Push("x");

                foreach(var stacks in stack)
                {
                    Console.WriteLine(stacks);
                }
                Console.WriteLine("peek "+ stack.Peek());  //peek meaning display
                Console.WriteLine("pop "+ stack.Pop());    //pop means delete
                Console.WriteLine("pop after peeh "+ stack.Peek());
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            foreach(int queues in queue)
            {
                Console.WriteLine(queues);
            }


            LinkedList<string> lined = new LinkedList<string>();
            lined.AddFirst("he");
            lined.AddFirst("she");
            lined.AddLast("others");

             LinkedListNode<String> node=lined.Find("she");  
        lined.AddBefore(node, "us");  
        lined.AddAfter(node, "they");  
            foreach(var line in lined)
            {
                Console.WriteLine(line);
            }
            
            
            Dictionary<string,string> dictionary = new Dictionary<string, string>();
            dictionary.Add("1", "a");
            dictionary.Add("2", "b");
            foreach(KeyValuePair<string, string> value in dictionary)
            {
                Console.WriteLine(value.Key + "   " + value.Value);
            }

            SortedDictionary<int, string> sortdic = new SortedDictionary<int, string>();
            {
                sortdic.Add(1, "d");
                sortdic.Add(3, "c");
                sortdic.Add(4, "d");
                sortdic.Add(2, "e");
             foreach(KeyValuePair<int,string> sort in sortdic)
                {
                    Console.WriteLine(sort.Key + "  " + sort.Value);
                }

            }


            SortedList<string, string> slist = new SortedList<string, string>();
            slist.Add("1", "Sonoo");
            slist.Add("4", "Peter");
            slist.Add("5", "James");
            slist.Add("3", "Ratan");
            slist.Add("2", "Ratan");
            foreach (KeyValuePair<string, string> kv in slist)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}
