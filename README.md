# Algorithms on C#

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


## Sort algorithms
### Selection sort
Sort/SelectionSort/SelectionSort.cs

Immutable version of algorithm (return sorted array)
```csharp
List<T> SelectionSortImmutableForValueTypes<T>(List<T> arr, IComparer<T> comparer)
```

Mutable version of algorithm (mutate income array)
```csharp
void SelectionSortMutable<T>(List<T> arr, IComparer<T> comparer)
```

### QuickSort
Sort/QuickSort/QuickSort.cs

```csharp
List<T> QuickSortImmutable<T>(List<T> arr, IComparer<T> comparer)
```