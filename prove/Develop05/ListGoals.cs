using System;

public class ListGoals
{
    //public List<NewEntry> _entries = new List<NewEntry>();
    //public List<Goals> _goals = new List<Goals>();
    private string _goals;
    //Constructors
    public ListGoals()
    {
        _goals = "Unknown";
    }

    public ListGoals(string goal)
    {
        _goals = goal;
    }

    public void DisplayGoals() 
    {
        //for (int i = 0; i < goal.Count; i++)
            //{
                //Console.WriteLine(goal);
                //finalPhrase += goal[i].ToString() + " ";
                //removePhrase += removeList[i].ToString();
            //}
        /*foreach (Goals entry in _goals)
        {
            entry.WriteOutGoals();
            
        }
        */
    }

    
}