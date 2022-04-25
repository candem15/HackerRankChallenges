using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
/*
1. C#: Team Interface
Implement inheritance as described below.
Create a class Team that has the following:

1. A member variable teamName [string]

2. A member variable noofPlayers [integer]

3. A constructor function:
1. It takes 2 parameters and assigns them to teamName and
noOfPlayers respectively.

4. A member function AddPlayer(count).
1. It takes an integer count as a parameter and
increases noofplayers by count.

5. A member function RemovePlayer/count):
1. It takes an integer count as a parameter and tries to
decrease noofPlayers by count.
2. If decreasing makes no OfPlayers negative, then this
function simply returns false.
3. Else, decrease no OfPlayers by count and return true.

Create a class Subteam that inherits from the above class Team. It
has the following:

1. A constructor function:
1. It takes 2 parameters, teamName and no OfPlayers, and
calls the base class constructor with these parameters.

2. A member function Change TeamName(name:
1. It takes a string name as a parameter and changes
teamName to name.

Note: Declare all the members as public so that they are accessible
by the stubbed code.
Your implementation of the function will be tested by a stubbed
code on several input files. Each input file contains parameters for
the function calls. The functions will be called with those
parameters, and the result of their executions will be printed to the
standard output by the stubbed code.
*/
    public class TeamInterface
    {
        public class Team
        {

        }

        public class Subteam : Team
        {
            public Subteam(string initialName, int count)
            {
                İnitialName = initialName;
                Count = count;
                noOfPlayers=count;
                teamName=İnitialName;
            }

            public string teamName { get; set; }
            public string İnitialName { get; }
            public int Count { get; }
            public int noOfPlayers { get; set; }
            internal void AddPlayer(int count)
            {
                noOfPlayers+=count;
            }
            internal bool RemovePlayer(int count)
            {
                if(noOfPlayers>=count)
                {
                    noOfPlayers-=count;
                    return true;
                }
                return false;
            }
            internal void ChangeTeamName(string name)
            {
                teamName=name;
            }
        }
        class Solution
        {
            static void Main(string[] args)
            {

                if (!typeof(Subteam).IsSubclassOf(typeof(Team)))
                {
                    throw new Exception("Subteam class should inherit from Team class");
                }

                String str = Console.ReadLine();
                String[] strArr = str.Split();
                string initialName = strArr[0];
                int count = Convert.ToInt32(strArr[1]);
                Subteam teamObj = new Subteam(initialName, count);
                Console.WriteLine("Team " + teamObj.teamName + " created");

                str = Console.ReadLine();
                count = Convert.ToInt32(str);
                Console.WriteLine("Current number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
                teamObj.AddPlayer(count);
                Console.WriteLine("New number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);


                str = Console.ReadLine();
                count = Convert.ToInt32(str);
                Console.WriteLine("Current number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
                var res = teamObj.RemovePlayer(count);
                if (res)
                {
                    Console.WriteLine("New number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
                }
                else
                {
                    Console.WriteLine("Number of players in team " + teamObj.teamName + " remains same");
                }

                str = Console.ReadLine();
                teamObj.ChangeTeamName(str);
                Console.WriteLine("Team name of team " + initialName + " changed to " + teamObj.teamName);
            }
        }
    }
}
