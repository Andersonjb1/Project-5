namespace Anderson_Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                BinaryTree<QuizText> tree = GetTree();
                BinaryTreeNode<QuizText> node = tree.Root;
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
        }

        public class QuizText
        {
            public string Text { get; set; }
            public QuizText(string text) => Text = text;
        }

        private static BinaryTree<QuizText> GetTree()
        {
            BinaryTree<QuizText> tree = new BinaryTree<QuizText>();
            tree.Root = new BinaryTreeNode<QuizText>()
            {
                Data = new QuizText("Do you have experience in developing applications ? "),

                Children = new List<TreeNode<QuizText>>()
                {
            new BinaryTreeNode<QuizText>()
            {
                Data = new QuizText("Have you worked as a developer for more than 5 years ? "),
                Children = new List<TreeNode<QuizText>>()
                {
                    new BinaryTreeNode<QuizText>()
                    {
                        Data = new QuizText("Apply as a senior developer!")
                    },
                    new BinaryTreeNode<QuizText>()
                    {
                        Data = new QuizText("Apply as a middle developer!")
                    }
                }
            },
            new BinaryTreeNode<QuizText>()
            {
                Data = new QuizText("Have you completed the university?"),
                Children = new List<TreeNode<QuizText>>()
                {
                    new BinaryTreeNode<QuizText>()
                    {
                        Data = new QuizText("Apply for a junior developer!")
                    },
                    new BinaryTreeNode<QuizText>()
                    {
                        Data = new QuizText("Will you find some time during the semester?"),
                        Children = new List<TreeNode<QuizText>>()
                        {
                            new BinaryTreeNode<QuizText>()
                            {
                                Data = new QuizText("Apply for our long-time internship program!")
                            },
                            new BinaryTreeNode<QuizText>()
                            {
                                Data = new QuizText("Apply for summer internship program!")
                            }
                        }
                    }
                }
            }
}
            };
            tree.Count = 9;
            return tree;
        }

        static void WriteAnswer(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}