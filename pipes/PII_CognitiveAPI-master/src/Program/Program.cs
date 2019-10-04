using System;
using System.Drawing;

namespace CognitiveCoreUCU
{
    // clase modificada, clase publica, funcion FoundFace devuelve un bool, no es void
    public class ProgramCognitiveAPI
    {
        static void Main(string[] args)
        {
            CognitiveFace cog = new CognitiveFace("a36648d3c5134ab692acd35605d491f7", false);
            cog.Recognize(@"bill.jpg");
            FoundFace(cog);
            cog.Recognize(@"bill2.jpg");
            FoundFace(cog);
            cog.Recognize(@"yacht.jpg");
            FoundFace(cog);
            
        }
        public static bool FoundFace(CognitiveFace cog)
        {
            if (cog.FaceFound)
            {
                Console.WriteLine("Face Found!");
                if (cog.SmileFound)
                {
                    Console.WriteLine("Found a Smile :)");
                }
                else
                {
                    Console.WriteLine("No smile found :(");
                }
                return true;
            }
            else
                Console.WriteLine("No Face Found");
                return false;
        }
    }
}
