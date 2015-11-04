using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Networks_Lab_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().start_server(args[0]);
        }

        public void start_server(string file_name)
        {
            if (string.IsNullOrEmpty(file_name))
                return;
            IPEndPoint obj_endpoint = new IPEndPoint(IPAddress.Any, 123);
            Socket server_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server_socket.Bind(obj_endpoint);
            Console.WriteLine("Listening...");
            server_socket.Listen(0);
            Socket client_socket = server_socket.Accept();
            Console.WriteLine("Connected");
            Console.WriteLine("Sending...");
            client_socket.Send(read_file(file_name));
            Console.WriteLine("Sent");
            Console.WriteLine("Closing...");
            client_socket.Close();
            Console.WriteLine("Closed");
            Console.ReadLine();
        }

        /**
         * I used this documentation to read a file into bytes array
         * https://msdn.microsoft.com/en-us/library/system.io.filestream.read(v=vs.110).aspx
         **/
        public byte[] read_file(string file_name)
        {
            FileStream fsSource = new FileStream(file_name, FileMode.Open, FileAccess.Read);
            byte[] file_content = new byte[fsSource.Length];
            fsSource.Read(file_content, 0, (int)fsSource.Length);
            byte[] file_name_length = BitConverter.GetBytes(file_name.Length);
            byte[] file_name_bytes = Encoding.ASCII.GetBytes(file_name);
            int total_length = file_content.Length + file_name_bytes.Length + 4;
            byte[] ret = new byte[total_length];
            Array.Copy(file_name_length, ret, 4);
            Array.Copy(file_name_bytes, 0, ret, 4, file_name_bytes.Length);
            Array.Copy(file_content, 0, ret, 4 + file_name_bytes.Length, file_content.Length);
            return ret;
        }
    }
}
