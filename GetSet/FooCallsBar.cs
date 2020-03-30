using System;

namespace GetSet
{
    public class FooCallsBar
    {
        public void CallBar(Bar bar)
        {
            Console.WriteLine(bar.CoveredGet);
            Console.WriteLine(bar.CoveredProperty);
        }
    }
}
