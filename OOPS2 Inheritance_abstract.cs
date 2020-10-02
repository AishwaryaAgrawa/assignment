using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Abstract_assignment
{
    class Cricket_Test
    {
        static void Main(string[] args)
        {
            int targetR;
            Console.WriteLine("Sample Input ");
            Console.Write("Enter TargetRun : ");
            targetR = Convert.ToInt32(Console.ReadLine());
            OneDayCricket onecr = new OneDayCricket(50, targetR);
            Console.Write("Enter Current Score : ");
            onecr.Currentscore = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Current Over : ");
            onecr.Currentover = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("\nSample Output ");
            double runrate= onecr.CalcurrentRunrate();
            Console.WriteLine("Current RunRate : {0}", runrate);
            double reqrunrate = onecr.CalcReqRunrate();
            Console.WriteLine("Current Required RunRate : {0}", reqrunrate);
            Console.ReadKey();
        }
    }

    abstract class Cricket
    {
        private readonly int maxovers;
        private int targetscore;
        private int currentover;
        private int currentscore;

        public int Maxovers { get => maxovers; }
        public int Targetscore { get => targetscore; }
        public int Currentover { get => currentover; set => currentover = value; }
        public int Currentscore { get => currentscore; set => currentscore = value; }

        public Cricket(int maxove,int targetsc)
        {
            maxovers = maxove;
            targetscore = targetsc;
        }
        abstract public double CalcurrentRunrate();
        abstract public double CalcReqRunrate();
    }

    class OneDayCricket : Cricket
    { 
        public OneDayCricket(int maxov,int targetsc): base(maxov, targetsc)
        {
            //this is derived class constructor to initailze the base class constructor
        }

        public override double CalcurrentRunrate()
        {
            double result = 0;
            try
            {
                result = Currentscore / Currentover;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public override double CalcReqRunrate()
        {
            double result=0;
            try
            {
                int remrun = Targetscore - Currentscore;
                int remover = Maxovers - Currentover;
                 result = remrun / remover;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }


    }
}
