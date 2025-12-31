var pares = numerosPares(10);
IEnumerable<int> numerosPares(int limite)
{
    var listaPares = new List<int>();
    for (int i = 1; i <= limite; i+=2)
    {
       listaPares.Add(i);
    }return listaPares;
}
IEnumerable<int> numerosPares2(int limite)
{
    var listaPares = new List<int>();
    for (int i = 1; i <= limite; i += 2)
    {
       yield return i;
    }
}
foreach (var numero in pares)
{
    Console.WriteLine(numero);
}