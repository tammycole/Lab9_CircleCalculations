namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
           
                CircleApp userCommunication = new CircleApp();
                CircleApp.Welcome();

            bool run = true;
            while (run == true)
            {
                int i = 1;

                for (i = 1; ; i++)
                    {
                        double r = CircleApp.GetRadius();
                        Circle c = new Circle(r);
                        double circumference = c.GetCircumference(r);
                        string formattedC = c.GetFormattedCircumference(circumference);
                        double area = c.GetArea(r);
                        string formattedA = c.GetFormattedArea(area);
                        CircleApp.PrintStats(formattedC, formattedA);

                        run = CircleApp.Continue();
                         if (run == false)
                         {
                        break;
                         }
                }
                CircleApp.FinalCount(i);
                CircleApp.Goodbye();

            }
        }
    }
}
