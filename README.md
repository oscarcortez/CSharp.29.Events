# CSharp.29.Events

sirve para que se ejecuten otros metodos/acciones cuando se ejecutan los metodos que se llamann

para esto se usa un delegate:
```csharp
public delegate void EjemploDelegado();
```

y el evento en si: 
```csharp
public event EjemploDelegado EjemploEvento;
```

si el evento no esta suscrito a nada no mandara nada
```csharp
if (EjemploEvento != null)
{
    EjemploEvento();
    Console.WriteLine($"la suma es {a + b}");
}
else
{
    Console.WriteLine($"No estas suscrito a los eventos.");
}
```

se suscribe con el operador +=
```csharp
editor.EjemploEvento += EjemploEventHandler;
editor.EjemploEvento += EjemploEventHandler2;
```
