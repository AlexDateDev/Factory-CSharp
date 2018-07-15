//// ----------------------------------------------------------------------------
//// Título:    try - catch - finally
////
//// Fecha:     07/10/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------


//int i, j;
////
//try
//{
//    Console.Write("Un numero ");
//    i = Convert.ToInt32(Console.ReadLine());
//    Console.Write("Otro numero ");
//    j = Convert.ToInt32(Console.ReadLine());

//    int r = i / j;

//    Console.WriteLine("El resultado es: {0}", r);
//}
//catch (FormatException)
//{
//    Console.WriteLine("No es un número válido");
//    // Salimos de la función, pero se ejecutará el finally
//    return;
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("La división por cero no está permitida.");
//}
//catch (Exception ex)
//{
//    // Captura del resto de excepciones
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    // Este código siempre se ejecutará
//    Console.WriteLine("Se acabó");
//}
