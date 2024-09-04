using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

public static class StaticTrainee
{
    private static List<Trainee> _traineeList = new List<Trainee>();
    private static readonly object _lockObject = new object();

    // TaskCompletionSource to track the loading state
    private static TaskCompletionSource<bool> _loading = new TaskCompletionSource<bool>();

    public static Task LoadingTask => _loading.Task;

    public static void SetTraineeList(List<Trainee> traineeList)
    {
        lock (_lockObject)
        {
            _traineeList = traineeList;
        }
        _loading.TrySetResult(true); // Mark the loading as complete
    }

    public static List<Trainee> GetTraineeList()
    {
        lock (_lockObject)
        {
            return new List<Trainee>(_traineeList); // Return a copy to prevent modification
        }
    }

    public static void ClearTraineeList()
    {
        lock (_lockObject)
        {
            _traineeList.Clear();
        }
    }

    public static void ResetLoading()
    {
        _loading = new TaskCompletionSource<bool>(); // Reset the loading task
    }
}
