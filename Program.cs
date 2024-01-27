using MyOgreProgram.Classes;
using org.ogre;


namespace MyOgreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning=true;
            bool isFormClosing;
            MyOgreApp ogreApp;

            ogreApp = new MyOgreApp();
            ogreApp.Init();

            while(isRunning) 
            {
                isRunning = ogreApp.Update();
                Thread.Sleep(10);
            }
            ogreApp.Close();

        }
    }
}