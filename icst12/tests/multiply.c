typedef struct s {
	int x;
	int y;
}Point;

int fun(Point p) {
	if(p.x * p.y == 42)
		return 1;
	else return 0;
}

