using System;
using System.Collections.Generic;
using System.Text;

namespace Cs.Advanced.AnonymousMethods;

//event contract
public delegate void MyDelegateType(int a, int b);

public class Publisher
{
    //publisher espone event (solo lui puo scatenarlo)
    public event MyDelegateType myEvent; //definition event

    public void RaiseEvent(int a, int b) {
        //step 2: raise event
        if (this.myEvent != null) { 
            this.myEvent(a, b);
        }
    }

}
