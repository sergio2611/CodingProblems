using System;
using System.ComponentModel;
public class MyList<T>{


    private T[] array;
    private int count;

    public MyList()
    {
        array = new T[10]; // Initial size of the array (you can adjust as needed)
        count = 0;
    }

    public void AddItem(T item)
    {
        if(count == array.Length){}
         //resize array
         else
         {
            count++;
            array[count] = item;
         }
    }

    public void RemoveItem(T item)
    {
        var index = GetIndexOfItem(item);
        for(int i = index ; i < array.Length -1; i++)
        {           
            array[i] = array[i+1];                  
        }
        count--;

    }

    public int GetIndexOfItem(T item)
    {
        int index = 0;
        for(int i = 0 ; i < array.Length; i++)
        {
            if(array[i].Equals(item))
             {
                index = i;
                break;
             }
        }
        return index;
    }

    public void ToStringList()
    {
        for(int i= 0 ; i< array.Length; i ++)
        {
            Console.WriteLine("Item in position " +i+" , value :" + array[i].ToString() );
        }
    }



}