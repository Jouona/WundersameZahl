namespace WundersameZahl;

public interface ISort {
    void Sort(List<int> list);
}

public class BubbleSort : ISort {
    public void Sort(List<int> list) {
        int n = list.Count;
        for (int i = 0; i < n - 1; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                if (list[j] > list[j + 1]) {
                    Swap(list, j, j + 1);
                }
            }
        }
    }

    void Swap(List<int> list, int a, int b) {
        (list[a], list[b]) = (list[b], list[a]);
    }
}