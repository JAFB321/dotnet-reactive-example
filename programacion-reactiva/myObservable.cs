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
        public event EventHandler<String> eventHandler;
        public IObservable<EventPattern<String>> observable;
        
        public myObservable()
        { 
            observable = Observable.FromEventPattern<String>(
                    e => eventHandler += e,
                    e => eventHandler -= e
                );

        }
        
        public void doSomething(String some)
        {
            eventHandler(null, some);
        }

        public void subscribe(Action<EventPattern<String>> action)
        {
            observable.Subscribe(action);
        }
    }
}
