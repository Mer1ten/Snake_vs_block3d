using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Walk : MonoBehaviour
{
    public int CurrentScore;
    public TextMesh Score;
    public float sp = 0;
    public float Sens;

    public Rigidbody PlayerSphere;
    public bool Status = true;
    public Vector3 _previousMousePosition;
    public List<Transform> Tails;
    public float BonesDistance;
    public GameObject BonePrefab;
    

    void Start()
    {
        Application.targetFrameRate = 90;
        PlayerSphere = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        CurrentScore = Tails.Count()+1;
        Score.text = CurrentScore.ToString();

    }
    private void FixedUpdate()
    {
        MoveSnake();
    }
    private void MoveSnake()
    {
        Vector3 pos = PlayerSphere.position;
        Vector3 PrevPosition = pos;
        float sqrtDistance = BonesDistance * BonesDistance;
        foreach (var bone in Tails)
        {
            if ((bone.position - PrevPosition).sqrMagnitude > sqrtDistance)
            {
                var temp = bone.position;
                bone.position = PrevPosition;
                PrevPosition = temp;
            }
            else
            {
                break;
            }
        }
        if (Status)
            pos += new Vector3(0, 0, sp * Time.deltaTime);
        if (Input.GetMouseButton(0))
        {

            Vector3 delta = Input.mousePosition - _previousMousePosition;
            if (delta.x < 0)
            { pos.x -= Sens * Time.deltaTime; }
            if (delta.x > 0)
            { pos.x += Sens * Time.deltaTime; }

        }
        PlayerSphere.MovePosition(pos);
        _previousMousePosition = Input.mousePosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out FoodScore food))
        {
            
            int foodscore = food.ScoreEat;
            for (int i= 0; i < foodscore+1; i++)
            {
                var bone = Instantiate(BonePrefab);
                Tails.Add(bone.transform);
            }
            food.Status = false;
        }
        if (other.TryGetComponent(out BlockBreak block))
        {
            int blockscore = block.ScoreBreak;
            for (int i = 0; i < blockscore + 1; i++)
            {
                block.ScoreBreak -= 1;
                Tails[Tails.Count - 1].transform.localScale = new Vector3(0, 0, 0);
                Tails.RemoveAt(Tails.Count - 1);
            }
        }
    }

}
