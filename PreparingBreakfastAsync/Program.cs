namespace PreparingBreakfastAsync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrepareBreakfastAsync();
        }
        static void PrepareBreakfastAsync()
        {
            Console.WriteLine("Starting Breakfast...");

            Task makeTeaTask = new Task(MakeTeaAsync);
            makeTeaTask.Start();

            Task makefryEggsTask = new Task(MakeFriedEggsAsync);
            makefryEggsTask.Start();

            makeTeaTask.Wait();
            makefryEggsTask.Wait();

            Task callFamilyForBreakfastTask = new Task(CallingFamilyToBreakfast);
            callFamilyForBreakfastTask.Start();

            Task preparingTableTask = new Task(PreparingTable);
            preparingTableTask.Start();


            callFamilyForBreakfastTask.Wait();
            preparingTableTask.Wait();

        }
        static void MakeTeaAsync()
        {
            Console.WriteLine("1-Starting boiling water..!");
            Thread.Sleep(2000);
            Console.WriteLine("4-Water boiled , Tea is ready!");
        }
        static void MakeFriedEggsAsync()
        {
            Console.WriteLine("2-Craking eggs..!");
            Console.WriteLine("3-Frying eggs..!");
            Thread.Sleep(2000);
            Console.WriteLine("5-Eggs ready!");
        }
        static void CallingFamilyToBreakfast()
        {
            Console.WriteLine("6-Calling family to Kitchen: \nFather,Mother,Brother and Sister...!");
            Thread.Sleep(2000);
            Console.WriteLine("8-Everyone came,Have a good Breakfast");
        }
        static void PreparingTable()
        {
            Console.WriteLine("7-Bring the Eggs and Tea to the table");
            Thread.Sleep(1000);
        }
    }
}