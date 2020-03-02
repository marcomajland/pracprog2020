using System;
class main{
	static Func<double,vector,vector> F = delegate(double x, double y){		
		return new vector(y[1],y[0]*(1-y[0]));
	};
	public static int Main(){
		double a = 0;
		double b = 3;
		vector ya = new vector(0, 0.5);
	
		vector y = ode.rk23(F, a, ya, b);
		Error.WriteLine($"y0    ={y[0]}    y1\t={y[1]}");
		Error.WriteLine($"sin(b)={Sin(b)} cos(b)\t={Cos(b)}");
		if(approx(y[0],Sin(b),acc,eps) && approx(y[1],Cos(b),acc,eps))
			Error.WriteLine("test passed");
		else
			Error.WriteLine("test failed");
			Error.WriteLine($"npoints={xs.Count}");

		for(int i=0;i<xs.Count;i++)
			WriteLine($"{xs[i]} {ys[i][0]} {ys[i][1]}");
	}
}
//public static vector rk23 // calls driver with rkstep23 stepper
//(Func<double,vector,vector> F, // the ODE system to integrate
//double a, // initial point
//vector ya, // functions at the initial point
//double b, // final point
//List<double> xlist=null, // list of x's, if needed
//List<vector> ylist=null, // list of y's, if needed
//double acc=1e-3, // absolute accuracy goal
//double eps=1e-3, // relative accuracy goal
//double h=0.1, //initial step-size
//int limit=999 // maximal number of steps
//)
//{
