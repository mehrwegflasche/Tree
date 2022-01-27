public abstract class Tree
{
    private bool _isEmpty;
    public abstract class Position
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
        public abstract bool Equals(Position p);

        /// <summary>
        /// Returns true if the position represents the same location.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public abstract bool NotEquals(Position p);
    }

    /// <summary>
    /// Return position representing the tree's root.
    /// This may return null if the root is empty.
    /// </summary>
    /// <value></value>
    public abstract Position Root { get; set; }

    /// <summary>
    /// Returns position representing the Parent.
    /// </summary>
    /// <value></value>
    public abstract Position Parent { get; set; }

    /// <summary>
    /// Returns the number of children the Position has.
    /// </summary>
    /// <value></value>
    public abstract int NumberOfChildren(Position p);

    /// <summary>
    /// Returns a list of Postions representing p's children.
    /// </summary>
    /// <value></value>
    public abstract List<Position> Children(Position p);

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
    public bool IsRoot(Position p)
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
    public bool IsLeaf(Position p)
    {
        return NumberOfChildren(p) == 0;
    }

    /// <summary>
    /// The depth of the the position of a tree is 1+depth of the parent.
    /// </summary>
    /// <param name="p"></param>
    /// <returns></returns>
    public int Depth(Position p)
    {
        if (IsRoot(p))
        {
            return 0;
        }
        else
        {
            return 1 + Depth(this.Parent);
        }
    }

    //TODO Implement Height





}