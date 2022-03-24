The functions of this library are pretty simple and easy to understand, there are only a few function for now and they can all be executed on the tree object istance:

1)tree.Add(int value), it adds a new node with a value to the tree and auto sorts it, it returns true if it succedes and false if it doesn't;
2)tree.Navigate(), this returns an array of all the values in the tree from smallest to biggest;
3)tree.RNavigate(), same as navigate but the array is from biggest to smallest;
4)tree.FindBool(int value), searches the tree for a node with the specified value and returns true if it exist and false if it doesn't;
5)tree.FindNode(int value), searches the tree to find a node with the specified value and returns it;
6)tree.NodeSearchBool(Node node), searches a specific node object with all of it's attributes and returns true or false depending on the result of the search;
7)tree.NodeSeachNode(Node node), seaches a node objects and returns it, completely useless but i added it anyways;
8)tree.Major(int N), finds the biggest values and returns the in an array length N;
9)tree.Minor(int N), finds the smallest values and returns the in an array length N;

All of the functions that return an array also return duplicates if they exist, adding ND as a prefix{e.g. tree.NDNavigate()}
to any of those will make the return an array with no duplicates.
