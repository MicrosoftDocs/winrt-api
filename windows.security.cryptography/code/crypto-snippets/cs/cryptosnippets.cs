
//<SnippetShowCryptographicBufferOverview>
public void CryptographicBufferOverview()
{
    // 1. Generate random data.
    UInt32 buffLength = 32;
    IBuffer buffRnd = CryptographicBuffer.GenerateRandom(buffLength);
    String strRndData = CryptographicBuffer.EncodeToHexString(buffRnd);

    // 2. Generate a random number.
    UInt32 Rnd = CryptographicBuffer.GenerateRandomNumber();

    // 3. Decode a Base 64 string to a buffer and encode the buffer to a Base64 string.
    String strBase64v1 = "uiwyeroiugfyqcajkds897945234==";
    IBuffer buffFromBase64 = CryptographicBuffer.DecodeFromBase64String(strBase64v1);
    String strBase64v2 = CryptographicBuffer.EncodeToBase64String(buffFromBase64);

    // 4. Decode a hexadecimal string to a buffer and encode the buffer to a hexadecimal string.
    String strHexv1 = "30310AFF";
    IBuffer buffFromHex = CryptographicBuffer.DecodeFromHexString(strHexv1);
    String strHexv2 = CryptographicBuffer.EncodeToHexString(buffFromHex);

    // 5. Convert a strings to binary data and convert binary data to strings.
    String strIn = "Input String";
    IBuffer buffUTF16BE = CryptographicBuffer.ConvertStringToBinary(strIn, BinaryStringEncoding.Utf16BE);
    String  strUTF16BE  = CryptographicBuffer.ConvertBinaryToString(BinaryStringEncoding.Utf16BE, buffUTF16BE);
    IBuffer buffUTF16LE = CryptographicBuffer.ConvertStringToBinary(strIn, BinaryStringEncoding.Utf16LE);
    String  strUTF16LE  = CryptographicBuffer.ConvertBinaryToString(BinaryStringEncoding.Utf16LE, buffUTF16LE);
    IBuffer buffUTF8 = CryptographicBuffer.ConvertStringToBinary(strIn, BinaryStringEncoding.Utf8);
    String  strUTF8  = CryptographicBuffer.ConvertBinaryToString(BinaryStringEncoding.Utf8, buffUTF8);

    // 6. Create a buffer from a byte array and create a byte array from a buffer,
    byte[] arrByte = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    IBuffer buffFromByteArr = CryptographicBuffer.CreateFromByteArray(arrByte);
    byte[] arrByteNew;
    CryptographicBuffer.CopyToByteArray(buffFromByteArr, out arrByteNew);

    // 7. Compare two buffers. The following Boolean value is true because the code points are equal.
    String strHex = "30310aff";
    String strBase64 = "MDEK/w==";
    IBuffer buff1 = CryptographicBuffer.DecodeFromHexString(strHex);
    IBuffer buff2 = CryptographicBuffer.DecodeFromBase64String(strBase64);
    Boolean bVal = CryptographicBuffer.Compare(buff1, buff2);

}

//</SnippetShowCryptographicBufferOverview>

//<SnippetShowBufferCompare>

public void CompareBuffers()
{
    // Create a hexadecimal string.
    String strHex = "30310aff";

    // Create a Base64 string that is equivalent to strHex.
    String strBase64v1 = "MDEK/w==";

    // Create a Base64 string that is not equivalent to strHex.
    String strBase64v2 = "KEDM/w==";

    // Decode strHex to a buffer.
    IBuffer buff1 = CryptographicBuffer.DecodeFromHexString(strHex);

    // Decode strBase64v1 to a buffer.
    IBuffer buff2 = CryptographicBuffer.DecodeFromBase64String(strBase64v1);

    // Decode strBase64v2 to a buffer.
    IBuffer buff3 = CryptographicBuffer.DecodeFromBase64String(strBase64v2);

    // Compare the hexadecimal-decoded buff1 to the Base64-decoded buff2.
    // The code points in the two buffers are equal, and the Boolean value
    // is true.
    Boolean bVal_1 = CryptographicBuffer.Compare(buff1, buff2);

    // Compare the hexadecimal-decoded buff1 to the Base64-decoded buff3.
    // The code points in the two buffers are not equal, and the Boolean value
    // is false.
    Boolean bVal_2 = CryptographicBuffer.Compare(buff1, buff3);
}

//</SnippetShowBufferCompare>

//<SnippetShowBinaryConversion>
public void ConvertData()
{
    // Create a string to convert.
    String strIn = "Input String";

    // Convert the string to UTF16BE binary data.
    IBuffer buffUTF16BE = CryptographicBuffer.ConvertStringToBinary(strIn, BinaryStringEncoding.Utf16BE);

    // Convert the string to UTF16LE binary data.
    IBuffer buffUTF16LE = CryptographicBuffer.ConvertStringToBinary(strIn, BinaryStringEncoding.Utf16LE);

    // Convert the string to UTF8 binary data.
    IBuffer buffUTF8 = CryptographicBuffer.ConvertStringToBinary(strIn, BinaryStringEncoding.Utf8);
}

//</SnippetShowBinaryConversion>




//<SnippetShowByteArrayCopy>
public void ByteArrayCopy()
{
    // Initialize a byte array.
    byte[] arrByte = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    // Create a buffer from the byte array.
    IBuffer buffer = CryptographicBuffer.CreateFromByteArray(arrByte);

    // Encode the buffer into a hexadecimal string (for display);
    String strHex = CryptographicBuffer.EncodeToHexString(buffer);

    // Copy the buffer back into a new byte array.
    byte[] arrByteNew;
    CryptographicBuffer.CopyToByteArray(buffer, out arrByteNew);
}

//</SnippetShowByteArrayCopy>

//<SnippetShowBase64Encoding>
public void EncodeDecodeBase64()
{
    // Define a Base64 encoded string.
    String strBase64 = "uiwyeroiugfyqcajkds897945234==";

    // Decoded the string from Base64 to binary.
    IBuffer buffer = CryptographicBuffer.DecodeFromBase64String(strBase64);

    // Encode the buffer back into a Base64 string.
    String strBase64New = CryptographicBuffer.EncodeToBase64String(buffer);
}

//</SnippetShowBase64Encoding>

//<SnippetShowHexEncoding>
public void EncodeDecodeHex()
{
    // Define a hexadecimal string.
    String strHex = "30310AFF";

    // Decode a hexadecimal string to binary.
    IBuffer buffer = CryptographicBuffer.DecodeFromHexString(strHex);

    // Encode the buffer back into a hexadecimal string.
    String strHexNew = CryptographicBuffer.EncodeToHexString(buffer);
}

//</SnippetShowHexEncoding>



//<SnippetShowRandom>

using Windows.Security.Cryptography;
using Windows.Storage.Streams;

namespace Random
{
    sealed partial class GenerateRandomDataApp : Application
    {
        public GenerateRandomDataApp()
        {
            // Initialize the application.
            this.InitializeComponent();

            // Create a buffer that contains random data.
            String strRndHex = this.GenerateRndData();

            // Create a random integer.
            UInt32 uRnd = this.GenerateRndNumber();
        }

