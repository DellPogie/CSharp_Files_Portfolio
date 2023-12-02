namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(@"ooooo   ooooo           oooo  oooo                   oooooo   oooooo     oooo                    oooo        .o8  .o. 
`888'   `888'           `888  `888                    `888.    `888.     .8'                     `888       ""888  888 
 888     888   .ooooo.   888   888   .ooooo.           `888.   .8888.   .8'    .ooooo.  oooo d8b  888   .oooo888  888 
 888ooooo888  d88' `88b  888   888  d88' `88b           `888  .8'`888. .8'    d88' `88b `888""""8P  888  d88' `888  Y8P 
 888     888  888ooo888  888   888  888   888            `888.8'  `888.8'     888   888  888      888  888   888  `8' 
 888     888  888    .o  888   888  888   888 .o.         `888'    `888'      888   888  888      888  888   888  .o. 
o888o   o888o `Y8bod8P' o888o o888o `Y8bod8P' Y8P          `8'      `8'       `Y8bod8P' d888b    o888o `Y8bod88P"" Y8P ", Console.ForegroundColor
            = ConsoleColor.DarkCyan);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;                        
            bool b = true;
            string str = "Press Esc key to continue ...";
            do
            {
                while (!Console.KeyAvailable)
                {
                    switch(b)
                    {
                        case true: Console.WriteLine(str); break;
                        case false: Console.WriteLine(new string(' ', str.Length)); break; 
                    }
                    b = b != true;
                    Console.CursorTop = 9;
                    Thread.Sleep(200);
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}