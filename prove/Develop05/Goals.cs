using System;

public abstract class Goals
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goals(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    /*public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }
*/

//RecordEvent This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
//IsComplete - This method should return true if the goal is completed. The way you determine if a goal is complete is different for each type of goal.

//These are the two main behaviors that are shared among all goals yet implemented differently. But in addition to these, there are other behaviors that should be present for both the base class and the derived classes. Take time to think about the additional behaviors you will need.

//Don't forget to account for saving and loading in your design.
    //public abstract string NameOfYourGoal();

    //public abstract string ShortDescription();

    public abstract int GetPointsAwarded();

    public abstract string GetCompleted();

    public abstract int GetTimes();

    public abstract int GetBonus();

    public abstract string GetRecordEvent();
}