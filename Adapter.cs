using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class TurkeyAdapter : IDuck
    {
        ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Quack() => turkey.Gobble();
        
        public void Fly()
        {
            for (int i = 0; i < 5; i++)
                turkey.Fly();
        }
    }
}
