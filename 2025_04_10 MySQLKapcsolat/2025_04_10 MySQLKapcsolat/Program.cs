namespace _2025_04_10_MySQLKapcsolat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBaseConnection connection = new DataBaseConnection();
            //Console.WriteLine(connection.ConnOpen());
            //Console.WriteLine(connection.ConnClose());

            List<string> st = connection.TableNames();
            if (st == null)
            {
                Console.WriteLine("Probléma az adatok elérésével!");
            }
            else
            {
                //foreach (var name in st)
                //{
                //    Console.WriteLine(name);
                //}

                //connection.TableNames()
                //    .ForEach(c => Console.WriteLine(c));

                connection.TableNames()
                    .ForEach(Console.WriteLine);
            }

            List<List<string>> tablaAdatok = connection.TablaAdatai("termekek");
            foreach (var rekord in tablaAdatok)
            {
                rekord.ForEach(c => Console.Write(c+" "));
                Console.WriteLine();
            }
            

        }
    }
}
