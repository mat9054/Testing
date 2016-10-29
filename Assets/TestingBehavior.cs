using UnityEngine;
using System.Collections;

public class TestingBehavior : MonoBehaviour {

    public int counter = 10;
    public float horizontalSpacing = 2f;
    public float verticalSpacing = 1f;
    public float timer = 3;
    public float nextTime = 0f;
    public int minHeight = 1;
    public int maxHeight = 10;


    // Use this for initialization
    void Start () {
    
        
	}
	
	// Update is called once per frame
	void Update () {

        if (counter > 0 && Time.fixedTime > nextTime)
        {
            nextTime = Time.fixedTime + timer;
            for (int z = 0; z < 10; z++)
            {
                int random = Random.Range(minHeight, maxHeight);
                for (int i = 0; i < random; i++)
                {
                    CustomerBox cbox = new CustomerBox();
                    cbox.box.transform.position = new Vector3(counter * horizontalSpacing, i * verticalSpacing, z * horizontalSpacing);
                    cbox.PickRandomColor();
                }
            }
            counter--;
        }
        

    }

    class CustomerBox
    {
        public GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);

        public void PickRandomColor()
        {
            box.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, Random.value);
        }
    }
}
