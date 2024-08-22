using System.Collections.Generic;
using Domain.Entities;

public static class StaticTrainee
{
    private static List<Trainee> _traineeList = new List<Trainee>();

    public static void SetTraineeList(List<Trainee> traineeList)
    {
        _traineeList = traineeList;
    }

    public static List<Trainee> GetTraineeList()
    {
        return _traineeList;
    }

    public static void ClearTraineeList()
    {
        _traineeList.Clear();
    }
}
