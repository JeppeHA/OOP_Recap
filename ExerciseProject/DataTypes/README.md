
# Datatypes

## 1. The billionaire problem

A billionaire is keeping count of his total net worth after a major deal his network increased by 2 billion.
But that caused his tracking software to stop working. You job is to fix it so he can display his wealth.

```

int netWorth = 1000000000;
int increase = 2000000000;
Console.WriteLine("Current wealth: " + (netWorth + increase));

```

## 2.String interpolation

Traditionally when we want to print our variables to the console we do:

```
string name = "Jeppe";
Console.WriteLine("Hello my name is " + name + " nice to meet you");
```
But this is tedious and can be confusing there for we can use string interpolation to make it easier.
 ```
string name = "Jeppe";
Console.WriteLine($"Hello my name {name} is nice to meet you");
```

Your task now is to change the code in the Story.cs file to use string interpolation.