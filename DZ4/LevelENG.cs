using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4
{
    class LevelENG<TName, TSurname,TRank> : IEnumerable<object>, IEnumerator<object>
    {
        private readonly TName[] name;
        private readonly TSurname[] surname;
        private readonly TRank[] rank;
        private readonly int lenght;

        int position = -1;

        public int Lenght
        {
            get { return lenght; }
        }


        public LevelENG(int n)
        {
            name = new TName[n];
            surname = new TSurname[n];
            rank = new TRank[n];
            lenght = n;
        }

        //public string this[int index]
        //{
        //    get
        //    {
        //        if (index >= 0 && index < name.Length)
        //            return rank[position]+ " - " + name[index] + " - " + surname[index];
        //        return "Error!";
        //    }
        //}

        public void Add(int i, TName n, TSurname s, TRank r)
        {
            name[i] = n;
            surname[i] = s;
            rank[i] = r;
        }

        public bool MoveNext()
        {
            if (position < name.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get { return rank[position] + " - " + surname[position] + " " + name[position]; }
        }

        object IEnumerator.Current
        {
            get { return rank[position] + " - " + surname[position] + " " + name[position]; }
        }

        public IEnumerator<object> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public void Dispose()
        {
            Reset();
        }
    }
}
