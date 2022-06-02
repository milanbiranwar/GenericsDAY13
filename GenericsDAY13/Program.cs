// See https://aka.ms/new-console-template for more information
using GenericsDAY13;

Console.WriteLine("Hello, World!");

//Console.WriteLine("Find max Number");
//int output = MaximumNumber.MaximumIntegerNumber(11, 22, 33);
//Console.WriteLine(output);
//double doubleoutput = MaximumNumber.MaximumFloatNumber(111.2, 22.45, 78.56);
//Console.WriteLine(doubleoutput);
//string strigoutput = MaximumNumber.MaximumStringNumber("Apple", "Peach", "Banana");
//Console.WriteLine(strigoutput);// A-65, B-66 C-67..Z=, a=97,b=98,99..z, '0'-48, 1-49,2-50,3-51,4-52...
int[] intArray = { 112, 432, 344, 555, 678 };
GenericsMaximumNumber<int> generic = new GenericsMaximumNumber<int>(intArray);
generic.PrintMaxValue();
double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
GenericsMaximumNumber<double> genericDouble = new GenericsMaximumNumber<double>(doubleArray);
genericDouble.PrintMaxValue();
string[] stringArray = { "111", "222", "333", "55", "999" };
GenericsMaximumNumber<string> genericString = new GenericsMaximumNumber<string>(stringArray);
//GenericMaximum<Employee> genericString = new GenericMaximum<string>(stringArray);
Console.ReadKey();
