private void ShiftUp(int index)
{
    int parentIndex = (index - 1) / 2;
    while (parentIndex >= 0 && heap[parentIndex] > heap[index])
    {
        Swap(parentIndex, index);
        index = parentIndex;
        parentIndex = (index - 1) / 2;
    }
}



private void ShiftDown(int index)
{
    while (true)
    {
        int leftChildIndex = 2 * index + 1;
        int rightChildIndex = 2 * index + 2;
        int largest = index;



        if (leftChildIndex < size && heap[leftChildIndex] < heap[largest])
        {
            largest = leftChildIndex;
        }



        if (rightChildIndex < size && heap[rightChildIndex] < heap[largest])
        {
            largest = rightChildIndex;
        }



        if (largest != index)
        {
            Swap(largest, index);
            index = largest;
        }
        else
        {
            break;
        }
    }
}