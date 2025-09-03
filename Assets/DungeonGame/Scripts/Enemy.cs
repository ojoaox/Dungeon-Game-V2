using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string nome;
    public float vida;
    public float speed;
    public float maxVida;
    public Transform target;



    private void Start()
    {
        vida = maxVida;
        Introduction();
    }


    void Introduction()
    {
        Debug.Log("O nome � " + nome + "a vida � " + vida + "e o m�ximo de vida �" + maxVida);
    }

    void Move()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            target.position,
            speed);
    }

    private void Update()
    {
        Move();
    }
}