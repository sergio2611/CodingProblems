using System;
using System.ComponentModel;
public class MyList<T>{


    private T[] array;
    private int count;

    public MyList()
    {
        array = new T[5]; // Initial size of the array (you can adjust as needed)
        count = 0;
    }

    public void ResizeArray()
    {
        Console.WriteLine("im here");
        var newcount = count*2;
        T[] array2 = new T[newcount];
        for(int i = 0 ; i < array.Length; i ++)
        {
            array2[i] = array[i];
            Console.WriteLine("position " + i);
        }     
        array = array2;        
    }

    public void MyListStats()
    {
        Console.WriteLine("count is :" + count + ", array lenght : " + array.Length);
    }

    public void AddItem(T item)
    {
        if(count == array.Length){
            ResizeArray();
        }     
            array[count] = item;
            count++;
         
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