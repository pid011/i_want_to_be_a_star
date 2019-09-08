﻿using UnityEngine;

namespace IWantToBeAStar.MainGame.MapObjects.Hazards
{
    public class LeftRightMovement : MonoBehaviour
    {
        public float speed;
        public bool IsRandomSpeed;

        // Use this for initialization
        private void Start()
        {
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            SoundPlayer player = GetComponent<SoundPlayer>();

            if (IsRandomSpeed)
            {
                speed = Random.Range(3f, 7f);
            }

            if (transform.position.x == GameData.LeftPosition.x)
            {
                // 머리가 오른쪽을 보도록 뒤집기
                Vector3 scale = transform.localScale;
                scale.x *= -1;
                transform.localScale = scale;

                rigidbody.velocity = transform.right * speed;
                player.PlaySound(-SoundPlayer.RIGHT_SOUND);
            }
            else
            {
                rigidbody.velocity = transform.right * -speed;
                player.PlaySound(SoundPlayer.RIGHT_SOUND);
            }
        }
    }
}