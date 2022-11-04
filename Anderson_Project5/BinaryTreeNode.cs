namespace Anderson_Project5
{

    public class BinaryTreeNode<T>
    {
        public BinaryTreeNode() => Children =
            new List<BinaryTreeNode<T>>() { null, null };
        public T Data { get; set; }
        public BinaryTreeNode<T> Parent { get; set; }
        public List<BinaryTreeNode<T>> Children { get; set; }

        public BinaryTreeNode<T> Left
        {
            get { return (BinaryTreeNode<T>)Children[0]; }
            set { Children[0] = value; }
        }

        public BinaryTreeNode<T> Right
        {
            get { return (BinaryTreeNode<T>)Children[1]; }
            set { Children[1] = value; }
        }

        public int GetHeight()
        {
            int height = 1;
            BinaryTreeNode<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }
    }
}
