using UnityEngine;

public class HelloWorld : MonoBehaviour
{
     [RuntimeInitializeOnLoadMethod]
    private static void OnRuntimeMethodLoad()
    {
        Debug.Log("HELLO ARTIFACT WORLD");
    }
}
