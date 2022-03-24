namespace Binary_Trees
{
    public class Tree
    {
        public Node root;

        public Tree(int aroot)
        {
            root = new Node(aroot);
            if (aroot == null)
            {
                throw new Exception("Root cannot be null");
            }
        }

        public bool Add(int value)
        {
            if (value != null)
            {
                bool result = root.AddNode(value);
                if (result == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("Value cannot be null");
            }
        }

        public int[] Navigate()
        {
            int[] data = root.Visit(null);

            return data;
        }

        public Node? SearchNode(int sValue)
        {
            Node? result = root.FindNode(sValue);
            return result;
        }

        public bool SearchBool(int sValue)
        {
            bool result = root.FindBool(sValue);
            return result;
        }

        public Node? NodeSearchNode(Node? sNode)
        {
            Node? result = root.NodeFindNode(sNode);
            return result;
        }

        public bool NodeSearchBool(Node? sNode)
        {
            bool result = root.NodeFindBool(sNode);
            return result;
        }

        public int[] RNavigate()
        {
            int[] data = root.RVisit(null);

            return data;
        }

        public int[] Major(int n)
        {
            int[] majors = new int[n];
            majors = root.FindMax(n, null);
            return majors;
        }

        public int[] Minor(int n)
        {
            int[] minors = new int[n];
            minors = root.FindMin(n, null);
            return minors;
        }

        public int[] NDRNavigate()
        {
            int[] data = root.NDRVisit(null);

            return data;
        }

        public int[] NDMajor(int n)
        {
            int[] majors = new int[n];
            majors = root.NDFindMax(n, null);
            return majors;
        }

        public int[] NDMinor(int n)
        {
            int[] minors = new int[n];
            minors = root.NDFindMin(n, null);
            return minors;
        }

        public int[] NDNavigate()
        {
            int[] data = root.NDVisit(null);

            return data;
        }

    }
}