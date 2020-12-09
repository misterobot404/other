
namespace bintree
{
    public class BinaryTree
    {
        public long? Data { get; private set; }
        public BinaryTree Left { get; set; }
        public BinaryTree Right { get; set; }
        public BinaryTree Parent { get; set; }

        public void Insert(long data)
        {
            if (Data == null || Data == data)
            {
                Data = data;
                return;
            }
            if (Data > data)
            {
                if (Left == null) Left = new BinaryTree();
                Insert(data, Left, this);
            }
            else
            {
                if (Right == null) Right = new BinaryTree();
                Insert(data, Right, this);
            }
        }
        private void Insert(long data, BinaryTree node, BinaryTree parent)
        {

            if (node.Data == null || node.Data == data)
            {
                node.Data = data;
                node.Parent = parent;
                return;
            }
            if (node.Data > data)
            {
                if (node.Left == null) node.Left = new BinaryTree();
                Insert(data, node.Left, node);
            }
            else
            {
                if (node.Right == null) node.Right = new BinaryTree();
                Insert(data, node.Right, node);
            }
        }

        public BinaryTree Find(long data)
        {
            if (Data == data) return this;
            if (Data > data)
            {
                return Find(data, Left);
            }
            return Find(data, Right);
        }
        private BinaryTree Find(long data, BinaryTree node)
        {
            if (node == null) return null;

            if (node.Data == data) return node;
            if (node.Data > data)
            {
                return Find(data, node.Left);
            }
            return Find(data, node.Right);
        }

        public int MinEl()
        {
            return MinEl((int)Data, Left);
        }
        private int MinEl(int data, BinaryTree node)
        {
            if (node == null) return data;

            if (node.Data < data)
            {
                return MinEl((int)node.Data, node.Left);
            }
            return data;
        }

        public int MaxEl()
        {
            return MaxEl((int)Data, Right);
        }
        private int MaxEl(int data, BinaryTree node)
        {
            if (node == null) return data;

            if (node.Data > data)
            {
                return MaxEl((int)node.Data, node.Right);
            }          
            return data;
        }

        public int NodeAmount()
        {
            return NodeAmount(Left) + NodeAmount(Right) + 1;
        }
        private int NodeAmount(BinaryTree node)
        {
            if (node == null) return 0;
            return NodeAmount(node.Left) + NodeAmount(node.Right) + 1;
        }

        public int Height()
        {
            if(Height(Left) < Height(Right))
            {
                return Height(Right) + 1;
            }
            else
            {
                return Height(Left) + 1;
            }
        }
        private int Height(BinaryTree node)
        {
            if (node == null) return 0;

            if (Height(node.Left) < Height(node.Right))
            {
                return Height(node.Right) +1;
            }
            else
            {
                return Height(node.Left) +1;
            }
        }

        public int ListAmount()
        {
            return ListAmount(0, Left) + ListAmount(0, Right);
        }
        private int ListAmount(int amount, BinaryTree node)
        {
            if (node == null) return 0;

            if (node.Left == null && node.Right == null)
            {
                return amount + 1;
            }
            else
            {
                return ListAmount(amount, node.Left) + ListAmount(amount, node.Right);
            }
        }

    }
}
