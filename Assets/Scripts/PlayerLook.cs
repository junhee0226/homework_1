using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    Transform tf;
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }
    void Start()
    {
        tf = transform;
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector3 Player = Camera.main.ScreenToWorldPoint(mousePos);

        if (Player.x < tf.position.x)
        {
            tf.localScale = new Vector3(-3, 3, 3);
        }
        else
        {
            tf.localScale = new Vector3(3, 3, 3);
        }
    }
}
