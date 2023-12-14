using StackOn.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOnList
{

    public class List
    {
        public Node? Head { get; set; }
        public int Count { get; set; }


        public void Add(dynamic item)
        {
            Node node = new Node { Data = item };

            if (Head == null) Head = node;
            else
            {
                node.Next = Head;
                Head = node;
            }
            Count++;
        }

        public dynamic Remove()
        {
            if (Head == null) throw new ContainerUnderflowException("Стэк пуст");
            Node current = Head;
            Head = Head.Next;
            Count--;
            return current.Data;
        }
        public dynamic this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexValueException("Значение индекса выходит за рамки хранилища", index);
                }

                Node current = Head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                return current!.Data;
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexValueException("Значение индекса выходит за рамки хранилища", index);
                }

                Node current = Head;
                for (int i = 0; i <= index; i++)
                {
                    current = current!.Next;
                }
                current!.Data = value;
            }
        }
    }
}