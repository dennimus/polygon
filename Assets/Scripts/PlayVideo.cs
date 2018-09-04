using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour {

    private bool touching = false;
    private bool playing = false;
    public GameObject Player;
    public VideoPlayer videoPlayer;

    // Use this for initialization
    void Start () {
        videoPlayer = GetComponent<VideoPlayer>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.E))
        {
            //check for player's collision with game object tagged Dock
            if (touching)
            {
                if (playing)
                {
                    videoPlayer.Pause();
                    playing = false;                }
                else
                {
                    videoPlayer.Play();
                    playing = true;
                }
            }
        }

         

    }

    void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            touching = true;
        }
    }

    void OnTriggerExit(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            touching = false;
        }
    }
}
