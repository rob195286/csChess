using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace chessGame.model.board
{
    public class ColumnCollection : ICollection<Char>
    {
        private List<char> _columnCollection;

        public int Count { get => _columnCollection.Count; }
        public bool IsReadOnly { get => false; }
        public char this[int index]
        {
            get => (char) _columnCollection[index];
            set => _columnCollection[index] = value;
        }


        public ColumnCollection()
        {
            _columnCollection = new List<char>() { };
        }

        public ColumnCollection(int columnNumber)
        {
            // todo faire une exepction si > 26
            _columnCollection = new List<char>() { };

            for (int i = 0; i<columnNumber; i++)
                _columnCollection.Add(char.Parse(((char)(i + 65)).ToString().ToLower()));
        }


        public void Add(char item)
        {
            if (!_columnCollection.Contains(item))
                _columnCollection.Add(item);
            else
                Console.WriteLine("Char {0} was already added to the collection.", item.ToString());
        }

        public void Clear()
        {
            _columnCollection.Clear();
        }

        public bool Contains(char item)
        {
            bool exist = false;

            foreach (char ch in _columnCollection)
                if (Equals(ch, item))
                    exist = true;
            return exist;
        }

        public void CopyTo(char[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("The array cannot be null.");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            if (Count > array.Length - arrayIndex + 1)
                throw new ArgumentException("The destination array has fewer elements than the collection.");

            for (int i = 0; i < _columnCollection.Count; i++)
                array[i + arrayIndex] = _columnCollection[i];
        }

        public IEnumerator<char> GetEnumerator()
        {
            return new ColumnEnumerator(this);
        }

        public bool Remove(char item)
        {
            bool result = false;
            char currentChar = 'x';
            // Iterate the column collection to
            // find the char to be removed.
            for (int i = 0; i < _columnCollection.Count; i++)
            {
                currentChar = _columnCollection[i];

                if (Equals(currentChar, item))
                {
                    _columnCollection.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ColumnEnumerator(this);
        }
    }

    
    public class ColumnEnumerator : IEnumerator<char>
    {
        private ColumnCollection _columnCollection;
        private int currentIndex;
        private char currentColumn;

        public ColumnEnumerator(ColumnCollection collection)
        {
            _columnCollection = collection;
            currentIndex = -1;
            currentColumn = default(char);
        }

        public bool MoveNext()
        {
            bool isOk = false;
            //Avoids going beyond the end of the collection.
            if (++currentIndex >= _columnCollection.Count)
                isOk = false;
            else
            {
                // Set current box to next item in collection.
                currentColumn = _columnCollection[currentIndex];
                isOk = true;
            }
            return isOk;
        }

        public void Reset() { currentIndex = -1; }

        void IDisposable.Dispose() { }

        public char Current
        {
            get { return currentColumn; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
