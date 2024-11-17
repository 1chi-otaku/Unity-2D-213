using UnityEditor;

class GameState
{
    public static ModalScript modalScriptInstance;
    public static bool IsLevelComplete;
    public static void Pause(string title = null, string message = null, string buttonMessage = null)
    {
        modalScriptInstance.ShowModal(true, title, message, buttonMessage);
    }
}