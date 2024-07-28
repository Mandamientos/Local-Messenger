namespace Local_Messenger
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Int32 allocatedPort = 0;

            if (args.Length == 0)
            {
                Console.WriteLine("Error, ejecute dotnet run -port <puerto>");
                Environment.Exit(1);
            }
            else
            {
                int k = 0;
                foreach (string arg in args)
                {
                    if (k == 0 && arg == "-port")
                    {
                        k++;
                        continue;
                    }
                    else if (k == 1)
                    {
                        string allocatedPortStr = arg;
                        try
                        {
                            allocatedPort = int.Parse(allocatedPortStr);
                            if (49152 > allocatedPort || allocatedPort > 65535)
                            {
                                Console.WriteLine("El puerto debe estar en el rango de 49152-65535.");
                                Environment.Exit(1);
                            }
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("¡Ingrese un puerto correcto!");
                            Environment.Exit(1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error, ejecute dotnet run Program.cs -port <puerto>");
                        Environment.Exit(1);
                    }

                }
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new askPort());
        }
    }
}