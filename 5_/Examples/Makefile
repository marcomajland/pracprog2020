all : out.txt errors.txt
	cat $^
examples.exe : examples.cs
	mcs -out:$@ $<
out.txt : examples.exe
	mono $< 1> out.txt 2> errors.txt
