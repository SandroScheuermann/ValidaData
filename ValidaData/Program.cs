using System;

namespace ValidaData
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            Data validaData;

            data = "20/02/-1";
            validaData = new Data(data);

            data = "29/30/2020";
            validaData = new Data(data);

            data = "02/02/2021";
            validaData = new Data(data);

            data = "02/02/2020";
            validaData = new Data(data);

            data = "02/2021";
            validaData = new Data(data);

            data = "";
            validaData = new Data(data);

            Console.ReadLine();
        }
    }
}
