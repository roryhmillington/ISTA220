Rory H Millington 

ISTA220 Homework Chapter 9 

March 15, 2018

1. Declare an enum for military ranks, either oﬃcer or enlisted. Name it Ranks. What are the symbols, like Private, PFD, Corporal, or 1stLt, 2ndLt, Capt?

    enum WarrantOfficer { WO1, CW2, CW3, CW4,CW5 }

2. Using the Ranks enum, assign a rank to yourself or a friend.

   WarrantOfficer  Millington = WarrantOfficer.CW3
   Console.WriteLine(Millington);

3. Determine the numeric index of particular ranks, using the Ranks enum.

    enum WarrantOfficer { WO1 = 1, CW2 = 2, CW3 = 3, CW4 = 4, CW5= 5 }

4. How do you select the type of an enum?

    Size you need to use.    

5. Are structs stored on the stack or on the heap? What about enums?
    
    Stack, Stack

6. Declare a struct named DOD with four branches.

    struct DOD
{
    string Army, Navy, AirForce , Marines;
    ...
    public DOD (int Army, int Navy, int, AirForce, int Marines)
    {
        this.Army = hh % 24;
        this.Navy = mm % 60;
        this.AirForce = ss % 60;
        this.Marines =    
    }
 public int DOD()
    {
        return this.DOD:
    }
 }


      

7. Why can’t you create a default constructor for a struct?

    The reason you can’t declare your own default constructor for a structure is that the compiler always generates one.

