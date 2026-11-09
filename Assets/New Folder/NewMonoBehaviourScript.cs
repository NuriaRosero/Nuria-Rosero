using UnityEngine;
using UnityEngine.Assemblies;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 1;
    public bool JugadorA;
    void Update()
    {
        Vector3 dir = new Vector3(0, 0);
        if (JugadorA == true)
        {
            //Jugadir A
            if (Keyboard.current.wKey.isPressed)
            {
                dir.y = 1;
            }
            if (Keyboard.current.sKey.isPressed)
            {
                dir.y = -1;
            }
        }
        else
        {
            //Jugador B
            if (Keyboard.current.upArrowKey.isPressed)
            {
                dir.y = 1;
            }
            if (Keyboard.current.downArrowKey.isPressed)
            {
                dir.y = -1;
            }
        }
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }

    
}
