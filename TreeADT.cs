public abstract class TreeADT
{
    private bool _isEmpty;
    public abstract class Node
    {
        /// <summary>
        /// Returns the element stored.
        /// </summary>
        /// <returns></returns>
        public abstract int GetElement();

        /// <summary>
        /// Returns true if the position represents the same location.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public abstract bool Equals(Node p);

        /// <summary>
        /// Returns true if the position represents the same location.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public abstract bool NotEquals(Node p);
    }

    /// <summary>
    /// Return position representing the tree's root.
    /// This may return null if the root is empty.
    /// </summary>
    /// <value></value>
    public abstract Node Root { get; set; }

    /// <summary>
    /// Returns position representing the Parent.
    /// </summary>
    /// <value></value>
    public abstract Node Parent(Node p);

    /// <summary>
    /// Returns the number of children the Position has.
    /// </summary>
    /// <value></value>
    public abstract int NumberOfChildren(Node p);

    /// <summary>
    /// Returns a list of Postions representing p's children.
    /// </summary>
    /// <value></value>
    public abstract List<Node> Children(Node p);

    /// <summary>
    /// Returns the total number of elements in a tree. 
    /// </summary>
    /// <value></value>
    public abstract int Length { get; set; }

    /// <summary>
    /// Returns if the position is the root.
    /// </summary>
    /// <param name="p"></param>
    /// <returns></returns>
    public bool IsRoot(Node p)
    {
        return Root == p;
    }

    /// <summary>
    /// Returns true if the tree doesnt have any elements.
    /// </summary>
    /// <value></value>
    public bool IsEmpty()
    {
        return Length == 0;
    }

    /// <summary>
    /// Returns if the position is the leaf.
    /// </summary>
    /// <param name="p"></param>
    /// <returns></returns>
    public bool IsLeaf(Node p)
    {
        return NumberOfChildren(p) == 0;
    }

    /// <summary>
    /// The depth of the the position of a tree is 1+depth of the parent.
    /// </summary>
    /// <param name="p"></param>
    /// <returns></returns>
    public int Depth(Node p)
    {
        if (IsRoot(p))
        {
            return 0;
        }
        else
        {
            return 1 + Depth(Parent(p));
        }
    }

    //TODO Implement Height





}