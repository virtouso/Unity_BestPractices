# Unity BestPractices

## MVC

seperate application in models, controllers as logic and monobehaviours as views. 

## Dependency Injection

DI can be very hard in game dev engines like unity as theh DI container should read all object 
hierarchy to find dependencies.

there are also simpler approach that can be a good DI technique and also avoids the cons of 
singleton and service locators. 

there is only one context class. any object can bind itself or call get dependencies

## Single Entry

like a console application the app starts from only on single entry point like main method.

its helps learning and unboarding simpler and much faster. 


## SignalBus

simplified signal bus/ event dispatcher for unity c#.

instead of making classes directly call eachother, on class just raised an event and subscribers all receive it.

its mostly inspired by zenject signalbus. 

## Monobehaviour Extensions

