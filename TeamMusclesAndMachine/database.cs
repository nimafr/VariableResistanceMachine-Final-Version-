using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace TeamMusclesAndMachine
{
    class database
    {
        private string folderName = @"c:\Exercise Machine\Database\";
        private static string users_filename = "users_data.txt";
        public static List<String> user_names = new List<string>();
        public static List<int> user_ids = new List<int>();
        public static List<String> workout_names = new List<string>();
        public static List<String> timers = new List<string>();
        public static List<String> reps = new List<string>();
        public static List<String> max_forces = new List<string>();
        public static List<String> avg_forces = new List<string>();
        public static List<String> body_groups = new List<string>();

        ArrayList workout_dates = new ArrayList();
        /* workout_dates.Add("2018-5-19");
             workout_dates.Add("2018-5-20");
             workout_dates.Add("2018-5-21");*/
        static void Main()
        {


        }

        public void Input_userdata(String name)
        {
            int id = 0;
            bool check = true;
            if (user_names.Count != 0)
            {
                store_user_ids();
                while (check == true)
                {
                    if (user_ids.Contains(id) == false)
                    {
                        break;
                    }
                    id++;
                }
            }

            String write = name + "," + id;             //declare string to input

            if (!File.Exists(folderName + users_filename))
            {
                // try
                //  {
                System.IO.Directory.CreateDirectory(folderName + id + @"\");


                StreamWriter sw = File.CreateText(folderName + users_filename);
                sw.WriteLine(write);

                sw.Close();
            }

            else
            {
                System.IO.Directory.CreateDirectory(folderName + id + @"\");
                using (StreamWriter sw = File.AppendText(folderName + users_filename))
                {
                    sw.WriteLine(write);
                    sw.Close();
                }
            }

        }

        public void get_users()
        {
            String line;
            user_names.Clear();

            try
            {
                StreamReader sr = new StreamReader(folderName + users_filename);

                while ((line = sr.ReadLine()) != null)
                {
                    String[] var = line.Split(',');
                    Console.WriteLine(var.ToString());
                    user_names.Add(var[0]);
                    //line = sr.ReadLine(); /
                }

                sr.Close();
                Console.ReadLine();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void delete_user(int i)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(folderName + users_filename); //open temp file 

                while ((line = sr.ReadLine()) != null)
                {
                    String[] var = line.Split(',');
                    if (!var[0].Equals(user_names[i]))
                    {
                        StreamWriter sw = new StreamWriter(folderName + "temp_file.txt", append: true);
                        sw.WriteLine(line);
                        sw.Close();
                    }
                    else
                    {
                        int uid = get_user_id(user_names[i]);
                        Directory.Delete(folderName + uid + @"\", true);
                        get_users();
                        if (user_names.Count == 1)
                        {
                            sr.Close();
                            File.Delete(folderName + users_filename);
                            break;
                        }
                    }

                }

                sr.Close();
                Console.ReadLine();

                // System.IO.File.Move("D:\\temp_file.txt", "D:\\users_data.txt"); //Rename temp file to original file name
                File.Replace(folderName + "temp_file.txt", folderName + "users_data.txt", folderName + "temp_file2.txt", false);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public string return_username(int i)
        {
            return user_names[i];
        }
        public List<String> return_userlist()
        {
            return user_names;
        }
        public int get_user_id(String name)
        {
            String line;
            int id = 0;
            try
            {
                StreamReader sr = new StreamReader(folderName + users_filename); //open temp file 

                while ((line = sr.ReadLine()) != null)
                {
                    String[] var = line.Split(',');
                    if (var[0].Equals(name))
                    {
                        id = Int32.Parse(var[1]);
                        break;
                    }

                }
                sr.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return id;
        }

        public void store_user_ids()
        {
            String line;
            user_ids.Clear();
            try
            {
                StreamReader sr = new StreamReader(folderName + users_filename); //open temp file 

                while ((line = sr.ReadLine()) != null)
                {
                    String[] var = line.Split(',');
                    user_ids.Add(Int32.Parse(var[1]));
                }
                sr.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void add_workout(String Username, int UserID, String Workout, int wID, String bGroup, int actuator_Start, int actuator_End)
        {
            String User_ID = UserID.ToString();
            String aStart = actuator_Start.ToString();
            String aEnd = actuator_End.ToString();
            String workout_Selection = "workout_selection.txt";

            //String fLine = Username + User_ID;

            //Random r = new Random();
            //var x = r.Next(100, 999);
            //String id = x.ToString();
            //String wID = bGroup + id;

            String write = Workout + "," + wID + "," + bGroup + "," + aStart + "," + aEnd;

           /* if (!File.Exists(folderName + UserID + @"\" + workout_Selection))
            {

                //System.IO.Directory.CreateDirectory(folderName);

                StreamWriter sw = File.CreateText(folderName + UserID + @"\" + workout_Selection);
                //sw.WriteLine(fLine);
                sw.WriteLine(write);
                sw.Close();

            }
            else
            {*/
                using (StreamWriter sw = File.AppendText(folderName + UserID + @"\" + workout_Selection))
                {
                    sw.WriteLine(write);
                    sw.Close();
                }
            //}
            //return wID;
        }
        public void create_default_workouts(int UserID)
        {
            String User_ID = UserID.ToString();
            String workout_Selection = "workout_selection.txt";

                StreamWriter sw = File.CreateText(folderName + UserID + @"\" + workout_Selection);
                sw.WriteLine("Seated Lat Pull Downs,0,BACK,10,102");
                sw.WriteLine("Seated Rows,1,BACK,0,0");
                sw.WriteLine("Bent Over Rows,2,BACK,0,0");
                sw.WriteLine("Bench Press,3,CHEST,0,0");
                sw.WriteLine("Inclined Press,4,CHEST,0,0");
                sw.WriteLine("Bench Cable Flys,5,CHEST,0,0");
                sw.WriteLine("Biceps Curl,6,BICEPS,0,0");
                sw.WriteLine("Hammer Curl,7,BICEPS,0,0");
                sw.WriteLine("Bent Over Lateral Raise,8,DELTOIDS,0,0");
                sw.WriteLine("Shrug,9,DELTOIDS,0,0");
                sw.WriteLine("Scaption,10,DELTOIDS,0,0");
                sw.WriteLine("Bent Over Rows,11,TRICEPS,0,0");
                sw.WriteLine("Triceps Push Down,12,TRICEPS,0,0");
                sw.WriteLine("Upright,13,TRICEPS,0,0");
                sw.WriteLine("Belt Squat,14,LEGS,0,0");
                sw.WriteLine("Deadlift,15,LEGS,0,0");
                sw.Close();
        }

        public void Input_wHistory(String Username, int UserID, String timer, String wID, int total_Reps, int max_force, int avg_force)
        {

            String Reps = total_Reps.ToString();
            String Max = max_force.ToString();
            String Avg = avg_force.ToString();

            String workout_History = "workout_history.txt";


            DateTime today = DateTime.Today;
            String write = today.ToString("d") + "," + timer + "," + wID + "," + Reps + "," + Max + "," + Avg;

            if (!File.Exists(folderName + UserID + @"\" + workout_History))
            {


                StreamWriter sw = File.CreateText(folderName + UserID + @"\" + workout_History);
                sw.WriteLine(write);
                sw.Close();

            }
            else
            {
                using (StreamWriter sw = File.AppendText(folderName + UserID + @"\" + workout_History))
                {
                    sw.WriteLine(write);
                    sw.Close();
                }
            }

        }

        public List<String> get_workout_names(int UserID)
        {
            String line;
            workout_names.Clear();

            try
            {
                StreamReader sr = new StreamReader(folderName + UserID + @"\" + "workout_selection.txt");

                while ((line = sr.ReadLine()) != null)
                {
                    String[] var = line.Split(',');
                    workout_names.Add(var[0]);
                }

                sr.Close();
                Console.ReadLine();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return workout_names;
        }
        public int get_start(int UserID, int WorkID)
        {
            String line;
            int start = 0;
            try
            {
                StreamReader sr = new StreamReader(folderName + UserID + @"\" + "workout_selection.txt");

                while ((line = sr.ReadLine()) != null)
                {
                    String[] var = line.Split(',');
                    if (WorkID == Int32.Parse(var[1]))
                    {
                        start = Int32.Parse(var[3]);
                        break;
                    }

                }

                sr.Close();
                Console.ReadLine();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return start;
        }
        public int get_end(int UserID, int WorkID)
        {
            String line;
            int end = 0;
            try
            {
                StreamReader sr = new StreamReader(folderName + UserID + @"\" + "workout_selection.txt");

                while ((line = sr.ReadLine()) != null)
                {
                    String[] var = line.Split(',');
                    if (WorkID == Int32.Parse(var[1]))
                    {
                        end = Int32.Parse(var[4]);
                        break;
                    }
                }

                sr.Close();
                Console.ReadLine();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return end;
        }
        public void get_workout_history(int UserID, int WorkID, String Date)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(folderName + UserID + @"\" + "workout_history.txt");

                while ((line = sr.ReadLine()) != null)
                {
                    String[] var = line.Split(',');
                    if (WorkID == Int32.Parse(var[2]))
                    {
                        timers.Add(var[1]);
                        reps.Add(var[3]);
                        max_forces.Add(var[4]);
                        avg_forces.Add(var[5]);
                    }
                }

                sr.Close();
                Console.ReadLine();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public List<String> get_workout_bodygroups(int UserID)
        {
            String line;
            body_groups.Clear();

            try
            {
                StreamReader sr = new StreamReader(folderName + UserID + @"\" + "workout_selection.txt");

                while ((line = sr.ReadLine()) != null)
                {
                    String[] var = line.Split(',');
                    body_groups.Add(var[2]);
                }

                sr.Close();
                Console.ReadLine();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return body_groups;
        }

        public void delete_workout(int UserID, int WorkID)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(folderName + UserID + @"\" + "workout_selection.txt"); //open temp file 

                while ((line = sr.ReadLine()) != null)
                {
                    String[] var = line.Split(',');
                    if (!var[1].Equals(WorkID.ToString()))
                    {
                        StreamWriter sw = new StreamWriter(folderName + UserID + @"\" + "temp_file.txt", append: true);
                        sw.WriteLine(line);
                        sw.Close();
                    }
                }

                sr.Close();

                // System.IO.File.Move("D:\\temp_file.txt", "D:\\users_data.txt"); //Rename temp file to original file name
               File.Replace(folderName+ UserID + @"\"+ "temp_file.txt", folderName + UserID + @"\" + "workout_selection.txt", folderName + UserID + @"\" + "temp_file2.txt", false);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public void edit_workout(String New_name,int UserID, int WorkID)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(folderName + UserID + @"\" + "workout_selection.txt"); //open temp file 

                while ((line = sr.ReadLine()) != null)
                {
                    String[] var = line.Split(',');
                    if (!var[1].Equals(WorkID.ToString()))
                    {
                        StreamWriter sw = new StreamWriter(folderName + UserID + @"\" + "temp_file.txt", append: true);
                        sw.WriteLine(line);
                        sw.Close();
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter(folderName + UserID + @"\" + "temp_file.txt", append: true);
                        string newline = New_name + "," + var[1] + "," + var[2] + "," + var[3] + ","+var[4];
                        sw.WriteLine(newline);
                        sw.Close();
                    }
                }

                sr.Close();

                // System.IO.File.Move("D:\\temp_file.txt", "D:\\users_data.txt"); //Rename temp file to original file name
                File.Replace(folderName + UserID + @"\" + "temp_file.txt", folderName + UserID + @"\" + "workout_selection.txt", folderName + UserID + @"\" + "temp_file2.txt", false);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
