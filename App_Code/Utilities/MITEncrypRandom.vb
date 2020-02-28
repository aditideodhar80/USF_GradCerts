Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Namespace C21MIT.Util

    Public Class RandomKeyString

        'Generates a Random alphanumeric string

        Shared Function Generate(ByVal Key_Chars As Integer) As String
            Dim i_key As Integer
            Dim Random1 As Single
            Dim arrIndex As Int16
            Dim sb As New StringBuilder
            Dim RandomLetter As String

            Dim LettersArray As Char()
            Dim NumbersArray As Char()

            'converts LettersArray & NumberArray To Character Array
            LettersArray = "abcdefghjkmnpqrstuvwxyz".ToCharArray
            NumbersArray = "23456789".ToCharArray

            For i_key = 1 To Key_Chars

                'start the clock
                Randomize()
                Random1 = Rnd()
                arrIndex = -1

                'if the value is even then generate Letter
                'else generate a number
                'The number 117 is chosen randomly to bring the 
                'value above 0
                If (CType(Random1 * 117, Integer)) Mod 2 = 0 Then
                    'generate randome index in LettersArray
                    Do While arrIndex < 0
                        arrIndex = Convert.ToInt16(LettersArray.GetUpperBound(0) * Random1)
                    Loop
                    RandomLetter = LettersArray(arrIndex)

                    'create another randome number , if it is odd
                    'we capitalize the letter
                    If (CType(arrIndex * Random1 * 99, Integer)) Mod 2 <> 0 Then
                        RandomLetter = LettersArray(arrIndex).ToString
                        RandomLetter = RandomLetter.ToUpper
                    End If
                    sb.Append(RandomLetter)
                Else
                    'Generate a random index in the NumbersArray
                    Do While arrIndex < 0
                        arrIndex = Convert.ToInt16(NumbersArray.GetUpperBound(0) * Random1)
                    Loop
                    sb.Append(NumbersArray(arrIndex))
                End If
            Next
            Return sb.ToString
        End Function

    End Class

    Public Class PasswordHash

        Private Function CreateSalt(ByVal size As Integer) As String
            Dim rng As RNGCryptoServiceProvider = New RNGCryptoServiceProvider
            Dim buff(size) As Byte
            rng.GetBytes(buff)
            Return Convert.ToBase64String(buff)
        End Function

        Shared Function CreatePasswordHash40Bit(ByVal pwd As String) As String
            Dim saltAndPwd As String = String.Concat(pwd, "test")
            Dim hashedPwd As String = FormsAuthentication.HashPasswordForStoringInConfigFile(saltAndPwd, "sha1")
            Return hashedPwd
        End Function

    End Class

    Public Class RJEncryp

        Private Shared ReadOnly bytIV() As Byte = {119, 201, 19, 3, 172, 89, 6, 31, 205, 99, 25, 18, 44, 117, 61, 172}

        Public Shared Function EncryptString128Bit(ByVal vstrTextToBeEncrypted As String, _
            ByVal vstrEncryptionKey As String) As String

            Dim bytValue() As Byte
            Dim bytKey() As Byte
            Dim bytEncoded() As Byte
            Dim objMemoryStream As New MemoryStream()
            Dim objCryptoStream As CryptoStream
            Dim objRijndaelManaged As RijndaelManaged


            '   **********************************************************************
            '   ******  Strip any null character from string to be encrypted    ******
            '   **********************************************************************

            vstrTextToBeEncrypted = StripNullCharacters(vstrTextToBeEncrypted)

            '   **********************************************************************
            '   ******  Value must be within ASCII range (i.e., no DBCS chars)  ******
            '   **********************************************************************

            bytValue = Encoding.ASCII.GetBytes(vstrTextToBeEncrypted.ToCharArray)

            bytKey = Encoding.ASCII.GetBytes(vstrEncryptionKey.ToCharArray)

            objRijndaelManaged = New RijndaelManaged()

            '   ***********************************************************************
            '   ******  Create the encryptor and write value to it after it is   ******
            '   ******  converted into a byte array                              ******
            '   ***********************************************************************

            Try

                objCryptoStream = New CryptoStream(objMemoryStream, _
                  objRijndaelManaged.CreateEncryptor(bytKey, bytIV), _
                  CryptoStreamMode.Write)
                objCryptoStream.Write(bytValue, 0, bytValue.Length)

                objCryptoStream.FlushFinalBlock()

                bytEncoded = objMemoryStream.ToArray
                objMemoryStream.Close()
                objCryptoStream.Close()
            Catch



            End Try

            '   ***********************************************************************
            '   ******   Return encryptes value (converted from  byte Array to   ******
            '   ******   a base64 string).  Base64 is MIME encoding)             ******
            '   ***********************************************************************

            Return Convert.ToBase64String(bytEncoded)

        End Function

        Public Shared Function DecryptString128Bit(ByVal vstrStringToBeDecrypted As String, _
            ByVal vstrDecryptionKey As String) As String
            vstrStringToBeDecrypted = vstrStringToBeDecrypted.Replace(" ", "+")
            Dim bytDataToBeDecrypted() As Byte

            '   *****************************************************************
            '   ******   Convert base64 encrypted value to byte array      ******
            '   *****************************************************************

            Try

                bytDataToBeDecrypted = Convert.FromBase64String(vstrStringToBeDecrypted)

            Catch ex As FormatException
                HttpContext.Current.Response.Redirect("~/users/omessages.aspx?qModule=InvalidEDPar")
            End Try


            Dim bytTemp() As Byte
            Dim objRijndaelManaged As New RijndaelManaged()
            Dim objMemoryStream As MemoryStream
            Dim objCryptoStream As CryptoStream
            Dim bytDecryptionKey() As Byte



            '   ********************************************************************
            '   ******   Encryption Key must be 256 bits long (32 bytes)      ******
            '   ******   If it is longer than 32 bytes it will be truncated.  ******
            '   ******   If it is shorter than 32 bytes it will be padded     ******
            '   ******   with upper-case Xs.                                  ****** 
            '   ********************************************************************

            bytDecryptionKey = Encoding.ASCII.GetBytes(vstrDecryptionKey.ToCharArray)

            ReDim bytTemp(bytDataToBeDecrypted.Length)

            objMemoryStream = New MemoryStream(bytDataToBeDecrypted)

            '   ***********************************************************************
            '   ******  Create the decryptor and write value to it after it is   ******
            '   ******  converted into a byte array                              ******
            '   ***********************************************************************

            Try

                objCryptoStream = New CryptoStream(objMemoryStream, _
                   objRijndaelManaged.CreateDecryptor(bytDecryptionKey, bytIV), _
                   CryptoStreamMode.Read)

                objCryptoStream.Read(bytTemp, 0, bytTemp.Length)

                'objCryptoStream.FlushFinalBlock()
                objMemoryStream.Close()
                objCryptoStream.Close()

            Catch ex As Exception

            End Try

            '   *****************************************
            '   ******   Return decypted value     ******
            '   *****************************************

            Return StripNullCharacters(Encoding.ASCII.GetString(bytTemp))

        End Function


        Private Shared Function StripNullCharacters(ByVal vstrStringWithNulls As String) As String

            Dim intPosition As Integer
            Dim strStringWithOutNulls As String

            intPosition = 1
            strStringWithOutNulls = vstrStringWithNulls

            Do While intPosition > 0
                intPosition = InStr(intPosition, vstrStringWithNulls, vbNullChar)

                If intPosition > 0 Then
                    strStringWithOutNulls = Left$(strStringWithOutNulls, intPosition - 1) & _
                                      Right$(strStringWithOutNulls, Len(strStringWithOutNulls) - intPosition)
                End If

                If intPosition > strStringWithOutNulls.Length Then
                    Exit Do
                End If
            Loop

            Return strStringWithOutNulls

        End Function


    End Class

End Namespace
