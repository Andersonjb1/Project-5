namespace Anderson_Project5
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BTree<T>
    {
        /// <summary>
        /// 
        /// </summary>
        public BTreeNode<T> Root { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public BTreeNode<string> insertLevelOrder(string[] arr, int i)
        {
            BTreeNode<string> root = null;
            // recursive calling to create child nodes
            if (i < arr.Length)
            {
                root = new BTreeNode<string>(arr[i]);

                // insert left child
                root.Left = insertLevelOrder(arr, 2*i + 2);

                // insert right child
                root.Right = insertLevelOrder(arr, 2*i + 1);
            }
            return root;
        }
    }
}