        public String GenerateRndData()
        {
            // Define the length, in bytes, of the buffer.
            UInt32 length = 32;

            // Generate random data and copy it to a buffer.
            IBuffer buffer = CryptographicBuffer.GenerateRandom(length);

            // Encode the buffer to a hexadecimal string (for display).
            String hexRnd = CryptographicBuffer.EncodeToHexString(buffer);

            return hexRnd;
        }

        public UInt32 GenerateRndNumber()
        {
            // Generate a random number.
            UInt32 Rnd = CryptographicBuffer.GenerateRandomNumber();

            return Rnd;
        }
    }
}

//</SnippetShowRandom>



//<SnippetShowCertEnrollMgr>
using Windows.Security.Cryptography.Certificates;
using System.Threading.Tasks;

namespace SampleCertificateEnrollmentManager
{

    sealed partial class CertEnrollMgrApp : Application
    {
        public CertEnrollMgrApp()
        {
            // Initialize the application.
            this.InitializeComponent();

            // Create a certificate request.
            this.GetCertificateRequest();
        }

        public async void GetCertificateRequest()
        {
            // Create a certificate request asynchronously.
            String certificateRequest = await this.SampleCreateRequest();
        }

        public async Task<String>SampleCreateRequest()
        {
            // Create a CertificateRequestProperties object.
            CertificateRequestProperties requestProp = new CertificateRequestProperties();

            // Assign a subject name to the properties object.
            requestProp.Subject = "SampleRequest";

            // Create a certificate request.
            String strRequest = await CertificateEnrollmentManager.CreateRequestAsync(requestProp);

            // Return the request string.
            return strRequest;
        }
    }
}

//</SnippetShowCertEnrollMgr>

//<SnippetShowExportable>
public ExportOption GetSetExportable(ExportOption inputOption)
{
    // Create a new CertificateRequestProperties object.
    CertificateRequestProperties reqProperties = new CertificateRequestProperties();
    
    // The default value is ExportOption.NotExportable
    ExportOption defaultOption = reqProperties.Exportable;

    // If the input option does not equal the default option, reset the property value.
    if (inputOption != defaultOption)
    {
        reqProperties.Exportable = inputOption;
    }

    // Return the option value.
    return reqProperties.Exportable;
}

//</SnippetShowExportable>

//<SnippetShowDisplayName>
public String GetSetDisplayName(String strDisplayNameIn)
{
    // Create a new CertificateRequestProperties object.
    CertificateRequestProperties reqProperties = new CertificateRequestProperties();
    
    // The default value is an empty string.
    String defaultName = reqProperties.FriendlyName;

    // If the input option does not equal the default option, reset the property value.
    if (strDisplayNameIn != defaultName)
    {
        reqProperties.FriendlyName = strDisplayNameIn;
    }

    // Return the display name.
    return reqProperties.FriendlyName;

}

//</SnippetShowDisplayName>

//<SnippetShowHashAlg>
public String GetSetHashAlgorithm(String strAlgNameIn)
{
    // Create a new CertificateRequestProperties object.
    CertificateRequestProperties reqProperties = new CertificateRequestProperties();

    // The default value is SHA256.
    String strDefaultAlgName = reqProperties.HashAlgorithmName;

    // If the input option does not equal the default option, reset the property value.
    if (strAlgNameIn != strDefaultAlgName)
    {
        reqProperties.HashAlgorithmName = strAlgNameIn;
    }

    // Return the algorithm name.
    return reqProperties.HashAlgorithmName;
}

//</SnippetShowHashAlg>

//<SnippetShowPublicKeyAlg>
public String GetSetPublicKeyAlgorithm(String strAlgNameIn)
{
    // Create a new CertificateRequestProperties object.
    CertificateRequestProperties reqProperties = new CertificateRequestProperties();

    // The default value is RSA.
    String strDefaultAlgName = reqProperties.KeyAlgorithmName;

    // If the input option does not equal the default option, reset the property value.
    if (strAlgNameIn != strDefaultAlgName)
    {
        reqProperties.KeyAlgorithmName = strAlgNameIn;
    }

    // Return the algorithm name.
    return reqProperties.KeyAlgorithmName;
}

//</SnippetShowPublicKeyAlg>

//<SnippetShowProtectionLevel>
public KeyProtectionLevel GetSetKeyProtectionLevel(KeyProtectionLevel levelIn)
{
    // Create a new CertificateRequestProperties object.
    CertificateRequestProperties reqProperties = new CertificateRequestProperties();

    // The default value is NoConsent.
    KeyProtectionLevel defaultLevel = reqProperties.KeyProtectionLevel;

    // If the input option does not equal the default option, reset the property value.
    if (levelIn != defaultLevel)
    {
        reqProperties.KeyProtectionLevel = levelIn;
    }

    // return the key protection level.
    return reqProperties.KeyProtectionLevel;
}

//</SnippetShowProtectionLevel>

//<SnippetShowKeySize>
public UInt32 GetSetKeySize(UInt32 sizeIn)
{
    // Create a new CertificateRequestProperties object.
    CertificateRequestProperties reqProperties = new CertificateRequestProperties();

    // The default value is 2048 bits.
    UInt32 uDefaultSize = reqProperties.KeySize;

    // If the input option does not equal the default option, reset the property value.
    if (SizeIn != uDefaultSize)
    {
        reqProperties.KeySize = SizeIn;
    }

    // Return the key size.
    return reqProperties.KeySize;
}

//</SnippetShowKeySize>

//<SnippetShowKspName>
public String GetSetKspName(String strNameIn)
{
    // Create a new CertificateRequestProperties object.
    CertificateRequestProperties reqProperties = new CertificateRequestProperties();

    // The default value is Microsoft Software Key Storage Provider.
    String strDefaultName = reqProperties.KeyStorageProviderName;

    // If the input option does not equal the default option, reset the property value.
    if (strNameIn != strDefaultName)
    {
        reqProperties.KeyStorageProviderName = strNameIn;
    }

    // Return the KSP name.
    return reqProperties.KeyStorageProviderName;
}

//</SnippetShowKspName>

//<SnippetShowKeyUsages>
public EnrollKeyUsages GetSetKeyUsage(EnrollKeyUsages keyUseIn)
{
    // Create a new CertificateRequestProperties object.
    CertificateRequestProperties reqProperties = new CertificateRequestProperties();

    // The default value is signing.
    EnrollKeyUsages defaultKeyUse = reqProperties.KeyUsages;

    // If the input option does not equal the default option, reset the property value.
    if (keyUseIn != defaultKeyUse)
    {
        reqProperties.KeyUsages = keyUseIn;
    }

    // Return the value.
    return reqProperties.KeyUsages;
}

//</SnippetShowKeyUsages>

//<SnippetShowSubjectName>
public String GetSetSubjectName(String strNameIn)
{
    // Create a new CertificateRequestProperties object.
    CertificateRequestProperties reqProperties = new CertificateRequestProperties();

    // The default value is an empty string.
    String strDefaultName = reqProperties.Subject;

    // If the input option does not equal the default option, reset the property value.
    if (strNameIn != strDefaultName)
    {
        reqProperties.Subject = strNameIn;
    }

    // Return the subject name.
    return reqProperties.Subject;
}

//</SnippetShowSubjectName>

//<SnippetShowKeyAlgNamesClass>
using Windows.Security.Cryptography.Certificates;

