//// ----------------------------------------------------------------------------
//// T�tulo:    try - catch - finally
////
//// Fecha:     07/10/2013
//// Autor:    Alex Sol�
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
//    Console.WriteLine("No es un n�mero v�lido");
//    // Salimos de la funci�n, pero se ejecutar� el finally
//    return;
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("La divisi�n por cero no est� permitida.");
//}
//catch (Exception ex)
//{
//    // Captura del resto de excepciones
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    // Este c�digo siempre se ejecutar�
//    Console.WriteLine("Se acab�");
//}
