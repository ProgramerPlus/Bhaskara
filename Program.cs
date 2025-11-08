/* string senhaDigitada;
string senhaCorreta = "123abc";

Console.WriteLine("Digite sua senha...:");
senhaDigitada = Console.ReadLine()!;

bool acertou = senhaDigitada == senhaCorreta;

if(acertou){
Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine("Senha correta!!!");
} 
else
{
Console.ForegroundColor=ConsoleColor.Red;
Console.WriteLine("Errou!!!");
}

Console.ResetColor(); */



Console.Clear();
double a, b ,c, delta,x1, x2, raiz;

Console.WriteLine("Digite o valor de a:");
a=Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Digite o valor de b:");
b=Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Digite o valor de c:");
c=Convert.ToInt32(Console.ReadLine()!);

delta = Math.Pow(b,2) - 4 * a * c;
if(delta<0){
Console.WriteLine("Raíz quadrada negativa!");
}

else if(delta==0){

Console.WriteLine("Impossível operar o zero! Digite outro número!");

}
else{
     raiz=Math.Sqrt(delta);
x1 = -b + raiz/(2 * a);
x2 = -b - raiz/(2 * a);

Console.WriteLine($"Resultado positivo:{x1}.\nResultado negativo:{x2}.\nDelta:{delta:N2}");
}