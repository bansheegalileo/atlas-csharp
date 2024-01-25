using System;
/// <summary>queue</summary>
/// <typeparam name="T">any type</typeparam>
public class Queue<T>
{
    /// <summary>used4 get/set</summary>
    /// <value>first elem</value>
    public Node head { get; set; }
    /// <summary>used4 get/set</summary>
    /// <value>last elem</value>
    public Node tail { get; set; }
    private int count;
    /// <summary>checks generic class type</summary>
    /// <returns>type</returns>
    public String CheckType(){
        return typeof(T).ToString();
    }
    /// <summary>cre8s new node + adds to end of queue</summary>
    public void Enqueue(T value){
        Node n = new Node(value);
        if (count == 0){
            head = n;
            tail = n;
            head.next = null;
        }
        else{
            tail.next = n;
        }
        this.count += 1;
    }
    /// <summary>counts nodes in Q</summary>
    /// <returns>num of Q'd elems</returns>
    public int Count(){
        return this.count;
    }
    /// <summary>node of the Q</summary>
    public class Node{
        private T value { get; set; }
        /// <summary>nxt node</summary>
        /// <value>get/set nxt node</value>
        public Node next { get; set; }
        /// <summary>default node cl. cinstructor</summary>
        /// <param name="value">setup node val on init</param>
        public Node(T value){
            this.value = value;
        }
    }
}
