///////////////////////////////////////////////////////////////////////////////
//
// Author: Blaine Anderson, Andersonjb1@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 5
// Description: Example of a quiz using a binary tree.
//
///////////////////////////////////////////////////////////////////////////////
namespace Anderson_Project5
{
    /// <summary>
    /// node for the binary tree with left and right properties
    /// to ensure there are only two children per node.
    /// </summary>
    /// <typeparam name="T"> generic type in this case used as a string for the quiz </typeparam>
    public class BTreeNode<T>
    {
        /// <summary>
        /// value within each node
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Left and Right child of each node 
        /// </summary>
        public BTreeNode<T> Left, Right;

        /// <summary>
        /// constructor that takes a generic type as a parameter
        /// and on creation sets its right and left children to null
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
