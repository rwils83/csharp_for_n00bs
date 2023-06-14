//explicit typing
int explicitInt = 1;

// implicit typing
var implicitInt = 1;

// when var can and cant be used

//ok
int emptyInt;
//not ok
//var emptyInt; //uncomment to break code, can not implicit type empty variable 

//mutable var
var mutableVar = "blah";

//immutable var: MUST BE EXPLICITLY TYPED
const string immutableVar = "not blah";


// implicit cast

var i = 20;
double d = i;

//invalid cast
double d1 = 3.14D;
// int i1 = d1; //uncomment to break the code due to invalid cast
//explicit cast
double d2 = 3.14D;
int i2 = (int)d2;

Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", explicitInt, implicitInt, i, d, d1, d2, i2);