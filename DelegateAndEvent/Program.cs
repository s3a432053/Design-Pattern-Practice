

using DelegateAndEvent;

ObjectA objectA = new ObjectA("Roger");
ObjectB objectB = new ObjectB();
ObjectC objectC = new ObjectC();

objectA.ObjAnounceEvent += objectB.ObjBGreeting;
objectA.ObjAnounceEvent += objectC.ObjCGreeting;

objectA.OnObjAEventBeenCalled();