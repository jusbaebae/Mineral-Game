using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager inst;

    public Player player;
    public float money;
    public float hp;
    public float power;

    void Awake()
    {
        player = GetComponent<Player>();
    }
}
