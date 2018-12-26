using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Draw
    {
        // cobra aparece e come nome snake
        public void Titulo()
        {

            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                 SNAKE                                                           |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            Console.ReadKey();
        }


        // cobra come o que o jogador escolher
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                 SNAKE                                                           |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                               START GAME                                                        |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                               MAX PONTOS                                                        |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                CREDITS                                                          |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.ReadKey();
        }

        public void Game()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                   ");
            Console.WriteLine("                                                                                                                   ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                      PONTOS: 00              NIVEL:00           LIFE:  <3  <3  <3                               |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                                                                                                   ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.ReadKey();
        }

        // cobra anda para cima e baixo?
        public void Credits()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                                    CREDITS                                                      |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                         INÊS GONÇALVES  nº 21702076                                             |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                             INÊS NUNES  nº 21702520                                             |");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("|                                              SARA GAMA  nº 21705494                                             |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}

