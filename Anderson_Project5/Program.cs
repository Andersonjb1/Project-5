///////////////////////////////////////////////////////////////////////////////
//
// Author: Blaine Anderson, Andersonjb1@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 5
// Description: Example of a quiz using a binary tree.
//
///////////////////////////////////////////////////////////////////////////////

namespace Anderson_Project5
{/// <summary>
/// Runs the quiz and determines what happens after each answer.
/// </summary>
    internal class Program
    {
        /// <summary>
        /// Logic to decide which branch of the tree to go down and
        /// print the questions and answers.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            BTree<string> tree = GetTree();
            BTreeNode<string> node = tree.Root;

            Console.WriteLine("Enter Y for yes, N for no.");

            while (node != null) // loop while there is a node
            {
                if (node.Left != null || node.Right != null) // only continue if there is a left OR right node 
                {
                    WriteQuestion(node.Data.ToString()); // print the question 
                    switch (Console.ReadKey(true).Key)   // read keyboard input 
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
                else  // if both the left and the right is null
                {
                    WriteQuestion(node.Data.ToString());  
                    node = null;
                }
            }
        }

        /// <summary>
        /// sets the questions in the tree up for the quiz
        /// </summary>
        /// <returns>a binary tree used for the quiz</returns>
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
            tree.Root = tree.InsertData(questions, index);
            tree.Count = questions.Length;
            return tree;
        }

        /// <summary>
        /// changes the color of the answers to differentiate them from the questions
        /// </summary>
        /// <param name="text"> Yes or No answer from the keyboard </param>
        static void WriteAnswer(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// changes the color of the questions to differentiate them from the answers
        /// </summary>
        /// <param name="text"> Questions from the quiz </param>
        static void WriteQuestion(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}