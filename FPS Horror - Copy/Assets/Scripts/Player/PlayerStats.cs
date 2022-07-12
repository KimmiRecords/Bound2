﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour, IGaseable, IGraviFloorDamageable
{
    //todos los stats del personaje principal
    //incluye getter y setter para hp y usbs recolectados
    //inluye metodos para hacerme daño, y variables para los estados del player (si tiene linterna, llaves, etc)
    //construye HPRegen por composicion
    //crea el evento OnDeath, al que otros objetos se van a suscribir
    //TP2 - Francisco Serra, Rocio Casco y Diego Katabian

    public static PlayerStats instance;

    public float playerHpMax;
    public float hpRegen;
    public GameObject CanvasVidaUtil;
    public GameObject ModeloLinterna;
    public CardKeyAccess[] cardKeyAccesses; //referencio a los paneles que necesitan llave para operar
    public int maxUsbs;

    public delegate void MyDelegate(Vector3 cp);
    public event MyDelegate OnDeath;


    [HideInInspector]
    public Transform playerTransform;
    [HideInInspector]
    public bool playerFear = false;
    [HideInInspector]
    public bool hasFlashlight = true;
    [HideInInspector]
    public bool hasCardKey = false;
    [HideInInspector]
    public bool isPaused = false;
    [HideInInspector]
    public Vector3 lastCheckpoint;

    float _playerHp;
    int _usbsCollected;
    int _speedBoosts;
    HPRegen _hpRegen;

    public float PlayerHp
    {
        get
        {
            return _playerHp;
        }

        set
        {
            _playerHp = value;
        }
    }
    public int UsbsCollected
    {
        get
        {
            return _usbsCollected;
        }

        set
        {
            if (_usbsCollected < maxUsbs)
            {
                _usbsCollected = value;
            }
        }
    }
    public int SpeedBoosts
    {
        get
        {
            return _speedBoosts;
        }

        set
        {
            _speedBoosts = value;
            if (_speedBoosts < 0)
            {
                _speedBoosts = 0;
            }
        }
    }

    void Awake()
    {
        if (instance)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }

        _hpRegen = new HPRegen(hpRegen, playerHpMax);
        playerTransform = transform;
        lastCheckpoint = Vector3.zero;
        _playerHp = playerHpMax;
        UsbsCollected = 0;
        GetFlashlight();
    }
    void Update()
    {
        if (!playerFear)
        {
            _hpRegen.CheckAndRegen(ref _playerHp);
        }
    }

    public void GetFlashlight()
    {
        hasFlashlight = true;
        CanvasVidaUtil.SetActive(true);
        ModeloLinterna.SetActive(true);

    }
    public void GetCardKey()
    {
        if (!hasCardKey)
        {
            hasCardKey = true;
        }
        GrantAccess(cardKeyAccesses);
    }
    public void GrantAccess(CardKeyAccess[] CKAs)
    {
        for (int i = 0; i < CKAs.Length; i++) //doy acceso a todos los paneles
        {
            CKAs[i].GetAccess();
            CKAs[i].ChangeText();
        }
    }
    public void TakeDamage(float dmg)
    {
        if (!isPaused)
        {
            PlayerHp -= dmg;
        }

        if (_playerHp <= 0)
        {
            Die();
        }
    }
    public void InstaDeath()
    {
        PlayerHp = 0;
        Die();
    }
    public void Die()
    {
        if (lastCheckpoint == Vector3.zero)
        {
            SceneManager.LoadScene("YouDiedScene");
        }
        else
        {
            PlayerHp = playerHpMax;
            OnDeath(lastCheckpoint);
        }
    }
    public void Win()
    {
        print("YOU WIN");
        _usbsCollected = 0;
        SceneManager.LoadScene("YouWinScene");
    }

    public void Gas(float dmg)
    {
        TakeDamage(dmg);
    }

    public void EnterGas()
    {
        AudioManager.instance.PlayTos();
    }

    public void TakeFloorDamage(float dmg)
    {
        TakeDamage(dmg);
    }
}
