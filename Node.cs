namespace Binary_Trees
{
    public class Node
    {
        public int value;
        public Node? left = null;
        public Node? right = null;

        public Node(int aValue)
        {
            if (aValue == null)
            {
                throw new Exception("Value cannot be null");
            }
            value = aValue;

        }

        public bool AddNode(int Value)
        {

            if (Value != value)
            {
                if (Value != null)
                {
                    if (Value < value)
                    {
                        if (left == null)
                        {
                            left = new Node(Value);
                            return true;
                        }
                        else
                        {
                            left.AddNode(Value);
                            return true;
                        }
                    }
                    else if (Value > value)
                    {
                        if (right == null)
                        {
                            right = new Node(Value);
                            return true;
                        }
                        else
                        {
                            right.AddNode(Value);
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return true;
            }
        }

        public int[] Visit(int[]? oD)
        {

            int[] data = new int[0];
            if (oD != null)
            {
                data = oD;
            }

            if (left != null)
            {
                int[] nd = left.Visit(data);
                data = nd;
                Array.Resize(ref data, data.Length + 1);
                data[data.Length - 1] = value;
                //Console.WriteLine(value);

                if (right != null)
                {
                    Array.Resize(ref data, data.Length + 1);
                    data[data.Length - 1] = value;
                    int[] nnd = right.Visit(data);
                    data = nnd;
                    //Console.WriteLine(value);

                }
                return data;
            }
            if (left == null)
            {
                if (right == null)
                {

                    Array.Resize(ref data, data.Length + 1);
                    data[data.Length - 1] = value;
                    return data;
                }
                if (right != null)
                {
                    Array.Resize(ref data, data.Length + 1);
                    data[data.Length - 1] = value;
                    int[] nd = right.Visit(data);
                    data = nd;
                    //Console.WriteLine(value);
                    return data;
                }
            }

            return data;
        }

        public int[] RVisit(int[]? oD)
        {

            int[] data = new int[0];
            if (oD != null)
            {
                data = oD;
            }

            if (right != null)
            {
                int[] nd = right.RVisit(data);
                data = nd;
                Array.Resize(ref data, data.Length + 1);
                data[data.Length - 1] = value;
                //Console.WriteLine(value);

                if (left != null)
                {
                    Array.Resize(ref data, data.Length + 1);
                    data[data.Length - 1] = value;
                    int[] nnd = left.RVisit(data);
                    data = nnd;
                    //Console.WriteLine(value);

                }
                return data;
            }
            if (right == null)
            {
                if (left == null)
                {

                    Array.Resize(ref data, data.Length + 1);
                    data[data.Length - 1] = value;
                    return data;
                }
                if (left != null)
                {
                    Array.Resize(ref data, data.Length + 1);
                    data[data.Length - 1] = value;
                    int[] nd = left.RVisit(data);
                    data = nd;
                    //Console.WriteLine(value);
                    return data;
                }
            }

            return data;
        }

        public Node? FindNode(int sValue)
        {
            if (sValue == value)
            {
                return this;
            }
            else if (sValue < value)
            {
                if (left != null)
                {
                    Node? result = left.FindNode(sValue);
                    if (result != null)
                    {
                        return this;
                    }
                }
            }
            else if (sValue > value)
            {
                if (right != null)
                {
                    Node? result = right.FindNode(sValue);
                    if (result != null)
                    {
                        return this;
                    }
                }
            }

            return null;
        }

        public Node? NodeFindNode(Node? sNode)
        {
            if (sNode != null)
            {
                if (sNode == this)
                {
                    return this;
                }
                else if (sNode.value < value)
                {
                    if (left != null)
                    {
                        Node? result = left.NodeFindNode(sNode);
                        if (result != null)
                        {
                            return this;
                        }
                    }
                }
                else if (sNode.value > value)
                {
                    if (right != null)
                    {
                        Node? result = right.NodeFindNode(sNode);
                        if (result != null)
                        {
                            return this;
                        }
                    }
                }

                return null;
            }
            return null;
        }

        public bool FindBool(int sValue)
        {
            if (sValue == value)
            {
                return true;
            }
            else if (sValue < value)
            {
                if (left != null)
                {
                    bool result = left.FindBool(sValue);
                    if (result)
                    {
                        return true;
                    }
                }
            }
            else if (sValue > value)
            {
                if (right != null)
                {
                    bool result = right.FindBool(sValue);
                    if (result)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool NodeFindBool(Node? sNode)
        {
            if (sNode != null)
            {
                if (sNode == this)
                {
                    return true;
                }
                else if (sNode.value < value)
                {
                    if (left != null)
                    {
                        bool result = left.NodeFindBool(sNode);
                        if (result)
                        {
                            return true;
                        }
                    }
                }
                else if (sNode.value > value)
                {
                    if (right != null)
                    {
                        bool result = right.NodeFindBool(sNode);
                        if (result)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
            return false;
        }

        public int[] FindMax(int n, int[]? oD)
        {
            int[] data = new int[0];
            if (oD != null)
            {
                data = oD;
            }
            if (data.Length < n)
            {


                if (right != null)
                {
                    if (data.Length < n)
                    {
                        int[] nd = right.RVisit(data);
                        if (nd.Length < n)
                        {
                            data = nd;
                        }
                        else
                        {
                            Array.Resize(ref nd, n);
                            data = nd;
                        }
                        if (data.Length < n)
                        {
                            Array.Resize(ref data, data.Length + 1);
                            data[data.Length - 1] = value;
                        }
                        //Console.WriteLine(value);
                    }
                    else
                    {
                        return data;
                    }

                    if (left != null)
                    {
                        if (data.Length < n)
                        {


                            Array.Resize(ref data, data.Length + 1);
                            data[data.Length - 1] = value;
                            int[] nnd = left.RVisit(data);
                            if (nnd.Length < n)
                            {
                                data = nnd;
                            }
                            else
                            {
                                Array.Resize(ref nnd, n);
                                data = nnd;
                            }
                            //Console.WriteLine(value);
                        }
                        else
                        {
                            return data;
                        }
                    }
                    if (data.Length < n)
                    {
                        return data;
                    }
                    else
                    {
                        return data;
                    }
                }
                if (right == null)
                {
                    if (left == null)
                    {
                        if (data.Length < n)
                        {
                            Array.Resize(ref data, data.Length + 1);
                            data[data.Length - 1] = value;
                            return data;
                        }
                        else
                        {
                            return data;
                        }
                    }
                    if (left != null)
                    {
                        if (data.Length < n)
                        {
                            Array.Resize(ref data, data.Length + 1);
                            data[data.Length - 1] = value;
                            int[] nd = left.RVisit(data);
                            if (nd.Length < n)
                            {
                                data = nd;
                            }
                            else
                            {
                                Array.Resize(ref nd, n);
                                data = nd;
                            }


                            return data;

                            //Console.WriteLine(value);

                        }
                        else
                        {
                            return data;
                        }
                    }
                }

                return data;
            }
            else
            {
                return data;
            }
        }

        public int[] FindMin(int n, int[]? oD)
        {
            int[] data = new int[0];
            if (oD != null)
            {
                data = oD;
            }
            if (data.Length < n)
            {


                if (left != null)
                {
                    if (data.Length < n)
                    {
                        int[] nd = left.Visit(data);
                        if (nd.Length < n)
                        {
                            data = nd;
                        }
                        else
                        {
                            Array.Resize(ref nd, n);
                            data = nd;
                        }
                        if (data.Length < n)
                        {
                            Array.Resize(ref data, data.Length + 1);
                            data[data.Length - 1] = value;
                        }
                        //Console.WriteLine(value);
                    }
                    else
                    {
                        return data;
                    }

                    if (right != null)
                    {
                        if (data.Length < n)
                        {


                            Array.Resize(ref data, data.Length + 1);
                            data[data.Length - 1] = value;
                            int[] nnd = right.Visit(data);
                            if (nnd.Length < n)
                            {
                                data = nnd;
                            }
                            else
                            {
                                Array.Resize(ref nnd, n);
                                data = nnd;
                            }
                            //Console.WriteLine(value);
                        }
                        else
                        {
                            return data;
                        }
                    }
                    if (data.Length < n)
                    {
                        return data;
                    }
                    else
                    {
                        return data;
                    }
                }
                if (left == null)
                {
                    if (right == null)
                    {
                        if (data.Length < n)
                        {
                            Array.Resize(ref data, data.Length + 1);
                            data[data.Length - 1] = value;
                            return data;
                        }
                        else
                        {
                            return data;
                        }
                    }
                    if (right != null)
                    {
                        if (data.Length < n)
                        {
                            Array.Resize(ref data, data.Length + 1);
                            data[data.Length - 1] = value;
                            int[] nd = right.Visit(data);
                            if (nd.Length < n)
                            {
                                data = nd;
                            }
                            else
                            {
                                Array.Resize(ref nd, n);
                                data = nd;
                            }


                            return data;

                            //Console.WriteLine(value);

                        }
                        else
                        {
                            return data;
                        }
                    }
                }

                return data;
            }
            else
            {
                return data;
            }
        }

        public int[] NDVisit(int[]? oD)
        {

            int[] data = new int[0];
            if (oD != null)
            {
                data = oD;
            }

            if (left != null)
            {
                int[] nd = left.NDVisit(data);
                data = nd;
                Array.Resize(ref data, data.Length + 1);
                data[data.Length - 1] = value;
                //Console.WriteLine(value);

                if (right != null)
                {
                    Array.Resize(ref data, data.Length + 1);
                    data[data.Length - 1] = value;
                    int[] nnd = right.NDVisit(data);
                    data = nnd;
                    //Console.WriteLine(value);

                }
                data = data.Distinct().ToArray();
                return data;
            }
            if (left == null)
            {
                if (right == null)
                {

                    Array.Resize(ref data, data.Length + 1);
                    data[data.Length - 1] = value;
                    data = data.Distinct().ToArray();
                    return data;
                }
                if (right != null)
                {
                    Array.Resize(ref data, data.Length + 1);
                    data[data.Length - 1] = value;
                    int[] nd = right.NDVisit(data);
                    data = nd;
                    //Console.WriteLine(value);
                    data = data.Distinct().ToArray();
                    return data;
                }
            }
            data = data.Distinct().ToArray();
            return data;
        }

        public int[] NDRVisit(int[]? oD)
        {

            int[] data = new int[0];
            if (oD != null)
            {
                data = oD;
            }

            if (right != null)
            {
                int[] nd = right.NDRVisit(data);
                data = nd;
                Array.Resize(ref data, data.Length + 1);
                data[data.Length - 1] = value;
                //Console.WriteLine(value);

                if (left != null)
                {
                    Array.Resize(ref data, data.Length + 1);
                    data[data.Length - 1] = value;
                    int[] nnd = left.NDRVisit(data);
                    data = nnd;
                    //Console.WriteLine(value);

                }
                data = data.Distinct().ToArray();
                return data;
            }
            if (right == null)
            {
                if (left == null)
                {

                    Array.Resize(ref data, data.Length + 1);
                    data[data.Length - 1] = value;
                    data = data.Distinct().ToArray();
                    return data;
                }
                if (left != null)
                {
                    Array.Resize(ref data, data.Length + 1);
                    data[data.Length - 1] = value;
                    int[] nd = left.NDRVisit(data);
                    data = nd;
                    //Console.WriteLine(value);
                    data = data.Distinct().ToArray();
                    return data;
                }
            }
            data = data.Distinct().ToArray();
            return data;
        }

        public int[] NDFindMax(int n, int[]? oD)
        {
            int[] data = new int[0];
            if (oD != null)
            {
                data = oD;
            }
            if (data.Length < n)
            {


                if (right != null)
                {
                    if (data.Length < n)
                    {
                        int[] nd = right.NDRVisit(data);
                        if (nd.Length < n)
                        {
                            data = nd;
                        }
                        else
                        {
                            Array.Resize(ref nd, n);
                            data = nd;
                        }
                        if (data.Length < n)
                        {
                            Array.Resize(ref data, data.Length + 1);
                            data[data.Length - 1] = value;
                        }
                        //Console.WriteLine(value);
                    }
                    else
                    {
                        data = data.Distinct().ToArray();
                        return data;
                    }

                    if (left != null)
                    {
                        if (data.Length < n)
                        {


                            Array.Resize(ref data, data.Length + 1);
                            data[data.Length - 1] = value;
                            int[] nnd = left.NDRVisit(data);
                            if (nnd.Length < n)
                            {
                                data = nnd;
                            }
                            else
                            {
                                Array.Resize(ref nnd, n);
                                data = nnd;
                            }
                            //Console.WriteLine(value);
                        }
                        else
                        {
                            data = data.Distinct().ToArray();
                            return data;
                        }
                    }
                    if (data.Length < n)
                    {
                        data = data.Distinct().ToArray();
                        return data;
                    }
                    else
                    {
                        data = data.Distinct().ToArray();
                        return data;
                    }
                }
                if (right == null)
                {
                    if (left == null)
                    {
                        if (data.Length < n)
                        {
                            Array.Resize(ref data, data.Length + 1);
                            data[data.Length - 1] = value;
                            data = data.Distinct().ToArray();
                            return data;
                        }
                        else
                        {
                            data = data.Distinct().ToArray();
                            return data;
                        }
                    }
                    if (left != null)
                    {
                        if (data.Length < n)
                        {
                            Array.Resize(ref data, data.Length + 1);
                            data[data.Length - 1] = value;
                            int[] nd = left.NDRVisit(data);
                            if (nd.Length < n)
                            {
                                data = nd;
                            }
                            else
                            {
                                Array.Resize(ref nd, n);
                                data = nd;
                            }

                            data = data.Distinct().ToArray();
                            return data;

                            //Console.WriteLine(value);

                        }
                        else
                        {
                            data = data.Distinct().ToArray();
                            return data;
                        }
                    }
                }
                data = data.Distinct().ToArray();
                return data;
            }
            else
            {
                data = data.Distinct().ToArray();
                return data;
            }
        }

        public int[] NDFindMin(int n, int[]? oD)
        {
            int[] data = new int[0];
            if (oD != null)
            {
                data = oD;
            }
            if (data.Length < n)
            {


                if (left != null)
                {
                    if (data.Length < n)
                    {
                        int[] nd = left.NDVisit(data);
                        if (nd.Length < n)
                        {
                            data = nd;
                        }
                        else
                        {
                            Array.Resize(ref nd, n);
                            data = nd;
                        }
                        if (data.Length < n)
                        {
                            Array.Resize(ref data, data.Length + 1);
                            data[data.Length - 1] = value;
                        }
                        //Console.WriteLine(value);
                    }
                    else
                    {
                        data = data.Distinct().ToArray();
                        return data;
                    }

                    if (right != null)
                    {
                        if (data.Length < n)
                        {


                            Array.Resize(ref data, data.Length + 1);
                            data[data.Length - 1] = value;
                            int[] nnd = right.NDVisit(data);
                            if (nnd.Length < n)
                            {
                                data = nnd;
                            }
                            else
                            {
                                Array.Resize(ref nnd, n);
                                data = nnd;
                            }
                            //Console.WriteLine(value);
                        }
                        else
                        {
                            data = data.Distinct().ToArray();
                            return data;
                        }
                    }
                    if (data.Length < n)
                    {
                        data = data.Distinct().ToArray();
                        return data;
                    }
                    else
                    {
                        data = data.Distinct().ToArray();
                        return data;
                    }
                }
                if (left == null)
                {
                    if (right == null)
                    {
                        if (data.Length < n)
                        {
                            Array.Resize(ref data, data.Length + 1);
                            data[data.Length - 1] = value;
                            data = data.Distinct().ToArray();
                            return data;
                        }
                        else
                        {
                            data = data.Distinct().ToArray();
                            return data;
                        }
                    }
                    if (right != null)
                    {
                        if (data.Length < n)
                        {
                            Array.Resize(ref data, data.Length + 1);
                            data[data.Length - 1] = value;
                            int[] nd = right.NDVisit(data);
                            if (nd.Length < n)
                            {
                                data = nd;
                            }
                            else
                            {
                                Array.Resize(ref nd, n);
                                data = nd;
                            }

                            data = data.Distinct().ToArray();
                            return data;

                            //Console.WriteLine(value);

                        }
                        else
                        {
                            data = data.Distinct().ToArray();
                            return data;
                        }
                    }
                }

                return data;
            }
            else
            {
                return data;
            }
        }
    }
}
