using System;

Dictionary<string, double> faturamento = new Dictionary<string, double>
{
    {"SP", 67836.43},
    {"RJ", 36678.66},
    {"MG", 29229.88},
    {"ES", 27165.48},
    {"Outros", 19849.53}
};

double total = faturamento.Values.Sum();

foreach (KeyValuePair<string, double> item in faturamento)
{
    double percentual = (item.Value / total) * 100;
    Console.WriteLine("{0} - {1:0.00}%", item.Key, percentual);
}
