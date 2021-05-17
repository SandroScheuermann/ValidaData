using System;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            Data validaData;

            data = "20/02/2020";
            validaData = new Data(data);

            data = "29/02/2020";
            validaData = new Data(data);

            data = "29/02/2021";
            validaData = new Data(data);

            data = "29/20/2021412";
            validaData = new Data(data);

            data = "02/2021";
            validaData = new Data(data);

            data = "teste";
            validaData = new Data(data);

            data = "sd/02/2021";
            validaData = new Data(data);

            data = "50/03/2021";
            validaData = new Data(data);

            Console.ReadLine();
        }
    }
}
