using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class LinkedListMergeSort
    {
        public LinkedList MergeSort(LinkedList linkedList)
        {
            // big o (kn logn)
            //Sorts a linked list in ascending order
            //recursively divide linked list into sublist containing a single node
            //repeatedly merge the sublists to produce sorted sublists until one remains

            if (linkedList.Size() == 1)
            {
                return linkedList;
            }
            else if (linkedList._head == null)
            {
                return linkedList;
              }

            (var lefthalf, var righthalf) = Split(linkedList);

            var left = MergeSort(lefthalf);
            var right = MergeSort(righthalf);
            return Merge(left, right);
        }

        public (LinkedList leftHalf,LinkedList rightHalf) Split(LinkedList linkedList)
        {
            //takes bigO(k logn)
            //divide the unsorted list at midpoint into sublist
            if(linkedList == null || linkedList._head == null)
            {
                var leftHalf = linkedList;
                var rightHalf = new LinkedList();
                return (leftHalf,rightHalf);
            }
            else
            {
                var size = linkedList.Size();
                var mid = size / 2;
                var midNode = linkedList.NodeAtIndex(mid - 1);
                var lefthalf = linkedList;
                var rightHalf = new LinkedList();
                rightHalf._head = midNode.nextNode;
                midNode.nextNode = null;

                return (lefthalf, rightHalf);
            }

        }

        public LinkedList Merge(LinkedList left,LinkedList right)
        {
            // runs in linear time
            //merge two linked list sorting by data in nodes
            //returns new merged list

            var merged = new LinkedList();
            //add a fake head that is discarded later
            merged.Add(0);
            //set current to the head of the linked list
            var current = merged._head;
            //obtain head nodes for left and right linked list
            var leftHead = left._head;
            var rightHead = right._head;
            //iterate over left and right until we reach the tail node of either

            while(leftHead!=null || rightHead!=null)
            {
                //if the head of the left node is null we past the tail
                //add the node from right to merged linked list
                if(leftHead==null)
                {
                    current.nextNode = rightHead;
                    //call next on right to set loop condition to false
                    rightHead = rightHead.nextNode;
                }
                //if the head node of right is null we past the tail
                //add the taile node from left to merged linked list
                else if(rightHead == null){
                    current.nextNode = leftHead;
                    //call next on right to set loop condition to false
                    leftHead = leftHead.nextNode;
                }
                else{
                    // not a either taile node 
                    // obtain node data to perform comparison operations
                    var leftData = leftHead._data;
                    var rightData = rightHead._data;
                    if(leftData< rightData)
                    {
                        current.nextNode = leftHead;
                        leftHead= leftHead.nextNode;
                    }
                    //if data on left is greater than right set current to right node
                    else{
                        current.nextNode = rightHead;
                        rightHead = rightHead.nextNode;
                    }

                }
                // move current to next node
                current = current.nextNode;

            }
            //discard fake head and set first merge node as head
            var _head = merged._head.nextNode;
            merged._head = _head;
            return merged;
        }
    }
}
