using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace PETA_ICT11A_Group2
{
    class Program
    {
        static void Main(string[] args)
        {

            string header = @"
+-----------------------------------------------------+  
 _ _ _                     _____ _          _         
(_) | |                   /  __ \ |        | |        
 _| | |_ __   ___  ___ ___| /  \/ |__   ___| | ___ __ 
| | | | '_ \ / _ \/ __/ __| |   | '_ \ / _ \ |/ / '__|
| | | | | | |  __/\__ \__ \ \__/\ | | |  __/   <| |   
|_|_|_|_| |_|\___||___/___/\____/_| |_|\___|_|\_\_|   
+-----------------------------------------------------+                                                   
";
            string seperator = "+-----------------------------------------------------+";

            string name, gender;
            string age;


            string[] nameInput = new string[]{
                "Please Enter your full name : ", "What is your full name ?", "Put your full name here", "may i have your full name please?"
            };


            string[] ageInput = new string[]{
                "How old are you?", "How old are you now ?" , "may i have your age please?"
            };

            string[] genderInput = new string[]{
                "What is your gender?", "Are you male or female?","I'm sorry, but our policy dictates that we ask this \nquestion: What is your gender?",
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
            string[] cholera = new string[] { "2", "3", "8", "9" };/*DIARRHEA,FATIGUE,LIGHTHEADEDNESS,ANXIETY*/
            string[] strongyloidiasis = new string[] { "2", "4", "5", "6" };/*DIARRHEA,MUSCLE ACHES,COUGHING,INDIGESTION*/
            string[] malaria = new string[] { "2", "4", "5", "7" };/*DIARRHEA,MUSCLE ACHES,COUGHING,JAW PAIN*/
            string[] sepsisAndShock = new string[] { "2", "4", "5", "8" };/*DIARRHEA,MUSCLE ACHES,COUGHING,LIGHTHEADEDNESS*/
            string[] pseudomonas = new string[] { "2", "4", "5", "9" };/*DIARRHEA,MUSCLE ACHES,COUGHING,ANXIETY*/
            string[] drugOverdose = new string[] { "2", "4", "6", "7" };/*DIARRHEA,MUSCLE ACHES,INDIGESTION,JAW PAIN*/
            string[] toxicShockSyndrome = new string[] { "2", "4", "6", "8" };/*DIARRHEA,MUSCLE ACHES,INDIGESTION,LIGHTHEADEDNESS*/
            string[] eosinophiliaMyalgiaSyndrome = new string[] { "2", "4", "6", "9" };/*DIARRHEA,MUSCLE ACHES,INDIGESTION,ANXIETY*/
            string[] sickleCellAnemia = new string[] { "2", "4", "7", "8" };/*DIARRHEA,MUSCLE ACHES,JAW PAIN,LIGHTHEADEDNESS*/
            string[] stressHeadache = new string[] { "2", "4", "7", "9" };/*DIARRHEA,MUSCLE ACHES,JAW PAIN,ANXIETY*/
            string[] bacterialMeningitis = new string[] { "2", "4", "8", "9" };/*DIARRHEA,MUSCLE ACHES,LIGHTHEADEDNESS,ANXIETY*/
            string[] atypicalPneumonia = new string[] { "2", "5", "6", "7" };/*DIARRHEA,COUGHING,INDIGESTIONS,JAW PAIN*/
            string[] pancreaticCancer = new string[] { "2", "5", "6", "8" };/*DIARRHEA,COUGHING,INDIGESTIONS,LIGHTHEADEDNESS*/
            string[] pepticUlcer = new string[] { "2", "5", "6", "9" };/*DIARRHEA,COUGHING,INDIGESTIONS,ANXIETY*/
            string[] thoracicAorticAneurysm = new string[] { "2", "5", "7", "8" };// DIARRHEA,COUGHING,JAW PAIN,LIGHTHEADEDNESS
            string[] endometriosis = new string[] { "2", "5", "7", "9" };// DIARRHEA,COUGHING,JAW PAIN,ANXIETY
            string[] panicDisorder = new string[] { "2", "5", "8", "9" };// DIARRHEA,COUGHING,LIGHTHEADEDNESS,ANXIETY
            string[] visceroptosis = new string[] { "2", "6", "7", "8" };// DIARRHEA,INDIGESTION,JAW PAIN,LIGHTHEADEDNESS
            string[] systemicSclerosis = new string[] { "2", "6", "7", "9" };// DIARRHEA,INDIGESTION,JAW PAIN,ANXIETY
            string[] perniciousAnemia = new string[] { "2", "6", "8", "9" };// DIARRHEA,INDIGESTION,LIGHTHEADEDNESS,ANXIETY
            string[] posturalOrthostaticTachycardiaSyndrome = new string[] { "2", "7", "8", "9" };// DIARRHEA,JAW PAIN,LIGHTHEADEDNESS,ANXIETY
            string[] infectiousMononucleosis = new string[] { "3", "4", "5", "6" };// FATIGUE,MUSCLE ACHES,COUGHING,INDIGESTIONS
            string[] influenza2 = new string[] { "3", "4", "5", "7" };// FATIGUE,MUSCLE ACHES,COUGHING,JAW PAIN
            string[] relapsingFever = new string[] { "3", "4", "5", "8" };// FATIGUE,MUSCLE ACHES,COUGHING,LIGHTHEADEDNESS
            string[] influenza3 = new string[] { "3", "4", "5", "9" };// FATIGUE,MUSCLE ACHES,COUGHING,ANXIETY
            string[] HumanGranulocyticAnaplasmosis = new string[] { "3", "4", "6", "7" };// FATIGUE,MUSCLE ACHES,INDIGESTION,JAW PAIN
            string[] CommonCold = new string[] { "3", "4", "6", "8" };// FATIGUE,MUSCLE ACHES,INDIGESTION,LIGHTHEADEDNESS
            string[] ChronicFatigueSyndrome = new string[] { "3", "4", "6", "9" };// FATIGUE,MUSCLE ACHES,INDIGESTION,ANXIETY
            string[] ToothAbscess = new string[] { "3", "4", "7", "8" };// FATIGUE,MUSCLE ACHES,JAW PAIN,LIGHTHEADEDNESS
            string[] Fibromyalgia = new string[] { "3", "4", "7", "9" };// FATIGUE,MUSCLE ACHES,JAW PAIN,ANXIETY
            string[] AlcoholHangover = new string[] { "3", "4", "8", "9" };// FATIGUE,MUSCLE ACHES,LIGHTHEADEDNESS,ANXIETY
            string[] SJogrensSyndrome = new string[] { "3", "5", "6", "7" };// FATIGUE,COUGHING,INDIGESTION,JAW PAIN
            string[] HeartFailure = new string[] { "3", "5", "6", "8" };// FATIGUE,COUGHING,INDIGESTION,LIGHTHEADEDNESS
            string[] pericarditis2 = new string[] { "3", "5", "6", "9" };// FATIGUE,COUGHING,INDIGESTION,ANXIETY
            string[] cryptococcusNeoformans = new string[] { "3", "5", "7", "8" };// FATIGUE,COUGHING,JAW PAIN,LIGHTHEADEDNESS
            string[] aorticAneurysm2 = new string[] { "3", "5", "7", "9" };// FATIGUE,COUGHING,JAW PAIN,ANXIETY
            string[] brucellosis2 = new string[] { "3", "5", "8", "9" };// FATIGUE,COUGHING,LIGHTHEADEDNESS,ANXIETY
            string[] HeavyMetalIntoxication = new string[] { "3", "6", "7", "8" };// FATIGUE,INDIGESTION,JAW PAIN,LIGHTHEADEDNESS
            string[] cirrhosis = new string[] { "3", "6", "7", "9" };// FATIGUE,INDIGESTION,JAW PAIN,ANXIETY
            string[] GravesDisease = new string[] { "3", "6", "8", "9" };// FATIGUE,INDIGESTION,LIGHTHEADEDNESS,ANXIETY
            string[] concussion = new string[] { "3", "7", "8", "9" };// FATIGUE,JAW PAIN,LIGHTHEADEDNESS,ANXIETY
            string[] TrigeminalNeuralgia = new string[] { "4", "5", "6", "7" };// MUSCLE ACHES,COUGHING,INDIGESTION,JAW PAIN
            string[] CommonCold2 = new string[] { "4", "5", "6", "8" };// MUSCLE ACHES,COUGHING,INDIGESTION,LIGHTHEADEDNESS -
            string[] FlukeInfection = new string[] { "4", "5", "6", "9" };// MUSCLE ACHES,COUGHING,INDIGESTION,ANXIETY - 
            string[] PulmonaryEmbolism = new string[] { "4", "5", "7", "8" };// MUSCLE ACHES,COUGHING,JAW PAIN,LIGHTHEADEDNESS - 
            string[] sinusitis = new string[] { "4", "5", "7", "9" };// MUSCLE ACHES,COUGHING,JAW PAIN,ANXIETY - 
            string[] influenza4 = new string[] { "4", "5", "8", "9" };// MUSCLE ACHES,COUGHING,LIGHTHEADEDNESS,ANXIETY 
            string[] lymeDisease = new string[] { "4", "6", "7", "8" };// MUSCLE ACHES,INDIGESTION,JAW PAIN,LIGHTHEADEDNESS
            string[] toothAbscess = new string[] { "4", "6", "7", "9" };// MUSCLE ACHES,INDIGESTION,JAW PAIN,ANXIETY
            string[] diabeticNeuropathy = new string[] { "4", "6", "8", "9" };// MUSCLE ACHES,INDIGESTION,LIGHTHEADEDNESS,ANXIETY
            string[] generalAnxietyDisorder = new string[] { "4", "6", "7", "8" };// MUSCLE ACHES,JAW PAIN,LIGHTHEADEDNESS,ANXIETY
            string[] bronchitis = new string[] { "5", "6", "7", "8" };// COUGHING,INDIGESTION,JAW PAIN,LIGHTHEADEDNESS
            string[] esophagitis = new string[] { "5", "6", "7", "9" };// COUGHING,INDIGESTION,JAW PAIN,ANXIETY
            string[] gastroesophagealReflux = new string[] { "5", "6", "8", "9" };// COUGHING,INDIGESTION,LIGHTHEADEDNESS,ANXIETY
            string[] asthma = new string[] { "5", "7", "8", "9" };// COUGHING,JAW PAIN,LIGHTHEADEDNESS,ANXIETY
            string[] unstableAngina = new string[] { "6", "7", "8", "9" };// INDIGESTION,JAW PAIN,LIGHTHEADEDNESS,ANXIETY


            int symptomCollector, symptomCollector2, symptomCollector3, symptomCollector4;
            Console.Clear();
            //display header
            Console.WriteLine(header);

            //display date and time
            Console.WriteLine("\nToday is " + DateTime.Now);
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
            Console.Clear();

        menu:
            //name input
            Console.WriteLine(seperator);
            Console.WriteLine(nameInput[new Random().Next(0, nameInput.Length)]);
            Console.WriteLine(seperator);
            name = Console.ReadLine();
            Console.Clear();


            while (true)
            {
                if (name != null && name.Length < 5)
                {//this statement checks if there's a name and it should be greater than 5 characters
                    Console.WriteLine(seperator);
                    Console.WriteLine(nameInput[new Random().Next(0, nameInput.Length)]);
                    Console.WriteLine(seperator);
                    name = Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    break;

                }
            }
            Console.Clear();

            //age input

            Console.WriteLine(seperator);
            Console.WriteLine(ageInput[new Random().Next(0, ageInput.Length)]);
            Console.WriteLine(seperator);
            age = Console.ReadLine();
            Console.Clear();

            while (true)
            {
                if (age == "")
                {
                    Console.WriteLine(seperator);
                    Console.WriteLine(ageInput[new Random().Next(0, ageInput.Length - 1)]);
                    Console.WriteLine(seperator);
                    age = Console.ReadLine();
                    Console.Clear();
                }
                else if (age != "")
                {
                    break;
                }
            }


            //Gender Input
            Console.WriteLine(seperator);
            Console.WriteLine(genderInput[new Random().Next(0, genderInput.Length)]);
            Console.WriteLine(seperator);
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
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine(genderInput[2]);
                    Console.WriteLine(seperator);
                    Console.WriteLine("1. Male");
                    Console.WriteLine("2. Female");
                    gender = Console.ReadLine();


                }
            }


            Console.Clear();
            ArrayList sympt = new ArrayList(9);

            sympt.Add("\n\t1.) Fever");
            sympt.Add("\t2.) Diarrhea");
            sympt.Add("\t3.) Fatigue");
            sympt.Add("\t4.) Muscle aches");
            sympt.Add("\t5.) Coughing");
            sympt.Add("\t6.) indigestion");
            sympt.Add("\t7.) jaw pain");
            sympt.Add("\t8.) lightheadedness");
            sympt.Add("\t9.) anxiety");


            // Console.WriteLine("Please select 4 symptoms but 1 at a time\n");
            Console.WriteLine(seperator);
            Console.WriteLine("List of symptoms");
            Console.WriteLine(seperator);
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
            Console.Clear();
            // sympt.RemoveAt(symptomCollector-1);
            sympt[symptomCollector - 1] = null;
            Console.WriteLine(seperator);
            Console.WriteLine("List of symptoms");
            Console.WriteLine(seperator);
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
            Console.Clear();
            // sympt.RemoveAt(symptomCollector2-1); 
            sympt[symptomCollector2 - 1] = null;
            Console.WriteLine(seperator);
            Console.WriteLine("List of symptoms");
            Console.WriteLine(seperator);
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

            Console.Clear();
            // sympt.RemoveAt(symptomCollector3-1); 
            sympt[symptomCollector3 - 1] = null;
            Console.WriteLine(seperator);
            Console.WriteLine("List of symptoms");
            Console.WriteLine(seperator);
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

            Console.Clear();
            // sympt.RemoveAt(symptomCollector4-1); 
            sympt[symptomCollector4 - 1] = null;
            Console.WriteLine(seperator);
            Console.WriteLine("List of symptoms");
            Console.WriteLine(seperator);
            foreach (string str in sympt)
                Console.WriteLine(str);
            Console.WriteLine("\n");

            string a = Convert.ToString(symptomCollector);
            string b = Convert.ToString(symptomCollector2);
            string c = Convert.ToString(symptomCollector3);
            string d = Convert.ToString(symptomCollector4);
            Console.Clear();

            string results;
            

            

            

            

            if (foodPoisoning.Contains(a) && foodPoisoning.Contains(b)
            && foodPoisoning.Contains(c) && foodPoisoning.Contains(d))
            {
                results = @"
+-----------------------------------------------------+
|               Treatment and Medication              |   
|                    (Food Poison)                    |
+-----------------------------------------------------+
| So your main job is to drink plenty of fluids. Start| 
|with ice chips or small sips if you need to.It’s also|
|helpful to:                                          |
|                                                     |
|   - Avoid food for the first few hours as your      |
|    stomach settles down                             |
| - Drink water, broth, or an electrolyte solution,   |
|    which will replace the minerals that you lose    |
|    with vomiting and diarrhea                       |
|  - Eat when you feel ready, but start with small    |
|    amounts of bland, non fatty foods such as toast, |
|    rice, and crackers                               |
|  - Get plenty of rest                               |
|  - Stay away from dairy,caffeine, alcohol, bubbly   |
|    or fizzy drinks, or spicy and fatty foods --     |
|    they can just make everything worse              |
+-----------------------------------------------------+
            ";

                Console.WriteLine(results);

            }
            else if (crohnsDisease.Contains(a) && crohnsDisease.Contains(b)
            && crohnsDisease.Contains(c) && crohnsDisease.Contains(d))
            {
                results = @"
+-----------------------------------------------------+
|               Treatment and Medication              |
|                  (Crohn's Disease)                  |
+-----------------------------------------------------+
| Along with the medicine your doctor prescribes, you |
|may want to add “complementary” treatments to help   |
|with Crohn’s symptoms, boost your immune system, or  |
|just feel better every day. There are many options   |
|out there, from herbal remedies to mindfulness       |
|practices.  But remember: Let your doctor know about |
|any new therapies you want to try. She can give you  |
|an idea of what’s safe and most likely to help you.  |
|                                                     |
|       - Probiotics                                  |
|       - Prebiotics                                  |
|       - Fish Oils                                   |
|       - Bowel Rest                                  |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (dyspepsia.Contains(a) && dyspepsia.Contains(b)
            && dyspepsia.Contains(c) && dyspepsia.Contains(d))
            {
                results = @"
+-----------------------------------------------------+
|               Treatment and Medication              |
|                     (Dyspepsia)                     |
+-----------------------------------------------------+
| Along with the medicine your doctor prescribes, you |
|may want to add “complementary” treatments to help   |
|with Crohn’s symptoms, boost your immune system, or  |
|just feel better every day. There are many options   |
|out there, from herbal remedies to mindfulness       |
|practices.  But remember: Let your doctor know about |
|any new therapies you want to try. She can give you  |
|an idea of what’s safe and most likely to help you.  |
|                                                     |
|       - Probiotics                                  |
|       - Prebiotics                                  |
|       - Fish Oils                                   |
|       - Bowel Rest                                  |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (whippleDisease.Contains(a) && whippleDisease.Contains(b)
            && whippleDisease.Contains(c) && whippleDisease.Contains(d))
            {

                 results = @"
+-----------------------------------------------------+
|               Treatment and Medication              |
|                  (Whipple Disease)                  |
+-----------------------------------------------------+
|   Treatment of Whipple disease is with antibiotics, |
|either alone or in combination, which can destroy the|
|bacteria causing the infection.                      |
|                                                     |
|                                                     |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (dumpingSyndrome.Contains(a) && dumpingSyndrome.Contains(b)
            && dumpingSyndrome.Contains(c) && dumpingSyndrome.Contains(d))
            {

                results = @"
+-----------------------------------------------------+
|               Treatment and Medication              |
|                  (dumping Syndrome)                 |
+-----------------------------------------------------+
|   Early dumping syndrome is likely to resolve on    |
|its own within three months. In the meantime, there's|
|a good chance that diet changes will ease your       |
|symptoms. If not, your doctor may recommend          |
|medications or surgery.                              |
|                                                     |
|   Medications:                                      |
|                                                     |
|   For people with severe signs and symptoms         |
|unrelieved by dietary changes, doctors sometimes     |
|prescribe octreotide (Sandostatin). This anti-       |
|diarrheal drug, administered by injection under your |
|skin (subcutaneously), can slow the emptying of food |
|into the intestine. Possible side effects include    |
|nausea, vomiting and stomach upset.                  |
|                                                     |
|    Talk with your doctor about the proper way to    |
|self-administer the drug.                            |
|                                                     |
|                                                     |
|                                                     |
|                                                     |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (gad.Contains(a) && gad.Contains(b)
            && gad.Contains(c) && gad.Contains(d))
            {

                results = @"
+-----------------------------------------------------+
|               Treatment and Medication              |
|           (Generalized Anxiety  disorder)           |
+-----------------------------------------------------+
|   Medications:                                      |
|                                                     |
|   Several types of medications are used to treat    |
|generalized anxiety disorder, including those below. |
|Talk with your doctor about benefits, risks and      |
|possible side effects.                               |
|                                                     |
|    - Buspirone. An anti-anxiety medication called   |
|buspirone may be used on an ongoing basis. As with   |
|most antidepressants,it typically takes up to several|
|weeks to become fully effective.                     |
|                                                     |
|    - Benzodiazepines. In limited circumstances, your|
|doctor may prescribe a benzodiazepine for relief of  |
|anxiety symptoms. These sedatives are generally used |
|only for relieving acuteanxiety on a short-term basis|
|Because they can be habit-forming, these medications |
|aren't a good choice if you have or had problems with|
|alcohol or drug abuse.                               |
|                                                     |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (influenza.Contains(a) && influenza.Contains(b)
            && influenza.Contains(c) && influenza.Contains(d))
            {

                results = @"
+-----------------------------------------------------+
|               Treatment and Medication              |
|                     (Influenza)                     |
+-----------------------------------------------------+
|   Medications:                                      |
|                                                     |
|   Usually, you'll need nothing more than bed rest   |
|and plenty of fluids to treat the flu. But in some   |
|cases, your doctor may prescribe an antiviral        |
|medication, such as oseltamivir (Tamiflu) or         |
|zanamivir (Relenza). If taken soon after you notice  |
|symptoms, these drugs may shorten your illness by a  |
|day or so and help prevent serious complications.    | 
|                                                     |
|   Oseltamivir is an oral medication. Zanamivir is   |
|inhaled through a device similar to an asthma inhaler|
|and shouldn't be used by anyone with respiratory     |
|problems, such as asthma and lung disease.           |
|                                                     |
|    Antiviral medication side effects may include    |
|nausea and vomiting. These side effects may be       |
|lessened if the drug is taken with food. Oseltamivir |
|has also been associated with delirium and self-harm |
|behaviors in teenagers.                              |
|                                                     |
|                                                     |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (gastroenteritis.Contains(a) && gastroenteritis.Contains(b)
            && gastroenteritis.Contains(c) && gastroenteritis.Contains(d))
            {

                results = @"
+-----------------------------------------------------+
|               Treatment and Medication              |
|                  (Gastroenteritis)                  |
+-----------------------------------------------------+
|                                                     |
|    Stop eating for a few hours to let your stomach  |
|settle.                                              |
|                                                     |
|    - Sip liquids, such as a sports drink or water,  |
|to prevent dehydration. Drinking fluids too quickly  |
|can worsen the nausea and vomiting, so try to take   |
|small frequent sips over a couple of hours, instead  |
|of drinking a large amount at once.                  |
|                                                     |
|    - Take note of urination. You should be urinating|
|at regular intervals, and your urine should be light |
|and clear. Infrequent passage of dark urine is a sign|
|of dehydration. Dizziness and lightheadedness also   |
|are signs of dehydration. If any of these signs and  |
|symptoms occur and you can't drink enough fluids,    |
|seek medical attention.                              |
|                                                     |
|    - Ease back into eating. Try to eat small amounts|
|of food frequently if you experience nausea.         |
|Otherwise, gradually begin to eat bland, easy to     |
|digest foods, such as soda crackers, toast, gelatin, |
|bananas, rice and chicken. Stop eating if your nausea|
|returns. Avoid milk and dairy products, caffeine,    |
|alcohol, nicotine, and fatty or highly seasoned foods|
|for a few days.                                      |
|                                                     |
|    - Get plenty of rest. The illness and dehydration|
|can make you weak and tired.                         |
|                                                     |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (dengueFever.Contains(a) && dengueFever.Contains(b)
            && dengueFever.Contains(c) && dengueFever.Contains(d))
            {

                results = @"
+-----------------------------------------------------+
|               Treatment and Medication              |
|                   (Dengue Fever)                    |
+-----------------------------------------------------+
|                                                     |
|    No specific treatment for dengue fever exists.   |
|Your doctor may recommend that you drink plenty of   |
|fluids to avoid dehydration from vomiting and a      |
|high fever.                                          |
|                                                     |
|    While recovering from dengue fever, watch for    |
|signs and symptoms of dehydration. Call your doctor  |
|right away if you develop any of the following:      |
|                                                     |
|    - Decreased urination                            |
|    - Few or no tears                                |
|    - Dry mouth or lips                              |
|    - Lethargy or confusion                          |
|    - Cold or clammy extremities                     |
|                                                     |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (flu.Contains(a) && flu.Contains(b)
            && flu.Contains(c) && flu.Contains(d))
            {

                results = @"
+-----------------------------------------------------+
|               Treatment and Medication              |
|                        (Flu)                        |
+-----------------------------------------------------+
|                                                     |
|   Usually, you'll need nothing more than bed rest   |
|and plenty of fluids to treat the flu. But in some   |
|cases, your doctor may prescribe an antiviral        |
|medication, such as oseltamivir (Tamiflu) or zanami- |
|vir (Relenza). If taken soon after you notice        |
|symptoms, these drugs may shorten your illness by a  |
|day or so and help prevent serious complications.    |
|                                                     |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (irritableBowelSyndrome.Contains(a) && irritableBowelSyndrome.Contains(b)
            && irritableBowelSyndrome.Contains(c) && irritableBowelSyndrome.Contains(d))
            {

                results = @"
+-----------------------------------------------------+
|               Treatment and Medication              |
|              (Irritable Bowel Syndrome)             |
+-----------------------------------------------------+
|                                                     |
|   Medications approved for certain people with      |
|IBS include:                                         |
|                                                     |
|   - Rifaximin (Xifaxan). This antibiotic can        |
|decrease bacterial overgrowth and diarrhea.          |
|                                                     |
|    - Lubiprostone (Amitiza). Lubiprostone can       |
|increase fluid secretion in your small intestine to  |
|help with the passage of stool. It's approved for    |
|women who have IBS with constipation, and is         |
|generally prescribed only for women with severe      |
|symptoms that haven't responded to other treatments. |
|                                                     |
|    - Linaclotide (Linzess). Linaclotide also can    |
|increase fluid secretion in your small intestine to  |
|help you pass stool. Linaclotide can cause diarrhea, |
|but taking the medication 30 to 60 minutes before    |
|eating might help.                                   |
|                                                     |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (meningitis.Contains(a) && meningitis.Contains(b)
            && meningitis.Contains(c) && meningitis.Contains(d))
            {

                results = @"
+-----------------------------------------------------+
|              Treatment and Medication               |
|                   (Meningitis)              	      | 
+-----------------------------------------------------+
|                                                     |
| The treatment depends on the type of meningitis you |
|or your child has.                                   |	
|                                                     |
|   Bacterial meningitis:                             |  
|                                                     |
|   *Acute bacterial meningitis must be treated	      |
|immediately with intravenous antibiotics and 	      |
|sometimes corticosteroids. This helps to ensure      |
|recovery and reduce the risk of complications, such  |
|as brain swelling and seizures.	                  |
|                                                     |
|The antibiotic or combination of antibiotics depends |
|on the type of bacteria causing the infection. Your  |
|doctor may recommend a broad-spectrum antibiotic     |
|until he or she can determine the exact cause of the |
|meningitis. Your doctor may drain any infected       |
|sinuses or mastoids	                              |
|                                                     |
|   — the bones behind the outer ear that connects to |
|middle ear.                                          |
|                                                     |
|   *Viral meningitis				                  |
|                                                     | 
|    - Antibiotics cant cure viral meningitis,and most|
|cases improve on their own in several weeks. 	      |				
|Treatment of mild cases of viral meningitis usually  |
|includes:					                          |
|   - Bed rest					                      |
|   - Plenty of fluids				                  |
|   - Over-the-counter pain medications to help reduce|
|fever and relieve body aches			              |
|   - Your doctor may prescribe corticosteroids to    |
|reduce swelling in the brain, and an anticonvulsant  |
|medication to control seizures. If a herpes virus    |
|caused your meningitis, an antiviral medication is   |
|available.					                          |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (gastrointestinal.Contains(a) && gastrointestinal.Contains(b)
            && gastrointestinal.Contains(c) && gastrointestinal.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                  (Gastro Internal)                  | 
+-----------------------------------------------------+
|-Often, GI bleeding stops on its own. If it doesn't, |
|treatment depends on where the bleed is from. In many|
|cases, medication or a procedure to control the      |
|bleeding can be given during some tests. For example,|
|it's sometimes possible to treat a bleeding peptic   |
|ulcer during an upper endoscopy or to remove polyps  |
|during a colonoscopy.				                  |
|-If you have an upper GI bleed, you might be given an|
|IV drug known as a proton pump inhibitor (PPI) to    |
|suppress stomach acid production. Once the source of |
|the bleeding is identified, your doctor will 	      |
|determine whether you need to continue taking a PPI. |
|Depending on the amount of blood loss and whether you|
|continue to bleed, you might require fluids through a|
|needle (IV) and, possibly, blood transfusions. If you|
|take blood-thinning medications, including aspirin or|
|nonsteroidal anti-inflammatory medications, you might|
|need to stop.					                      |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (abdominalPain.Contains(a) && abdominalPain.Contains(b)
            && abdominalPain.Contains(c) && abdominalPain.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                  (Abdominal Pain)                   | 
+-----------------------------------------------------+
|Home Remedies:					                      |
|-You might try a heating pad to ease belly pain.     |
|Chamomile or peppermint tea may help with gas.Be sure|
|to drink plenty of clear fluids so your body has     |
|enough water.					                      |
|						                              |
|You also can do things to make stomach pain less     |
|likely. It can help to:			                  |
|-Eat several smaller meals instead of three big ones |
|-Chew your food slowly and well		              |
|-Stay away from foods that bother you (spicy or fried|
|foods, for example)				                  |
|-Ease stress with exercise, meditation, or yoga      |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (stress.Contains(a) && stress.Contains(b)
            && stress.Contains(c) && stress.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                     (Stress)                        | 
+-----------------------------------------------------+
|Some examples of good ways to deal with stress:      |
|						                              |
|-Take some deep breaths.			                  |
|-Talk to someone you trust.			              |
|-Create a stress diary, note down when you feel      |
|stressed and why.				                      |
|-Have a health check with your doctor.		          |
|-Exercise.					                          |
|-Eat a healthy, balanced diet.			              |
|-Try to avoid smoking, alcohol and caffeine.         |
|-Make time for things you enjoy.		              |
|						                              |
|These are ways to help you bounce back and be more   |
|resilient to stress.				                  |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (lupus.Contains(a) && lupus.Contains(b)
            && lupus.Contains(c) && lupus.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                      (Lupus)                        | 
+-----------------------------------------------------+
|   Treatment for lupus depends on your signs and     |
|symptoms. Determining whether your signs and symptoms|
|should be treated and what medications to use        |
|requires a careful discussion of the benefits and    |
|risks with your doctor.                              |
|                                                     |
|    As your signs and symptoms flare and subside,    |
|you and your doctor may find that you'll need to     |
|change medications or dosages. The medications most  |
|commonly used to control lupus include:              |
|                                                     |
|    - Nonsteroidal anti-inflammatory drugs (NSAIDs). |
|    - Antimalarial drugs                             |
|    - Corticosteroids                                |
|    - Immunosuppressants.                            |
|    - Biologics                                      |
|                                                     |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (pneumonia.Contains(a) && pneumonia.Contains(b)
            && pneumonia.Contains(c) && pneumonia.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                     (Pneumonia)                     | 
+-----------------------------------------------------+
|Treatment for pneumonia involves curing the infection|
|and preventing complications. People who have        |
|community-acquired pneumonia usually can be treated  |
|at home with medication. Although most symptoms ease |
|in a few days or weeks, the feeling of tiredness can |
|persist for a month or more.			              |
|Specific treatment depend on the type and severity of|
|your pneumonia, your age and your overall health. The|
|options include:				                      |
|						                              |
|-Antibiotics. These medicines are used to treat      |
|bacterial pneumonia. It may take time to identify the|
|type of bacteria causing your pneumonia and to choose|
|the best antibiotic to treat it. If your symptoms    |
|don't improve, your doctor may recommend a different |
|antibiotic.					                      |
|-Cough medicine. This medicine may be used to calm   |
|your cough so that you can rest. Because coughing    |
|helps loosen and move fluid from your lungs, it's a  |
|good idea not to eliminate your cough completely. In |
|addition, you should know that very few studies have |
|looked at whether over-the-counter cough medicines   |
|lessen coughing caused by pneumonia. If you want to  |
|try a cough suppressant, use the lowest dose that    |
|helps you rest.				                      |
|-Fever reducers/pain relievers. You may take these as|
|needed for fever and discomfort. These include drugs |
|such as aspirin, ibuprofen (Advil, Motrin IB, others)|
|and acetaminophen (Tylenol, others).                 |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (sinusInfection.Contains(a) && sinusInfection.Contains(b)
            && sinusInfection.Contains(c) && sinusInfection.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                  (Sinus Infection)                  | 
+-----------------------------------------------------+
|Treatments:					                      |
|-Antibiotics					                      |
|  Antibiotics are standard treatments for bacterial  |
|sinus infections.Antibiotics are usually taken from 3| 
|to 28 days, depending on the type of antibiotic.     |
|Because the sinuses are deep-seated in the bones, and|
|blood supply is limited, longer treatments may be    |
|prescribed for people with longer lasting or severe  |
|cases. 					                          |
|-Nasal decongestant sprays			                  |
|  Topical nasal decongestants can be helpful if used |
|for no more than three to four days.These medications|
|shrink swollen nasal passages, facilitating the flow |
|of drainage from the sinuses.Overuse of topical nasal| 
|decongestants can result in a dependent condition in |
|which the nasal passages swell shut, called rebound  |
|phenomenon.					                      |
|-Antihistamines                                      |
|  Antihistamines block inflammation caused by an     |
|allergic reaction so they can help to fight symptoms |
|of allergies that can lead to swollen nasal and sinus|
|passages. 					                          |
|-Nasal decongestants and antihistamines              |
|  Over-the-counter combination drugs should be used  |
|with caution. Some of these drugs contain drying     |
|agents that can thicken mucus. Only use them when    |
|prescribed by your allergist.			              |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (chronicCough.Contains(a) && chronicCough.Contains(b)
            && chronicCough.Contains(c) && chronicCough.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                  (Chronic Cough)                    | 
+-----------------------------------------------------+
|Medications used to treat chronic cough may include: | 
|-Antihistamines, glucocorticoids and decongestants.  |
|These drugs are standard treatment for allergies and |
|postnasal drip.				                      |
|-Inhaled asthma drugs. The most effective treatments |
|for asthma-related cough are glucocorticoids and     |
|bronchodilators, which reduce inflammation and open  |
|up your airways.				                      |
|-Antibiotics.If a bacterial infection is causing your|
|chronic cough, your doctor may prescribe antibiotics.|
|-Acid blockers.When lifestyle changes don't take care|
|of acid reflux, you may be treated with medications  |
|that block acid production. Some people need surgery |
|to resolve the problem.			                  |
|-Cough suppressants. If the reason for your cough    |
|can't be determined and it's causing serious problems|
|for you, such as keeping you from sleeping, your     |
|doctor may prescribe a cough suppressant. However,   |
|there's no evidence that over-the-counter cough      |
|medicines are effective.			                  |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (heartBurn.Contains(a) && heartBurn.Contains(b)
            && heartBurn.Contains(c) && heartBurn.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                    (Heartburn)                      | 
+-----------------------------------------------------+
|  Many over-the-counter medications can help relieve |
|heartburn. The options include:	                  |
|                                                     |
|-Antacids,which help neutralize stomach acid.Antacids|
|may provide quick relief. But they can't heal an     |
|esophagus damaged by stomach acid.	                  |
|                                                     |
|-H-2-receptor antagonists (H2RAs), which can reduce  |
|stomach acid. H2RAs don't act as quickly as antacids,|
|but may provide longer relief.		                  |
|                                                     |
|-Proton pump inhibitors, such as lansoprazole        |
|(Prevacid 24HR) and omeprazole (Nexium 24HR, Prilosec|
|OTC), which also can reduce stomach acid.	          |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (tuberculousMeningitis.Contains(a) && tuberculousMeningitis.Contains(b)
            && tuberculousMeningitis.Contains(c) && tuberculousMeningitis.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|              (Tuberculous Meningitis)               | 
+-----------------------------------------------------+
|  Treatment:					                      |
|The treatment depends on the type of meningitis you  |
|or your child has.				                      |
| 						                              |
|*Bacterial meningitis				                  |
| -Acute bacterial meningitis must be treated 	      |
|immediately with intravenous antibiotics and 	      |
|sometimes corticosteroids. This helps to ensure      |
|recovery and reduce the risk of complications, such  |
|as brain swelling and seizures.		              |
| 						                              |
|The antibiotic or combination of antibiotics depends |
|on the type of bacteria causing the infection. Your  |
|doctor may recommend a broad-spectrum antibiotic     |
|until he or she can determine the exact cause of the |
|meningitis.					                      |
| 						                              |
|Your doctor may drain any infected sinuses or	      |
| mastoids — the bones behind the outer ear that      |
|connect to the middle ear.			                  |
|						                              |
|*Viral meningitis				                      |
| -Antibiotics can't cure viral meningitis, and most  |
|cases improve on their own in several weeks.Treatment|
|of mild cases of viral meningitis usually includes:  |
| 						                              |
|-Bed rest				                              |
|-Plenty of fluids 				                      |
|-Over-the-counter pain medications to help reduce    |
|fever and relieve body aches			              |
|-Your doctor may prescribe corticosteroids to reduce |
|swelling in the brain, and an anticonvulsant 	      |
|medication to control seizures. If a herpes virus    |
|caused your meningitis, an antiviral medication is   |
|available.					                          |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (viralPharyngitis.Contains(a) && viralPharyngitis.Contains(b)
            && viralPharyngitis.Contains(c) && viralPharyngitis.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                (Viral Pharyngitis)                  | 
+-----------------------------------------------------+
| Treatment:					                      |
|-There is no specific treatment for viral pharyngitis|
|You can relieve symptoms by gargling with warm salt  |
|water several times a day (use one half teaspoon or 3|
|grams of salt in a glass of warm water). Taking      |
|anti-inflammatory medicine, such as acetaminophen,can| 
|control fever. Excessive use of anti-inflammatory    |
|lozenges or sprays may make a sore throat worse.     |
|						                              |
|-It is important NOT to take antibiotics when a sore |
|throat is due to a viral infection. The antibiotics  |
|will not help. Using them to treat viral infections  |
|helps bacteria become resistant to antibiotics.      |
|						                              |
|-With some sore throats (such as those caused by     |
|infectious mononucleosis),the lymph nodes in the neck|
|may become very swollen. Your provider may prescribe |
|anti-inflammatory drugs, such as prednisone, to treat|
|them.						                          |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (vertigo.Contains(a) && vertigo.Contains(b)
            && vertigo.Contains(c) && vertigo.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                    (Vertigo)                        | 
+-----------------------------------------------------+
| Medications:					                      |
|*Water pills. If you have Meniere's disease, your    |
|doctor may prescribe a water pill (diuretic). This   |
|along with a low-salt diet may help reduce how often |
|you have dizziness episodes.			              |
|*Medications that relieve dizziness and nausea. Your |  
|doctor may prescribe drugs to provide immediate      |
|relief from vertigo, dizziness and nausea, including |
|prescription antihistamines and anticholergenics.Many|
|of these drugs cause drowsiness.		              |
|*Anti-anxiety medications. Diazepam (Valium) and     |
|alprazolam (Xanax) are in a class of drugs called    |
|benzodiazepines, which may cause addiction. They may |
|also cause drowsiness.				                  |
|*Preventive medicine for migraine. Certain medicines |
|may help prevent migraine attacks.		              |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (laryngitis.Contains(a) && laryngitis.Contains(b)
            && laryngitis.Contains(c) && laryngitis.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                   (Laryngitis)                      | 
+-----------------------------------------------------+
| Treatment:					                      |
|-Acute laryngitis often gets better on its own within|
|a week or so. Self-care measures also can help       |
|improve symptoms.				                      |
|						                              |
|-Chronic laryngitis treatments are aimed at treating |
|the underlying causes, such as heartburn, smoking or |
|excessive use of alcohol.			                  |
|						                              |
|Medications used in some cases include:	          |
|						                              |
|*Antibiotics. In almost all cases of laryngitis, an  |
|antibiotic won't do any good because the cause is    |
|usually viral. But if you have a bacterial infection,|
|your doctor may recommend an antibiotic.	          |
|*Corticosteroids. Sometimes, corticosteroids can help|
|reduce vocal cord inflammation.However,this treatment|
|is used only when there's an urgent need to treat    |
|laryngitis — for example, when you need to use your  |
|voice to sing or give a speech or oral presentation, |
|or in some cases when a toddler has laryngitis       |
|associated with croup.				                  |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (colds.Contains(a) && colds.Contains(b)
            && colds.Contains(c) && colds.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                     (Colds)                         | 
+-----------------------------------------------------+
|			                                          |
|If you catch a cold,you can expect to be sick for one|
|to two weeks. That doesn't mean you have to be	      |
|miserable. Besides getting enough rest, these 	      |
|remedies might help you feel better:		          |
|						                              |
|*Stay hydrated. Water, juice, clear broth or warm    |
|lemon water with honey helps loosen congestion and   |
|prevents dehydration. Avoid alcohol, coffee and      |
|caffeinated sodas, which can make dehydration worse. |
|*Rest.Your body needs to heal.			              |
|*Soothe a sore throat. A saltwater gargle — 1/4 to   |
|1/2 teaspoon salt dissolved in an 8-ounce glass of   |
|warm water — can temporarily relieve a sore or       |
|scratchy throat. Children younger than 6 years are   |
|unlikely to be able to gargle properly.              |
|				                                      |
|*Relieve pain. For children 6 months or younger, give|
|only acetaminophen. For children older than 6 months,|
|give either acetaminophen or ibuprofen. Ask your     |
|child's doctor for the correct dose for your child's |
|age and weight. Adults can take acetaminophen        |
|(Tylenol, others), ibuprofen 			              |
|(Advil, Motrin IB, others) or aspirin.		          |
|						                              |
|Use caution when giving aspirin to children or	      |
|teenagers. Though aspirin is approved for use in     |
|children older than age 3, children and teenagers    |
|recovering from chickenpox or flu-like symptoms      |
|should never take aspirin.This is because aspirin has|
|been linked to Reye's syndrome,a rare but potentially|
|life-threatening condition, in such children.        |
|						                              |
|*Sip warm liquids. A cold remedy used in many        |
|cultures, taking in warm liquids, such as chicken    |
|soup, tea or warm apple juice, might be soothing and |
|might ease congestion by increasing mucus flow.      |
|*Add moisture to the air. A cool-mist vaporizer or   |
|humidifier can add moisture to your home, which might|
|help loosen congestion. Change the water daily, and  |
|clean the unit according to the manufacturer's       |
|instructions.                                        |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (anxietyCough.Contains(a) && anxietyCough.Contains(b)
            && anxietyCough.Contains(c) && anxietyCough.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                  (Anxiety Cough)                    | 
+-----------------------------------------------------+
| Treatment:					                      |
|*Learn to deep breathe. This is essentially a        |
|relaxation exercise. Breathe in slowly through your  |
|nose for about five seconds. Hold your breath for two|
|seconds. Breathe out through your mouth for at least |
|seven seconds. Do this multiple times every day.     |
|*Learn to think differently.Rather than allowing your|
|thoughts to stay on anxious things, list several     |
|positive things you can think about. When you feel   |
|anxious, pull out the list and think about one of the|
|positive things.				                      |
+-----------------------------------------------------+
            ";
                Console.WriteLine(results);

            }
            else if (heartAttack.Contains(a) && heartAttack.Contains(b)
            && heartAttack.Contains(c) && heartAttack.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                  (Heart Attack)                     | 
+-----------------------------------------------------+
| **What to do if you or someone else may be having a |
|     heart attack?**				                  |
|- Call 911 or your local medical emergency number.   |
|Don't ignore or attempt to tough out the symptoms of |
|a heart attack for more than five minutes. If you    |
|don't have access to emergency medical services, have|
|a neighbor or a friend drive you to the nearest      |
|hospital. Drive yourself only as a last resort, and  |
|realize that it places you and others at risk when   |
|you drive under these circumstances.		          |
|- Chew and swallow an aspirin,unless you are allergic|
|to aspirin or have been told by your doctor never to |
|take aspirin. But seek emergency help first, such as |
|calling 911.					                      |
|- Take nitroglycerin, if prescribed. If you think    |
|you're having a heart attack and your doctor has     |
|previously prescribed nitroglycerin for you, take it |
|as directed. Do not take anyone else's nitroglycerin,|
|because that could put you in more danger.	          |
|- Begin CPR if the person is unconscious. If you're  |
|with a person who might be having a heart attack and |
|he or she is unconscious, tell the 911 dispatcher or |
|another emergency medical specialist. You may be     |
|advised to begin cardiopulmonary resuscitation (CPR).|  
+-----------------------------------------------------+
";
                Console.WriteLine(results);

            }
            else if (acidReflux.Contains(a) && acidReflux.Contains(b)
           && acidReflux.Contains(c) && acidReflux.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                  (Acid Reflux)                      | 
+-----------------------------------------------------+
| -- One of the most effective ways to treat acid     |
|reflux disease is to avoid the foods and beverages   |
|that trigger symptoms. Here are other steps you can  |
|take:						                          |
|						                              |
|*Eat smaller meals more frequently throughout the day|
|and modify the types of foods you are eating..       |
|*Quit smoking.					                      |
|*Put blocks under the head of your bed to raise it at|
|least 4 inches to 6 inches.			              |
|*Eat at least 2 to 3 hours before lying down.        |
|*Try sleeping in a chair for daytime naps.           |
|*Don't wear tight clothes or tight belts.            |
|*If you're overweight or obese, take steps to lose   |
|weight with exercise and diet changes.               |
|*Also, ask your doctor whether any medication could  |
|be triggering your heartburn or other symptoms of    |
|acid reflux disease.				                  |
+-----------------------------------------------------+
";
                Console.WriteLine(results);

            }
            else if (GERD.Contains(a) && GERD.Contains(b)
          && GERD.Contains(c) && GERD.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|          (Gastroesophageal reflux disease)          | 
+-----------------------------------------------------+
| Treatment:					                      |
|- GERD will often be treated with medications before |
|attempting other lines of treatment.                 |
| 						                              |
|- Proton pump inhibitors are one of the main         |
|pharmaceutical treatment options for people with GERD|
|.They decrease the amount of acid produced by the    |
|stomach.					                          |
|						                              |
|Other options include:				                  |
| 					                                  |
|*H2 blockers: These are another option to help	      |
|decrease acid production.			                  |
|*Antacids: These counteract the acid in the stomach  |
|with alkaline chemicals. Side effects can include    |
|diarrhea and constipation. Antacids are available to |
|purchase online.                                     |
|*Prokinetics: These help the stomach empty faster.   |
|Side effects include diarrhea, nausea, and anxiety.  |
|*Erythromycin: Ths is a type of antibiotic that also |
|helps empty the stomach.			                  |
+-----------------------------------------------------+
";
                Console.WriteLine(results);

            }
            else if (depression.Contains(a) && depression.Contains(b)
         && depression.Contains(c) && depression.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                   (Depression)                      | 
+-----------------------------------------------------+
|         -- Depression treatment tips --             |
|*Learn as much as you can about your depression.     |
|It’s important to determine whether your depression  |
|symptoms are due to an underlying medical condition. | 
|If so, that condition will need to be treated first. |
|						                              |
|*It takes time to find the right treatment. It might |
|take some trial and error to find the treatment and  |
|support that works best for you.                     |
|						                              |
|*Don’t rely on medications alone. Although medication| 
|can relieve the symptoms of depression, it is not    |
|usually suitable for long-term use. Other treatments,|
|including exercise and therapy, can be just as       |
|effective as medication, often even more so,but don’t|
|come with unwanted side effects. If you do decide to |
|try medication, remember that medication works best  |
|when you make healthy lifestyle changes as well.     |
|						                              |
|*Get social support. The more you cultivate your     |
|social connections, the more protected you are from  |
|depression. If you are feeling stuck, don’t hesitate |
|to talk to trusted family members or friends, or seek|
|out new connections at a depression support group.   |
|						                              |
|*Treatment takes time and commitment. All of these   |
|depression treatments take time, and sometimes it    |
|might feel overwhelming or frustratingly slow.That is| 
|normal. Recovery usually has its ups and downs.      |
+-----------------------------------------------------+
";
                Console.WriteLine(results);

            }
            else if (pericarditis.Contains(a) && pericarditis.Contains(b)
        && pericarditis.Contains(c) && pericarditis.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                   (Pericarditis)                    | 
+-----------------------------------------------------+
|        -- Specific Types of Treatment --	          |
|*First, your doctor may advise you to rest until you |
|feel better and have no fever. He or she may tell you|
|to take over-the-counter, anti-inflammatory medicines|
|to reduce pain and inflammation. Examples of these   |
|medicines are aspirin and ibuprofen.		          |
|                                                     |
|*Stronger medicine may be needed if the pain is      |
|severe. Your doctor may prescribe a medicine called  |
|colchicine and a steroid called prednisone.	      |
| 						                              |
|*If an infection is causing your pericarditis, your  |
|doctor will prescribe an antibiotic or other medicine|
|.You may need to stay in the hospital during 	      |
|treatment so your doctor can check you for 	      |
|complications.Symptoms of acute pericarditis can last| 
|from a few days to three weeks. Chronic pericarditis |
|may last several months.			                  |
+-----------------------------------------------------+
";
                Console.WriteLine(results);

            }
            else if (aorticAneurysm.Contains(a) && aorticAneurysm.Contains(b)
       && aorticAneurysm.Contains(c) && aorticAneurysm.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                 (Aortic Aneurysm)                   | 
+-----------------------------------------------------+
|                  -- Treatment --		              |
|- The goal of treatment — either medical monitoring  |
|or surgery is to prevent your aneurysm from rupturing| 
|						                              |
|*Medical monitoring                                  |
| - Your doctor might recommend this option if your   |
|abdominal aortic aneurysm is small and you don't have|
|symptoms.You'll have regular appointments to check if|
|your aneurysm is growing, treatment to manage other  |
|medical conditions, such as high blood pressure, that|
|could worsen your aneurysm.			              |
|						                              |
|*Surgery					                          |
|- Repair is generally recommended if your aneurysm is|
|1.9 to 2.2 inches (4.8 to 5.6 centimeters) or larger |
|or if it's growing quickly. Also, your doctor might  |
|recommend surgery if you have symptom such as stomach|
|pain or you have a leaking,tender or painful aneurysm|
|						                              |
| -- Depending on several factors, including location |
|and size of the aneurysm, your age, and other        |
|conditions you have, repair options might include:   |
|						                              |
|*Open abdominal surgery. This involves removing the  |
|damaged section of the aorta and replacing it with a |
|synthetic tube (graft), which is sewn into place.Full|
|recovery is likely to take a month or more.	      |
|*Endovascular repair. This less invasive procedure is|
|used more often. Doctors attach a synthetic graft to |
|the end of a thin tube (catheter) that's inserted    |
|through an artery in your leg and threaded into your |
|aorta.						                          |
|						                              |
|(Long-term survival rates are similar for both       |
|endovascular surgery and open surgery).              |
+-----------------------------------------------------+
";
                Console.WriteLine(results);

            }
            else if (brucellosis.Contains(a) && brucellosis.Contains(b)
      && brucellosis.Contains(c) && brucellosis.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                   (Brucellosis)                     | 
+-----------------------------------------------------+
|       -- How Is Brucellosis Treated? --	          |
|- Brucellosis can be difficult to treat. If you have |
|brucellosis, your doctor will prescribe antibiotics. |
|Antibiotics commonly used to treat brucellosis       |
|include:					                          |
|					                                  |
|*doxycycline (Acticlate, Monodox, Vibra-Tabs, 	      |
|Vibramycin)					                      |
|*streptomycin					                      |
|*ciprofloxacin (Cipro) or ofloxacin (Floxin)	      |
|*rifampin (Rifadin, Rimactane)			              |
|*sulfamethoxazole/trimethoprim (Bactrim)	          |  
|*tetracycline (Sumycin)			                  |
|						                              |
|- You will generally be given doxycycline and	      |
|rifampin a in combination for 6-8 weeks.	          |
|						                              |
|- You must take the antibiotics for many weeks to    | 
|prevent the disease from returning.  The rate of     |
|relapse following treatment is about 5-15% and       |
|usually occurs within the first six months after     |
|treatment. 					                      |
|						                              |
|- Recovery can take weeks, even months. Patients who |
|receive treatment within one month of the start of   |
|symptomscan be cured of the disease.                 |
+-----------------------------------------------------+
";
                Console.WriteLine(results);

            }
            else if (flukeInfection.Contains(a) && flukeInfection.Contains(b)
     && flukeInfection.Contains(c) && flukeInfection.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|                 (Fluke Infection)                   | 
+-----------------------------------------------------+
|                  -- Treatments --		              |
|*A medication called triclabendazole is commonly used|
|to treat a liver fluke infection, as this effectively|
|kills the liver flukes and their eggs.		          |
|						                              |
|*Other drugs, such as pain relievers, may be used to |
|treat some of the symptoms such as pain and diarrhea.|
|						                              |
|*Surgery may be necessary in rare cases where        |
|cholangitis, an infection of the bile ducts in the   |
|liver, has developed.				                  |
+-----------------------------------------------------+
";
                Console.WriteLine(results);

            }
            else if (irritablebowelsyndrome.Contains(a) && irritablebowelsyndrome.Contains(b)
    && irritablebowelsyndrome.Contains(c) && irritablebowelsyndrome.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|              Treatment and Medication               |
|             (Irritable Bowel Syndrome)              |
+-----------------------------------------------------+
|                                                     |
|   Avoid foods that trigger your symptoms            |
|   Eat high-fiber foods                              |
|   Drink plenty of fluids                            |
|   Exercise regularly                                |
|   Get enough sleep                                  |
|   Your doctor might suggest that you eliminate      |
| from your diet                                      |
|   A dietitian can help you with these diet changes  |
|                                                     |
|   Fiber supplements                                 |
|   Laxatives                                         |
|   Anti-diarrheal medications                        |
+-----------------------------------------------------+
";
                Console.WriteLine(results);

            }
            else if (panicAttack.Contains(a) && panicAttack.Contains(b)
   && panicAttack.Contains(c) && panicAttack.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|               Treatment and Medication              |
|                   (Panic Attack)                    |
+-----------------------------------------------------+
|    If one medication doesn't work well for you, your| 
|doctor may recommend switching to another or         |
|combining certain medications to boost effectiveness.|
|Keep in mind that it can take several weeks after    |
|first starting a medication to notice an improvement |
|in symptoms.                                         |
|                                                     |
|    All medications have a risk of side effects, and |
|some may not be recommended in certain situations,   |
|such as pregnancy. Talk with your doctor about       |
|possible side effects and risks.                     |
|                                                     |
|    Benzodiazepines                                  |
|    Serotonin and norepinephrine reuptake inhibitors |
|    Selective serotonin reuptake inhibitors          |
|                                                     |
+-----------------------------------------------------+
";
                Console.WriteLine(results);

            }
            else if (chronicFatigueSyndrome.Contains(a) && chronicFatigueSyndrome.Contains(b)
  && chronicFatigueSyndrome.Contains(c) && chronicFatigueSyndrome.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|               Treatment and Medication              |
|              (Chronic Fatigue Syndrome)             |
+-----------------------------------------------------+
|    Cognitive training. Talking with a counselor can |
|help you figure out options to work around some of   |
|the limitations that chronic fatigue syndrome imposes|
|on you. Feeling more in control of your life can     |
|improve your outlook dramatically.                   |
|                                                     |
|    Graded exercise. A physical therapist can help   |
|determine what exercises are best for you. Inactive  |
|people often begin with range-of-motion and          |
|stretching exercises for just a few minutes a day.   |
|Gradually increasing the intensity of your exercise  |
|over time may help reduce your hypersensitivity to   |
|exercise, just like allergy shots gradually reduce   |
|a person's hypersensitivity to a particular allergen.|
|                                                     |
+-----------------------------------------------------+
";
                Console.WriteLine(results);

            }
            else if (viralHepatitis.Contains(a) && viralHepatitis.Contains(b)
 && viralHepatitis.Contains(c) && viralHepatitis.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|               Treatment and Medication              |
|                   (Viral Hepatitis)                 |
+-----------------------------------------------------+
|    No specific treatment exists for hepatitis A.    |
|Your body will clear the hepatitis A virus on its    |
|own. In most cases of hepatitis A, the liver heals   |
|within six months with no lasting damage.            |
|                                                     |
|    Hepatitis A treatment usually focuses on keeping |
|comfortable and controlling signs and symptoms.      |
|You may need to:                                     |
|                                                     |
|    - Rest.                                          |
|                                                     |
|    Many people with hepatitis A infection feel tired|
|and sick and have less energy.                       |
|                                                     |
|                                                     |
|    - Manage nausea                                  |
|    - Avoid alcohol and use medications with care    |
+-----------------------------------------------------+
";
                Console.WriteLine(results);

            }
            else if (cholera.Contains(a) && cholera.Contains(b)
&& cholera.Contains(c) && cholera.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|               Treatment and Medication              |
|                      (Cholera)                      |
+-----------------------------------------------------+
|    Cholera requires immediate treatment because the |
|disease can cause death within hours.                |
|                                                     |
|    - Rehydration. The goal is to replace lost fluids|
|and electrolytes using a simple rehydration solution,|
|oral rehydration salts (ORS). The ORS solution is    |
|available as a powder that can be reconstituted in   |
|boiled or bottled water. Without rehydration,        |
|approximately half the people with cholera die. With |
|treatment, the number of fatalities drops to less    |
|than 1 percent.                                      |
|                                                     |
|   - Intravenous fluids. During a cholera epidemic,  |
|most people can be helped by oral rehydration alone, |
|but severely dehydrated people may also need         |
|intravenous fluids.                                  |
|                                                     |
|    - Antibiotics. While antibiotics are not a       |
|necessary part of cholera treatment, some of these   |
|drugs may reduce both the amount and duration of     |
|cholera-related diarrhea for people who are severely |
|ill.                                                 |
|                                                     |
|    - Zinc supplements. Research has shown that zinc |
|may decrease and shorten the duration of diarrhea in |
|children with cholera.                               |
|                                                     |
+-----------------------------------------------------+
";
                Console.WriteLine(results);

            }
            else if (strongyloidiasis.Contains(a) && strongyloidiasis.Contains(b)
&& strongyloidiasis.Contains(c) && strongyloidiasis.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|               Treatment and Medication              |
|                  (strongyloidiasis)                 |
+-----------------------------------------------------+
|    The initial sign of acute strongyloidiasis, if   |
|noticed at all, is a localized pruritic, erythematous|
|rash at the site of skin penetration. Patients may   |
|then develop tracheal irritation and a dry cough as  |
|the larvae migrate from the lungs up through the     |
|trachea. After the larvae are swallowed into the     |
|gastrointestinal tract, patients may experience      |
|diarrhea, constipation, abdominal pain, and anorexia.|
|                                                     |
|NO CURE!                                             |
|                                                     |
+-----------------------------------------------------+
";
                Console.WriteLine(results);

            }
            else if (malaria.Contains(a) && malaria.Contains(b)
&& malaria.Contains(c) && malaria.Contains(d))
            {

                results = @"

+-----------------------------------------------------+
|               Treatment and Medication              |
|                      (Malaria)                      |
+-----------------------------------------------------+
|                                                     |
|    The most common antimalarial drugs include:      |
|                                                     |
|    - Artemisinin-based combination therapies (ACTs).|
|ACTs are, in many cases, the first line treatment for|
|malaria. There are several different types of ACTs.  |
|Examples include artemether-lumefantrine (Coartem)   |
|and artesunate-amodiaquine. Each ACT is a combination|
|of two or more drugs that work against the malaria   |
|parasite in different ways.                          |
|                                                     |
|    - Chloroquine phosphate. Chloroquine is the      |
|preferred treatment for any parasite thats sensitive |
|to the drug. But in many parts of the world, the     |
|parasites that cause malaria are resistant to        |
|chloroquine, and the drug is no longer an effective  |
|treatment.                                           |
|                                                     |
|                                                     |
|                                                     |
+-----------------------------------------------------+
";
                Console.WriteLine(results);

            }//next disease pls


            Console.WriteLine("Please Enter to Continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(seperator);
            Console.WriteLine("Press M to go back to menu and Q to quit");
            Console.WriteLine(seperator);
            string optMenu = Console.ReadLine();
            Console.Clear();

            while (true)
            {
                if (optMenu == "M" || optMenu == "m")
                {
                    goto menu;
                }
                else if (optMenu == "Q" || optMenu == "q")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(seperator);
                    Console.WriteLine("Press M to go back to menu and Q to quit");
                    Console.WriteLine(seperator);
                    optMenu = Console.ReadLine();
                }
            }

        }
    }
}
