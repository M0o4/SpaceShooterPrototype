using System;

public static class GameOverScreen 
{
    public static event Action onGaveOver;
    public static void GameOver()
    {
        onGaveOver?.Invoke();
    }
}
