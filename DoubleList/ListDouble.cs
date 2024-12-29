using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleList{
    public class Node<T>{
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }
        public Node(T data){
            Data = data;
            Next = null;
            Prev = null;
        }
    }
    public class DoubleList<T>{
        private Node<T> head;
        private Node<T> tail;
        private int count;
        public DoubleList(){
            head = null;
            tail = null;
            count = 0;
        }
        public void AddEnd(T data){
            Node<T> newNode = new Node<T>(data);
            if (head == null){
                head = newNode;
                tail = newNode;
            }
            else{
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
            count++;
        }
        public void AddStart(T data){
            Node<T> newNode = new Node<T>(data);
            if (head == null){
                head = newNode;
                tail = newNode;
            }
            else{
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
            count++;
        }
        public bool RemoveFirst(){
            if (head == null){
                return false;
            }
            if (head == tail){
                head = null;
                tail = null;
            }
            else{
                head = head.Next;
                head.Prev = null;
            }
            count--;
            return true;
        }
        public bool RemoveLast(){
            if (tail == null){
                return false;
            }
            if (head == tail){
                head = null;
                tail = null;
            }
            else{
                tail = tail.Prev;
                if (tail != null) { 
                    tail.Next = null;
                }
            }
            count--;
            return true;
        }
        public bool Exist(T data){
            Node<T> current = head;
            while (current != null){
                if (current.Data.Equals(data)){
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public int Count{
            get{
                return count;
            }
        }
        public void Print(){
            if (head == null) { 
                Console.WriteLine("Список порожній."); 
                return;
            }
            Console.Write("Список: ");
            Node<T> current = head;
            while (current != null){
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
        public void Reverse() { 
            Node<T> current = head; 
            Node<T> temp = null;
            while (current != null) {
                temp = current.Prev;
                current.Prev = current.Next; 
                current.Next = temp;
                current = current.Prev; 
            }
            if (temp != null) { 
                head = temp.Prev; 
            }
            tail = head; 
            while (tail != null && tail.Next != null) { 
                tail = tail.Next; 
            }
        }
    }
}