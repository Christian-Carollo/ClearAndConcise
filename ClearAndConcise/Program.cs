
// Modificare l'applicazione precedente in modo da utilizzare la sintassi del metodo di LINQ.

Random random = new Random();

List<int> listaInteri = Enumerable.Range(1, 1000).Select(numeroCauale => random.Next(numeroCauale)).Where(numero => numero % 2 != 0).ToList();

listaInteri.ForEach(numero => Console.WriteLine(numero));