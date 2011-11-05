package korat.examples.my;

import java.util.HashSet;
import java.util.LinkedList;
import java.util.Set;

import korat.finitization.IFinitization;
import korat.finitization.IObjSet;
import korat.finitization.impl.FinitizationFactory;

public class LL<T> {
	public static class LinkedListElement<T> {
		public T Data;
		public LinkedListElement<T> Prev;
		public LinkedListElement<T> Next;

		public LinkedListElement(T data) {
			Data = data;
		}
	}

	private LinkedListElement<T> Head;
	private LinkedListElement<T> Tail;
	private int size;

    @SuppressWarnings("unchecked")
    public boolean repOK() {
		if(Head == null || Tail == null) return size == 0;
		if(size == 1) return Head == Tail;
		if(Head.Prev != null) return false;
		if(Tail.Next != null) return false;

		LinkedListElement<T> last = Head;

        Set visited = new HashSet();
        LinkedList workList = new LinkedList();
		visited.add(Head);
		workList.add(Head);

        while (!workList.isEmpty()) {
            LinkedListElement<T> current =
			    (LinkedListElement<T>) workList.removeFirst();
            if (current.Next != null) {
                if (!visited.add(current.Next))
                    return false;
                workList.add(current.Next);
				if(current.Next.Prev != current)
					return false;
				last = current.Next;
            }
        }
		if(last != Tail)
			return false;
        // checks that size is consistent
        return (visited.size() == size);
    }

    public static IFinitization finLL(int size) {
        return finLL(size, size, size);
    }

    public static IFinitization finLL(int nodesNum, int minSize, int maxSize) {
        IFinitization f = FinitizationFactory.create(LL.class);
        IObjSet nodes = f.createObjSet(LinkedListElement.class, nodesNum, true);
        f.set("Head", nodes);
        f.set("Tail", nodes);
        f.set("size", f.createIntSet(minSize, maxSize));
        f.set("LinkedListElement.Next", nodes);
        f.set("LinkedListElement.Prev", nodes);
        return f;
    }
}

