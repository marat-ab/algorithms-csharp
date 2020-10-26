# Algorithms on Python
## Search algorithms
### Binary search
Search/BinarySearch/BinarySearch.cs

Binary search algorithm that uses an iterative algorithm:
```csharp
int? BinarySearchIter<T>(List<T> arr, T item, IComparer<T> comparer)
```

Binary search algorithm that uses an recursion algorithm:
```csharp
int? BinarySearchRecurs<T>(List<T> arr, T item, IComparer<T> comparer, int low = -1, int high = -1)
```