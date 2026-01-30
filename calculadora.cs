
class Program
{
    public static void Main (string[] args)
    {
        //guarda numeros que o usuario digitar 
        //iniciar com 0 é uma boa pratica
        int numero1, numero2, resultado = 0;
        
        //guarda operaçao
        string operacao;
        
        //int.Parse converte texto para inteiro
        Console.WriteLine("Digite um número: ");
        numero1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite a operação: ");
        operacao = Console.ReadLine();

        Console.WriteLine("Digite o segundo número: ");
        numero2 = int.Parse(Console.ReadLine());

        //switch compara o valor da operaçao com cada case
        //se numero2 for 0, dá erro (DivideByZeroException)
        //default = caso o usuario digite algo diferente dos cases
        switch (operacao)
        {
            case "+":
            resultado = numero1 + numero2;
            break;

            case "-":
            resultado = numero1 - numero2;
            break;

            case "/":
            resultado = numero1 / numero2;
            break;

            case "*":
            resultado = numero1 * numero2;
            break;

            default: 
            Console.WriteLine("Operação inválida :O");
            break;
        }

        //{0} vira numero1, {1} vira operacao, etc 
        Console.WriteLine("{0} {1} {2} = {3}", numero1, operacao, numero2, resultado);
    }
}








