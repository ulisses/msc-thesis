int Puzzle(int x, int n) {
	return BinarySearch(x, 0, n); 
}

int BinarySearch(int x, int lo, int hi) {
	while (lo < hi) {
		int mid = (lo+hi)/2;
		pathcrawler_assert(mid >= lo && mid < hi);
		if (x < mid) { hi = mid; } else { lo = mid+1; }
	}
	return lo; 
}

