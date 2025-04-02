

using cv08;

ArchivTeplot archiv = new();
archiv.Load("D:\\256795\\BPC-OOP\\cv08\\xd.txt");

Console.WriteLine("Všechny teploty:");
archiv.TiskTeplot();

Console.WriteLine("Průměrné roční teploty:");
archiv.TiskPrumernychRocnichTeplot();

Console.WriteLine("Průměrná teplota:");
archiv.TiskPrumernychMesicnichTeplot();

archiv.Kalibrace(-0.1);
archiv.Save("D:\\256795\\BPC-OOP\\cv08\\xd2.txt");