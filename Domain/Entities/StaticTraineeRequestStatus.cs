public static class StaticTraineeRequestStatus
{
    private static bool _isRequestInProgress = false;

    public static void SetRequestInProgress()
    {
        _isRequestInProgress = true;
    }

    public static void SetRequestCompleted()
    {
        _isRequestInProgress = false;
    }

    public static bool IsRequestInProgress()
    {
        return _isRequestInProgress;
    }
}