namespace SampleKeyAlgorithmNames
{
    sealed partial class KeyAlgNamesApp : Application
    {
        public KeyAlgNamesApp()
        {
            // Initialize the application.
            this.InitializeComponent();

            // Demonstrate how to retrieve and set public key algorithm name.
            this.SamplePublicKeyAlgNames();
        }

        public void SamplePublicKeyAlgNames()
        {
            // Create a new CertificateRequestProperties object.
            CertificateRequestProperties reqProperties = new CertificateRequestProperties();

            // Retrieve the default value (RSA).
            String strDefaultAlgName = reqProperties.KeyAlgorithmName;

            // Set the value to DSA.
            reqProperties.KeyAlgorithmName = KeyAlgorithmNames.Dsa;

            //Set the value to ECDH_P256.
            reqProperties.KeyAlgorithmName = KeyAlgorithmNames.Ecdh256;

            //Set the value to ECDH_P384.
            reqProperties.KeyAlgorithmName = KeyAlgorithmNames.Ecdh384;

            //Set the value to ECDH_P521.
            reqProperties.KeyAlgorithmName = KeyAlgorithmNames.Ecdh521;

            //Set the value to ECDSA_P256.
            reqProperties.KeyAlgorithmName = KeyAlgorithmNames.Ecdsa256;

            //Set the value to ECDSA_P384.
            reqProperties.KeyAlgorithmName = KeyAlgorithmNames.Ecdsa384;

            //Set the value to ECDSA_P521.
            reqProperties.KeyAlgorithmName = KeyAlgorithmNames.Ecdsa521;
        }
    }
}

//</SnippetShowKeyAlgNamesClass>

//<SnippetShowKeyAlgNamesProps>
public void SamplePublicKeyAlgNames()
{
    // Create a new CertificateRequestProperties object.
    CertificateRequestProperties reqProperties = new CertificateRequestProperties();

    // Retrieve the default value (RSA).
    String strDefaultAlgName = reqProperties.KeyAlgorithmName;

    // Set the value to DSA.
    reqProperties.KeyAlgorithmName = KeyAlgorithmNames.Dsa;

    //Set the value to ECDH_P256.
    reqProperties.KeyAlgorithmName = KeyAlgorithmNames.Ecdh256;

    //Set the value to ECDH_P384.
    reqProperties.KeyAlgorithmName = KeyAlgorithmNames.Ecdh384;

    //Set the value to ECDH_P521.
    reqProperties.KeyAlgorithmName = KeyAlgorithmNames.Ecdh521;

    //Set the value to ECDSA_P256.
    reqProperties.KeyAlgorithmName = KeyAlgorithmNames.Ecdsa256;

    //Set the value to ECDSA_P384.
    reqProperties.KeyAlgorithmName = KeyAlgorithmNames.Ecdsa384;

    //Set the value to ECDSA_P521.
    reqProperties.KeyAlgorithmName = KeyAlgorithmNames.Ecdsa521;
}

//</SnippetShowKeyAlgNamesProps>

//<SnippetShowKspNamesClass>
using Windows.Security.Cryptography.Certificates;

namespace SampleKeyStorageProviderNames
{

    sealed partial class KspNamesApp : Application
    {
        public KspNamesApp()
        {
            // Initialize the application.
            this.InitializeComponent();

            // Demonstrate how to retrieve and set the key storage provider name.
            this.SampleKspNames();
        }

        public void SampleKspNames()
        {
            // Create a new CertificateRequestProperties object.
            CertificateRequestProperties reqProperties = new CertificateRequestProperties();

            // Retrieve the default value ("Microsoft Software Key Storage Provider").
            String strDefaultName = reqProperties.KeyStorageProviderName;

            // Set the value to "Microsoft Platform Crypto Provider".
            reqProperties.KeyStorageProviderName = KeyStorageProviderNames.PlatformKeyStorageProvider;

            // Set the value to "Microsoft Smart Card Key Storage Provider".
            reqProperties.KeyStorageProviderName = KeyStorageProviderNames.SmartcardKeyStorageProvider;
        }
    }
}

//</SnippetShowKspNamesClass>

//<SnippetShowAsymmKeyAlgOverview>

using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace SampleAsymmetricKeyAlgorithmProvider
{
    sealed partial class AsymmetricKeyAlgorithmApp : Application
    {
        static IBuffer buffKeyPair;

        public AsymmetricKeyAlgorithmApp()
        {
            // Initialize the application.
            this.InitializeComponent();

            // Create a symmetric session key.
            String strSymmetricAlgName = SymmetricAlgorithmNames.AesCbc;
            UInt32 symmetricKeyLength = 32;
            IBuffer buffSessionKey;
            this.SampleCreateSymmetricSessionKey(
                strSymmetricAlgName, 
                symmetricKeyLength, 
                out buffSessionKey);

            // Create an asymmetric key pair.
            String strAsymmetricAlgName = AsymmetricAlgorithmNames.RsaPkcs1;
            UInt32 asymmetricKeyLength = 512;
            IBuffer buffPublicKey;
            this.SampleCreateAsymmetricKeyPair(
                strAsymmetricAlgName, 
                asymmetricKeyLength, 
                out buffPublicKey);
 
            // Encrypt the symmetric session key by using the asymmetric public key.
            IBuffer buffEncryptedSessionKey;
            this.SampleAsymmetricEncryptSessionKey(
                strAsymmetricAlgName,
                buffSessionKey,
                buffPublicKey,
                out buffEncryptedSessionKey);

            // Decrypt the symmetric session key by using the asymmetric private key
            // that corresponds to the public key used to encrypt the session key.
            this.SampleAsymmetricDecryptSessionKey(
                strAsymmetricAlgName,
                strSymmetricAlgName,
                buffEncryptedSessionKey);
        }

        public void SampleCreateSymmetricSessionKey(
            string strSymmetricAlgName,
            UInt32 keyLength,
            out IBuffer buffSessionKey)
        {
            // Open a symmetric algorithm provider for the specified algorithm.
            SymmetricKeyAlgorithmProvider objAlg = SymmetricKeyAlgorithmProvider.OpenAlgorithm(strSymmetricAlgName);

            // Create a symmetric session key.
            IBuffer keyMaterial = CryptographicBuffer.GenerateRandom(keyLength);
            CryptographicKey sessionKey = objAlg.CreateSymmetricKey(keyMaterial);

            buffSessionKey = keyMaterial;
        }

        public void SampleCreateAsymmetricKeyPair(
            String strAsymmetricAlgName,
            UInt32 keyLength,
            out IBuffer buffPublicKey)
        {
            // Open the algorithm provider for the specified asymmetric algorithm.
            AsymmetricKeyAlgorithmProvider objAlgProv = AsymmetricKeyAlgorithmProvider.OpenAlgorithm(strAsymmetricAlgName);

            // Demonstrate use of the AlgorithmName property (not necessary to create a key pair).
            String strAlgName = objAlgProv.AlgorithmName;

            // Create an asymmetric key pair.
            CryptographicKey keyPair = objAlgProv.CreateKeyPair(keyLength);

            // Export the public key to a buffer for use by others.
            buffPublicKey = keyPair.ExportPublicKey();

            // You should keep your private key (embedded in the key pair) secure. For  
            // the purposes of this example, however, we're just copying it into a
            // static class variable for later use during decryption.
            AsymmetricKeyAlgorithmApp.buffKeyPair = keyPair.Export();
        }
 
        public void SampleAsymmetricEncryptSessionKey(
            String strAsymmetricAlgName,
            IBuffer buffSessionKeyToEncrypt,
            IBuffer buffPublicKey,
            out IBuffer buffEncryptedSessionKey)
        {
            // Open the algorithm provider for the specified asymmetric algorithm.
            AsymmetricKeyAlgorithmProvider objAlgProv = AsymmetricKeyAlgorithmProvider.OpenAlgorithm(strAsymmetricAlgName);

            // Import the public key from a buffer.
            CryptographicKey publicKey = objAlgProv.ImportPublicKey(buffPublicKey);

            // Encrypt the session key by using the public key.
            buffEncryptedSessionKey = CryptographicEngine.Encrypt(publicKey, buffSessionKeyToEncrypt, null);
        }

        public void SampleAsymmetricDecryptSessionKey(
            String strAsymmetricAlgName,
            String strSymmetricAlgName,
            IBuffer buffEncryptedSessionKey)
        {
            // Open the algorithm provider for the specified asymmetric algorithm.
            AsymmetricKeyAlgorithmProvider objAsymmAlgProv = AsymmetricKeyAlgorithmProvider.OpenAlgorithm(strAsymmetricAlgName);

            // Import the public key from a buffer. You should keep your private key
            // secure. For the purposes of this example, however, the private key is
            // just stored in a static class variable.
            CryptographicKey keyPair = objAsymmAlgProv.ImportKeyPair(AsymmetricKeyAlgorithmApp.buffKeyPair);

            // Use the private key embedded in the key pair to decrypt the session key.
            IBuffer buffDecryptedSessionKey = CryptographicEngine.Decrypt(keyPair, buffEncryptedSessionKey, null);

            // Convert the decrypted session key into a CryptographicKey object that
            // can be used to decrypt the message that it previously encrypted (not shown).
            SymmetricKeyAlgorithmProvider objSymmAlgProv = SymmetricKeyAlgorithmProvider.OpenAlgorithm(strSymmetricAlgName);
            CryptographicKey sessionKey = objSymmAlgProv.CreateSymmetricKey(buffDecryptedSessionKey);
        }
    }
}

