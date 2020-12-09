using System;
using System.Collections.Generic;

namespace bintree
{
    class NodeList
    {
        public List<Node> _nodeList { get; private set; }
        public Node _currentNode { get; private set; }

        public NodeList()
        {
            _nodeList = new List<Node>();
            _nodeList.Add(new Node("Root"));
            _currentNode = _nodeList.Find(x => x._data == "Root");
        }

        public void addNode(string dataNode)
        {
            _nodeList.Add(new Node(dataNode));
        }
        public void addLink(string nodeBase, string nodeLink)
        {
            Node nodeBase_Temp = _nodeList.Find(x => x._data == nodeBase);
            Node nodeLink_Temp = _nodeList.Find(x => x._data == nodeLink);
            nodeBase_Temp._nextNodes.Add(nodeLink_Temp);
        }
        public void setCurrentNode(string currentNode)
        {
            _currentNode = _nodeList.Find(x => x._data == currentNode);
        }
    }

    class Node
    {
        public List<Node> _nextNodes { get; private set; }
        public string _data { get; private set; }

        public Node(string data)
        {
            _data = data;
            _nextNodes = new List<Node>();
        }
    }
}
