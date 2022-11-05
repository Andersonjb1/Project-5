namespace Anderson_Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BTree<QuizText> tree = GetTree();
            BTreeNode<QuizText> node = tree.Root;

            Console.WriteLine("Enter Y for yes, N for no.");

            while (node != null)
            {
                if (node.Left != null || node.Right != null)
                {
                    Console.Write(node.Data.Text);
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
                    WriteAnswer(node.Data.Text);
                    node = null;
                }
            }
        }


        private static BTree<QuizText> GetTree()
        {
            BTree<QuizText> tree = new BTree<QuizText>();
            tree.Root = new BTreeNode<QuizText>()
            {
                Data = new QuizText("Do you have experience in the computing field?"),

                Children = new List<BTreeNode<QuizText>>()
                {
                    new BTreeNode<QuizText>()
                    {
                        Data = new QuizText("Have you worked as a developer for more than 5 years?"),
                        Children = new List<BTreeNode<QuizText>>()
                        {
                            new BTreeNode<QuizText>()
                            {
                                Data = new QuizText("Apply as a senior developer!")
                            },
                            new BTreeNode<QuizText>()
                            {
                                Data = new QuizText("Apply as a middle developer!")
                            }
                        }
                    },
                    new BTreeNode<QuizText>()
                    {
                        Data = new QuizText("Have you completed the university?"),
                        Children = new List<BTreeNode<QuizText>>()
                        {
                            new BTreeNode<QuizText>()
                            {
                                Data = new QuizText("Apply for a junior developer!")
                            },
                            new BTreeNode<QuizText>()
                            {
                                Data = new QuizText("Will you find some time during the semester?"),
                                Children = new List<BTreeNode<QuizText>>()
                                {
                                    new BTreeNode<QuizText>()
                                    {
                                        Data = new QuizText("Apply for our long-time internship program!")
                                    },
                                    new BTreeNode<QuizText>()
                                    {
                                        Data = new QuizText("Apply for summer internship program!")
                                    }
                                }
                            }
                        }
                    }
                }
            };
            tree.Count = tree.Root.GetHeight();
            return tree;
        }

        static void WriteAnswer(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}