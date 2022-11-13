// 

using System;
using static System.Console;

Clear();
WriteLine("Введите элементы массива через пробел");
string[] arr = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int num = 3;

string[] newArr = GetSelection(arr, num);

string[] GetSelection(string[] arr, int n) {
    string[] newArr = new string [arr.Length];
    int count = -1;
    for(int i = 0; i < arr.Length; i++) {
        if(arr[i].Length <= 3) {
            count++;
            newArr[count] = arr[i];
        }
    }
    
    string[] result = new string [count + 1];
    for(int i = 0; i <= count; i++) {
        result[i] = newArr[i];
    }

    return result;
}

WriteLine(String.Join(", ", newArr));