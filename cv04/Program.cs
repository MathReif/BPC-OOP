using cv04;


string text = "Toto je retezec predstavovany nekolika radky,\n"
+ "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
+ "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
+ "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
+ "posledni veta!";

StringStatistics xd = new StringStatistics(text);
xd.CountWords();
xd.CountRows();
xd.CountSentence();
xd.Longest();
xd.Shortest();
xd.Alphabeticaly();
