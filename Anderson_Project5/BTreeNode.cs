namespace Anderson_Project5
{

    public class BTreeNode<T>
    {
        public BTreeNode() => Children =
            new List<BTreeNode<T>>() { null, null };
        public T Data { get; set; }
        public BTreeNode<T> Parent { get; set; }
        public List<BTreeNode<T>> Children { get; set; }

        public BTreeNode<T> Left
        {
            get { return (BTreeNode<T>)Children[0]; }
            set { Children[0] = value; }
        }

        public BTreeNode<T> Right
        {
            get { return (BTreeNode<T>)Children[1]; }
            set { Children[1] = value; }
        }

        public int GetHeight()
        {
            int height = 1;
            BTreeNode<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }
    }
}
