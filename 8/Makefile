matlib.dll : ode.cs vector.cs
	mcs $^ -t:library 2> out.txt
main.exe : main.cs matlib.dll
	mcs $< -r:$^

