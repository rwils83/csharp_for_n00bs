using System;
//control flow

// if else elif

var blah = true;

if (blah)
{
    Console.WriteLine("Prints because true");
}

if (!blah)
{
    Console.WriteLine("Doesn't print because false"); //! flips boolean, ie not blah == blah is not true
}

if (!blah)
{
    Console.WriteLine("Doesn't print because not ture");
}
else if (blah)
{
    Console.WriteLine("Prints because true");
}
else
{
    Console.WriteLine("Doesn't print unless no other conditions are met");
}
//case switch
//Better than multiple if else if else statements

var animal = "Dog";

var sound = animal switch
{
    "Dog" => "Woof",
    "Cat" => "Meow",
    _ => "Mute"
};
Console.WriteLine(sound);
animal = "Cat";

sound = animal switch
{
    "Dog" => "Woof",
    "Cat" => "Meow",
    _ => "Mute"
};
Console.WriteLine(sound);
animal = "Penguin";

sound = animal switch
{
    "Dog" => "Woof",
    "Cat" => "Meow",
    _ => "Mute"
};
Console.WriteLine(sound);
//enums
//var (firstName, lastName, status) = ("Charles", "Dickens", Status.Dead);

//internal enum Status
//
 // Dead,
 //   Alive
//};
//for loop

for (int i1 =0; i1 < 10; i1++)
{
    Console.WriteLine(i1);
}

var array = new[] {1, 2, 3, 4, 5};
for (var i2 = 0; i2 < array.Length; i2++)
{
    Console.WriteLine(array[i2]);
}

// while loop
var i3 = 0;
while (i3 < 10)
{
    Console.WriteLine(i3);
    i3++;
}

while (true)
{
    Console.Write("> ");
    var input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input))
    {
        continue;
    }
    else if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }
    else
    {
        Console.WriteLine("You entered: {0}", input);
    }
}