//</SnippetShowAsymmKeyAlgOverview>

//<SnippetShowSymmDecryption>
public void SampleCipherDecryption(
    String strAlgName,
    IBuffer buffEncrypt,
    IBuffer iv,
    BinaryStringEncoding encoding,
    CryptographicKey key)
{
    // Declare a buffer to contain the decrypted data.
    IBuffer buffDecrypted;

    // Open an symmetric algorithm provider for the specified algorithm. 
    SymmetricKeyAlgorithmProvider objAlg = SymmetricKeyAlgorithmProvider.OpenAlgorithm(strAlgName);

    // The input key must be securely shared between the sender of the encrypted message
    // and the recipient. The initialization vector must also be shared but does not
    // need to be shared in a secure manner. If the sender encodes a message string 
    // to a buffer, the binary encoding method must also be shared with the recipient.
    buffDecrypted = CryptographicEngine.Decrypt(key, buffEncrypt, iv);

    // Convert the decrypted buffer to a string (for display). If the sender created the
    // original message buffer from a string, the sender must tell the recipient what 
    // BinaryStringEncoding value was used. Here, BinaryStringEncoding.Utf8 is used to
    // convert the message to a buffer before encryption and to convert the decrypted
    // buffer back to the original plaintext.
    String strDecrypted = CryptographicBuffer.ConvertBinaryToString(encoding, buffDecrypted);
}

//</SnippetShowSymmDecryption>

//<SnippetShowAuthenticatedDecryption>
public void AuthenticatedDecryption(
    String strAlgName,
    CryptographicKey key,
    EncryptedAndAuthenticatedData objEncrypted,
    BinaryStringEncoding encoding,
    IBuffer buffNonce)
{
    // Declare a buffer to contain the decrypted data.
    IBuffer buffDecrypted;

    // Open a SymmetricKeyAlgorithmProvider object for the specified algorithm.
    SymmetricKeyAlgorithmProvider objAlgProv = SymmetricKeyAlgorithmProvider.OpenAlgorithm(strAlgName);

    // The input key must be securely shared between the sender of the encrypted message
    // and the recipient. The nonce must also be shared but does not need to be shared
    // in a secure manner. If the sender encodes the message string to a buffer, the
    // binary encoding method must also be shared with the recipient.
    // The recipient uses the DecryptAndAuthenticate() method as follows to decrypt the 
    // message, authenticate it, and verify that it has not been altered in transit.
    buffDecrypted = CryptographicEngine.DecryptAndAuthenticate(
        key,
        objEncrypted.EncryptedData,
        buffNonce,
        objEncrypted.AuthenticationTag,
        null);

    // Convert the decrypted buffer to a string (for display). If the sender created the
    // original message buffer from a string, the sender must tell the recipient what 
    // BinaryStringEncoding value was used. Here, BinaryStringEncoding.Utf8 is used to
    // convert the message to a buffer before encryption and to convert the decrypted
    // buffer back to the original plaintext.
    String strDecrypted = CryptographicBuffer.ConvertBinaryToString(encoding, buffDecrypted);

}

//</SnippetShowAuthenticatedDecryption>

//<SnippetShowDerivationFromPbkdf>
public String SampleDeriveFromPbkdf(
    String strAlgName,
    UInt32 targetSize)
{
    // Open the specified algorithm.
    KeyDerivationAlgorithmProvider objKdfProv = KeyDerivationAlgorithmProvider.OpenAlgorithm(strAlgName);

    // Create a buffer that contains the secret used during derivation.
    String strSecret = "MyPassword";
    IBuffer buffSecret = CryptographicBuffer.ConvertStringToBinary(strSecret, BinaryStringEncoding.Utf8);

    // Create a random salt value.
    IBuffer buffSalt = CryptographicBuffer.GenerateRandom(32);

    // Specify the number of iterations to be used during derivation.
    UInt32 iterationCount = 10000;

    // Create the derivation parameters.
    KeyDerivationParameters pbkdf2Params = KeyDerivationParameters.BuildForPbkdf2(buffSalt, iterationCount);

    // Create a key from the secret value.
    CryptographicKey keyOriginal = objKdfProv.CreateKey(buffSecret);

    // Derive a key based on the original key and the derivation parameters.
    IBuffer keyDerived = CryptographicEngine.DeriveKeyMaterial(
        keyOriginal,
        pbkdf2Params,
        targetSize);

    // Encode the key to a hexadecimal value (for display)
    String strKeyHex = CryptographicBuffer.EncodeToHexString(keyDerived);

    // Return the encoded string
    return strKeyHex;
}

//</SnippetShowDerivationFromPbkdf>

