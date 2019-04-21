using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// PROBLEM: To determine the illness of a person
// SOLUTION: to create a c# prrogram console to automatically tell the illness of a person by choosing symptoms

// INPUT: 
// AGE (INPUT SHOULD BE A NUMBER OR ELSE THE PROGRAM WILL CRASH)
// NAME (NAME SHOULD NOT BE LESS THAN 6 LETTERS)
// SEX (SEX INPUT's SHOULD BE EITHER 1 OR 2)
// LIST OF SYMPTOMS (SYMPTOMS' INPUT SHOULD BE A NUMBER BETWEEN 1-9)
// DISPLAY
// ARRAY OF SYMPTOMS
// ARRAY OF ILLNESS
// PERSONAL INFORMATION
// RECOMMENDATION
// GET WELL SOON
namespace Performance_Task_Group_2_ICT11A
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, gender;
            int age;

            string[] nameInput = new string[]{
                "Please Enter your name : ", "What is your name ?", "Put your name here", "may i have your name please?"
            };

            string[] ageInput = new string[]{
                "How old are you?", "How old are you now ?" , "may i have your age please?"
            };

            string[] genderInput = new string[]{
                "What is your gender?", "Are you male or female?","I'm sorry, but our policy dictates that we ask this question: What is your gender?",
            };

            string[] select3 = new string[]{
                "Please select 3 more symptoms", "kindly pick 3 more", "try to choose 3 more symptoms", "choose another symptoms"
            };

            string[] select2 = new string[]{
                "Please select 2 more symptoms", "kindly pick 2 more", "try to choose 2 more symptoms", "choose another symptoms"
            };

            string[] select1 = new string[]{
                "select the last symptom", "last one", "please choose the last symptom"
            };

            /*Permutations of all the symptoms in the array */

            string[] foodPoisoning = new string[] { "1", "2", "3", "4" };/*FEVER,DIARRHEA,FATIGUE,MUSCLEACHES*/
            string[] crohnsDisease = new string[] { "1", "2", "3", "5" };/*FEVER,DIARRHEA,FATIGUE,COUGHING */
            string[] dyspepsia = new string[] { "1", "2", "3", "6", "9" };/*FEVER,DIARRHEA,FATIGUE,INDIGESTIONS */
            string[] whippleDisease = new string[] { "1", "2", "3", "7" };/*FEVER,DIARRHEA,FATIGUE,JAWPAIN */
            string[] dumpingSyndrome = new string[] { "1", "2", "3", "8" };/*FEVER,DIARRHEA,FATIGUE,LIGHTHEADEDNESS */
            string[] gad = new string[] { "1", "2", "3", "9" };/*FEVER,DIARRHEA,FATIGUE,ANXIETY */
            string[] influenza = new string[] { "1", "2", "4", "5", "8" };/*FEVER,DIARRHEA,MUSCLEACHES,COUGHING */
            string[] gastroenteritis = new string[] { "1", "2", "4", "6" };/*FEVER,DIARRHEA,MUSCLEACHES,INDIGESTIONS */
            string[] dengueFever = new string[] { "1", "2", "4", "7" };/*FEVER,DIARRHEA,MUSCLEACHES,JAWPAIN */
            string[] flu = new string[] { "1", "3", "4", "5", "8" };/*FEVER,DIARRHEA,MUSCLEACHES,LIGHTHEADEDNESS */
            string[] irritableBowelSyndrome = new string[] { "1", "2", "4", "9" };/*FEVER,DIARRHEA,MUSCLEACHES,ANXIETY */
            string[] meningitis = new string[] { "1", "2", "5", "7" };/*FEVER,DIARRHEA,COUGHING,JAWPAIN */
            string[] gastrointestinal = new string[] { "1", "2", "5", "9" };/*FEVER,DIARRHEA,COUGHING,ANXIETY */
            string[] abdominalPain = new string[] { "1", "2", "6", "7", "8" };/*FEVER,DIARRHEA,INDIGESTIONS,LIGHTHEADEDNESS*/
            string[] stress = new string[] { "1", "2", "3", "7", "9" };/*FEVER,DIARRHEA,JAWPAIN,ANXIETY*/
            string[] lupus = new string[] { "1", "3", "4", "7" };/*FEVER,FATIGUE,MUSCLEACHES,JAWPAIN*/
            string[] pneumonia = new string[] { "1", "3", "5", "6", "8" };/*FEVER,FATIGUE,COUGHING,INDIGESTIONS*/
            string[] sinusInfection = new string[] { "1", "3", "5", "7" };/*FEVER,FATIGUE,COUGHING,JAWPAIN*/
            string[] chronicCough = new string[] { "1", "3", "5", "9" };/*FEVER,FATIGUE,COUGHING,ANXIETY*/
            string[] heartBurn = new string[] { "1", "3", "5", "6", "7" };/*FEVER,FATIGUE,INDIGESTIONS,JAWPAIN*/
            string[] tuberculousMeningitis = new string[] { "1", "3", "4", "6", "7", "8" };/*FEVER,FATIGUE,INDIGESTIONS,LIGHTHEADEDNESS*/
            string[] viralPharyngitis = new string[] { "1", "3", "7", "8" };/*FEVER,FATIGUE,JAWPAIN,LIGHTHEADEDNESS*/
            string[] vertigo = new string[] { "1", "3", "8", "9" };/*FEVER,FATIGUE,LIGHTHEADEDNESS,ANXIETY*/
            string[] laryngitis = new string[] { "1", "4", "5", "6" };/*FEVER,MUSCLEACHES,COUGHING,INDIGESTIONS*/
            string[] colds = new string[] { "1", "4", "5", "7" };/*FEVER,MUSCLEACHES,COUGHING,JAWPAIN*/
            string[] anxietyCough = new string[] { "1", "4", "5", "9" };/*FEVER,MUSCLEACHES,COUGHING,ANXIETY*/
            string[] heartAttack = new string[] { "1", "4", "6", "7", "9" };/*FEVER,MUSCLEACHES,INDIGESTIONS,JAWPAIN*/
            string[] acidReflux = new string[] { "1", "4", "5", "6", "8" };/*FEVER,MUSCLEACHES,INDIGESTIONS,LIGHTHEADEDNESS*/
            string[] GERD = new string[] { "1", "4", "6", "9", "5" };/*FEVER,MUSCLEACHES,INDIGESTIONS,ANXIETY*/
            string[] depression = new string[] { "1", "4", "8", "9" };/*FEVER,MUSCLEACHES,LIGHTHEADEDNESS,ANXIETY*/
            string[] pericarditis = new string[] { "1", "5", "7", "8" };/*FEVER,COUGHING,JAWPAIN,LIGHTHEADEDNESS*/
            string[] aorticAneurysm = new string[] { "1", "5", "7", "9" };/*FEVER,COUGHING,JAWPAIN,ANXIETY*/
            string[] brucellosis = new string[] { "1", "5", "8", "9" };/*FEVER,COUGHING,LIGHTHEADEDNESS,ANXIETY*/
            string[] flukeInfection = new string[] { "1", "5", "7", "8" };/*FEVER,INDIGESTIONS,JAWPAIN,LIGHTHEADEDNESS*/
            string[] irritablebowelsyndrome = new string[] { "1", "6", "7", "9" };/*FEVER,INDIGESTIONS,JAWPAIN,ANXIETY*/
            string[] panicAttack = new string[] { "1", "6", "8", "9" };/*FEVER,INDIGESTIONS,LIGHTHEADEDNESS,ANXIETY*/
            string[] chronicFatigueSyndrome = new string[] { "1", "7", "8", "9" };/*FEVER,JAWPAIN,LIGHTHEADEDNESS,ANXIETY*/
            string[] viralHepatitis = new string[] { "2", "3", "4", "5" };/*f*/

            /*WALA PANG ELSE IF STATEMENT NASA BABA NITO */

            // string[]  IBS = new string[] {"2","3","4","6"};/*DIARRHEA,FATIGUE,MUSCLEACHES,INDIGESTIONS*/
            // string[]  chronicStomachPain = new string[] {"2","3","4","7"};/*DIARRHEA,FATIGUE,MUSCLEACHES,JAWPAIN*/
            // string[]  addisonsDisease = new string[] {"2","3","4","8"};/*DIARRHEA,FATIGUE,MUSCLEACHES,LIGHTHEADEDNESS*/
            // string[]  IBS2 = new string[] {"2","3","4","9"};/*DIARRHEA,FATIGUE,MUSCLEACHES,ANXIETY*/
            // string[]  acuteLiverFailure = new string[] {"2","3","5","6"};/*DIARRHEA,FATIGUE,COUGHING,INDIGESTIONS*/
            // string[]  whippleDisease2= new string[] {"2","3","5","7"};/*DIARRHEA,FATIGUE,COUGHING,JAWPAIN*/
            // string[]  pneumonia2 = new string[] {"2","3","5","8"};/*DIARRHEA,FATIGUE,COUGHING,LIGHTHEADEDNESS*/
            // string[]  anemia = new string[] {"2","3","5","9"};/*DIARRHEA,FATIGUE,COUGHING,ANXIETY*/
            // string[]  cirrhosis = new string[] {"2","3","6","7"};/*DIARRHEA,FATIGUE,INDIGESTIONS,JAWPAIN*/
            // string[]  vitaminB12Deficiency = new string[] {"2","3","6","8"};/*DIARRHEA,FATIGUE,INDIGESTIONS,LIGHTHEADEDNESS*/
            // string[]  hyperthyroidism = new string[] {"2","3","6","9"};/*DIARRHEA,FATIGUE,INDIGESTIONS,ANXIETY*/
            // string[]  migraine = new string[] {"2","3","7","8"};/*DIARRHEA,FATIGUE,JAWPAIN,LIGHTHEADEDNESS*/
            // string[]  celiacDisease= new string[] {"2","3","7","9"};/*DIARRHEA,FATIGUE,JAWPAIN,ANXIETY*/
            // string[]  = new string[] {"2","3","8","9"};/*DIARRHEA,FATIGUE,LIGHTHEADEDNESS,ANXIETY*/
            // string[]  = new string[] {"2","4","5","6"};/*DIARRHEA,MUSCLEACHES,COUGHING,INDIGESTIONS*/
            // string[]  = new string[] {"2","4","5","7"};/*DIARRHEA,MUSCLEACHES,COUGHING,JAWPAIN*/
            // string[]  = new string[] {"2","4","5","8"};/*DIARRHEA,MUSCLEACHES,COUGHING,LIGHTHEADEDNESS*/
            // string[]  = new string[] {"2","4","5","9"};/*DIARRHEA,MUSCLEACHES,COUGHING,ANXIETY*/
            // string[]  = new string[] {"2","4","6","7"};/*DIARRHEA,MUSCLEACHES,INDIGESTIONS,JAWPAIN*/
            // string[]  = new string[] {"2","4","6","8"};/*DIARRHEA,MUSCLEACHES,INDIGESTIONS,LIGHTHEADEDNESS*/
            // string[]  = new string[] {"2","4","6","9"};/*DIARRHEA,MUSCLEACHES,INDIGESTIONS,ANXIETY*/
            // string[]  = new string[] {"2","4","7","8"};/*DIARRHEA,MUSCLEACHES,JAWPAIN,LIGHTHEADEDNESS*/
            // string[]  = new string[] {"2","4","7","9"};/*DIARRHEA,MUSCLEACHES,JAWPAIN,ANXIETY*/
            // string[]  = new string[] {"2","4","8","9"};/*DIARRHEA,MUSCLEACHES,LIGHTHEADEDNESS,ANXIETY*/
            // string[]  = new string[] {"2","5","6","7"};/*DIARRHEA,COUGHING,INDIGESTIONS,JAWPAIN*/
            // string[]  = new string[] {"2","5","6","8"};/*DIARRHEA,COUGHING,INDIGESTIONS,LIGHTHEADEDNESS*/
            // string[]  = new string[] {"2","5","6","9"};/*DIARRHEA,COUGHING,INDIGESTIONS,ANXIETY*/
            // string[]  = new string[] {"2","5","7","8"};// DIARRHEA,COUGHING,JAWPAIN,LIGHTHEADEDNESS
            // string[]  = new string[] {"2","5","7","9"};// DIARRHEA,COUGHING,JAWPAIN,ANXIETY
            // string[]  = new string[] {"2","5","8","9"};// DIARRHEA,COUGHING,LIGHTHEADEDNESS,ANXIETY
            // string[]  = new string[] {"2","6","7","8"};// DIARRHEA,INDIGESTIONS,JAWPAIN,LIGHTHEADEDNESS
            // string[]  = new string[] {"2","6","7","9"};// DIARRHEA,INDIGESTIONS,JAWPAIN,ANXIETY
            // string[]  = new string[] {"2","6","8","9"};// DIARRHEA,INDIGESTIONS,LIGHTHEADEDNESS,ANXIETY
            // String[]  = new string[] {"2","7","8","9"};// DIARRHEA,JAWPAIN,LIGHTHEADEDNESS,ANXIETY
            // String[]  = new string[] {"3","4","5","6"};// FATIGUE,MUSCLEACHES,COUGHING,INDIGESTIONS
            // String[]  = new string[] {"3","4","5","7"};// FATIGUE,MUSCLEACHES,COUGHING,JAWPAIN
            // String[]  = new string[] {"3","4","5","8"};// FATIGUE,MUSCLEACHES,COUGHING,LIGHTHEADEDNESS
            // String[]  = new string[] {"3","4","5","9"};// FATIGUE,MUSCLEACHES,COUGHING,ANXIETY
            // String[]  = new string[] {"3","4","6","7"};// FATIGUE,MUSCLEACHES,INDIGESTIONS,JAWPAIN
            // String[]  = new string[] {"3","4","6","8"};// FATIGUE,MUSCLEACHES,INDIGESTIONS,LIGHTHEADEDNESS
            // String[]  = new string[] {"3","4","6","9"};// FATIGUE,MUSCLEACHES,INDIGESTIONS,ANXIETY
            // String[]  = new string[] {"3","4","7","8"};// FATIGUE,MUSCLEACHES,JAWPAIN,LIGHTHEADEDNESS
            // String[]  = new string[] {"3","4","7","9"};// FATIGUE,MUSCLEACHES,JAWPAIN,ANXIETY
            // String[]  = new string[] {"3","4","8","9"};// FATIGUE,MUSCLEACHES,LIGHTHEADEDNESS,ANXIETY
            // String[]  = new string[] {"3","5","6","7"};// FATIGUE,COUGHING,INDIGESTIONS,JAWPAIN
            // String[]  = new string[] {"3","5","6","8"};// FATIGUE,COUGHING,INDIGESTIONS,LIGHTHEADEDNESS
            // String[]  = new string[] {"3","5","6","9"};// FATIGUE,COUGHING,INDIGESTIONS,ANXIETY
            // String[]  = new string[] {"3","5","7","8"};// FATIGUE,COUGHING,JAWPAIN,LIGHTHEADEDNESS
            // String[]  = new string[] {"3","5","7","9"};// FATIGUE,COUGHING,JAWPAIN,ANXIETY
            // String[]  = new string[] {"3","5","8","9"};// FATIGUE,COUGHING,LIGHTHEADEDNESS,ANXIETY
            // String[]  = new string[] {"3","6","7","8"};// FATIGUE,INDIGESTIONS,JAWPAIN,LIGHTHEADEDNESS
            // String[]  = new string[] {"3","6","7","9"};// FATIGUE,INDIGESTIONS,JAWPAIN,ANXIETY
            // String[]  = new string[] {"3","6","8","9"};// FATIGUE,INDIGESTIONS,LIGHTHEADEDNESS,ANXIETY
            // String[]  = new string[] {"3","7","8","9"};// FATIGUE,JAWPAIN,LIGHTHEADEDNESS,ANXIETY
            // String[]  = new string[] {"4","5","6","7"};// MUSCLEACHES,COUGHING,INDIGESTIONS,JAWPAIN
            // String[]  = new string[] {"4","5","6","8"};// MUSCLEACHES,COUGHING,INDIGESTIONS,LIGHTHEADEDNESS
            // String[]  = new string[] {"4","5","6","9"};// MUSCLEACHES,COUGHING,INDIGESTIONS,ANXIETY
            // String[]  = new string[] {"4","5","7","8"};// MUSCLEACHES,COUGHING,JAWPAIN,LIGHTHEADEDNESS
            // String[]  = new string[] {"4","5","7","9"};// MUSCLEACHES,COUGHING,JAWPAIN,ANXIETY
            // String[]  = new string[] {"4","5","8","9"};// MUSCLEACHES,COUGHING,LIGHTHEADEDNESS,ANXIETY
            // String[]  = new string[] {"4","6","7","8"};// MUSCLEACHES,INDIGESTIONS,JAWPAIN,LIGHTHEADEDNESS
            // String[]  = new string[] {"4","6","7","9"};// MUSCLEACHES,INDIGESTIONS,JAWPAIN,ANXIETY
            // String[]  = new string[] {"4","6","8","9"};// MUSCLEACHES,INDIGESTIONS,LIGHTHEADEDNESS,ANXIETY
            // String[]  = new string[] {"4","6","7","8"};// MUSCLEACHES,JAWPAIN,LIGHTHEADEDNESS,ANXIETY
            // String[]  = new string[] {"5","6","7","8"};// COUGHING,INDIGESTIONS,JAWPAIN,LIGHTHEADEDNESS
            // String[]  = new string[] {"5","6","7","9"};// COUGHING,INDIGESTIONS,JAWPAIN,ANXIETY
            // String[]  = new string[] {"5","6","8","9"};// COUGHING,INDIGESTIONS,LIGHTHEADEDNESS,ANXIETY
            // String[]  = new string[] {"5","7","8","9"};// COUGHING,JAWPAIN,LIGHTHEADEDNESS,ANXIETY
            // String[]  = new string[] {"6","7","8","9"};// INDIGESTIONS,JAWPAIN,LIGHTHEADEDNESS,ANXIETY




            int symptomCollector, symptomCollector2, symptomCollector3, symptomCollector4;

            //name input
            Console.WriteLine(nameInput[new Random().Next(0, nameInput.Length)]);
            name = Console.ReadLine();

            while (true)
            {
                if (name != null && name.Length < 5)
                {//this statement checks if there's a name and it should be greater than 5 characters
                    Console.WriteLine(nameInput[new Random().Next(0, nameInput.Length)]);
                    name = Console.ReadLine();
                }
                else
                {
                    break;

                }
            }

            //age Input
            Console.WriteLine("\n");
            Console.WriteLine(ageInput[new Random().Next(0, ageInput.Length)]);
            age = int.Parse(Console.ReadLine());

            while (true)
            {
                if (age > 100)
                {
                    Console.WriteLine(ageInput[new Random().Next(0, ageInput.Length - 1)]);
                    age = int.Parse(Console.ReadLine());
                }
                else if (age < 100)
                {
                    break;
                }
            }

            //Gender Input
            Console.WriteLine("\n");
            Console.WriteLine(genderInput[new Random().Next(0, genderInput.Length)]);
            Console.WriteLine("1. Male");
            Console.WriteLine("2. Female\n");
            gender = Console.ReadLine();

            while (true)
            {
                if (gender == "1")
                {
                    gender = "Male";
                    break;
                }
                else if (gender == "2")
                {
                    gender = "Female";
                    break;
                }
                else if (gender != "1" || gender != "2")
                {

                    Console.WriteLine(genderInput[2]);
                    Console.WriteLine("1. Male");
                    Console.WriteLine("2. Female");
                    gender = Console.ReadLine();

                }
            }


            ArrayList sympt = new ArrayList(9);

            sympt.Add("1.) Fever");
            sympt.Add("2.) Diarrhea");
            sympt.Add("3.) Fatigue");
            sympt.Add("4.) Muscle aches");
            sympt.Add("5.) Coughing");
            sympt.Add("6.) indigestion");
            sympt.Add("7.) jaw pain");
            sympt.Add("8.) lightheadedness");
            sympt.Add("9.) anxiety");

            // Console.WriteLine("Please select 4 symptoms but 1 at a time\n");
            foreach (string str in sympt)
                Console.WriteLine(str);
            Console.WriteLine("\n");

            //first input
            Console.WriteLine("Please select 4 symptoms but 1 at a time");
            symptomCollector = int.Parse(Console.ReadLine());
            while (true)
            {
                if (symptomCollector > 9)
                {
                    Console.WriteLine("Please select 4 symptoms but 1 at a time");
                    symptomCollector = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
            // sympt.RemoveAt(symptomCollector-1);
            sympt[symptomCollector - 1] = null;
            foreach (string str in sympt)
                Console.WriteLine(str);
            Console.WriteLine("\n");

            //second input
            Console.WriteLine(select3[new Random().Next(0, select3.Length)]);
            symptomCollector2 = int.Parse(Console.ReadLine());
            while (true)
            {
                if (symptomCollector2 > 9 || symptomCollector2 == symptomCollector)
                {
                    Console.WriteLine(select3[new Random().Next(0, select3.Length)]);
                    symptomCollector2 = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
            // sympt.RemoveAt(symptomCollector2-1); 
            sympt[symptomCollector2 - 1] = null;
            foreach (string str in sympt)
                Console.WriteLine(str);
            Console.WriteLine("\n");

            //third input
            Console.WriteLine(select2[new Random().Next(0, select2.Length)]);
            symptomCollector3 = int.Parse(Console.ReadLine());
            while (true)
            {
                if (symptomCollector3 > 9 || symptomCollector3 == symptomCollector || symptomCollector3 == symptomCollector2)
                {
                    Console.WriteLine(select2[new Random().Next(0, select2.Length)]);
                    symptomCollector3 = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
            // sympt.RemoveAt(symptomCollector3-1); 
            sympt[symptomCollector3 - 1] = null;
            foreach (string str in sympt)
                Console.WriteLine(str);
            Console.WriteLine("\n");
            //fourth input
            Console.WriteLine(select1[new Random().Next(0, select1.Length)]);
            symptomCollector4 = int.Parse(Console.ReadLine());
            while (true)
            {
                if (symptomCollector4 > 9 || symptomCollector4 == symptomCollector3 || symptomCollector4 == symptomCollector2 || symptomCollector4 == symptomCollector)
                {
                    Console.WriteLine(select1[new Random().Next(0, select1.Length)]);
                    symptomCollector4 = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
            // sympt.RemoveAt(symptomCollector4-1); 
            sympt[symptomCollector4 - 1] = null;
            foreach (string str in sympt)
                Console.WriteLine(str);
            Console.WriteLine("\n");

            string a = Convert.ToString(symptomCollector);
            string b = Convert.ToString(symptomCollector2);
            string c = Convert.ToString(symptomCollector3);
            string d = Convert.ToString(symptomCollector4);

            if (foodPoisoning.Contains(a) && foodPoisoning.Contains(b)
                && foodPoisoning.Contains(c) && foodPoisoning.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Food Poisoning");

            }
            else if (crohnsDisease.Contains(a) && crohnsDisease.Contains(b)
               && crohnsDisease.Contains(c) && crohnsDisease.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Crohn's Disease");

            }
            else if (dyspepsia.Contains(a) && dyspepsia.Contains(b)
               && dyspepsia.Contains(c) && dyspepsia.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Dyspepsia");

            }
            else if (whippleDisease.Contains(a) && whippleDisease.Contains(b)
               && whippleDisease.Contains(c) && whippleDisease.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Whipple Disease");

            }
            else if (dumpingSyndrome.Contains(a) && dumpingSyndrome.Contains(b)
               && dumpingSyndrome.Contains(c) && dumpingSyndrome.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Dumping Syndrome");

            }
            else if (gad.Contains(a) && gad.Contains(b)
               && gad.Contains(c) && gad.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Generalized anxiety disorder");

            }
            else if (influenza.Contains(a) && influenza.Contains(b)
               && influenza.Contains(c) && influenza.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Influenza");

            }
            else if (gastroenteritis.Contains(a) && gastroenteritis.Contains(b)
               && gastroenteritis.Contains(c) && gastroenteritis.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Gastroenteritis");

            }
            else if (dengueFever.Contains(a) && dengueFever.Contains(b)
               && dengueFever.Contains(c) && dengueFever.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Dengue Fever");

            }
            else if (flu.Contains(a) && flu.Contains(b)
               && flu.Contains(c) && flu.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Flu");

            }
            else if (irritableBowelSyndrome.Contains(a) && irritableBowelSyndrome.Contains(b)
               && irritableBowelSyndrome.Contains(c) && irritableBowelSyndrome.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Irritable Bowel Syndrome");

            }
            else if (meningitis.Contains(a) && meningitis.Contains(b)
               && meningitis.Contains(c) && meningitis.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Meningitis");

            }
            else if (gastrointestinal.Contains(a) && gastrointestinal.Contains(b)
               && gastrointestinal.Contains(c) && gastrointestinal.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("GastroIntestinal");

            }
            else if (abdominalPain.Contains(a) && abdominalPain.Contains(b)
               && abdominalPain.Contains(c) && abdominalPain.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Abdominal Pain");

            }
            else if (stress.Contains(a) && stress.Contains(b)
               && stress.Contains(c) && stress.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Stress");

            }
            else if (lupus.Contains(a) && lupus.Contains(b)
               && lupus.Contains(c) && lupus.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Lupus");

            }
            else if (pneumonia.Contains(a) && pneumonia.Contains(b)
               && pneumonia.Contains(c) && pneumonia.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Pneumonia");

            }
            else if (sinusInfection.Contains(a) && sinusInfection.Contains(b)
               && sinusInfection.Contains(c) && sinusInfection.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Sinus Infection");

            }
            else if (chronicCough.Contains(a) && chronicCough.Contains(b)
               && chronicCough.Contains(c) && chronicCough.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Chronic Cough");

            }
            else if (heartBurn.Contains(a) && heartBurn.Contains(b)
               && heartBurn.Contains(c) && heartBurn.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Heart Burn");

            }
            else if (tuberculousMeningitis.Contains(a) && tuberculousMeningitis.Contains(b)
               && tuberculousMeningitis.Contains(c) && tuberculousMeningitis.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Tuberculous Meningitis");

            }
            else if (viralPharyngitis.Contains(a) && viralPharyngitis.Contains(b)
               && viralPharyngitis.Contains(c) && viralPharyngitis.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Viral Pharyngitis");

            }
            else if (vertigo.Contains(a) && vertigo.Contains(b)
               && vertigo.Contains(c) && vertigo.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Vertigo");

            }
            else if (laryngitis.Contains(a) && laryngitis.Contains(b)
               && laryngitis.Contains(c) && laryngitis.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Laryngitis");

            }
            else if (colds.Contains(a) && colds.Contains(b)
               && colds.Contains(c) && colds.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Colds");

            }
            else if (anxietyCough.Contains(a) && anxietyCough.Contains(b)
               && anxietyCough.Contains(c) && anxietyCough.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Anxiety Cough");

            }
            else if (heartAttack.Contains(a) && heartAttack.Contains(b)
               && heartAttack.Contains(c) && heartAttack.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Heart Attack");

            }
            else if (acidReflux.Contains(a) && acidReflux.Contains(b)
               && acidReflux.Contains(c) && acidReflux.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Acid Reflux");

            }
            else if (GERD.Contains(a) && GERD.Contains(b)
               && GERD.Contains(c) && GERD.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Gastroesophageal reflux disease");

            }
            else if (depression.Contains(a) && depression.Contains(b)
               && depression.Contains(c) && depression.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Depression");

            }
            else if (pericarditis.Contains(a) && pericarditis.Contains(b)
               && pericarditis.Contains(c) && pericarditis.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Pericarditis");

            }
            else if (aorticAneurysm.Contains(a) && aorticAneurysm.Contains(b)
               && aorticAneurysm.Contains(c) && aorticAneurysm.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Aortic Aneurysm");

            }
            else if (brucellosis.Contains(a) && brucellosis.Contains(b)
               && brucellosis.Contains(c) && brucellosis.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Brucellosis");

            }
            else if (flukeInfection.Contains(a) && flukeInfection.Contains(b)
               && flukeInfection.Contains(c) && flukeInfection.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Fluke Infection");

            }
            else if (irritablebowelsyndrome.Contains(a) && irritablebowelsyndrome.Contains(b)
               && irritablebowelsyndrome.Contains(c) && irritablebowelsyndrome.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Irritable bowel syndrome");

            }
            else if (panicAttack.Contains(a) && panicAttack.Contains(b)
               && panicAttack.Contains(c) && panicAttack.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Panic Attack");

            }
            else if (chronicFatigueSyndrome.Contains(a) && chronicFatigueSyndrome.Contains(b)
               && chronicFatigueSyndrome.Contains(c) && chronicFatigueSyndrome.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Chronic Fatigue Syndrome");

            }
            else if (viralHepatitis.Contains(a) && viralHepatitis.Contains(b)
               && viralHepatitis.Contains(c) && viralHepatitis.Contains(d))
            {

                Console.WriteLine("Hi " + name);
                Console.WriteLine(age + " years old " + gender);
                Console.WriteLine("Viral Hepatitis");

            }

            Console.ReadKey();
        }
    }
}
