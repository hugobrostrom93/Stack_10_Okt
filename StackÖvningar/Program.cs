namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack <string> todo = new Stack<string>();
            todo.Push("Köpa mjölk");
            todo.Push("Köpa bröd");
            todo.Push("Köpa ägg");
            PrintStack(todo);

            string text = TextEditor();
            Console.Clear();
            Console.WriteLine("Du skrev:");
            Console.WriteLine(text);
        }

        public static void PrintStack(Stack<string> shoppingList)
        {
            Console.WriteLine("~ Shoppinglista ~");
            foreach (string item in shoppingList)
            {
                Console.WriteLine(item);
            }
        }

        public static string TextEditor()
        {
            // Deklarera variabler
            string text = "";
            Stack<string> undo = new();
            // Bearbeta
            while (true)
            {
                // Skriv ut texten
                Console.Clear();
                Console.WriteLine("--- Sunkig Texteditor med Undo funktion ---");
                Console.WriteLine("undo = ångra senaste raden\t\tend = avsluta");
                Console.WriteLine();
                Console.WriteLine(text);
                Console.WriteLine();
                // vänta på inmatning
                string input = Console.ReadLine();

                if (input == "undo")
                {
                    if (undo.Count > 0) text = undo.Pop();

                } 
                else if (input == "end")
                {
                    break;
                } 
                else
                {
                    undo.Push(text);
                    text += input + Environment.NewLine;
                }
                // om inmatning är ”undo” ångra senaste inmatning (pop)
                // om inmatning är ”end” hoppa ut ur loopen
                // annars spara texten (push)
            }
            return text;
        }


    }
}