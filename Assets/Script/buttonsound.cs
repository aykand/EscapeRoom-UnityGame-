﻿using UnityEngine;

using System.Collections;

using UnityEngine.UI;





[RequireComponent(typeof(Button))]

public class buttonsound : MonoBehaviour

{



    public AudioClip sound;



    private Button button { get { return GetComponent<Button>(); } }

    private AudioSource source { get { return GetComponent<AudioSource>(); } }





    // Use this for initialization

    void Start()

    {

        gameObject.AddComponent<AudioSource>();

        source.clip = sound;

        source.playOnAwake = false;



        button.onClick.AddListener(() => PlaySoud());

    }



    // Update is called once per frame

    void PlaySoud()

    {



        source.PlayOneShot(sound);

    }

}