//<SnippetShowSymmEncryption>
public IBuffer SampleCipherEncryption(
    String strMsg,
    String strAlgName,
    UInt32 keyLength,
    out BinaryStringEncoding encoding,
    out IBuffer iv,
    out CryptographicKey key)
{
    // Initialize the initialization vector.
    iv = null;

    // Initialize the binary encoding value.
    encoding = BinaryStringEncoding.Utf8;

    // Create a buffer that contains the encoded message to be encrypted. 
    IBuffer buffMsg = CryptographicBuffer.ConvertStringToBinary(strMsg, encoding);

    // Open a symmetric algorithm provider for the specified algorithm. 
    SymmetricKeyAlgorithmProvider objAlg = SymmetricKeyAlgorithmProvider.OpenAlgorithm(strAlgName);

    // Determine whether the message length is a multiple of the block length.
    // This is not necessary for PKCS #7 algorithms which automatically pad the
    // message to an appropriate length.
    if (!strAlgName.Contains("PKCS7"))
    {
        if ((buffMsg.Length % objAlg.BlockLength) != 0)
        {
            throw new Exception("Message buffer length must be multiple of block length.");
        }
    }

    // Create a symmetric key.
    IBuffer keyMaterial = CryptographicBuffer.GenerateRandom(keyLength);
    key = objAlg.CreateSymmetricKey(keyMaterial);

    // CBC algorithms require an initialization vector. Here, a random
    // number is used for the vector.
    if (strAlgName.Contains("CBC"))
    {
        iv = CryptographicBuffer.GenerateRandom(objAlg.BlockLength);
    }

    // Encrypt the data and return.
    IBuffer buffEncrypt = CryptographicEngine.Encrypt(key, buffMsg, iv);
    return buffEncrypt;
}

//</SnippetShowSymmEncryption>

//<SnippetShowAuthenticatedEncryption>
public EncryptedAndAuthenticatedData AuthenticatedEncryption(
    String strMsg,
    String strAlgName,
    UInt32 keyLength,
    out BinaryStringEncoding encoding,
    out IBuffer buffNonce,
    out CryptographicKey key)
{
    // Open a SymmetricKeyAlgorithmProvider object for the specified algorithm.
    SymmetricKeyAlgorithmProvider objAlgProv = SymmetricKeyAlgorithmProvider.OpenAlgorithm(strAlgName);

    // Create a buffer that contains the data to be encrypted.
    encoding = BinaryStringEncoding.Utf8;
    IBuffer buffMsg = CryptographicBuffer.ConvertStringToBinary(strMsg, encoding);

    // Generate a symmetric key.
    IBuffer keyMaterial = CryptographicBuffer.GenerateRandom(keyLength);
    key = objAlgProv.CreateSymmetricKey(keyMaterial);

    // Generate a new nonce value.
    buffNonce = GetNonce();

    // Encrypt and authenticate the message.
    EncryptedAndAuthenticatedData objEncrypted = CryptographicEngine.EncryptAndAuthenticate(
        key,
        buffMsg,
        buffNonce,
        null);

    return objEncrypted;

}

IBuffer GetNonce()
{
    // Security best practises require that an ecryption operation not
    // be called more than once with the same nonce for the same key.
    // A nonce value can be predictable, but must be unique for each
    // secure session.

    NonceBytes[0]++;
    for (int i = 0; i < NonceBytes.Length - 1; i++)
    {
        if (NonceBytes[i] == 255)
        {
            NonceBytes[i + 1]++;
        }
    }

    return CryptographicBuffer.CreateFromByteArray(NonceBytes);
}

//</SnippetShowAuthenticatedEncryption>

//<SnippetShowSigning>
public IBuffer SampleCreateHMAC(
    String strMsg,
    String strAlgName,
    out IBuffer buffMsg,
    out CryptographicKey hmacKey)
{
    // Create a MacAlgorithmProvider object for the specified algorithm.
    MacAlgorithmProvider objMacProv = MacAlgorithmProvider.OpenAlgorithm(strAlgName);

    // Create a buffer that contains the message to be signed.
    BinaryStringEncoding encoding = BinaryStringEncoding.Utf8;
    buffMsg = CryptographicBuffer.ConvertStringToBinary(strMsg, encoding);

    // Create a key to be signed with the message.
    IBuffer buffKeyMaterial = CryptographicBuffer.GenerateRandom(objMacProv.MacLength);
    hmacKey = objMacProv.CreateKey(buffKeyMaterial);

    // Sign the key and message together.
    IBuffer buffHMAC = CryptographicEngine.Sign(hmacKey, buffMsg);

    // Verify that the HMAC length is correct for the selected algorithm
    if (buffHMAC.Length != objMacProv.MacLength)
    {
        throw new Exception("Error computing digest");
    }

    // Return the HMAC.
    return buffHMAC;
}

//</SnippetShowSigning>

//<SnippetShowVerifySignature>
public void SampleVerifyHMAC(
    IBuffer buffMsg,
    CryptographicKey hmacKey,
    IBuffer buffHMAC)
{
    // The input key must be securely shared between the sender of the HMAC and 
    // the recipient. The recipient uses the CryptographicEngine.VerifySignature() 
    // method as follows to verify that the message has not been altered in transit.
    Boolean IsAuthenticated = CryptographicEngine.VerifySignature(hmacKey, buffMsg, buffHMAC);
    if (!IsAuthenticated)
    {
        throw new Exception("The message cannot be verified.");
    }
}

//</SnippetShowVerifySignature>

//<SnippetShowAppend>
public void SampleReusableHash()
{
    // Create a string that contains the name of the hashing algorithm to use.
    String strAlgName = HashAlgorithmNames.Sha512;

    // Create a HashAlgorithmProvider object.
    HashAlgorithmProvider objAlgProv = HashAlgorithmProvider.OpenAlgorithm(strAlgName);

    // Create a CryptographicHash object. This object can be reused to continually
    // hash new messages.
    CryptographicHash objHash = objAlgProv.CreateHash();

    // Hash message 1.
    String strMsg1 = "This is message 1.";
    IBuffer buffMsg1 = CryptographicBuffer.ConvertStringToBinary(strMsg1, BinaryStringEncoding.Utf16BE);
    objHash.Append(buffMsg1);
    IBuffer buffHash1 = objHash.GetValueAndReset();

    // Hash message 2.
    String strMsg2 = "This is message 2.";
    IBuffer buffMsg2 = CryptographicBuffer.ConvertStringToBinary(strMsg2, BinaryStringEncoding.Utf16BE);
    objHash.Append(buffMsg2);
    IBuffer buffHash2 = objHash.GetValueAndReset();

    // Hash message 3.
    String strMsg3 = "This is message 3.";
    IBuffer buffMsg3 = CryptographicBuffer.ConvertStringToBinary(strMsg3, BinaryStringEncoding.Utf16BE);
    objHash.Append(buffMsg3);
    IBuffer buffHash3 = objHash.GetValueAndReset();

    // Convert the hashes to string values (for display);
    String strHash1 = CryptographicBuffer.EncodeToBase64String(buffHash1);
    String strHash2 = CryptographicBuffer.EncodeToBase64String(buffHash2);
    String strHash3 = CryptographicBuffer.EncodeToBase64String(buffHash3);
}

//</SnippetShowAppend>

