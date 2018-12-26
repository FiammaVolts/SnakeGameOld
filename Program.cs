using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame {
    class Program {

        public World world;
        public Program prog = new Program();

        public void Start() {
            world.dir = "RIGHT";
            world.pre_dir = "";
            world.points = 0;
            world.nTail = 0;

            world.gameOver = false;
            world.reset = false;
            world.isPrinted = false;

            world.noseX = World.width / 2;
            world.noseY = World.height / 2;
            world.appleX = world.rnd.Next(1, World.width - 1);
            world.appleY = world.rnd.Next(1, World.height - 1);
        }

        static void Main(string[] args) {

            while(true) {
                prog.Start();
            }
        }
    }
}
