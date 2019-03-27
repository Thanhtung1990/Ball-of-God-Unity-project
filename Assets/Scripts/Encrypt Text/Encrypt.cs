using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class Encrypt{

	// creat 3 string key for encrypting plain text 
	static readonly string PasswordHash = "P@@Sw0rD";
	static readonly string SaltKey = "S@LT&key";
	static readonly string VIKey = "@182c3D4e5F6g7HB";

	// make function to encrypt plaintext by using method Encoding UTF8
	public static string EncryptString (string plainText){

		byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
		byte[] KeyBytes = new Rfc2898DeriveBytes (PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256/8);

		var symmeTrickey = new RijndaelManaged () {Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
		var encrypter = symmeTrickey.CreateEncryptor (KeyBytes,Encoding.ASCII.GetBytes(VIKey));

		byte[] cipherTextBytes;

		using (var memoryStream = new MemoryStream()){

			using(var crytoStream = new CryptoStream(memoryStream,encrypter,CryptoStreamMode.Write)){

				crytoStream.Write (plainTextBytes,0,plainTextBytes.Length);
				crytoStream.FlushFinalBlock ();
				cipherTextBytes = memoryStream.ToArray ();
				crytoStream.Close();
			}
			memoryStream.Close ();
		}

		return Convert.ToBase64String (cipherTextBytes);
	}
}