//<SnippetShowCryptographicKeyClass>
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace SampleCryptographicKey
{
    sealed partial class CryptographicKeyApp : Application
    {
        static IBuffer buffKeyPair;

        public CryptographicKeyApp()
        {
            // Initialize the application.
            this.InitializeComponent();

            // Create an asymmetric key pair.
            String strAsymmetricAlgName = AsymmetricAlgorithmNames.RsaPkcs1;
            UInt32 asymmetricKeyLength = 512;
            IBuffer buffPublicKey = this.SampleCreateAsymmetricKeyPair(
                strAsymmetricAlgName,
                asymmetricKeyLength);
        }

        public IBuffer SampleCreateAsymmetricKeyPair(
            String strAsymmetricAlgName,
            UInt32 keyLength)
        {
            // Open the algorithm provider for the specified asymmetric algorithm.
            AsymmetricKeyAlgorithmProvider objAlgProv = AsymmetricKeyAlgorithmProvider.OpenAlgorithm(strAsymmetricAlgName);

            // Create an asymmetric key pair.
            CryptographicKey keyPair = objAlgProv.CreateKeyPair(keyLength);

            // Export the public key to a buffer for use by others.
            IBuffer buffPublicKey = keyPair.ExportPublicKey();

            // You should keep your private key (embedded in the key pair) secure. For  
            // the purposes of this example, however, we're just copying it into a
            // static class variable for later use during decryption.
            CryptographicKeyApp.buffKeyPair = keyPair.Export();

            // Retrieve the size of the key pair.
            UInt32 lengthKeyPair = keyPair.KeySize;

            // Return the public key.
            return buffPublicKey;
        }
    }
}

//</SnippetShowCryptographicKeyClass>

//<SnippetShowEncryptedAuthenticatedDataClass>
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace SampleEncryptedAndAuthenticatedData
{
    sealed partial class EncryptedAuthenticatedDataApp : Application
    {
        // Initialize a static nonce value.
        static byte[] NonceBytes = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public EncryptedAuthenticatedDataApp()
        {
            // Initialize the application.
            this.InitializeComponent();

            // Initialize the encryption method.
            String strMsg = "This is a message.";   // Message to encrypt and authenticate.
            String strAlgName = SymmetricAlgorithmNames.AesGcm;
            UInt32 keyLength = 32;                  // Length of the key, in bytes
            BinaryStringEncoding encoding;          // Binary encoding
            IBuffer buffNonce;                      // Nonce
            CryptographicKey key;                   // Symmetric key

            // Encrypt and authenticate the message.
            EncryptedAndAuthenticatedData objEncrypted = this.AuthenticatedEncryption(
                strMsg,
                strAlgName,
                keyLength,
                out encoding,
                out buffNonce,
                out key);

            // Decrypt the encrypted data.
            this.AuthenticatedDecryption(
                strAlgName,
                key,
                objEncrypted,
                encoding,
                buffNonce);
        }

        public EncryptedAndAuthenticatedData AuthenticatedEncryption(
            String strMsg,
            String strAlgName, 
            UInt32 keyLength, 
            out BinaryStringEncoding encoding, 
            out IBuffer buffNonce,
            out CryptographicKey key)
        {
            // Open a SymmetricKeyAlgorithmProvider object for the specified algorithm.
            SymmetricKeyAlgorithmProvider objAlgProv = SymmetricKeyAlgorithmProvider.OpenAlgorithm(strAlgName);

            // Create a buffer that contains the data to be encrypted.
            encoding = BinaryStringEncoding.Utf8;
            IBuffer buffMsg = CryptographicBuffer.ConvertStringToBinary(strMsg, encoding);

            // Generate a symmetric key.
            IBuffer keyMaterial = CryptographicBuffer.GenerateRandom(keyLength);
            key = objAlgProv.CreateSymmetricKey(keyMaterial);

            // Generate a new nonce value.
            buffNonce = GetNonce();

            // Encrypt and authenticate the message.
            EncryptedAndAuthenticatedData objEncrypted = CryptographicEngine.EncryptAndAuthenticate(
                key,
                buffMsg,
                buffNonce,
                null);

            return objEncrypted;

        }

        public void AuthenticatedDecryption(
            String strAlgName, 
            CryptographicKey key,
            EncryptedAndAuthenticatedData objEncrypted,
            BinaryStringEncoding encoding, 
            IBuffer buffNonce)
        {
            // Declare a buffer to contain the decrypted data.
            IBuffer buffDecrypted;

            // Open a SymmetricKeyAlgorithmProvider object for the specified algorithm.
            SymmetricKeyAlgorithmProvider objAlgProv = SymmetricKeyAlgorithmProvider.OpenAlgorithm(strAlgName);

            // The input key must be securely shared between the sender of the encrypted message
            // and the recipient. The nonce must also be shared but does not need to be shared
            // in a secure manner. If the sender encodes the message string to a buffer, the
            // binary encoding method must also be shared with the recipient.
            // The recipient uses the DecryptAndAuthenticate() method as follows to decrypt the 
            // message, authenticate it, and verify that it has not been altered in transit.
            buffDecrypted = CryptographicEngine.DecryptAndAuthenticate(
                key,
                objEncrypted.EncryptedData,
                buffNonce,
                objEncrypted.AuthenticationTag,
                null);

            // Convert the decrypted buffer to a string (for display). If the sender created the
            // original message buffer from a string, the sender must tell the recipient what 
            // BinaryStringEncoding value was used. Here, BinaryStringEncoding.Utf8 is used to
            // convert the message to a buffer before encryption and to convert the decrypted
            // buffer back to the original plaintext.
            String strDecrypted = CryptographicBuffer.ConvertBinaryToString(encoding, buffDecrypted);

        }

        IBuffer GetNonce()
        {
            // Security best practises require that an ecryption operation not
            // be called more than once with the same nonce for the same key.
            // A nonce value can be predictable, but must be unique for each
            // secure session.

            NonceBytes[0]++;
            for (int i = 0; i < NonceBytes.Length - 1; i++)
            {
                if (NonceBytes[i] == 255)
                {
                    NonceBytes[i + 1]++;
                }
            }

            return CryptographicBuffer.CreateFromByteArray(NonceBytes);
        }
    }
}

//</SnippetShowEncryptedAuthenticatedDataClass>

//<SnippetShowHashAlgProviderClass>
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace SampleHashAlgorithmProvider
{

    sealed partial class HashAlgProviderApp : Application
    {
        public HashAlgProviderApp()
        {
            // Initialize the application.
            this.InitializeComponent();

            // Hash a message.
            String strAlgName = HashAlgorithmNames.Sha512;
            String strMsg = "This is a message to be hashed.";
            String strEncodedHash = this.SampleHashMsg(strAlgName, strMsg);
        }

        public String SampleHashMsg(String strAlgName, String strMsg)
        {
            // Convert the message string to binary data.
            IBuffer buffUtf8Msg = CryptographicBuffer.ConvertStringToBinary(strMsg, BinaryStringEncoding.Utf8);

            // Create a HashAlgorithmProvider object.
            HashAlgorithmProvider objAlgProv = HashAlgorithmProvider.OpenAlgorithm(strAlgName);

            // Demonstrate how to retrieve the name of the hashing algorithm.
            String strAlgNameUsed = objAlgProv.AlgorithmName;

            // Hash the message.
            IBuffer buffHash = objAlgProv.HashData(buffUtf8Msg);

            // Verify that the hash length equals the length specified for the algorithm.
            if (buffHash.Length != objAlgProv.HashLength)
            {
                throw new Exception("There was an error creating the hash");
            }

            // Convert the hash to a string (for display).
            String strHashBase64 = CryptographicBuffer.EncodeToBase64String(buffHash);

            // Return the encoded string
            return strHashBase64;
        }
    }
}

