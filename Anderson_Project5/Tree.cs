using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishHook
{
    public class TreeNode<DATA>
    {
        public DATA Data { get; set; }
        public List<TreeNode<DATA>> Children { get; private set; }

        public TreeNode(DATA data)
        {
            Data = data;
            Children = new List<TreeNode<DATA>>();
        }

        public void AddChild(Tree<DATA> tree)
        {
            Children.Add(tree.Root);
        }

        public void AddChild(TreeNode<DATA> node)
        { 
            Children.Add(node);
        }

        public void AddChild(DATA stuff)
        {
            Children.Add(new TreeNode<DATA>(stuff));
        }
    }

    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }

        public Tree() 
        {
        
        }

        public Tree(TreeNode<T> root)
        {
            this.Root = root;
        }

        public Tree(T data)
        {
            this.Root = new TreeNode<T>(data);
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(Root, 0);
        }

        public void PostOrderTraversal(TreeNode<T> startNode, int depth) {
            // SAVE THE CHILDREN!!!
            // Traverse Children first

            foreach (var child in startNode.Children)
            {
                PostOrderTraversal(child, depth+1);
            }

            // Then Display ourself
            for (int i = 0; i < depth; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine(startNode.Data.ToString());
        }

        public void PreOrderTraversal(TreeNode<T> startNode, int depth)
        {
            // PUT ON YOUR OWN MASK BEFORE ASSISTING ANY CHILDREN

            //  Display ourself
            for (int i = 0; i < depth; i++)
            {
                Console.Write(">>>>>");
            }
            Console.WriteLine(startNode.Data.ToString());

            // Traverse Children 

            foreach (var child in startNode.Children)
            {
                PreOrderTraversal(child, depth + 1);
            }
        }
    }
}
