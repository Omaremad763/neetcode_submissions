public class MedianFinder {
    private System.Collections.Generic.PriorityQueue<int, int> maxHeap;
    private System.Collections.Generic.PriorityQueue<int, int> minHeap;

    public MedianFinder() {
        maxHeap = new System.Collections.Generic.PriorityQueue<int, int>();
        minHeap = new System.Collections.Generic.PriorityQueue<int, int>();
    }
    
    public void AddNum(int num) {
        maxHeap.Enqueue(num, -num);
        
        int topMax = maxHeap.Dequeue();
        minHeap.Enqueue(topMax, topMax);
        
        if (minHeap.Count > maxHeap.Count) {
            int topMin = minHeap.Dequeue();
            maxHeap.Enqueue(topMin, -topMin);
        }
    }
    
    public double FindMedian() {
        if (maxHeap.Count > minHeap.Count) {
            return maxHeap.Peek();
        } else {
            return (maxHeap.Peek() + minHeap.Peek()) / 2.0;
        }
    }
}