//</SnippetShowHashAlgProviderClass>

//<SnippetKdfAlgClassOverview>

using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace SampleKeyDerivationAlgorithm
{
    sealed partial class SampleKeyDerivationProviderApp : Application
    {
        public SampleKeyDerivationProviderApp()
        {
            // Initialize the Application.
            this.InitializeComponent();

            // Derive key material from a password-based key derivation function.
            String strKdfAlgName = KeyDerivationAlgorithmNames.Pbkdf2Sha256;
            UInt32 targetKeySize = 32;
            UInt32 iterationCount = 10000;
            IBuffer buffKeyMatl = this.SampleDeriveKeyMaterialPbkdf(
                strKdfAlgName,
                targetKeySize,
                iterationCount);

            // Create a key.
            CryptographicKey key = this.SampleCreateKDFKey(
                strKdfAlgName,
                buffKeyMatl);
        }

        public IBuffer SampleDeriveKeyMaterialPbkdf(
            String strAlgName,
            UInt32 targetKeySize,
            UInt32 iterationCount)
        {

            // Open the specified algorithm.
            KeyDerivationAlgorithmProvider objKdfProv = KeyDerivationAlgorithmProvider.OpenAlgorithm(strAlgName);

            // Demonstrate how to retrieve the algorithm name.
            String strAlgUsed = objKdfProv.AlgorithmName;

            // Create a buffer that contains the secret used during derivation.
            String strSecret = "MyPassword";
            IBuffer buffSecret = CryptographicBuffer.ConvertStringToBinary(strSecret, BinaryStringEncoding.Utf8);

            // Create a random salt value.
            IBuffer buffSalt = CryptographicBuffer.GenerateRandom(32);

            // Create the derivation parameters.
            KeyDerivationParameters pbkdf2Params = KeyDerivationParameters.BuildForPbkdf2(buffSalt, iterationCount);

            // Create a key from the secret value.
            CryptographicKey keyOriginal = objKdfProv.CreateKey(buffSecret);

            // Derive a key based on the original key and the derivation parameters.
            IBuffer keyMaterial = CryptographicEngine.DeriveKeyMaterial(
                keyOriginal,
                pbkdf2Params,
                targetKeySize);

            // Demonstrate checking the iteration count.
            UInt32 iterationCountOut = pbkdf2Params.IterationCount;

            // Demonstrate returning the derivation parameters to a buffer.
            IBuffer buffParams = pbkdf2Params.KdfGenericBinary;

            // return the KDF key material.
            return keyMaterial;
        }

        public CryptographicKey SampleCreateKDFKey(
            String strAlgName,
            IBuffer buffKeyMaterial)
        {
            // Create a KeyDerivationAlgorithmProvider object and open the specified algorithm.
            KeyDerivationAlgorithmProvider objKdfAlgProv = KeyDerivationAlgorithmProvider.OpenAlgorithm(strAlgName);

            // Create a key by using the KDF parameters.
            CryptographicKey key = objKdfAlgProv.CreateKey(buffKeyMaterial);

            return key;
        }
    }
}

//</SnippetKdfAlgClassOverview>



//<SnippetShowDerivationFromSP800108>
public void SampleDeriveFromSP800108()
{
    // Create a string that contains the algorithm name.
    String strAlgName = KeyDerivationAlgorithmNames.Sp800108CtrHmacSha256;

    // Open the specified algorithm.
    KeyDerivationAlgorithmProvider objKdfProv = KeyDerivationAlgorithmProvider.OpenAlgorithm(strAlgName);

    // Specify the requested size, in bytes, of the derived key. 
    UInt32 targetSize = 32;

    // Create a buffer that contains the label value.
    String strPurpose = "Purpose";
    IBuffer buffLabel = CryptographicBuffer.ConvertStringToBinary(strPurpose, BinaryStringEncoding.Utf8);

    // Create a buffer that contains the context value.
    byte[] Nonce = { 1, 1, 0, 0, 0, 0, 0, 0};
    IBuffer buffContext = CryptographicBuffer.CreateFromByteArray(Nonce);

    // Create the derivation parameters.
    KeyDerivationParameters kdf800108Params = KeyDerivationParameters.BuildForSP800108(buffLabel, buffContext);

    // Create a secret value.
    IBuffer buffSecret = CryptographicBuffer.GenerateRandom(32);

    // Create a key from the secret value.
    CryptographicKey keyOriginal = objKdfProv.CreateKey(buffSecret);

    // Derive a key based on the original key and the derivation parameters.
    IBuffer keyDerived = CryptographicEngine.DeriveKeyMaterial(
        keyOriginal,
        kdf800108Params,
        targetSize);

    // Encode the key to a hexadecimal value (for display)
    String strKeyHex = CryptographicBuffer.EncodeToHexString(keyDerived);
}

//</SnippetShowDerivationFromSP800108>

//<SnippetShowDerivationFromSP80056a>
public void SampleDeriveFromSP80056a()
{
    // Create a string that contains the algorithm name.
    String strAlgName = KeyDerivationAlgorithmNames.Sp80056aConcatSha512;

    // Open the specified algorithm.
    KeyDerivationAlgorithmProvider objKdfProv = KeyDerivationAlgorithmProvider.OpenAlgorithm(strAlgName);

    // Specify the requested size, in bytes, of the derived key. 
    UInt32 targetSize = 32;

    // Create a buffer that contains the secret to be used during derivation.
    IBuffer buffSecret = CryptographicBuffer.GenerateRandom(32);

    // Create a buffer that contains the intended purpose of the derived key.
    String strAlgId = "Purpose";
    IBuffer buffAlgId = CryptographicBuffer.ConvertStringToBinary(strAlgId, BinaryStringEncoding.Utf8);

    // Create a buffer that contains public information contributed by the initiator.
    String strPartyUInfo = "Initiator public info";
    IBuffer buffPartyUInfo = CryptographicBuffer.ConvertStringToBinary(strPartyUInfo, BinaryStringEncoding.Utf8);

    // Create a buffer that contains public information contributed by the responder.
    String strPartyVInfo = "Responder public info";
    IBuffer buffPartyVInfo = CryptographicBuffer.ConvertStringToBinary(strPartyVInfo, BinaryStringEncoding.Utf8);

    // Create a buffer that contains public information known to both parties.
    String strSuppPubInfo = "Two party public info";
    IBuffer buffSuppPubInfo = CryptographicBuffer.ConvertStringToBinary(strSuppPubInfo, BinaryStringEncoding.Utf8);

    // Create a buffer that contains a shared private secret.
    IBuffer buffSuppPrivInfo = CryptographicBuffer.GenerateRandom(32);

    // Create the derivation parameters.
    KeyDerivationParameters kdf80056AParamsEx = KeyDerivationParameters.BuildForSP80056a(
        buffAlgId,
        buffPartyUInfo,
        buffPartyVInfo,
        buffSuppPubInfo,
        buffSuppPrivInfo);

    // Create a key from the secret value.
    CryptographicKey keyOriginal = objKdfProv.CreateKey(buffSecret);

    // Derive a key based on the original key and the derivation parameters.
    IBuffer keyDerived = CryptographicEngine.DeriveKeyMaterial(
        keyOriginal,
        kdf80056AParamsEx,
        targetSize);

    // Encode the key to a hexadecimal value (for display)
    String strKeyHex = CryptographicBuffer.EncodeToHexString(keyDerived);
}

