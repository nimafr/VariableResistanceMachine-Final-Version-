using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamMusclesAndMachine
{
    class daemon
    {
        database database = new database();
        //user_screen users2 = new user_screen();

        public daemon()
        {
            database.get_users();
            //database.get_workouts();  **NEED THIS FUNCTION IN DB**
        }

        public List<String> getUsers() //returns list of users
        {
            database.get_users();
            return database.return_userlist();
        }

        public string getUser(int i) //returns username of user[i]
        {
            return database.return_username(i);
        }

        public void deleteUser(int i) //deletes user[i]
        {
            database.delete_user(i);
        }

        public void addUser(String name)
        {
            database.Input_userdata(name);
        }
        public List<String> return_Userlist()
        {
            return database.return_userlist();
        }

        public int get_usersid(String name)
        {
            return database.get_user_id(name);
        }
        public void add_default_workouts(int Userid)
        {
            database.create_default_workouts(Userid);
        }
        //save to file in the form (Workout Name, Workout ID, Body Group, Position of actuator at Start, Position of actuator at End)
        public void create_workout(String Username, int UserID, String Workout, int wID, String bGroup, int actuator_Start, int actuator_End)
        {
            database.add_workout(Username, UserID, Workout, wID, bGroup, actuator_Start, actuator_End);
        }
        //removes workout from database
        public void remove_workout(int UserID,int WorkID)
        {
            database.delete_workout(UserID, WorkID);
        }
        public void change_workout_name(String newname,int UserID,int WorkID)
        {
            database.edit_workout(newname, UserID, WorkID);
        }
        //save to file in the form(Date of Workout, Length Of workout, Workout ID, Total Reps, Max Force, Avg Force)
        public void add_to_whistory(String Username, int UserID, String timer, String wID, int total_Reps, int max_force, int avg_force)
        {
            database.Input_wHistory(Username, UserID, timer, wID, total_Reps, max_force, avg_force);
        }
        //returns a list of workouts for that User
        public List<String> return_workout_list(int Userid)
        {
            return database.get_workout_names(Userid);
        }
        //returns a list of workouts body groups for that Users workouts
        public List<String> return_workout_bodygroups(int Userid)
        {
            return database.get_workout_bodygroups(Userid);
        }
        //returns start postion of actuator for a certain workout
        public int return_startposition(int UserId, int WorkoutID)
        {
            return database.get_start(UserId,WorkoutID);
        }
        //returns an end postition of actuator for a certain workout
        public int return_endposition(int UserId, int WorkoutID)
        {
            return database.get_end(UserId, WorkoutID);
        }
        //updates arraylists for reps,timer,avg forces, and max forces for a certain workout on a given date for a user
        public void get_workout_history(int UserID, int WorkoutID, String Date)
        {
            database.get_workout_history(UserID,WorkoutID,Date);
        }
        //return list of timers 
        public List<String> return_timers()
        {
            return database.timers;
        }
        //return list of reps
        public List<String> return_reps()
        {
            return database.reps;
        }
        //return list of maxforces
        public List<String> return_maxforces()
        {
            return database.max_forces;
        }
        //returns list of average forces
        public List<String> return_avgforces()
        {
            return database.avg_forces;
        }
        public int return_useridfromindex(int index)
        {
            return get_usersid(getUser(index));
        }




        /*
        public List<String> getWorkouts(int user_id)
        {
            database.get_workouts(); **NEED THIS FUNCTION IN DB**
            return database.return_workouts(user_id); **NEED THIS FUNCTION IN DB**
        }

        public 
        */

        public void update() //updates all data from database
        {
            database.get_users();
            //database.get_workouts(); **NEED THIS FUNCTION IN DB**
        }
    }
}
