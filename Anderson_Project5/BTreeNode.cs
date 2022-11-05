using System.Xml.Linq;

namespace Anderson_Project5
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BTreeNode<T>
    {
        /// <summary>
        /// 
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public BTreeNode<T> Parent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<BTreeNode<T>> Children { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public BTreeNode<string> Left, Right;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public BTreeNode(T data)
        {
            this.Data = data;
            this.Right = null;
            this.Left = null;
        }
    }
}
