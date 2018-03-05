Rory H Millington ISTA220 Chapter 2 

1.	1. What is a local variable? 
	
	Variables that only exist only in a method or small section of code. 
 
2.	What is a statement? 
	
	A statement is a command that performs an action, such as calculating a value and storing the result or displaying a message to the user. You combine statements to create methods. 
 
3.	What is an identifier? 
	
	Are names you use to identify elements is your program, such as namespaces, classes, methods, and variables.  
 
4.	What is a variable? 
	
	A variable is a storage location that holds a value. You can think of a variable as a box in the computer’s memory that holds temporary information.  A named location in memory that contains a value. 
 
5.	What is a method? 
	
	A named sequence of statements. A named location in memory that contains a behavior.
 
6.	Are primitive types and value types the same thing? See page 177. 
	
	Most of the primitive data types built into C#, such as int, float, double, and char (but not string) are collectively called value types. These types have a fixed size, and when you declare a variable as a value type, the compiler generates code that allocates a block of memory big enough to hold a corresponding value.  
 
7.	How are arithmetic operators and variable types related? 
	
	Arithmetic operators “operate” on values to create new ones.  
 
8.	How do you turn an integer into a string? 
	
	You can use the + operator to concatenate string values. Using the two string method.
 
9.	How do you turn a string into an integer? 
	
	The .NET Framwork provides a method called Int32.Parse that you can use to convert a string value to an integer if you need to perform arithmetic computations on values held as strings. 
 
10.	What is the difference between precedence and associativity? Give an example where this makes a difference. 
	
	Precedence is the order in which an expressions order is evaluated. Associativity is the direction (left or right) in which the operands of an operator are evaluated.  When an expression contains different operators that have the same precedence.  
 
11.	What is the definite assignment rule? 

	C# does not allow you to use an unassigned variable. You must assign a value to a variable before you can use it; otherwise your program will not compile. 
 
12.	12. How are the prefix and postfix increment and decrement operators evaluated differently? 
	
	Placing the operator symbol before the variable is called prefix form of the operator and using the operator symbol after the variable is called postfix form. In the prefix increment/decrement the operator is evaluated first. In the postfix the variable is evaluated first.  
 
13.	What is string interpolation? 
	
	The $ symbol at the start of a the string indicates that it is a interpolated string and any expressions between the [ and ] characters should be evaluated and the result substituted in their place. Renders many uses of the + operator obsolete for concatenating strings.  
 
14.	What does the var keyword do? 
	
	Var allows the computer to enter inter the type of variable.

