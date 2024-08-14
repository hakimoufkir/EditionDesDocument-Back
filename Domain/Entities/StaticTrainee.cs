namespace Domain.Entities;

public static class StaticTrainee
{
    public static List<Trainee> Trainees  { get; private set; } = new();
    public static TaskCompletionSource Loading = new();
    
    public static void SetAndResetList(List<Trainee> products)
    {
        Trainees = new List<Trainee>();
        Trainees.AddRange(products);
        Loading.TrySetResult(); 
    }


    public static void ResetLoading()
    {
        Loading = new TaskCompletionSource();
    }
}