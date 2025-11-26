# Arrays

## 1. Expanding an array

Arrays are a fixed size and cannot be expanded or shrunk we need a hole new array if we want to change the size
There for is your task to create a function that expands and shrinks an array to fit the amount of content.

### 1.1 Expand function

Finish the function AddToArray(int num).

```
int[] arr = {1,2,3};
void AddToArray(int num) {}
```



### 1.2 Shrinking array

Finish the function void RemoveFromArray(int num).

```
RemoveFromArray(int num)
```

<details>
<summary>Hints</summary>

Try creating a temporary array to hold the values.

</details>


## 2. Circular arrays

The modulus operator ``` % ``` is used for getting the remainder of an operation.
Example: 
```
int moneyInMyBackAccount = 10;
int costOfNewShinyGame = 8;
int balanceAfterPurchase = moneyInMyBackAccount % costOfNewShinyGame; // 2
```
This can be used to go in a loop or create what we would call a circular array.

### 2.1 Stoplight 

Finish the code so that it loops over the 3 colors using the modulus operator

```
string[] colors = {"Red", "Yellow", "Green"};
int timesToLoop = 1000;

for (int i = 0; i < timesToLoop; i++)
{
    
}
```
