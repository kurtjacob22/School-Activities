using System;

namespace ACTIVITY4_2_URQUICO
{
    class Program
    {
        static void Main(string[] args)
        {
            string header = @"
+--------------------------------------------------------------------------------------------+
     .-')                            .-') _        .-') _          _   .-')       ('-.  ,---.      
   .(  OO)                          (  OO) )      (  OO) )        ( '.( OO )_   _(  OO) |   |      
  (_)---\_)   ,--. ,--.    ,-.-') ,(_)----.       /     '._ ,-.-') ,--.   ,--.)(,------.|   |      
  '  .-.  '   |  | |  |    |  |OO)|       |       |'--...__)|  |OO)|   `.'   |  |  .---'|   |      
 ,|  | |  |   |  | | .-')  |  |  \'--.   /        '--.  .--'|  |  \|         |  |  |    |   |      
(_|  | |  |   |  |_|( OO ) |  |(_/(_/   /            |  |   |  |(_/|  |'.'|  | (|  '--. |  .'      
  |  | |  |   |  | | `-' /,|  |_.' /   /___          |  |  ,|  |_.'|  |   |  |  |  .--' `--'       
  '  '-'  '-.('  '-'(_.-'(_|  |   |        |         |  | (_|  |   |  |   |  |  |  `---..--.       
   `-----'--'  `-----'     `--'   `--------'         `--'   `--'   `--'   `--'  `------''--'       
+--------------------------------------------------------------------------------------------+
";
            string seperator = "+--------------------------------------------------------------------------------------------+";
            string multiple1 = @"

                            a.) Erno Rubik          c.)Noel Rubik
                            b.) Magno Rubik         d.)John Rubik

";

            string multiple2 = @"

                            a.) 1960          c.)1975
                            b.) 1986          d.)1974

";
            string multiple3 = @"

                            a.) USA          c.)Hungary
                            b.) Turkey       d.)Philippines

";

            string multiple4 = @"

                            a.) 3.475          c.)6.99
                            b.) 5.555          d.)3.598

";
            string multiple5 = @"

                            a.) World Cubers Association      c.)World Cubers Alliance
                            b.) World Cube Association        d.)World Cube Authority

