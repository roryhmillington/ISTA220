Rory H Millington ISTA220 Homework Chapter 6


1.	What is an exception?
        An exception separates the error handling code from the code that implements the primary logic of a program by using 
        exceptions and exception handlers.

2.	What happens in a try block if the program executes without errors?

        They run one after another until completion.

3.	How does the catch mechanism work for unhandled exceptions?

        Execution continues in the method containing the catch block that caught the exception. If the exception occurred in a method other than the one containing the catch                handler,  control does not return to the method that caused the exception. 

4.	What happens in a program if an exception block fails to handle an particular error?

        The program terminates with a unhandled exception.

5.	What is the parent class for all exceptions? How does this work?

        Exceptions are organized into families called inheritance hierarchies. all fall into the family simply called exceptions. 

6.	How do you determine the type of an error?

        Expand the InnerException property in the View Detail dialog box.

7.	What is the purpose of integer checking?

        To prevent overflow and get the wrong answer. 

8.	What does the finally block do?

        To make sure all statements are run regardless if and exception is thrown or not. 
