all : func.exe
	mono $<
func.exe : func.cs quado8.dll
	mcs $< -r:quado8.dll
quado8.dll : quado8.cs
	mcs $< -t:library
