namespace Tree
{
    public class BinaryTree
    {

        public Node? Parent { get; set; }

        public class Node
        {
            public Node? Left { get; set; }
            public Node? Right { get; set; }
            public int Value { get; set; }
            public Node? Parent { get; set; }
        }

        /// <summary>
        /// Add a root element to a tree, throw an error incase its non empty.
        /// </summary>
        /// <param name="value"></param>
        public void AddRoot(int value)
        {

        }

        /// <summary>
        /// Add a left child to the node. This throws an exception if the left 
		/// element is already present for the node.
		/// The method returns the Node that was added.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        public void AddLeft(Node node, int value)
        {

        }

        /// <summary>
        /// Add a right child to the node. This throws an exception if the 
		/// right child is already present for this node.
		/// The method returns the Node that was added. 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>	
        public void AddRight(Node node, int value)
        {

        }

        /// <summary>
        /// Replaces element stored at Node with a value v.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        public void Replace(Node node, int value)
        {

        }

        /// <summary>
        /// Deletes a node. Returns the value of the node that was deleted.
		/// Replace with the child. Incase the node has two children, an 
		/// exception is thrown.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int Delete(Node node)
        {
            return -1;
        }

        /// <summary>
        /// 1. Attach tree1 and tree2 as left subtrees to the main tree.
		/// 2. Reset tree1 and tree2 to null.
		/// 3. Throw an error if the node is not a leaf.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="tree1"></param>
        /// <param name="tree2"></param>
        public void Attach(Node node, BinaryTree tree1, BinaryTree tree2)
        {

        }


    }
}
