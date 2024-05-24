using System.Collections;

namespace ForeachVersusFor;

internal class MyList : IEnumerable<string>
{
    #region

    public IEnumerator<string> GetEnumerator()
    {
        return new MyListEnumerator(Items);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    #endregion

    public MyList()
    {
        Items = new string[1000];
        for (var i = 0; i < 1000; i++) Items[i] = $"{i:00000}";
    }

    public string[] Items { get; }

    private class MyListEnumerator(string[] items) : IEnumerator<string>
    {
        public bool MoveNext()
        {
            _position++;
            return _position < items.Length;
        }

        public void Reset()
        {
            _position = -1;
        }

        public string Current
        {
            get
            {
                if (_position < 0 || _position >= items.Length) throw new InvalidOperationException();
                return items[_position];
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            // No resources to dispose
        }

        private int _position = -1;
    }
}