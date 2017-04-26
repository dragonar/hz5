using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyszeresenKörKörösLáncola
{
    class KörKláncolás<T> where T : class
    {
        class Header<T> where T : class
        {
            public Header<T> Next = null;
            public Header<T> adat = null;
            public T Data = null;
        }

        Header<T> Head = null;

        public void Add(T Item)
        {
            if (Head == null)
            {
                Head = new Header<T>()
                {
                    Data = Item
                };

                Head.Next = Head;
            }
            else
            {
                Header<T> hdr = new Header<T>
                {
                    Data = Item
                };

                hdr.Next = Head;
                Head.Next = hdr;

            }
        }
        public void Insert(int Index, T Item)
        {
            if (Head == null)
            {
                Add(Item);
                return;
            }

            Header<T> Act = Head;
            int idx = 0;


            while (idx < Index)
            {
                Act = Act.Next;
                idx++;

                if (Act == Head)
                {
                    throw new OverflowException();
                }

            }

            Header<T> hdr = new Header<T>
            {
                Data = Item
            };
            hdr.Next = Act;


            if (Index == 0)
                Head = hdr;

        }
        public void Delete(int Index)
        {
            if (Head == null)
            {
                throw new OverflowException();
            }

            Header<T> Act = Head;
            int idx = 0;


            while (idx < Index)
            {
                Act = Act.Next;
                idx++;

                if (Act == Head)
                {
                    throw new OverflowException("Te barom, tulindexeltél");
                }
            }

            if (Index == 0)
                if (Head.Next == Head)//1 elemü lista
                {
                    Head = null;
                    return;
                }
                else
                    Head = Head.Next;

        }
        public T Get(int Index)
        {
            if (Head == null)
            {
                throw new OverflowException("Te barom, tulindexeltél");
            }

            Header<T> Act = Head;
            int idx = 0;


            while (idx < Index)
            {
                Act = Act.Next;
                idx++;

                if (Act == Head)
                {
                    throw new OverflowException("Te barom, tulindexeltél");
                }

            }
            return Act.Data;
        }

        public T this[int Index]
        {
            get
            {
                return Get(Index);
            }
        }

        public int count
        {
            get
            {
                if (Head == null)
                    return 0;

                Header<T> Act = Head;
                int cnt = 0;


                while (true)
                {
                    Act = Act.Next;
                    cnt++;

                    if (Act == Head)
                        return cnt;


                }
            }
        }
    }
}