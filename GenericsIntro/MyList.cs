using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //Bana bir tip ver
    {
        T[] items;
        //constructor cont classı newlersen otomatik çalışıyor.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) 
        {
            T[] tempArray = items;   //geçici dizinin referansı itemsın referansı
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
            


    }

    }
}
