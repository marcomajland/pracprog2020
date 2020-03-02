CSC = mcs
all : out.txt
	cat out.txt
out.txt : main.exe
	mono main.exe > out.txt
main.exe : main.cs vector.dll
	mcs -reference:vector.dll main.cs
vector.dll : vector.cs
	mcs -target:library -out:vector.dll vector.cs

