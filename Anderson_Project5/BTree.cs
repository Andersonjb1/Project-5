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
    /// Represents the whole binary tree using the generic class
    /// to specify the type of data stored in each node. 
    /// </summary>
    /// <typeparam name="T"> generic type to choose what is stored in each node </typeparam>
    public class BTree<T>
    {
        /// <summary>
        /// The root node as an instance of the BTreeNode class.
        /// </summary>
        public BTreeNode<T> Root { get; set; }
        /// <summary>
        /// Total number of nodes in the tree.
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Takes the given array of generic type
        /// and inserts the data into a tree at an index
        /// </summary>
        /// <param name="array"> generic type array that is inserted into the binary tree </param>
        /// <param name="i"> integer index passed to the method </param>
        /// <returns></returns>
        public BTreeNode<T> InsertData(T[] array, int i)
        {
            BTreeNode<T> root = null;
            // recursive calling to create child nodes
            if (i < array.Length)
            {
                root = new BTreeNode<T>(array[i]);

                // insert left child
                root.Left = InsertData(array, 2*i + 2);

                // insert right child
                root.Right = InsertData(array, 2*i + 1);
            }
            return root;
        }
    }
}
