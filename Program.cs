namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> meses = new LinkedList<string>();
            meses.AddLast("Março");
            meses.AddFirst("Janeiro");

            var marco = meses.Find("Março");

            meses.AddBefore(marco, "Fevereiro");
            meses.AddAfter(marco, "Abril");

            var node = new LinkedListNode<string>("Maio");
            meses.AddLast(node);

            meses.Remove("Março"); //Encontra e remove o item
            meses.Remove(node);  //Remove o node especifico
            meses.RemoveFirst(); //Remove o primeiro item da lista
            meses.RemoveLast(); //Remove o ultimo item da lista


            foreach (var mes in meses)
            {
                Console.WriteLine(mes);
            }
            Console.ReadLine();
        }
    }
}