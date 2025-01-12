using Unity.VisualScripting;
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


    
    // pour que l'obstacle se déplace avec un Lerp dans le temps d'une startposition a une endposition
    private void MoveObstacle()
    {
        x += Time.deltaTime * speed;
        transform.position = Vector3.Lerp(VectorStartPosition, VectorEndPosition, x);

        if (transform.position == VectorEndPosition)
        {
           ResetObstacle();
        }

    }

    // qui fait revenir l'obstacle a sa startposition quand il a atteint sa endposition avec un x qui revient a zero car le Lerp continue d'augmenter
    private void ResetObstacle()
    {
        RandomScoringPlace();
        transform.position = VectorStartPosition;
        x = 0;        
    }

    // pour placer la zone de scoring aléatoirement sur les obstacles
    private void RandomScoringPlace()
    {
        float _yPos = Random.Range(yPositionMin, yPositionMax);
        VectorStartPosition = new Vector3(xStartPostion, _yPos, 0);
        VectorEndPosition = new Vector3(xEndPostion, _yPos, 0);
    }

    // la position
    private void Init()
    {
        VectorStartPosition = new Vector3(xStartPostion, 0, 0);
        VectorEndPosition = new Vector3(xEndPostion, 0, 0);
    }

    // quand le jeu se lance les position des obstacles sont init
    private void Start()
    {
        Init();
    }

    // Chaque frame on actualise la position des obstacles
    private void Update()
    {
        MoveObstacle();
    }
}
