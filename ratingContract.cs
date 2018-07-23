using System;
using Com.Expload;

[Program]
public class ProgramStrings
{
public Mapping<String, int> list = new Mapping<String, int>();

public void initRating(string name) {
list.put(name, 0);
}

public void increaseRating(string name) {
list.put(name, list.get(name) + 10);
}


public int readRating(string name) {
return list.get(name);
}


static public void Main () {}
}