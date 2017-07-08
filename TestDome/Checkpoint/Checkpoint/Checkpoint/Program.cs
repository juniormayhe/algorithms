using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckpointApp
{
    class Checkpoint
    {
        public Queue<string> Passaports { get; set; }

        public Checkpoint()
        {
            this.Passaports = new Queue<string>();
        }

        public void Enter(string passportNumber)
        {
            this.Passaports.Enqueue(passportNumber);
        }

        public string Exit()
        {
            if (this.Passaports.Count()==0)
                return null;
            return this.Passaports.Dequeue();
        }

        public static void Main(string[] args)
        {
            Checkpoint checkpoint = new Checkpoint();
            checkpoint.Enter("AB54321");
            checkpoint.Enter("UK32032");
            
            Console.WriteLine(checkpoint.Exit());
            Console.WriteLine(checkpoint.Exit());
            Console.WriteLine(checkpoint.Exit());
            Console.ReadLine();
        }


    }

}
