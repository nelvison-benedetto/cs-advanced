using System;
using System.Collections.Generic;
using System.Text;

namespace Cs.Advanced.AnonymousMethods;

//delegate type
public delegate void MyDelegateType(int a, int b);

public class Publisher
{
    //step 1: create event
    public event MyDelegateType myEvent;

    public void RaiseEvent(int a, int b) {
        //step 2: raise event
        if (this.myEvent != null) { 
            this.myEvent(a, b);
        }
    }

}
