using UnityEngine;

public class Obstacles : MonoBehaviour
{    
    private Vector3 VectorStartPosition;
    private Vector3 VectorEndPosition;
    [SerializeField]
    private float xStartPostion = 0f;
    [SerializeField]
    private float xEndPostion = 0f;
    [SerializeField]
    private float yPositionMin = 0;
    [SerializeField]
    private float yPositionMax = 0;
    [SerializeField]
    private float x = 0f;
    [SerializeField]
    private float speed = .5f; 


    

    private void MoveObstacle()
    {
        x += Time.deltaTime * speed;
        transform.position = Vector3.Lerp(VectorStartPosition, VectorEndPosition, x);

        if (transform.position == VectorEndPosition)
        {
           ResetObstacle();
        }

    }

    private void ResetObstacle()
    {
        RandomScoringPlace();
        transform.position = VectorStartPosition;
        x = 0;        
    }


    private void RandomScoringPlace()
    {
        float _yPos = Random.Range(yPositionMin, yPositionMax);
        VectorStartPosition = new Vector3(xStartPostion, _yPos, 0);
        VectorEndPosition = new Vector3(xEndPostion, _yPos, 0);
    }

    private void Init()
    {
        VectorStartPosition = new Vector3(xStartPostion, 0, 0);
        VectorEndPosition = new Vector3(xEndPostion, 0, 0);
    }

    private void Start()
    {
        Init();
    }
    private void Update()
    {
        MoveObstacle();
    }
}
