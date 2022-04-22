using System;

class Program {
  public static void Main (string[] args) {
    int valoradc;
    int valorsub;
    int valormult;
    int valordiv;
    int z=1;

    do{
    Console.WriteLine ("Escolha uma opcao abaixo");
    Console.WriteLine ("1-Calculadora Basica");
    Console.WriteLine ("2-Calculadora Cientifica");
    Console.WriteLine ("3-Sair");
    int opcao = int.Parse(Console.ReadLine());
    Console.Clear();
    
    switch (opcao){
      case 1: {
        Console.WriteLine ("1-Adicao");
        Console.WriteLine ("2-Subtracao");
        Console.WriteLine ("3-Multiplicacao");
        Console.WriteLine ("4-Divisao");
        int opcbasic = int.Parse(Console.ReadLine());
        Console.Clear();

        if(opcbasic==1){
        int[] matadc = new int[999];
        int y=1;
        int qntadc=0;
        
        for(int x=1;x<=y;x++){
          Console.WriteLine ("Valor {0}: ",x);
          matadc[x] = int.Parse(Console.ReadLine());
          qntadc++;
          Console.WriteLine("Adicionar mais um valor?");
          Console.WriteLine("1-Sim");
          Console.WriteLine("2-Nao");
          valoradc = int.Parse(Console.ReadLine());
          Console.Clear();

        if(valoradc==1){
        y++;
        }
        }
          
        int soma = 0;
        for(int x=1;x<=qntadc;x++){
          soma = soma+matadc[x];
        }

        Console.WriteLine ("Resultado: {0}",soma);
        }
        

        if(opcbasic==2){
        int[] matsub = new int[999];
        int y=1;
        int qntsub=0;
        
        for(int x=1;x<=y;x++){
          Console.WriteLine ("Valor {0}: ",x);
          matsub[x] = int.Parse(Console.ReadLine());
          qntsub++;
          Console.WriteLine("Adicionar mais um valor?");
          Console.WriteLine("1-Sim");
          Console.WriteLine("2-Nao");
          valorsub = int.Parse(Console.ReadLine());
          Console.Clear();

        if(valorsub==1){
        y++;
        }
        }
          
        int sub = matsub[1];
        for(int x=2;x<=qntsub;x++){
          sub = sub-matsub[x];
        }

        Console.WriteLine ("Resultado: {0}",sub);
        }

        
        if(opcbasic==3){
        int[] matmult = new int[999];
        int y=1;
        int qntmult=0;
        
        for(int x=1;x<=y;x++){
          Console.WriteLine ("Valor {0}: ",x);
          matmult[x] = int.Parse(Console.ReadLine());
          qntmult++;
          Console.WriteLine("Adicionar mais um valor?");
          Console.WriteLine("1-Sim");
          Console.WriteLine("2-Nao");
          valormult = int.Parse(Console.ReadLine());
          Console.Clear();

        if(valormult==1){
        y++;
        }
        }
          
        int mult = matmult[1];
        for(int x=2;x<=qntmult;x++){
          mult = mult*matmult[x];
        }

        Console.WriteLine ("Resultado: {0}",mult);
        }
        

        if(opcbasic==4){
        int[] matdiv = new int[999];
        int y=1;
        int qntdiv=0;
        
        for(int x=1;x<=y;x++){
          Console.WriteLine ("Valor {0}: ",x);
          matdiv[x] = int.Parse(Console.ReadLine());
          qntdiv++;
          Console.WriteLine("Adicionar mais um valor?");
          Console.WriteLine("1-Sim");
          Console.WriteLine("2-Nao");
          valordiv = int.Parse(Console.ReadLine());
          Console.Clear();

        if(valordiv==1){
        y++;
        }
        }
          
        int div = matdiv[1];
        for(int x=2;x<=qntdiv;x++){
          div = div/matdiv[x];
        }

        Console.WriteLine ("Resultado: {0}",div);
        }
        

        break;
      }
        
      case 2: {
        Console.WriteLine ("1-PI");
        Console.WriteLine ("2-Seno");
        Console.WriteLine ("3-Cosseno");
        Console.WriteLine ("4-Tangente");
        Console.WriteLine ("5-Potenciacao");
        Console.WriteLine ("6-Raiz Quadrada");
        int opcaocient = int.Parse(Console.ReadLine());
        Console.Clear();

        if(opcaocient==1){
        double pi = 3.14159265359;
        Console.WriteLine ("1-Adicao");
        Console.WriteLine ("2-Subtracao");
        Console.WriteLine ("3-Multiplicacao");
        Console.WriteLine ("4-Divisao");
        int opcpi = int.Parse(Console.ReadLine());
        Console.Clear();
          
        if(opcpi==1){
        Console.WriteLine ("Valor: ");
        double somapi = double.Parse(Console.ReadLine());
        double somapi2 = somapi+pi;
        Console.WriteLine ("Soma de {0} com PI = {1}\n",somapi,somapi2);
        }
        else if(opcpi==2){
        Console.WriteLine ("Valor: ");
        double subpi = double.Parse(Console.ReadLine());
        double subpi2 = pi-subpi;
        Console.WriteLine ("Subtracao de {0} com PI = {1}\n",subpi,subpi2);
        }
        else if(opcpi==3){
        Console.WriteLine ("Valor: ");
        double multpi = double.Parse(Console.ReadLine());
        double multpi2 = multpi*pi;
        Console.WriteLine ("Multiplicacao de {0} com PI = {1}\n",multpi,multpi2);
        }
        else if(opcpi==4){
        Console.WriteLine ("Valor: ");
        double divpi = double.Parse(Console.ReadLine());
        double divpi2 = pi/divpi;
        Console.WriteLine ("Divisao de {0} com PI = {1}\n",divpi,divpi2);
        }
        }

        if(opcaocient==2){
        Console.WriteLine ("Valor: ");
        double sen = double.Parse(Console.ReadLine());
        Console.WriteLine("Seno = {0}",Math.Sin(sen));
        }

        if(opcaocient==3){
        Console.WriteLine ("Valor: ");
        double cos = double.Parse(Console.ReadLine());
        Console.WriteLine("Cosseno = {0}",Math.Cos(cos));
        }

        if(opcaocient==4){
        Console.WriteLine ("Valor: ");
        double tan = double.Parse(Console.ReadLine());
        Console.WriteLine("Tangente = {0}",Math.Tan(tan));
        }

        if(opcaocient==5){
        Console.WriteLine ("Valor Base: ");
        double bas = double.Parse(Console.ReadLine());
        Console.WriteLine ("Valor Expoente: ");
        double expo = double.Parse(Console.ReadLine());
        Console.WriteLine("Potenciacao = {0}",Math.Pow(bas,expo));
        }

        if(opcaocient==6){
        Console.WriteLine ("Valor: ");
        double quad = double.Parse(Console.ReadLine());
        Console.WriteLine("Raiz Quadrada = {0}",Math.Sqrt(quad));
        }



        
        break;
      }

      case 3: {
        z++;
        break;
      }
      
    }

    if(z==1){
    Console.WriteLine ("\nFazer outro calculo?");
    Console.WriteLine("1-Sim");
    Console.WriteLine("2-Nao");
    int outrocalc = int.Parse(Console.ReadLine());
    Console.Clear();

    if(outrocalc==2){
    z++;
    }
    }
    
      
    }while(z==1);
  }

}