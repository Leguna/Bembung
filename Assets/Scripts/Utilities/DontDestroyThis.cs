using Base;

public class DontDestroyThis : SingletonMonoBehaviour<DontDestroyThis>
{
    protected override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(gameObject);
    }
}