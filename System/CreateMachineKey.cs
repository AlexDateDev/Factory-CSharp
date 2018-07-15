//// ----------------------------------------------------------------------------
//// Título:    CreateMachineKey
////
//// Fecha:     17/05/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------


//public static string CreateMachineKey(int length)
//{
//    // Create a byte array.
//    byte[] random = new byte[length/2];

//    // Create a cryptographically strong random number generator.
//    RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

//    // Fill the byte array with random bytes.
//    rng.GetBytes(random);

//    // Create a StringBuilder to hold the result once it is
//    // converted to hexadecimal format.
//    System.Text.StringBuilder machineKey = new
//    System.Text.StringBuilder(length);

//    // Loop through the random byte array and append each value
//    // to the StringBuilder.
//    for (int i = 0; i < random.Length; i++)
//    {
//        machineKey.Append(String.Format("{0:X2}", random[i]));
//    }
//    return machineKey.ToString();
//}

///*
//<machineKey
//  validationKey="61EA54E005915332011232149A2EEB317586824B265326CCDB3AD9ABDBE9D
//6F24B0625547769E835539AD3882D3DA88896EA531CC7AFE664866BD5242FC2B05D"
//  decryptionKey="61EA54E005915332011232149A2EEB317586824B265337AF"
//  validation="SHA1" />
//*/
