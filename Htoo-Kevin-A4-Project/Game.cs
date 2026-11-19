// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {

        // PLACE VARIABLES HERE:
        float PlayerX = 25;
        float PlayerY = 25;


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Steady Hands With Inverted Keys");
            Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //WHITE CLEAR SCREEN
            Window.ClearBackground(240);

            //INVERTED CONTROLS FOR PLAYER CUBE
            //PLAYER MOVES DOWN IF PRESSING D
            if (Input.IsKeyboardKeyDown(KeyboardKey.D) == true)
            {
                PlayerX -= Time.DeltaTime * 100;
            }
            //PLAYER MOVES DOWN IF PRESSING A
            if (Input.IsKeyboardKeyDown(KeyboardKey.A) == true)
            {
                PlayerX += Time.DeltaTime * 100;
            }
            //PLAYER MOVES DOWN IF PRESSING W
            if (Input.IsKeyboardKeyDown(KeyboardKey.W) == true)
            {
                PlayerY += Time.DeltaTime * 100;
            }
            //PLAYER MOVES DOWN IF PRESSING S
            if (Input.IsKeyboardKeyDown(KeyboardKey.S) == true)
            {
                PlayerY -= Time.DeltaTime * 100;
            }

            // MAKING PLAYER RED CUBE
            Draw.FillColor = Color.Red;
            Draw.Square(PlayerX, PlayerY, 25);
        }
    }

}
