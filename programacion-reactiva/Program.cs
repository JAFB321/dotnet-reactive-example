using programacion_reactiva;

myObservable observable = new myObservable();

observable.subscribe(some => {
    Console.WriteLine("Look! the object "+some.EventArgs);
    
});

observable.subscribe(some => {
    Console.WriteLine("Oh, yea, I saw it too");
});

observable.doSomething("code in c#");
observable.doSomething("push this to github");