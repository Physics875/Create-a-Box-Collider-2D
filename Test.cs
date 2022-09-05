using UnityEngine;

public class Test : MonoBehaviour
{
    public Transform C; // enemy2
    public Transform D; // enemy3
    public BoxCollider2D box;

    void Start()
    {
//        Debug.Log(Vector2.Distance(a.position, b.position)); //sqrt(3^2 + 3^2)

        Vector2 E = new Vector2(C.position.x, D.position.y); // 4 5

        Vector2 F = new Vector2(D.position.x, C.position.y); // 5 2

        Debug.Log(E);
        Debug.Log(F);

        float cf  = Vector2.Distance(C.position, F);
        float fd = Vector2.Distance(F, D.position);

        box.size = new Vector2(cf, fd);
        
    }
}
