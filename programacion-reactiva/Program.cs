using programacion_reactiva;

myObservable observable = new myObservable();

observable.subscribe(some => {
    Console.WriteLine("Look! the object did something");
});

observable.subscribe(some => {
    Console.WriteLine("Oh, yea, I saw it too");
});

observable.doSomething();
observable.doSomething();
observable.doSomething();