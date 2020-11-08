using System;
namespace ClassesExample
{
    public class Car
    {
        // Option 1 (Dot notation)
        public Car()
        {
        }


        // Option 2 (Object I)
        public Car(string makeInput, string modelInput, int year)
        {
            Make = makeInput;
            Model = modelInput;
            Year = year;
        }

        // get = read   set = write

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
