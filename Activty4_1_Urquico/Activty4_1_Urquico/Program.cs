using System;

namespace Activity4_1_Urquico
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string seperator = "+-------------------------------------------------------------------------------------------+";
            string name;
            string header = @"                                       
                     _____   _  _     _____                       
                    /  __ \_| || |_  |_   _|                      
                    | /  \/_  __  _|   | | ___ _ __ _ __ ___  ___ 
                    | |    _| || |_    | |/ _ \ '__| '_ ` _ \/ __|
                    | \__/\_  __  _|   | |  __/ |  | | | | | \__ \
                     \____/ |_||_|     \_/\___|_|  |_| |_| |_|___/
                                                                                                  
                                                    ";
            string[] ALesson = new string[] {

                "\nA.Basic Concepts of C#",
                "\n\tA1. What is C#?",
                "\tA2. Variables",
                "\tA3. Printing Text",
                "\tA4. Getting User Input",
                "\tA5. Adding Comments",
                "\tA6. The Var Keyword",
                "\tA7. Constants",
                "\tA8. Arithmetic Operators",
                "\tA9. Assignment and Increment Operators"

            };

            string[] BLesson = new string[] {

                    "\nB. Conditionals and Loops",
                    "\n\tB1. Logical Operators",
                    "\tB2. The Conditional Operators",
                    "\tB3. The if-else Statement",
                    "\tB4. The switch Statement",
                    "\tB5. The while Loop",
                    "\tB6. The for Loop",
                    "\tB7. The do-while Loop",
                    "\tB8. Break and Continue",
                    "\tPress Q to exit"

            };

            string topicAns,quitMenu;

            //header
            Console.WriteLine(seperator);
            Console.WriteLine(header);
            Console.WriteLine(seperator);

            //date and time
            Console.WriteLine("\nToday is " + DateTime.Now);
            Console.WriteLine("\tPlease enter any key to continue");
            Console.ReadKey();

            //input name
            Console.Clear();
            Console.WriteLine(seperator);
            Console.Write("Name: ");
            //Console.WriteLine("\n" + seperator);
            name = Console.ReadLine();



            Console.Clear();
            Console.WriteLine("\n\n\n\t\tHello " + name);
            Console.WriteLine("\n" + seperator);
            Console.WriteLine("C# Topics");

            for (int x = 0; x < ALesson.Length; x++)
            {
                Console.WriteLine(ALesson[x]);
            }

            for (int x = 0; x < BLesson.Length; x++)
            {
                Console.WriteLine(BLesson[x]);
            }

            Console.Write("\nPlease choose a topic: ");
            topicAns = Console.ReadLine();

            while (true)
            {
                if (topicAns == "")
                {
                    Console.Clear();

                    Console.WriteLine("C# Topics");

                    for (int x = 0; x < ALesson.Length; x++)
                    {
                        Console.WriteLine(ALesson[x]);
                    }

                    for (int x = 0; x < BLesson.Length; x++)
                    {
                        Console.WriteLine(BLesson[x]);
                    }

                    Console.Write("\nPlease choose a topic: ");
                    topicAns = Console.ReadLine();

                }
                else if (topicAns == "A1" || topicAns == "a1")
                {

                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("C# is a general object-oriented programming (OOP) language for networking and Web development. \nC# is specified as a common language infrastructure (CLI) language.");
                    Console.WriteLine(seperator);

                    break;
                }
                else if (topicAns == "Q" || topicAns == "q")
                {
                    Environment.Exit(0);

                }
                else if (topicAns == "A2" || topicAns == "a2")
                {
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("A variable is nothing but a name given to a storage area that our programs can manipulate." +
                        "\nEach variable in C# has a specific type, which determines the size and layout of the variable's" +
                        "\nmemory the range of values that can be stored within that memory and the set of operations \nthat can be applied to the variable.");
                    Console.WriteLine(seperator);

                    break;
                }
                else if (topicAns == "A3" || topicAns == "a3")
                {
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("The most common meaning of print in this part of the internet is to print or display text to \nthe console or command window.");

                    Console.WriteLine("\n\tSyntax : Console.WriteLine(\"Text here\");");
                    Console.WriteLine(seperator);

                    break;
                }
                else if (topicAns == "A4" || topicAns == "a4")
                {
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("Getting User Input is a way for the software to gather the user's information.");

                    Console.WriteLine("\n\tSyntax : somevariablenamehere = Console.ReadLine();");
                    Console.WriteLine(seperator);

                    break;
                }
                else if (topicAns == "A5" || topicAns == "a5")
                {
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("Comments can be used to document what the program does and what specific blocks" +
                        "\nor lines of code do. Since the C# compiler ignores comments, you can include them" +
                        "\nanywhere in a program without affecting your code. ");

                    Console.WriteLine("\n\tSyntax : //there are 2 ways to do a comment, first is using backslash\n and /*the other one is using asterisk and slash*/ ");
                    Console.WriteLine(seperator);

                    break;
                }
                else if (topicAns == "A6" || topicAns == "a6")
                {
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("var can only be used when a local variable is declared and initialized in the same\n" +
                        "statement; the variable cannot be initialized to null, or to a method group or an anonymous\n" +
                        "function. var cannot be used on fields at class scope. Variables declared by using var cannot \n" +
                        "be used in the initialization expression.");

                    Console.WriteLine("\n\tSyntax : var somevariablenamehere = \"value\" ");

                    Console.WriteLine(seperator);

                    break;
                }
                else if (topicAns == "A7" || topicAns == "a7")
                {
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("Constants are immutable values which are known at compile time and do not change \n" +
                        "for the life of the program. Constants are declared with the const modifier.");

                    Console.WriteLine("\n\tSyntax : const double pi = 3.14; ");

                    Console.WriteLine(seperator);

                    break;
                }
                else if (topicAns == "A8" || topicAns == "a8")
                {
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("In C#, an operator is a program element that is applied to one or more operands in\n" +
                        " an expression or statement. ... Operators that take two operands, such as arithmetic \n" +
                        "operators ( + , - , * , / ), are referred to as binary operators.");

                    Console.WriteLine("\n\tSyntax : int num = 123 + 321;");


                    Console.WriteLine(seperator);

                    break;
                }
                else if (topicAns == "A9" || topicAns == "a9")
                {
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("The increment operator, in C#, is a unary operator represented by the symbols ++. \n" +
                        "This operator is used in C# to increment the value of its operand by one. ... The operand \n" +
                        "in an increment operation can be a variable, a property access or an indexer access.");

                    Console.WriteLine("\n\tSyntax : int num = 5;\n" +
                        "\t\tint inc = num++;" + "the value will now become 6");
                    Console.WriteLine(seperator);

                    break;
                }
                else if (topicAns == "B1" || topicAns == "b1")
                {
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("In c#, Logical Operators are used to perform the logical operation between two operands\n" +
                        " like AND, OR and NOT based on our requirements. The Logical Operators will always work with\n" +
                        " Boolean expressions (true or false) and return Boolean values.");

                    Console.WriteLine("\n\tSyntax : 5 == 5;");
                    Console.WriteLine(seperator);

                    break;
                }
                else if (topicAns == "B2" || topicAns == "b2")
                {
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("In c#, Conditional Operators are used to perform the conditional operation between two operands \n" +
                        "like AND, OR and NOT based on our requirements. The Logical Operators will always work with \n" +
                        "Boolean expressions (true or false) and return Boolean values. ... It returns true if any one \n" +
                        "operand become a non zero.");


                    Console.WriteLine(seperator);

                    break;
                }
                else if (topicAns == "B3" || topicAns == "b3")
                {
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("An if statement identifies which statement to run based on the value of a Boolean expression.\n" +
                        " ... If condition is false, the else-statement runs. Because condition can't be simultaneously \n" +
                        "true and false, the then-statement and the else-statement of an if-else statement can never both run.");
                    Console.WriteLine(seperator);
                    Console.WriteLine("\n\tSyntax : if(x == 5){" +
                        "//execute a block of code" +
                        "}else{" +
                        "//executes a false statement" +
                        "}");

                    break;
                }
                else if (topicAns == "B4" || topicAns == "b4")
                {
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("C# - Switch Statement. Advertisements. A switch statement allows a variable to be tested \n" +
                        "for equality against a list of values. Each value is called a case, and the variable\n being switched" +
                        "on is checked for each switch case.");

                    Console.WriteLine("\n\tSyntax : switch(nameofvariable){\ncase 1: \nexecutes a block of code\n}");

                    Console.WriteLine(seperator);

                    break;
                }
                else if (topicAns == "B5" || topicAns == "b5")
                {
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("C# - while loop: C# includes the while loop to execute a block of code repeatedly. \n" +
                        "As per the while loop syntax, the while loop includes a boolean expression as a condition which \n" +
                        "will return true or false. It executes the code block, as long as the specified \nconditional expression returns true.");

                    Console.WriteLine("\n Syntax : while(true){executes a block of code}");
                    Console.WriteLine(seperator);

                    break;
                }
                else if (topicAns == "B6" || topicAns == "b6")
                {
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("C# - for loop. The for keyword indicates a loop in C#. The for loop executes a \n" +
                        "block of statements repeatedly until the specified condition returns false.");
                    Console.WriteLine("\n\t Syntax : for(declaration;boundary;assignment){executes a block of code}");
                    Console.WriteLine(seperator);

                    break;
                }
                else if (topicAns == "B7" || topicAns == "b7")
                {
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("C# - do while. The do-while loop is the same as a 'while' loop except that the \n" +
                        "block of code will be executed at least once, because it first executes the block \n" +
                        "of code and then it checks the condition.");

                    Console.WriteLine("\n\t Syntax : do{executes a block of code}while(this condition is not true);");
                    Console.WriteLine(seperator);

                    break;
                }
                else if (topicAns == "B8" || topicAns == "b8")
                {
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("The continue statement in C# works somewhat like the break statement. \n" +
                        "Instead of forcing termination, however, continue forces the next iteration \n" +
                        "of the loop to take place, skipping any code in between. ... For the while \n" +
                        "and do...while loops, continue statement causes the program control passes \n" +
                        "to the conditional tests.");

                    Console.WriteLine("\n\t Syntax : continue;\n" +
                        "\t\tbreak;");
                    Console.WriteLine(seperator);

                    break;
                }
                else if (topicAns == "A" || topicAns == "a")
                {
                    Console.Clear();

                    Console.WriteLine("C# Topics");

                    for (int x = 0; x < ALesson.Length; x++)
                    {
                        Console.WriteLine(ALesson[x]);
                    }

                    for (int x = 0; x < BLesson.Length; x++)
                    {
                        Console.WriteLine(BLesson[x]);
                    }

                    Console.Write("\nPlease choose a Lesson: ");
                    topicAns = Console.ReadLine();
                }
                else if (topicAns == "B" || topicAns == "b")
                {
                    Console.Clear();

                    Console.WriteLine("C# Topics");

                    for (int x = 0; x < ALesson.Length; x++)
                    {
                        Console.WriteLine(ALesson[x]);
                    }

                    for (int x = 0; x < BLesson.Length; x++)
                    {
                        Console.WriteLine(BLesson[x]);
                    }

                    Console.Write("\nPlease choose a Lesson: ");
                    topicAns = Console.ReadLine();
                }
                else if (topicAns != "")
                {
                    Console.Clear();

                    Console.WriteLine("C# Topics");

                    for (int x = 0; x < ALesson.Length; x++)
                    {
                        Console.WriteLine(ALesson[x]);
                    }

                    for (int x = 0; x < BLesson.Length; x++)
                    {
                        Console.WriteLine(BLesson[x]);
                    }

                    Console.Write("\nPlease choose a Lesson: ");
                    topicAns = Console.ReadLine();
                }
            }


            Console.WriteLine("Want to know more about C#? press M to go back to the menu, E to Exit...");
            quitMenu = Console.ReadLine();

            


            while (true) {

                if (quitMenu == "M" || quitMenu == "m")
                {
                    Console.WriteLine("C# Topics");

                    for (int x = 0; x < ALesson.Length; x++)
                    {
                        Console.WriteLine(ALesson[x]);
                    }

                    for (int x = 0; x < BLesson.Length; x++)
                    {
                        Console.WriteLine(BLesson[x]);
                    }

                    Console.Write("\nPlease choose a topic: ");
                    topicAns = Console.ReadLine();

                    while (true)
                    {
                        if (topicAns == "")
                        {
                            Console.Clear();

                            Console.WriteLine("C# Topics");

                            for (int x = 0; x < ALesson.Length; x++)
                            {
                                Console.WriteLine(ALesson[x]);
                            }

                            for (int x = 0; x < BLesson.Length; x++)
                            {
                                Console.WriteLine(BLesson[x]);
                            }

                            Console.Write("\nPlease choose a topic: ");
                            topicAns = Console.ReadLine();

                        }
                        else if (topicAns == "A1" || topicAns == "a1")
                        {

                            Console.Clear();
                            Console.WriteLine(seperator);
                            Console.WriteLine("C# is a general object-oriented programming (OOP) language for networking and Web development. \nC# is specified as a common language infrastructure (CLI) language.");
                            Console.WriteLine(seperator);

                            break;
                        }
                        else if (topicAns == "Q" || topicAns == "q")
                        {
                            Environment.Exit(0);

                        }
                        else if (topicAns == "A2" || topicAns == "a2")
                        {
                            Console.Clear();
                            Console.WriteLine(seperator);
                            Console.WriteLine("A variable is nothing but a name given to a storage area that our programs can manipulate." +
                                "\nEach variable in C# has a specific type, which determines the size and layout of the variable's" +
                                "\nmemory the range of values that can be stored within that memory and the set of operations \nthat can be applied to the variable.");
                            Console.WriteLine(seperator);

                            break;
                        }
                        else if (topicAns == "A3" || topicAns == "a3")
                        {
                            Console.Clear();
                            Console.WriteLine(seperator);
                            Console.WriteLine("The most common meaning of print in this part of the internet is to print or display text to \nthe console or command window.");

                            Console.WriteLine("\n\tSyntax : Console.WriteLine(\"Text here\");");
                            Console.WriteLine(seperator);

                            break;
                        }
                        else if (topicAns == "A4" || topicAns == "a4")
                        {
                            Console.Clear();
                            Console.WriteLine(seperator);
                            Console.WriteLine("Getting User Input is a way for the software to gather the user's information.");

                            Console.WriteLine("\n\tSyntax : somevariablenamehere = Console.ReadLine();");
                            Console.WriteLine(seperator);

                            break;
                        }
                        else if (topicAns == "A5" || topicAns == "a5")
                        {
                            Console.Clear();
                            Console.WriteLine(seperator);
                            Console.WriteLine("Comments can be used to document what the program does and what specific blocks" +
                                "\nor lines of code do. Since the C# compiler ignores comments, you can include them" +
                                "\nanywhere in a program without affecting your code. ");

                            Console.WriteLine("\n\tSyntax : //there are 2 ways to do a comment, first is using backslash\n and /*the other one is using asterisk and slash*/ ");
                            Console.WriteLine(seperator);

                            break;
                        }
                        else if (topicAns == "A6" || topicAns == "a6")
                        {
                            Console.Clear();
                            Console.WriteLine(seperator);
                            Console.WriteLine("var can only be used when a local variable is declared and initialized in the same\n" +
                                "statement; the variable cannot be initialized to null, or to a method group or an anonymous\n" +
                                "function. var cannot be used on fields at class scope. Variables declared by using var cannot \n" +
                                "be used in the initialization expression.");

                            Console.WriteLine("\n\tSyntax : var somevariablenamehere = \"value\" ");

                            Console.WriteLine(seperator);

                            break;
                        }
                        else if (topicAns == "A7" || topicAns == "a7")
                        {
                            Console.Clear();
                            Console.WriteLine(seperator);
                            Console.WriteLine("Constants are immutable values which are known at compile time and do not change \n" +
                                "for the life of the program. Constants are declared with the const modifier.");

                            Console.WriteLine("\n\tSyntax : const double pi = 3.14; ");

                            Console.WriteLine(seperator);

                            break;
                        }
                        else if (topicAns == "A8" || topicAns == "a8")
                        {
                            Console.Clear();
                            Console.WriteLine(seperator);
                            Console.WriteLine("In C#, an operator is a program element that is applied to one or more operands in\n" +
                                " an expression or statement. ... Operators that take two operands, such as arithmetic \n" +
                                "operators ( + , - , * , / ), are referred to as binary operators.");

                            Console.WriteLine("\n\tSyntax : int num = 123 + 321;");


                            Console.WriteLine(seperator);

                            break;
                        }
                        else if (topicAns == "A9" || topicAns == "a9")
                        {
                            Console.Clear();
                            Console.WriteLine(seperator);
                            Console.WriteLine("The increment operator, in C#, is a unary operator represented by the symbols ++. \n" +
                                "This operator is used in C# to increment the value of its operand by one. ... The operand \n" +
                                "in an increment operation can be a variable, a property access or an indexer access.");

                            Console.WriteLine("\n\tSyntax : int num = 5;\n" +
                                "\t\tint inc = num++;" + "the value will now become 6");
                            Console.WriteLine(seperator);

                            break;
                        }
                        else if (topicAns == "B1" || topicAns == "b1")
                        {
                            Console.Clear();
                            Console.WriteLine(seperator);
                            Console.WriteLine("In c#, Logical Operators are used to perform the logical operation between two operands\n" +
                                " like AND, OR and NOT based on our requirements. The Logical Operators will always work with\n" +
                                " Boolean expressions (true or false) and return Boolean values.");

                            Console.WriteLine("\n\tSyntax : 5 == 5;");
                            Console.WriteLine(seperator);

                            break;
                        }
                        else if (topicAns == "B2" || topicAns == "b2")
                        {
                            Console.Clear();
                            Console.WriteLine(seperator);
                            Console.WriteLine("In c#, Conditional Operators are used to perform the conditional operation between two operands \n" +
                                "like AND, OR and NOT based on our requirements. The Logical Operators will always work with \n" +
                                "Boolean expressions (true or false) and return Boolean values. ... It returns true if any one \n" +
                                "operand become a non zero.");


                            Console.WriteLine(seperator);

                            break;
                        }
                        else if (topicAns == "B3" || topicAns == "b3")
                        {
                            Console.Clear();
                            Console.WriteLine(seperator);
                            Console.WriteLine("An if statement identifies which statement to run based on the value of a Boolean expression.\n" +
                                " ... If condition is false, the else-statement runs. Because condition can't be simultaneously \n" +
                                "true and false, the then-statement and the else-statement of an if-else statement can never both run.");
                            Console.WriteLine(seperator);
                            Console.WriteLine("\n\tSyntax : if(x == 5){" +
                                "//execute a block of code" +
                                "}else{" +
                                "//executes a false statement" +
                                "}");

                            break;
                        }
                        else if (topicAns == "B4" || topicAns == "b4")
                        {
                            Console.Clear();
                            Console.WriteLine(seperator);
                            Console.WriteLine("C# - Switch Statement. Advertisements. A switch statement allows a variable to be tested \n" +
                                "for equality against a list of values. Each value is called a case, and the variable\n being switched" +
                                "on is checked for each switch case.");

                            Console.WriteLine("\n\tSyntax : switch(nameofvariable){\ncase 1: \nexecutes a block of code\n}");

                            Console.WriteLine(seperator);

                            break;
                        }
                        else if (topicAns == "B5" || topicAns == "b5")
                        {
                            Console.Clear();
                            Console.WriteLine(seperator);
                            Console.WriteLine("C# - while loop: C# includes the while loop to execute a block of code repeatedly. \n" +
                                "As per the while loop syntax, the while loop includes a boolean expression as a condition which \n" +
                                "will return true or false. It executes the code block, as long as the specified \nconditional expression returns true.");

                            Console.WriteLine("\n Syntax : while(true){executes a block of code}");
                            Console.WriteLine(seperator);

                            break;
                        }
                        else if (topicAns == "B6" || topicAns == "b6")
                        {
                            Console.Clear();
                            Console.WriteLine(seperator);
                            Console.WriteLine("C# - for loop. The for keyword indicates a loop in C#. The for loop executes a \n" +
                                "block of statements repeatedly until the specified condition returns false.");
                            Console.WriteLine("\n\t Syntax : for(declaration;boundary;assignment){executes a block of code}");
                            Console.WriteLine(seperator);

                            break;
                        }
                        else if (topicAns == "B7" || topicAns == "b7")
                        {
                            Console.Clear();
                            Console.WriteLine(seperator);
                            Console.WriteLine("C# - do while. The do-while loop is the same as a 'while' loop except that the \n" +
                                "block of code will be executed at least once, because it first executes the block \n" +
                                "of code and then it checks the condition.");

                            Console.WriteLine("\n\t Syntax : do{executes a block of code}while(this condition is not true);");
                            Console.WriteLine(seperator);

                            break;
                        }
                        else if (topicAns == "B8" || topicAns == "b8")
                        {
                            Console.Clear();
                            Console.WriteLine(seperator);
                            Console.WriteLine("The continue statement in C# works somewhat like the break statement. \n" +
                                "Instead of forcing termination, however, continue forces the next iteration \n" +
                                "of the loop to take place, skipping any code in between. ... For the while \n" +
                                "and do...while loops, continue statement causes the program control passes \n" +
                                "to the conditional tests.");

                            Console.WriteLine("\n\t Syntax : continue;\n" +
                                "\t\tbreak;");
                            Console.WriteLine(seperator);

                            break;
                        }
                        else if (topicAns == "A" || topicAns == "a")
                        {
                            Console.Clear();

                            Console.WriteLine("C# Topics");

                            for (int x = 0; x < ALesson.Length; x++)
                            {
                                Console.WriteLine(ALesson[x]);
                            }

                            for (int x = 0; x < BLesson.Length; x++)
                            {
                                Console.WriteLine(BLesson[x]);
                            }

                            Console.Write("\nPlease choose a Lesson: ");
                            topicAns = Console.ReadLine();
                        }
                        else if (topicAns == "B" || topicAns == "b")
                        {
                            Console.Clear();

                            Console.WriteLine("C# Topics");

                            for (int x = 0; x < ALesson.Length; x++)
                            {
                                Console.WriteLine(ALesson[x]);
                            }

                            for (int x = 0; x < BLesson.Length; x++)
                            {
                                Console.WriteLine(BLesson[x]);
                            }

                            Console.Write("\nPlease choose a Lesson: ");
                            topicAns = Console.ReadLine();
                        }
                        else if (topicAns != "")
                        {
                            Console.Clear();

                            Console.WriteLine("C# Topics");

                            for (int x = 0; x < ALesson.Length; x++)
                            {
                                Console.WriteLine(ALesson[x]);
                            }

                            for (int x = 0; x < BLesson.Length; x++)
                            {
                                Console.WriteLine(BLesson[x]);
                            }

                            Console.Write("\nPlease choose a Lesson: ");
                            topicAns = Console.ReadLine();
                        }
                    }


                    Console.WriteLine("Want to know more about C#? press M to go back to the menu, E to Exit...");
                    quitMenu = Console.ReadLine();

                }
                else if (quitMenu == "E" || quitMenu == "e")
                {
                    Environment.Exit(0);
                    break;
                } else if (quitMenu == "") {
                    Console.WriteLine("Want to know more about C#? press M to go back to the menu, E to Exit...");
                    quitMenu = Console.ReadLine();
                } else if (quitMenu != "") {
                    Console.WriteLine("Want to know more about C#? press M to go back to the menu, E to Exit...");
                    quitMenu = Console.ReadLine();
                }
            }


            Console.ReadKey();




        }
    }
}
