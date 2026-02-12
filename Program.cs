using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;
namespace PlayerMovement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public class
            {
            public float speed;
            public float jumpSrength;

            void Start()
            {
                rb = GetComponent<RightBody20>();
            }

            void Update()
            {
                float horizontalInput = horizontalInput.GetAxis("Horizontal");
                var x = horizontalInput * speed * Time.deltaTime;
                var xyz = new Vector(x, 0f, 0f);
                transform.Translate(xyz);

                var mth = Math.Abs(rb.linearVelocity.y) < 0.001f;
                Debug.Log("Cek isi mth =" + mth);

                if (Input.GetKeyDown(KeyCode.Space) && mth)
                {
                    var y = new Vector2(0f, jumpStrength);
                    rb.AddForce(y, ForceMode2D.Impulse);
                }
                }
            }
        }
    }
}