//</SnippetShowDerivationFromSP80056a>

//<SnippetShowMacAlgProviderClass>
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace SampleMacAlgorithmProvider
{
    sealed partial class MacAlgProviderApp : Application
    {
        public MacAlgProviderApp()
        {
            // Initialize the application.
            this.InitializeComponent();

            // Initialize the hashing process.
            String strMsg = "This is a message to be authenticated";
            String strAlgName = MacAlgorithmNames.HmacSha384;
            IBuffer buffMsg;
            CryptographicKey hmacKey;
            IBuffer buffHMAC;

            // Create a hashed message authentication code (HMAC)
            this.CreateHMAC(
                strMsg,
                strAlgName,
                out buffMsg,
                out hmacKey,
                out buffHMAC);

            // Verify the HMAC.
            this.VerifyHMAC(
                buffMsg,
                hmacKey,
                buffHMAC);
        }

        void CreateHMAC(
            String strMsg,
            String strAlgName,
            out IBuffer buffMsg,
            out CryptographicKey hmacKey,
            out IBuffer buffHMAC)
        {
            // Create a MacAlgorithmProvider object for the specified algorithm.
            MacAlgorithmProvider objMacProv = MacAlgorithmProvider.OpenAlgorithm(strAlgName);

            // Demonstrate how to retrieve the name of the algorithm used.
            String strNameUsed = objMacProv.AlgorithmName;

            // Create a buffer that contains the message to be signed.
            BinaryStringEncoding encoding = BinaryStringEncoding.Utf8;
            buffMsg = CryptographicBuffer.ConvertStringToBinary(strMsg, encoding);

            // Create a key to be signed with the message.
            IBuffer buffKeyMaterial = CryptographicBuffer.GenerateRandom(objMacProv.MacLength);
            hmacKey = objMacProv.CreateKey(buffKeyMaterial);

            // Sign the key and message together.
            buffHMAC = CryptographicEngine.Sign(hmacKey, buffMsg);

            // Verify that the HMAC length is correct for the selected algorithm
            if (buffHMAC.Length != objMacProv.MacLength)
            {
                throw new Exception("Error computing digest");
            }
         }

        public void VerifyHMAC(
            IBuffer buffMsg,
            CryptographicKey hmacKey,
            IBuffer buffHMAC)
        {
            // The input key must be securely shared between the sender of the HMAC and 
            // the recipient. The recipient uses the CryptographicEngine.VerifySignature() 
            // method as follows to verify that the message has not been altered in transit.
            Boolean IsAuthenticated = CryptographicEngine.VerifySignature(hmacKey, buffMsg, buffHMAC);
            if (!IsAuthenticated)
            {
                throw new Exception("The message cannot be verified.");
            }
        }
    }
}

//</SnippetShowMacAlgProviderClass>

//<SnippetShowSymmKeyAlgProviderClass>
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace SampleSymmetricKeyAlgorithmProvider
{
    sealed partial class SymmKeyAlgProviderApp : Application
    {
        public SymmKeyAlgProviderApp()
        {
            // Initialize the application.
            this.InitializeComponent();

            // Initialize the encryption process.
            String strMsg = "1234567812345678";     // Data to encrypt.
            String strAlgName = SymmetricAlgorithmNames.AesCbc;
            UInt32 keyLength = 32;                  // Length of the key, in bytes
            BinaryStringEncoding encoding;          // Binary encoding value
            IBuffer iv;                             // Initialization vector
            CryptographicKey key;                   // Symmetric key

            // Encrypt a message.
            IBuffer buffEncrypted = this.SampleCipherEncryption(
                strMsg,
                strAlgName,
                keyLength,
                out encoding,
                out iv,
                out key);

            // Decrypt a message.
            this.SampleCipherDecryption(
                strAlgName,
                buffEncrypted,
                iv,
                encoding,
                key);
        }

        public IBuffer SampleCipherEncryption(
            String strMsg,
            String strAlgName,
            UInt32 keyLength,
            out BinaryStringEncoding encoding,
            out IBuffer iv,
            out CryptographicKey key)
        {
            // Initialize the initialization vector.
            iv = null;

            // Initialize the binary encoding value.
            encoding = BinaryStringEncoding.Utf8;

            // Create a buffer that contains the encoded message to be encrypted. 
            IBuffer buffMsg = CryptographicBuffer.ConvertStringToBinary(strMsg, encoding);

            // Open a symmetric algorithm provider for the specified algorithm. 
            SymmetricKeyAlgorithmProvider objAlg = SymmetricKeyAlgorithmProvider.OpenAlgorithm(strAlgName);

            // Demonstrate how to retrieve the name of the algorithm used.
            String strAlgNameUsed = objAlg.AlgorithmName;

            // Determine whether the message length is a multiple of the block length.
            // This is not necessary for PKCS #7 algorithms which automatically pad the
            // message to an appropriate length.
            if (!strAlgName.Contains("PKCS7"))
            {
               if ((buffMsg.Length % objAlg.BlockLength) != 0)
                {
                    throw new Exception("Message buffer length must be multiple of block length.");
                }
            }

            // Create a symmetric key.
            IBuffer keyMaterial = CryptographicBuffer.GenerateRandom(keyLength);
            key = objAlg.CreateSymmetricKey(keyMaterial);

            // CBC algorithms require an initialization vector. Here, a random
            // number is used for the vector.
            if (strAlgName.Contains("CBC"))
            {
                iv = CryptographicBuffer.GenerateRandom(objAlg.BlockLength);
            }

            // Encrypt the data and return.
            IBuffer buffEncrypt = CryptographicEngine.Encrypt(key, buffMsg, iv);
            return buffEncrypt;
        }

        public void SampleCipherDecryption(
            String strAlgName,
            IBuffer buffEncrypt,
            IBuffer iv,
            BinaryStringEncoding encoding,
            CryptographicKey key)
        {
            // Declare a buffer to contain the decrypted data.
            IBuffer buffDecrypted;

            // Open an symmetric algorithm provider for the specified algorithm. 
            SymmetricKeyAlgorithmProvider objAlg = SymmetricKeyAlgorithmProvider.OpenAlgorithm(strAlgName);

            // The input key must be securely shared between the sender of the encrypted message
            // and the recipient. The initialization vector must also be shared but does not
            // need to be shared in a secure manner. If the sender encodes a message string 
            // to a buffer, the binary encoding method must also be shared with the recipient.
            buffDecrypted = CryptographicEngine.Decrypt(key, buffEncrypt, iv);

            // Convert the decrypted buffer to a string (for display). If the sender created the
            // original message buffer from a string, the sender must tell the recipient what 
            // BinaryStringEncoding value was used. Here, BinaryStringEncoding.Utf8 is used to
            // convert the message to a buffer before encryption and to convert the decrypted
            // buffer back to the original plaintext.
            String strDecrypted = CryptographicBuffer.ConvertBinaryToString(encoding, buffDecrypted);
        }
    }
}

//</SnippetShowSymmKeyAlgProviderClass>
