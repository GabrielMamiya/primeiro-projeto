using System;
using System.Globalization;

namespace primeiroprojeto
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int x;

            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {

                Console.WriteLine(x * x);
                x = int.Parse(Console.ReadLine());
            }



















            //         int a, b;
            //         a = int.Parse(Console.ReadLine());
            //         b = int.Parse(Console.ReadLine());

            //         //10 20   =  11 + 13 + 15 + 17 + 19

            //         //o primeiro eh menor ou igual ao segundo

            //         //1 = 9
            //         //2 = 11

            //         int soma = 0;

            //         for (int x = a; x < b; x++){

            //             if(x % 2 != 0){
            //                 soma += x;
            //             } 


            //         }

            //Console.WriteLine(soma);


            //} 







            //double arremeso1, arremeso2, arremeso3;

            //arremeso1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //arremeso2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //arremeso3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //if (arremeso1 >= arremeso2 && arremeso1 >= arremeso3)
            //{
            //    Console.WriteLine(arremeso1);
            //} else if (arremeso2 >= arremeso1 && arremeso2 >= arremeso3) 
            //{
            //    Console.WriteLine(arremeso2);
            //} else if( arremeso3 >= arremeso1 && arremeso3 >= arremeso1)
            //{
            //    Console.WriteLine(arremeso3);
            //}









            //double glicose = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //if(glicose <= 100.0){
            //    Console.WriteLine("NORMAL");
            //} else if (glicose <= 140.0){
            //    Console.WriteLine("ELEVADO");
            //} else if (glicose > 140.0) {
            //    Console.WriteLine("DIABETES");
            //}





            ////entrada 1 tamanho da foto (ex 10 15)
            ////saida 1 tamanho do retrato (ex 10 20)

            //int larguraFoto, alturaFoto, larguraRetrato, alturaRetrato;

            ////10 15
            ////10 20

            //larguraFoto = int.Parse(Console.ReadLine());
            //alturaFoto = int.Parse(Console.ReadLine());
            //larguraRetrato = int.Parse(Console.ReadLine());
            //alturaRetrato = int.Parse(Console.ReadLine());

            //if (larguraFoto <= larguraRetrato && alturaFoto <= alturaRetrato)
            //{
            //    Console.WriteLine("SIM");
            //}
            //else if (larguraFoto <= alturaRetrato && alturaFoto <= larguraRetrato){
            //    Console.WriteLine("SIM");
            //} else {
            //    Console.WriteLine("NAO");
            //}




            //// 3 notas do aluno, 1 por trimestre

            //double nota1, nota2, nota3, total;

            //nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //total = (double) nota1 + nota2 + nota3;

            //if(total < 60){
            //    Console.WriteLine(total.ToString("F2", CultureInfo.InvariantCulture));
            //    Console.WriteLine("DEPENDENCIA");
            //} else {
            //    Console.WriteLine(total.ToString("F2", CultureInfo.InvariantCulture));
            //}





            //400 ml de veneno
            //2 ml por segundo de vazao
            //30segundo de aplicacao

            //saida = sobra 340ml de veneno

            //int mlVeneno, vazao, segundosDeAplicacao, totalVenenoAplicado, totalVenenoSobra;

            //mlVeneno = int.Parse(Console.ReadLine());
            //vazao = int.Parse(Console.ReadLine());
            //segundosDeAplicacao = int.Parse(Console.ReadLine());

            //totalVenenoAplicado = vazao * segundosDeAplicacao;

            //totalVenenoSobra = (totalVenenoAplicado - mlVeneno) * -1;

            //if (totalVenenoSobra < 0)
            //{
            //    Console.WriteLine("nao eh possivel");
            //}
            //else
            //{
            //    Console.WriteLine("O total de veneno restante foi: " + totalVenenoSobra);
            //}


            //int n;
            //double x, y, resultado;

            //n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{

            //    x = double.Parse(Console.ReadLine());
            //    y = double.Parse(Console.ReadLine());

            //    if (y == 0.00)
            //    {
            //        Console.Write("Nao existe!");
            //    }
            //    else
            //    {
            //        resultado = x / y;

            //        Console.Write("Resultado: " + resultado);
            //    }

            //    Console.ReadLine();
            //}
            //int N;
            //double par1, par2, resultado;

            //N = int.Parse(Console.ReadLine());

            //for (int i = 0; i < N; i++){
            //    string[] vet = Console.ReadLine().Split(' ');


            //    par1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            //    par2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            //    if(par2 == 0.0){
            //        Console.WriteLine("nao existe");
            //    } else {
            //        resultado = (double) par1 / par2;
            //        Console.WriteLine(resultado.ToString("F2", CultureInfo.InvariantCulture));

            //    }

            //    Console.ReadLine();

            //}



            // PROGRAMA 2
            //        int idade, soma, contador;
            //        double media;

            //        soma = 0;
            //        contador = 0;

            //        idade = int.Parse(Console.ReadLine());

            //        while(idade >= 0){

            //            soma += idade;
            //            contador++;

            //idade = int.Parse(Console.ReadLine());

            //}

            //if(contador == 0){
            //    Console.WriteLine("IMPOSSIVEL CALCULAR");
            //}

            //media = (double) soma / contador;

            //Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

            //Console.ReadLine();



            //PROGRAMA 1    
            //double a, b, c, delta, x1, x2;

            //string[] vet = Console.ReadLine().Split(' ');

            //a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            //b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            //c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //delta = (b * b) - (4 * a * c);

            //if(a == 0.0 || delta < 0.0){
            //    Console.WriteLine("IMPOSSIVEL CALCULAR");
            //} else {
            //    x1 = (-b + Math.Sqrt(delta)) / 2 * a;
            //    x2 = (-b - Math.Sqrt(delta)) / 2 * a;
            //    Console.WriteLine("X1 = " + x1, CultureInfo.InvariantCulture);
            //    Console.WriteLine("X2 = " + x2, CultureInfo.InvariantCulture);

            //}

            //Console.ReadLine();



            //double x = 10.023932;
            //Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("O preco do pao esta: " + x);

            //string o;
            //int y;
            //double z;
            //char h;

            //o = Console.ReadLine();
            //y = int.Parse(Console.ReadLine());
            //z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //h = char.Parse(Console.ReadLine());

            //Console.WriteLine("String: " + o);
            //Console.WriteLine("Int: " + y );
            //Console.WriteLine("Double: " + z);
            //Console.WriteLine("Char: " + h);

            //string x;
            //int y;
            //double z;

            //string[] vet = Console.ReadLine().Split(' ');

            //x = vet[0];
            //y = int.Parse(vet[1]);
            //z = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

        }
    }
}

