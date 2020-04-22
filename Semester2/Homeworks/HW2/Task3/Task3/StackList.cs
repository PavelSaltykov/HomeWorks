﻿using System;

namespace Task3
{
    public class StackList : IStack
    {
        private StackElement top;

        private class StackElement
        {
            public int value;
            public StackElement next;

            public StackElement(int value, StackElement next)
            {
                this.value = value;
                this.next = next;
            }
        }

        public bool IsEmpty()
            => top == null;

        public void Push(int value)
        {
            top = new StackElement(value, top);
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }

            int value = top.value;
            top = top.next;
            return value;
        }

        public void Clear()
        {
            top = null;
        }
    }
}
