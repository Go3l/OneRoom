using UnityEngine;
using DG.Tweening;

public class Rocket : MonoBehaviour
{
    private bool canMove;

    private void Start()
    {
        transform.DORotate(new Vector3(90, 0, 0), 2f);
        transform.DOLocalMove(new Vector3(0, 1, -6), 2f).OnComplete(() => canMove=true);
    }

    //public float speed = 1f; //how fast the object should rotate

    //private void Update()
    //{

    //    transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y"),0, -Input.GetAxis("Mouse X")) * Time.deltaTime * speed);

    //}

    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;
    void Update()
    {
        if (!canMove) return;

        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(v, 0, h);
    }
}
