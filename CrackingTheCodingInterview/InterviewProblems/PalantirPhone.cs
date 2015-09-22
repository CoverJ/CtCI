using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.InterviewProblems
{
    /* PHONE INTERVIEW FOR FORWARD DEPLOYED SOFTWARE ENGINEER CIRCA MAY 2015
     * 1. Create a node class for a graph, the node should store information for firstly the nodes name and secondly a store of that nodes children.
     * 
     * 2. Create a method to find the lowest common ancestor given 2 nodes.
     * 
     * How I Went: Got the logic correct eventually but couldn't code a solution in time. So am using this as a method to improve.
     * To solve this problem my idea is to breadth first search the family tree, the SearchPath(node n) method performs this search and then tacks on n's parent node at the end.
     * This is needed to differentiate two nodes who are in the same level of hierarchy.
     * After the two nodes paths are gathered the paths are compared in LowestCommonAncestor()
     * the first name in path2 that doesnt match path1 is where the paths diverge and because path1 is shorter thats has to be the answer.
     * 
     * SOLUTION IS TESTED AND WORKING BUT DOES ASSUME BOTH NODES EXIST
     */
    class PalantirPhone
    {   
        static void solution()
        {
            #region TEST DATA
            var mum = new FTNode();
            mum.name = "mum";

            var john = new FTNode();
            john.name = "john";

            var ron = new FTNode();
            ron.name = "ron";

            var ben = new FTNode();
            ben.name = "ben";

            var mitch = new FTNode();
            mitch.name = "mitch";

            var daniel = new FTNode();
            daniel.name = "daniel";

            var andrew = new FTNode("andrew");

            var neville = new FTNode("neville");

            var josh = new FTNode("josh");

            var christina = new FTNode("christina");

            var ellie = new FTNode("ellie");

            var doug = new FTNode("doug");

            // Mum Connections
            mum.children.Add(john);
            mum.children.Add(ron);
            mum.children.Add(ben);
            // John Connections
            john.children.Add(mitch);
            // Ron Connections
            ron.children.Add(daniel);
            // Ben Connections
            ben.children.Add(andrew);
            ben.children.Add(doug);
            // Mitch Connections
            mitch.children.Add(neville);
            // Daniel Connections
            daniel.children.Add(josh);
            // Andrew Connections
            andrew.children.Add(christina);
            andrew.children.Add(ellie);
            #endregion
            var ft = new FamilyTree(mum);
            ft.LowerCommonAncestor(doug, ellie);
            Console.ReadLine();
        }
    }

    /// <summary>
    /// Node data structure for the family tree
    /// </summary>
    class FTNode
    {
        public string name;
        public List<FTNode> children;

        public FTNode()
        {
            children = new List<FTNode>();
        }
        public FTNode(string _name)
        {
            this.name = _name;
            children = new List<FTNode>();
        }
    }

    /// <summary>
    /// Data structure to hold the top node of the family tree,
    /// from there we can search the rest of the family tree.
    /// </summary>
    class FamilyTree
    {
        FTNode head;

        public FamilyTree(FTNode _head)
        {
            this.head = _head;
        }

        /// <summary>
        /// Compares the two lists gathered from node1 and node2 via the SearchPath(FTNode n) method
        /// to find the lowest common ancestor.
        /// Writes the result to console.
        /// </summary>
        /// <param name="node1">one of the two nodes we want to find the LCA for</param>
        /// <param name="node2">the other node we want to find the LCA for</param>
        public void LowerCommonAncestor(FTNode node1, FTNode node2)
        {
            var node1path = SearchPath(node1);
            var node2path = SearchPath(node2);

            // Assigns lowest Count path to node1path so we can output s1 with no problem.
            if (node1path.Count > node2path.Count)
            {
                var temp = node1path;
                node1path = node2path;
                node2path = temp;
            }   

            var counter = 0;
            string s1 = node1path[counter].name;
            string s2 = node2path[counter].name;

            while (s1 == s2 && counter < node1path.Count && counter < node2path.Count)
            {
                s1 = node1path[counter].name;
                s2 = node2path[counter].name;
                counter++;
            }
            Console.WriteLine(s1);

        }

        /// <summary>
        /// Searches a FamilyTree for FTNode n, in a bredth-first manner
        /// Adds the current (parent) node onto the end of the path to differentiate nodes on the same depth level.
        /// </summary>
        /// <param name="n">The node we are finding the path too</param>
        /// <returns>the path taken from the head of the family tree to node n</returns>
        public List<FTNode> SearchPath(FTNode n)
        {
            List<FTNode> list = new List<FTNode>();
            list.Add(head);
            bool found = false;
            int counter = 0;
            while (found != true)
            {
                FTNode currentNode = list[counter];
                if (currentNode.children.Contains(n))
                {
                    found = true;
                    list.Add(currentNode);
                    break;
                }

                for (int i = 0; i < currentNode.children.Count; i++)
                {
                    list.Add(currentNode.children[i]);
                }
                counter++;
            }
            return list;
        }
    }
}
