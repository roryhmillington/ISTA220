Rory Millington

ISTA220

Homework ch8

1. What is the diﬀerence between deep copy and shallow copy?

    Deep copy returns an instance of the class populated with the same data(Clone method), whereas the shallow copy just copies references.   

2. What is the value of a reference after you declare and initialize it?

    

3. How do you declare a value type?

    Assign value to a block of memory

4. How do you declare a reference type?

    Assign a address to  a block of memory.

5. Does C# allow you to assign NULL to a value type?
    
      No  

6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?

    Yes to figure out its value.     

7. What is the diﬀerence between the stack and the heap?

    When you call a method, the memory required for its parameters and local variables is always acquired from the stack.
    When you create a object (an instance of a class.) by using the new keyword, the memory required to build the object is always acquired from the heap.

8. What does it mean when we say that all classes are specialized types?

    They use the System.Oject to create a variable that can refer to any reference type.

9. What does ref do?

    Passes a reference to the actual argument rather than a copy of it.

10. What does out do?

      When you want the method itself to initialize the parameter.  

11. Describe boxing and unboxing in your own words.

        The automatic coping from the stack to the heap is called boxing.
        If the cast succeeds and the complier generated code is extracted form the boxed copy. Unboxing.

12. What does cast do?

    Checks to make sure that converting an item of one type to another is safe. 
