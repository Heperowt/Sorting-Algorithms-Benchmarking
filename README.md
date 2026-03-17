# ⚡ Sorting Algorithms Benchmarking (Bubble vs. Insertion)

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)

This project is a technical performance analysis of two fundamental sorting algorithms. It goes beyond simple implementation by measuring execution time across **10,000,000 (10 million) iterations** to see how theoretical complexity matches real-world performance.

## 🚀 The Experiment
- **Dataset:** A randomly generated array of 100 integers (range 1-1000).
- **Iterations:** Each algorithm sorts the same unsorted array 10 million times.
- **Measurement:** Used `System.Diagnostics.Stopwatch` for high-precision timing.
- **Memory Safety:** Implemented `Array.Copy` to ensure each iteration starts with the same unsorted data.

## 📊 Performance Results (Sample)
Based on the benchmarks, while both algorithms share the same worst-case complexity, their actual execution times differ significantly:

- **Bubble Sort:** Typically slower due to the high number of swap operations $O(n^2)$.
- **Insertion Sort:** Significantly faster, especially on small or partially sorted datasets.

## 🧠 Algorithmic Analysis

### Time Complexity Table
| Algorithm | Best Case | Average Case | Worst Case |
| :--- | :--- | :--- | :--- |
| **Bubble Sort** | $O(n^2)$ | $O(n^2)$ | $O(n^2)$ |
| **Insertion Sort** | $O(n)$ | $O(n^2)$ | $O(n^2)$ |

### Why is Insertion Sort faster?
Even though both are $O(n^2)$, **Insertion Sort** is more efficient in practice because:
1. It performs fewer writes (assignments instead of swaps).
2. Its "Best Case" O(n) is mathematically superior when the array is nearly sorted.
3. Bubble Sort is primarily used for educational purposes due to its excessive overhead.

## 🛠️ How to Run
1. Clone the repository.
2. Open in Visual Studio.
3. Run the application and wait for the 10 million iterations to complete. The console will output the total elapsed time in milliseconds and seconds.