";

            int totalScore = 0;
            int totalScore2 = 0;
            int totalScore3 = 0;

            Console.WriteLine(header);
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
            Console.Clear();


        quizQuestions:
            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("\t\t\tThis quiz tests your knowledge on Rubik's Cube");
            Console.WriteLine(seperator);
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(seperator);
            Console.WriteLine("\t\t\tLevel 1 - Multiple Choice(1 point each)");
            Console.WriteLine(seperator);
            Console.WriteLine("Press enter if you are ready");
            Console.ReadKey();
            Console.Clear();

        //question1
        question1:
            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("\t\t\t\t1.)Who created the Rubik's Cube?");
            Console.WriteLine(seperator);
            Console.WriteLine(multiple1);

            Console.Write("Input your answer here: ");
            string ans1 = Console.ReadLine();
            while (true)
            {
                if (ans1 == "a" || ans1 == "A")
                {
                    totalScore += 1;

                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYou are correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();

                    break;

                }
                else if (ans1 == "b" || ans1 == "B")
                {
                    totalScore += 0;

                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
					Console.WriteLine("\tErno Rubik is the one who invented the Rubik's cube");
                    Console.WriteLine(seperator);
                    Console.ReadKey();

                    break;
                }
                else if (ans1 == "c" || ans1 == "C")
                {
                    totalScore += 0;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
					Console.WriteLine("\tErno Rubik is the one who invented the Rubik's cube");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;
                }
                else if (ans1 == "d" || ans1 == "D")
                {
                    totalScore += 0;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
					Console.WriteLine("\tErno Rubik is the one who invented the Rubik's cube");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;
                }
                else if (ans1 == "")
                {
                    goto question1;

                }
                else if (ans1 != "")
                {
                    goto question1;

                }

            }

        //question2
        question2:
            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("\t\t\t\t2.)When was the Rubik's cube invented?");
            Console.WriteLine(seperator);
            Console.WriteLine(multiple2);

            Console.Write("Input your answer here: ");
            string ans2 = Console.ReadLine();
            while (true)
            {
                if (ans2 == "a" || ans2 == "A")
                {
                    totalScore += 0;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
					Console.WriteLine("\tIt was invented in 1974");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;

                }
                else if (ans2 == "b" || ans2 == "B")
                {
                    totalScore += 0;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
					Console.WriteLine("\tIt was invented in 1974");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;
                }
                else if (ans2 == "c" || ans2 == "C")
                {
                    totalScore += 0;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
					Console.WriteLine("\tIt was invented in 1974");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;
                }
                else if (ans2 == "d" || ans2 == "D")
                {
                    totalScore += 1;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;
                }
                else if (ans2 == "")
                {
                    goto question2;

                }
                else if (ans2 != "")
                {
                    goto question2;

                }

            }

        //question3
        question3:
            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("\t\t\t\t3.)Where was the Rubik's cube invented?");
            Console.WriteLine(seperator);
            Console.WriteLine(multiple3);

            Console.Write("Input your answer here: ");
            string ans3 = Console.ReadLine();

            while (true)
            {
                if (ans3 == "a" || ans3 == "A")
                {
                    totalScore += 0;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
					Console.WriteLine("\t\t\tIt was invented at Hungary");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;

                }
                else if (ans3 == "b" || ans3 == "B")
                {
                    totalScore += 0;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
					Console.WriteLine("\t\t\tIt was invented at Hungary");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;
                }
                else if (ans3 == "c" || ans3 == "C")
                {
                    totalScore += 1;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;
                }
                else if (ans3 == "d" || ans3 == "D")
                {
                    totalScore += 0;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
					Console.WriteLine("\t\t\tIt was invented at Hungary");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;
                }
                else if (ans3 == "")
                {
                    goto question3;

                }
                else if (ans3 != "")
                {
                    goto question3;

                }

            }


        //question4
        question4:
            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("\t\t\t4.)What is the current world record in Rubik's cube");
            Console.WriteLine(seperator);
            Console.WriteLine(multiple4);

            Console.Write("Input your answer here: ");
            string ans4 = Console.ReadLine();

            while (true)
            {
                if (ans4 == "a" || ans4 == "A")
                {
                    totalScore += 1;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is correct");
					
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;

                }
                else if (ans4 == "b" || ans4 == "B")
                {
                    totalScore += 0;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
					Console.WriteLine("\tThe current world record in Rubik's cube is 3.475");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;
                }
                else if (ans4 == "c" || ans4 == "C")
                {
                    totalScore += 0;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
					Console.WriteLine("\tThe current world record in Rubik's cube is 3.475");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;
                }
                else if (ans4 == "d" || ans4 == "D")
                {
                    totalScore += 0;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
					Console.WriteLine("\tThe current world record in Rubik's cube is 3.475");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;
                }
                else if (ans4 == "")
                {
                    goto question4;

                }
                else if (ans4 != "")
                {
                    goto question4;

                }

            }

        //question5
        question5:
            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("\t\t\t\t\t5.)What does WCA means?");
            Console.WriteLine(seperator);
            Console.WriteLine(multiple5);

            Console.Write("Input your answer here: ");
            string ans5 = Console.ReadLine();
            Console.Clear();
            while (true)
            {
                if (ans5 == "a" || ans5 == "A")
                {
                    totalScore += 0;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
					Console.WriteLine("\t\tWCA stands for World Cube Association");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;

                }
                else if (ans5 == "b" || ans5 == "B")
                {
                    totalScore += 1;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;
                }
                else if (ans5 == "c" || ans5 == "C")
                {
                    totalScore += 0;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
					Console.WriteLine("\t\tWCA stands for World Cube Association");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;
                }
                else if (ans5 == "d" || ans5 == "D")
                {
                    totalScore += 0;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
					Console.WriteLine("\t\tWCA stands for World Cube Association");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;
                }
                else if (ans5 == "")
                {
                    goto question5;

                }
                else if (ans5 != "")
                {
                    goto question5;

                }

            }

            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("\t\t\tYour score in Level 1 is " + totalScore + "/5");
            Console.WriteLine(seperator);
            Console.WriteLine("\n\tPress enter to proceed to level 2 - true or false ");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(seperator);
            Console.WriteLine("\t\t\tLevel 2 - True or False(3 points each)");
            Console.WriteLine("\t\tWrite true if the statement is true and false if it is false");
            Console.WriteLine(seperator);
            Console.WriteLine("Press enter if you are ready");
            Console.ReadKey();
            Console.Clear();

        //true or false1
        tof1:
            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("\t1.) Rubik's Cube is an example of mechanical puzzle");
            Console.WriteLine(seperator);
            Console.Write("\n\tEnter your answer here: ");
            string tof1 = Console.ReadLine();
            tof1 = tof1.ToLower();

             while(true){

                if (tof1 == "true") {

                    totalScore2 += 3;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;

                } else if (tof1 == "false") {

                    totalScore2 += 0;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;

                }else if(tof1 != ""){

                    goto tof1;

                }
                else if (tof1 == "")
                {

                    goto tof1;

                }

             }

        //true or false2
        tof2:
            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("\t2.) it took the inventor (Professor Erno Rubik) over a month to solve it.");
            Console.WriteLine(seperator);
            Console.Write("\n\tEnter your answer here: ");
            string tof2 = Console.ReadLine();
            tof2 = tof2.ToLower();

            while (true)
            {

                if (tof2 == "true")
                {

                    totalScore2 += 3;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;

                }
                else if (tof2 == "false")
                {

                    totalScore2 += 0;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;

                }
                else if (tof2 != "")
                {

                    goto tof2;

                }
                else if (tof2 == "")
                {

                    goto tof2;

                }

            }

        //true or false3
        tof3:
            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("\t3.) Over 5 million Rubik's Cube have been sold worldwide");
            Console.WriteLine(seperator);
            Console.Write("\n\tEnter your answer here: ");
            string tof3 = Console.ReadLine();
            tof3 = tof3.ToLower();

            while (true)
            {

                if (tof3 == "true")
                {

                    totalScore2 += 0;
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();

                    break;

                }
                else if (tof3 == "false")
                {

                    totalScore2 += 3;
                    
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;

                }
                else if (tof3 != "")
                {

                    goto tof3;

                }
                else if (tof3 == "")
                {

                    goto tof3;

                }

            }


        //true or false4
        tof4:
            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("4.) It has been calculated that there are 43,252,003,274,489,856,000 possible permutations of \nthe Rubik's Cube.");
            Console.WriteLine(seperator);
            Console.Write("\n\tEnter your answer here: ");
            string tof4 = Console.ReadLine();
            tof4 = tof4.ToLower();

            while (true)
            {

                if (tof4 == "true")
                {

                    totalScore2 += 3;


                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();

                    break;

                }
                else if (tof4 == "false")
                {

                    totalScore2 += 0;

                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();

                    break;

                }
                else if (tof4 != "")
                {

                    goto tof4;

                }
                else if (tof4 == "")
                {

                    goto tof4;

                }

            }


        //true or false5
        tof5:
            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("5.) It can be estimated that less than 5.8% of the world's population can solve the Rubik's Cube");
            Console.WriteLine(seperator);
            Console.Write("\n\tEnter your answer here: ");
            string tof5 = Console.ReadLine();
            tof5 = tof5.ToLower();

            while (true)
            {

                if (tof5 == "true")
                {

                    totalScore2 += 3;


                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();

                    break;

                }
                else if (tof5 == "false")
                {

                    totalScore2 += 0;

                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();

                    break;

                }
                else if (tof5 != "")
                {

                    goto tof5;

                }
                else if (tof5 == "")
                {

                    goto tof5;

                }

            }


            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("\t\t\tYour score in Level 2 is " + totalScore2 + "/15");
            Console.WriteLine(seperator);
            Console.WriteLine("\n\tPress enter to proceed to level 3 - IDENTIFICATION");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(seperator);
            Console.WriteLine("\t\t\tLevel 3 - IDENTIFICATION(5 points each)");
            Console.WriteLine(seperator);
            Console.WriteLine("Press enter if you are ready");
            Console.ReadKey();
            Console.Clear();

        //identification1
        ID1:
            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("1.) What is the size of the standard Rubik's Cube");
            Console.WriteLine(seperator);
            Console.Write("\n\tEnter your answer here: ");
            string ID1 = Console.ReadLine();
            ID1 = ID1.ToLower();

            while (true)
            {

                if (ID1 == "3x3x3")
                {

                    totalScore3 += 5;


                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();

                    break;

                } else if (ID1 == "") {
                    goto ID1;
                }
                else if (ID1 != "")
                {
                    totalScore3 += 0;


                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
                    Console.WriteLine("\t\t\tThe correct answer is \"3x3x3\"");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;
                }

            }

        //identification2
        ID2:
            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("2.) What is the popular nickname of the 2x2 Rubik's Cube?");
            Console.WriteLine(seperator);
            Console.Write("\n\tEnter your answer here: ");
            string ID2 = Console.ReadLine();
            ID2 = ID2.ToLower();

            while (true)
            {

                if (ID2 == "pocket cube")
                {

                    totalScore3 += 5;


                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();

                    break;

                }
                else if (ID2 == "")
                {
                    goto ID2;
                }
                else if (ID2 != "")
                {
                    totalScore3 += 0;


                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
                    Console.WriteLine("\t\t\tThe correct answer is \"Pocket Cube\"");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;
                }

            }


        //identification3
        ID3:
            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("3.) What is the popular nickname of the 4x4 Rubik's Cube?");
            Console.WriteLine(seperator);
            Console.Write("\n\tEnter your answer here: ");
            string ID3 = Console.ReadLine();
            ID3 = ID3.ToLower();

            while (true)
            {

                if (ID3 == "rubik's revenge")
                {

                    totalScore3 += 5;


                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();

                    break;

                }
                else if (ID3 == "")
                {
                    goto ID3;
                }
                else if (ID3 != "")
                {
                    totalScore3 += 0;


                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
                    Console.WriteLine("\t\t\tThe correct answer is \"Rubik's Revenge\"");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;
                }

            }

        //identification4
        ID4:
            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("4.) What is the name of the Tetrahedron Shaped Twisty Puzzle?");
            Console.WriteLine(seperator);
            Console.Write("\n\tEnter your answer here: ");
            string ID4 = Console.ReadLine();
            ID4 = ID4.ToLower();

            while (true)
            {

                if (ID4 == "pyraminx")
                {

                    totalScore3 += 5;


                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();

                    break;

                }
                else if (ID4 == "")
                {
                    goto ID4;
                }
                else if (ID4 != "")
                {
                    totalScore3 += 0;


                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
                    Console.WriteLine("\t\t\tThe correct answer is \"Pyraminx\"");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;
                }

            }

        //identification4
        ID5:
            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("5.) What is the minimum number of moves required to solve a standard Rubik's Cube from any position");
            Console.WriteLine(seperator);
            Console.Write("\n\tEnter your answer here: ");
            string ID5 = Console.ReadLine();
            ID5 = ID5.ToLower();

            while (true)
            {

                if (ID5 == "20")
                {

                    totalScore3 += 5;


                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is correct");
                    Console.WriteLine(seperator);
                    Console.ReadKey();

                    break;

                }
                else if (ID5 == "")
                {
                    goto ID5;
                }
                else if (ID5 != "")
                {
                    totalScore3 += 0;


                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("\t\t\tYour answer is not correct");
                    Console.WriteLine("\t\t\tThe correct answer is \"20\"");
                    Console.WriteLine(seperator);
                    Console.ReadKey();
                    break;

                }

            }

            int grandTotal =totalScore + totalScore2 + totalScore3;
            string rating;

            if(grandTotal > 30){
                rating = "Congratulations! You passed the exam";

            }else{
                rating = "Sorry, you failed the exam";
            }

            Console.Clear();
            Console.WriteLine(seperator);
            Console.WriteLine("\t\t\tYour score in Level 3 is " + totalScore3 + "/25");
            Console.WriteLine(seperator);
            Console.WriteLine("\n\tYour total score is "+ grandTotal + "/45");
            Console.WriteLine("\n\t"+ rating);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(seperator);
            Console.WriteLine("Press R to play again, and press E to exit");
            Console.WriteLine(seperator);
            string optMenu = Console.ReadLine();
            optMenu = optMenu.ToLower();

            totalScore = 0;
            totalScore2 = 0;
            totalScore3 = 0;

            while (true) {
                if (optMenu == "e")
                {
                    Environment.Exit(0);
                    break;
                }
                else if (optMenu == "r") {

                    goto quizQuestions;
                    

                }
            }



            Console.ReadKey();


        }
    }
}
