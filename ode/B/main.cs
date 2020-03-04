using System;
using System.Collections.Generic;
using static System.Console;
using static System.Math;
class main{
	// ODE1:
	// y0' = y1
	// ODE 2:
	// y1' = 1 - y0 + e*y0*y0
	static Func<double,vector,vector> ODE = delegate(double x, vector y){		
		double e = 0.01;
		return new vector(y[1], 1 - y[0] + e*y[0]*y[0]);
	};	
	public static int Main(){
		// Solve ODE1
		double a = 0;
		double b = 10*PI;
		vector ya = new vector(1, -0.5);

		var xs = new List<double>();
		var ys = new List<vector>();		

		vector y = ode.rk23(ODE, a, ya, b, xlist:xs, ylist:ys);
		for(int i=0;i<xs.Count;i++){
			WriteLine($"{xs[i]} {ys[i][0]}");
		}
		return 0;
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
