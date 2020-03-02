class main{
	public static void Main(){
	int n = 3;
	vector v = new vector(n);
	v.data[0] = 1;
	v.data[1] = 1;
	v.print();
	double a = 2;
	vector r = a*v;
	r.print();
	}
}
