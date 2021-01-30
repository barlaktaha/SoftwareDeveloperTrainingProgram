using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, int> Notlar = new MyDictionary<int, int>();
            Notlar.Add(3311, 70);
            Notlar.Add(3305, 55);
            Notlar.Add(3340, 30);

        }
    }
    class MyDictionary<T1, T2>
    {
        T1[] _array1;
        T2[] _array2;
        T1[] _tempArray1;
        T2[] _tempArray2;

        public MyDictionary()
        {
            _array1 = new T1[0];
            _array2 = new T2[0];


        }

        public void Add(T1 item1, T2 item2)
        {
            _tempArray1 = _array1;
            _tempArray2 = _array2;
            _array1 = new T1[_array1.Length + 1];
            _array2 = new T2[_array2.Length + 1];
            for (int i = 0; i < _tempArray1.Length; i++)
            {
                _array1[i] = _tempArray1[i];
            }
            for (int i = 0; i < _tempArray2.Length; i++)
            {
                _array2[i] = _tempArray2[i];
            }
        }
        public int Count1
        {
            get { return _array1.Length; }

        }
        public int Count2
        {
            get { return _array2.Length; }
        }
    }
}