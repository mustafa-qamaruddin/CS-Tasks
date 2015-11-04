using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Networks_Lab_Client
{
    class File_Info
    {
        public int file_name_length;
        public string file_name;
        public int file_content_length;
        public int total_content_length;
        public byte[] content;
        public string content_string;
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Program().start_client();
        }

        public void start_client()
        {
            try
            {
                IPAddress obj_ip_address = IPAddress.Parse("127.0.0.1");
                IPEndPoint obj_ip_endpoint = new IPEndPoint(obj_ip_address, 123);
                Socket client_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Console.WriteLine("Connecting...");
                client_socket.Connect(obj_ip_endpoint);
                Console.WriteLine("Connected");
                byte[] file_bytes = new byte[1024];
                int len = client_socket.Receive(file_bytes);
                File_Info obj_file_info = read_file(file_bytes, len);
                display_info(obj_file_info);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

        public File_Info read_file(byte[] raw_data, int length_data)
        {
            File_Info ret = new File_Info();
            ret.total_content_length = length_data;

            // read file name length
            byte[] file_name_length = new byte[4];
            Array.Copy(raw_data, 0, file_name_length, 0, 4);
            ret.file_name_length = BitConverter.ToInt32(file_name_length, 0);
            
            // read file name
            byte[] file_name_bytes = new byte[ret.file_name_length];
            Array.Copy(raw_data, 4, file_name_bytes, 0, ret.file_name_length);
            ret.file_name = Encoding.ASCII.GetString(file_name_bytes);
            
            // read file content
            ret.file_content_length = ret.total_content_length - 4 - ret.file_name_length;
            ret.content = new byte[ret.file_content_length];
            Array.Copy(raw_data, 4 + ret.file_name_length, ret.content, 0, ret.file_content_length);
            ret.content_string = Encoding.ASCII.GetString(ret.content, 0, ret.file_content_length);
            return ret;
        }

        public void display_info(File_Info _file_info)
        {
            Console.WriteLine(String.Format("Total Data Received: {0} Bytes", _file_info.total_content_length));
            Console.WriteLine(String.Format("File Name: {0}", _file_info.file_name));
            Console.WriteLine(String.Format("File Content: {0}", _file_info.content_string));
        }
    }
}
