// Using the sizeof operator.
using System;

struct StructWithNoMembers
{
}

struct StructWithMembers
{
	short s;
	int i;
	long l;
	bool b;
}

struct CompositeStruct
{
	StructWithNoMembers a;
	StructWithMembers b;

	StructWithNoMembers c;
}

class Unsafe2App
{
   unsafe public static void Main() 
   {
    Console.WriteLine("\nsizeof StructWithNoMembers structure = {0}", 
                      sizeof(StructWithNoMembers));
    Console.WriteLine("\nsizeof StructWithMembers structure = {0}",
                      sizeof(StructWithMembers));
    Console.WriteLine("\nsizeof CompositeStruct structure = {0}",
                      sizeof(CompositeStruct));
   }
}
