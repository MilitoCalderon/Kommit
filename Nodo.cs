using UnityEngine;

public class Nodo
{
    public int  valueNodo;
    public Nodo nextNodo;

    public Nodo(int value)
    {
        this.valueNodo = value;
        this.nextNodo = null;
    }
 
 
}

public class ListLinked
{
    public Nodo head;
    public Nodo tail;

    public void AddNodo(int newValue)
    {
        Nodo newNodo = new Nodo(newValue);
        if (this.head == null)
        {
            head = newNodo;
        }

        else
        {
            Nodo currNodo = head;

            while (currNodo.nextNodo != null)
            {
                currNodo = currNodo.nextNodo;
            }
            currNodo.nextNodo = newNodo;
   
        }
  
    }

    public void InsertTail(int newValueTail)
    {
        Nodo newNodoTail = new Nodo(newValueTail);

        if (head == null)
        {
           // head = 
        }

    }

}