using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive;

namespace programacion_reactiva
{
    // Personal implementation
    // hdeleon implementation https://www.youtube.com/watch?v=Kq0PNa-BWKU&ab_channel=hdeleon.net
    internal class myObservable
    {
        public event EventHandler eventHandler;
        public IObservable<object> observable;
        
        public myObservable()
        { 
            observable = Observable.FromEventPattern(
                    e => eventHandler += e,
                    e => eventHandler -= e
                );

        }
        
        public void doSomething()
        {
            eventHandler(null, EventArgs.Empty);
        }

        public void subscribe(Action<object> action)
        {
            observable.Subscribe(action);
        }
    }
}
