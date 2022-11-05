using System.Xml.Linq;

namespace Anderson_Project5
{/// <summary>
/// 
/// </summary>
    internal class Program
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            BTree<string> tree = GetTree();
            BTreeNode<string> node = tree.Root;

            Console.WriteLine("Enter Y for yes, N for no.");

            while (node != null)
            {
                if (node.Left != null || node.Right != null)
                {
                    WriteQuestion(node.Data.ToString());
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.Y:
                            WriteAnswer(" Yes");
                            node = node.Left;
                            break;
                        case ConsoleKey.N:
                            WriteAnswer(" No");
                            node = node.Right;
                            break;
                    }
                }
                else
                {
                    WriteAnswer(node.Data.ToString());
                    node = null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static BTree<string> GetTree()
        {
            string[] questions = new string[] {
                "Do you have experience in the computing field?",
                "Have you finished college?",
                "Have you worked as a developer for more than 5 years?",
                "Do you have extra time during the semester?",
                "Apply for a junior developer!",
                "Apply as a middle developer!" ,
                "Apply as a senior developer!", 
                "Apply for summer internship program!",
                "Apply for our long-time internship program!"
                };

            BTree<string> tree = new BTree<string>();
            int index = 0;
            tree.Root = tree.insertLevelOrder(questions, index);
            tree.Count = questions.Length;
            return tree;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        static void WriteAnswer(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        static void WriteQuestion(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}