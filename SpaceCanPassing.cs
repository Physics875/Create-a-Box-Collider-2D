using UnityEngine;

public class SpaceCanPassing : MonoBehaviour
{
    public Transform C; // enemy2
    public Transform D; // enemy3
    public BoxCollider2D box;
    
    void Update()
    {
        float valMidX = (C.position.x + D.position.x) / 2f;

        float valMidY = (C.position.y + D.position.y) / 2f;

        //Debug.Log(valMidX + "..." + valMidY);
            
        transform.position = new Vector2(valMidX, valMidY);

        Vector2 E = new Vector2(C.position.x, D.position.y); // 4 5

        Vector2 F = new Vector2(D.position.x, C.position.y); // 5 2

        float cf  = Vector2.Distance(C.position, F);
        float fd = Vector2.Distance(F, D.position);

        box.size = new Vector2(cf, fd);
        
    }
}
