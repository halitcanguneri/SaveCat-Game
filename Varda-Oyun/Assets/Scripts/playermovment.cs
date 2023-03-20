using UnityEngine;

public class playermovment : MonoBehaviour
{

    public Rigidbody2D rb;
    //public float speedX; //default deðer verilecek. float kuralýný unutma ör: speedX=500F <===
    //public Vector2 baslangicPozisyonu, bitisPozisyonu;
    public float kaydýrmahýzý;


    void FixedUpdate()
    {
        if (Input.anyKey)// saða sola hareket etmesini saðlayan kod (ekraný ikiye bölüyor)
        {
            if (Input.mousePosition.x < Screen.width / 2 && transform.position.x > -
           10f) //(ekraný ikiye bölüyor)
            {
                transform.position = new Vector3(transform.position.x - kaydýrmahýzý,
                transform.position.y, transform.position.z);
                //transform.Rotate(0f, 0f, -20f);
            }
            if (Input.mousePosition.x > Screen.width / 2 && transform.position.x <
           10f)//(ekraný ikiye bölüyor)
            {
                transform.position = new Vector3(transform.position.x + kaydýrmahýzý,
                transform.position.y, transform.position.z);
                //transform.Rotate(0f, 0f, 20f);
            }

        }



        // sürükle býrak hareket kodlarý sürükleme iþlemi bittiðinde çalýþýyor sað sol hareket

        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        //{
        //    baslangicPozisyonu = Input.GetTouch(0).position;
        //}

        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        //{
        //    bitisPozisyonu = Input.GetTouch(0).position;
        //    if ((bitisPozisyonu.x < baslangicPozisyonu.x) && transform.position.x > -
        //   3.03f)
        //    {
        //        transform.position = new Vector3(transform.position.x - 0.5f,
        //       transform.position.y, transform.position.z);
        //    }
        //    if ((bitisPozisyonu.x > baslangicPozisyonu.x) && transform.position.x <
        //   3.23f)
        //    {
        //        transform.position = new Vector3(transform.position.x + 0.5f,
        //       transform.position.y, transform.position.z);
        //    }
        //}


        //---------------------------------------------------------------------------------------------------

        // buradaki kodlar klavye kodlarý sað sol hareket


        //if (Input.GetKey("d"))
        //{
        //    rb.AddForce(speedX * Time.deltaTime, 0, 0);

        //}
        //if (Input.GetKey("a"))
        //{
        //    rb.AddForce(-speedX * Time.deltaTime, 0, 0);

        //}


    }
}

