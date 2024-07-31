namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //BaseClass ob=new DeriveClass();
            //ob.Charge();

            //MulInterface mulInterface = new MulInterface();
            //mulInterface.Inside();


            //AbstractDerive abstractDerive = new AbstractDerive();
            //AccessSpecifiersAndBoxingAndUnboxingAndStringAndStringBuilder second = new AccessSpecifiersAndBoxingAndUnboxingAndStringAndStringBuilder();
            //second.StringOperation();

            //LoopsAndConditionsAndExceptionHandling loops = new LoopsAndConditionsAndExceptionHandling();
            //loops.Looping();
            //Static_Constructor.PrintSc();
            //Constructor_OverLoading constructor_OverLoading = new Constructor_OverLoading();
            //Constructor_OverLoading constructor_OverLoading1 = new Constructor_OverLoading(10);
            //Constructor_OverLoading constructor_OverLoading2 = new Constructor_OverLoading("Bijay", 10);
            ImpKeyWords _impKeyWords=new ImpKeyWords();
            _impKeyWords.UseYield();

            Console.ReadKey();
        }
    }
    class BaseClass
    {
        public void Charge()
        {
            Console.WriteLine("Base Classs");
        }
    }
    class DeriveClass : BaseClass
    {
        public new void Charge()
        {
            Console.WriteLine("Derive Class");
        }
    }
}
