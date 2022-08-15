using System;

namespace licao_12_08 {
    class Program {
        static void Main(string[] args) {


            int mInicial = 0, hInicio = 0;
            Console.WriteLine("Informe hora e minuto inicial e final:");
            string[] linha = Console.ReadLine().Split(' ');
            int hora = Convert.ToInt32(linha[0]);
            int minuto = Convert.ToInt32(linha[1]);
            int hora2 = Convert.ToInt32(linha[2]);
            int minuto2 = Convert.ToInt32(linha[3]);

            if (hora == hora2 && minuto == minuto2) {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else {
                hInicio = hora2 - hora;
                mInicial = minuto2 - minuto;
            }
            if (hInicio < 0) {
                hInicio += 24;
            }
            if (mInicial < 0) {
                mInicial += 60;
                hInicio = hInicio - 1;
            }
            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", hInicio, mInicial);
        }
    }
}
