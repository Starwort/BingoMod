﻿namespace BingoMod.Util {
    /// <summary>
    ///  Singly-linked list node helper
    /// </summary>
    internal class LLNode<T> {
        public T value;
        public LLNode<T> next;
        public LLNode(T value, LLNode<T>? prev = null, LLNode<T>? next = null) {
            this.value = value;
            this.next = next ?? this;
            if (prev is not null) {
                prev.next = this;
            }
        }
        public LLNode<T> getEnd { 
            get {
                LLNode<T> node = next;
                while (node.next != this) {
                    node = node.next;
                } 
                return node;
            }
        }
    }
}
