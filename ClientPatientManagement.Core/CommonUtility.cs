using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientPatientManagement.Core
{
    public class CommonUtility
    {
        public static CommonUtility Instance;

        private CommonUtility()
        {
            Instance = new CommonUtility();
        }

        private void ToReas()
        {
            Console.WriteLine("Common");
        }

        protected string Write(string text)
        {
            return text.ToLower();
        }

        public string ProcessRestPostWithRequestBase64(string request, string url, Dictionary<string, string> configs, string LoggedInUserDomainName)
        {
            var resultBase64 = string.Empty;
            var ermsUser = string.Empty;
            var ermsUserPassword = string.Empty;
            var ermsUserDomain = string.Empty;

            configs.TryGetValue("ErmsApplicationUser", out ermsUser);
            configs.TryGetValue("ErmsUserPassword", out ermsUserPassword);
            configs.TryGetValue("ActiveDirectoryDomainName", out ermsUserDomain);

            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Credentials = new NetworkCredential(ermsUser, ermsUserPassword, ermsUserDomain);
            webrequest.Headers.Add(configs["ERMS_Header_TcrmUsername"],
               String.Format(@"{0}\{1}", configs["ActiveDirectoryDomainName"],
               configs["ErmsApplicationUser"]));

            webrequest.Method = "POST";
            webrequest.ContentType = "application/json";
            using (Stream webStream = webrequest.GetRequestStream())

            using (StreamWriter requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
            {
                requestWriter.Write(request);
            }

            var webResponse = (HttpWebResponse)webrequest.GetResponse();
            using (Stream webStream = webResponse.GetResponseStream())
            {
                if (webStream != null)
                {
                    byte[] m_Bytes = ReadToEnd(webStream);
                    resultBase64 = Convert.ToBase64String(m_Bytes);
                }
            }

            return resultBase64;
        }

        public static byte[] ReadToEnd(System.IO.Stream stream)
        {
            long originalPosition = 0;

            if (stream.CanSeek)
            {
                originalPosition = stream.Position;
                stream.Position = 0;
            }

            try
            {
                byte[] readBuffer = new byte[4096];

                int totalBytesRead = 0;
                int bytesRead;

                while ((bytesRead = stream.Read(readBuffer, totalBytesRead, readBuffer.Length - totalBytesRead)) > 0)
                {
                    totalBytesRead += bytesRead;

                    if (totalBytesRead == readBuffer.Length)
                    {
                        int nextByte = stream.ReadByte();
                        if (nextByte != -1)
                        {
                            byte[] temp = new byte[readBuffer.Length * 2];
                            Buffer.BlockCopy(readBuffer, 0, temp, 0, readBuffer.Length);
                            Buffer.SetByte(temp, totalBytesRead, (byte)nextByte);
                            readBuffer = temp;
                            totalBytesRead++;
                        }
                    }
                }

                byte[] buffer = readBuffer;
                if (readBuffer.Length != totalBytesRead)
                {
                    buffer = new byte[totalBytesRead];
                    Buffer.BlockCopy(readBuffer, 0, buffer, 0, totalBytesRead);
                }
                return buffer;
            }
            finally
            {
                if (stream.CanSeek)
                {
                    stream.Position = originalPosition;
                }
            }
        }
    }
}
