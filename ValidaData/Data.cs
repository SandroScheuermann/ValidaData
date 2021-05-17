using System;

namespace Data
{
    class Data
    {
        string[] dataArray;
        string data;
        public Data(string data)
        {
            this.data = data;
            dataArray = data.Split('/');
            Validar();
        }
        public void Validar()
        {
            try
            {
                int dia = 0;
                int mes = 0;
                int ano = 0;
                bool ehBissexto = false;

                if (dataArray.Length < 3)
                    throw new Exception("Formato de data inválido!\n");
                else
                {
                    dia = Convert.ToInt32(dataArray[0]);
                    mes = Convert.ToInt32(dataArray[1]);
                    ano = Convert.ToInt32(dataArray[2]);
                }

                if (ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0))
                {
                    ehBissexto = true;
                }

                if (dia < 0 || dia > 31 || mes == 4 && dia > 32 || mes == 6 && dia > 32 || mes == 9 && dia > 32 || mes == 11 && dia > 32 || mes == 2 && dia > 29 && ehBissexto == true || mes == 2 && dia > 28 && ehBissexto == false)
                    throw new Exception("Dia Inválido\n");

                if (mes < 0 || mes > 12)
                    throw new Exception("Mês inválido\n");

                if (ano < 0)
                    throw new Exception("Ano inválido\n");

                Console.WriteLine(data + "\n");
            }
            catch (Exception dataInvalida)
            {
                Console.WriteLine(dataInvalida.Message);
            }
        }
    }
}
