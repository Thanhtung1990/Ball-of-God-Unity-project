using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class Decrypt{

	// creat 3 string key for encrypting plain text 
	static readonly string PasswordHash = "P@@Sw0rD";
	static readonly string SaltKey = "S@LT&key";
	static readonly string VIKey = "@182c3D4e5F6g7HB";

	// make function to decrypt encrypted text 
	public static string DecryptString (string encryptedText){

		byte[] cipherTextBytes = Convert.FromBase64String (encryptedText);
		byte[] KeyBytes = new Rfc2898DeriveBytes (PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256/8);
		var symmeTrickey = new RijndaelManaged () {Mode = CipherMode.CBC, Padding = PaddingMode.None };

		var decrypter = symmeTrickey.CreateDecryptor (KeyBytes,Encoding.ASCII.GetBytes(VIKey));
		var memoryStream = new MemoryStream (cipherTextBytes);
		var crytoStream = new CryptoStream (memoryStream, decrypter, CryptoStreamMode.Read);

		byte [] plainTextBytes = new byte[cipherTextBytes.Length];

		int decryptedByCount = crytoStream.Read (plainTextBytes,0,plainTextBytes.Length);
		memoryStream.Close ();
		crytoStream.Close ();

		return Encoding.UTF8.GetString (plainTextBytes,0,decryptedByCount).TrimEnd("\0".ToCharArray());
	}
}
