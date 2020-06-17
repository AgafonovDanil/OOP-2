using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    class TV
    {
        public int channelChange = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для смены канала нажмите '+' или '-' ");

            TV newChannel = new TV();
            bool tvChannel = true;


            while (tvChannel)
            {
                string Switch = Console.ReadLine();
                if (Switch == "+")
                {
                    newChannel.channelChange++;
                }



                else if (newChannel.channelChange == 10)
                {
                    newChannel.channelChange = 0;
                }



                else if (Switch == "-" && newChannel.channelChange == 0)
                {
                    newChannel.channelChange = 10;
                }



                else if (Switch == "-")
                {
                    newChannel.channelChange--;
                }


                Console.WriteLine("Канал: " + newChannel.channelChange);
            }
            Console.ReadKey();
        }
    }
}
