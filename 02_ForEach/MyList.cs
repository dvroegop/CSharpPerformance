using System.Collections;

namespace _02_ForEach
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal class MyList : IEnumerable<string>
    {
        private readonly string[] _items;

        public string[] Items => _items;

        public MyList()
        {
            _items = new string[1000];
            for (int i = 0; i < 1000; i++)
            {
                _items[i] = $"{i:00000}";
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            return new MyListEnumerator(_items);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class MyListEnumerator : IEnumerator<string>
        {
            private readonly string[] _items;
            private int _position = -1;

            public MyListEnumerator(string[] items)
            {
                _items = items;
            }

            public bool MoveNext()
            {
                _position++;
                return _position < _items.Length;
            }

            public void Reset()
            {
                _position = -1;
            }

            public string Current
            {
                get
                {
                    if (_position < 0 || _position >= _items.Length)
                    {
                        throw new InvalidOperationException();
                    }
                    return _items[_position];
                }
            }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                // No resources to dispose
            }
        }
    }
}
