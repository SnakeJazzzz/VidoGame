using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RuntimeSet<T>: ScriptableObject
{
   public List<T> Items = new List<T>();

   public void Add(T thing)
   {
       
        Items.Add(thing);
   }

   public void Remove(T thing)
   {
      
        Items.Remove(thing);
        
   } 
}



