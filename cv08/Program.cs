

using cv08;

ArchivTeplot archiv = new();
archiv.Load("C:\\Users\\repas\\OneDrive\\GitHub\\BPC-OOP\\cv08\\xd.txt");

Console.WriteLine("Všechny teploty:");
archiv.TiskTeplot();

Console.WriteLine("Průměrné roční teploty:");
archiv.TiskPrumernychRocnichTeplot();

Console.WriteLine("Průměrná teplota za leden:");
archiv.TiskPrumernychMesicnichTeplot(1);

archiv.Kalibrace(-0.1);
archiv.Save("teploty_kalibrovane.txt");