double VTL, Pm, PJ;
double Pmn;

double VLN, IOFm,IOFd,JUROS;




Console.WriteLine(@"
--- Crédito Rotativo de Cartão de Crédito --- ");
Console.WriteLine("\n");
Console.Write("Valor total da fatura (R$)...:");
VTL = Convert.ToDouble(Console.ReadLine());

Console.Write($"Pagamento mínimo (%).........:");
Pm = Convert.ToDouble(Console.ReadLine());

Console.Write($"Taxa de juros mensais (%)....:");
PJ = Convert.ToDouble(Console.ReadLine());
Pmn = VTL / Pm;
Console.WriteLine("\n");
Console.WriteLine($"Pagamento mínimo..................:{Pmn}");
Console.WriteLine("\n");
Console.WriteLine("Caso seja pago o valor mínimo:");
Console.WriteLine("\n");
VLN =VTL - Pmn;
Console.WriteLine($"Valor não pago....................:{VLN}");

JUROS = VLN / PJ;
Console.WriteLine($"Juros.............................:{JUROS}");


IOFm = VLN * 0.0038;
Console.WriteLine($"IOF mensal........................:{IOFm}");

IOFd = VLN * 0.00246;
Console.WriteLine($"IOF diário........................:{IOFd}");

Console.WriteLine("\n");
double VTF;
VTF = VLN + JUROS + IOFm + IOFd;
Console.WriteLine($"Valor total da fatura (R$)...:{VTF}");


double CR;
CR = JUROS + IOFm + IOFd;
Console.Write($"Custo do crédito rotativo.........:{CR}");


