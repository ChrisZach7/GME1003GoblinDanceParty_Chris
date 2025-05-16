using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System;
using Microsoft.Xna.Framework.Media;

namespace GME1003GoblinDanceParty
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //Declare some variables
        private int _numStars;          //how many stars?
        private List<int> _starsX;      //list of star x-coordinates
        private List<int> _starsY;      //list of star y-coordinates

        private Texture2D _starSprite;  //the sprite image for our star

        private Random _rng;            //for all our random number needs                    
        private List<float> _starRotations;    // Task 2: rotation per star
        private List<float> _starTransparencies; // Task 3: transparency per star
        private List<float> _starScales; // Task 4: scale per star
        private List<Color> _starColors; // Task 5: color per star





        //***This is for the goblin. Ignore it.
        Goblin goblin;
        Song music;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _rng = new Random();        //finish setting up our Randon 
            _numStars = _rng.Next(50, 300); // random number between 50 and 300
            _starsX = new List<int>();  //stars X coordinate
            _starsY = new List<int>();  //stars Y coordinate
             
         
                                                           
            // Task 2: Initialize and fill rotation list
            _starRotations = new List<float>();
            for (int i = 0; i < _numStars; i++)
            {
                _starRotations.Add((float)_rng.NextDouble()); // values between 0f and 1f
            }

            // Task 3: Initialize and fill transparency list
            _starTransparencies = new List<float>();
            for (int i = 0; i < _numStars; i++)
            {
                _starTransparencies.Add(_rng.Next(25, 101) / 100f); // values between 0.25f and 1f
            }


            // Task 4: Initialize and fill scale list
            _starScales = new List<float>();
            for (int i = 0; i < _numStars; i++)
            {
                _starScales.Add(_rng.Next(25, 101) / 100f); // scale between 0.25f and 1.0f
            }


            // Task 5: Initialize and fill color list
            _starColors = new List<Color>();
            for (int i = 0; i < _numStars; i++)
            {
                _starColors.Add(new Color(
                    128 + _rng.Next(0, 129), // Red
                    128 + _rng.Next(0, 129), // Green
                    128 + _rng.Next(0, 129)  // Blue
                ));
            }



            //use a separate for loop for each list - for practice
            //List of X coordinates
            for (int i = 0; i < _numStars; i++) 
            { 
                _starsX.Add(_rng.Next(0, 801)); //all star x-coordinates are between 0 and 801
            }

            //List of Y coordinates
            for (int i = 0; i < _numStars; i++)
            {
                _starsY.Add(_rng.Next(0, 481)); //all star y-coordinates are between 0 and 480
            }

            //ToDo: List of Colors
            
            //ToDo: List of scale values

            //ToDo: List of transparency values

            //ToDo: List of rotation values


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            //load out star sprite
            _starSprite = Content.Load<Texture2D>("starSprite");


            //***This is for the goblin. Ignore it for now.
            goblin = new Goblin(Content.Load<Texture2D>("goblinIdleSpriteSheet"), 400, 400);
            music = Content.Load<Song>("chiptune");
            
            //if you're tired of the music player, comment this out!
            MediaPlayer.Play(music);

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

   
            //***This is for the goblin. Ignore it for now.
            goblin.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            
            _spriteBatch.Begin();

            //it would be great to have a background image here! 
            //you could make that happen with a single Draw statement.

            //this is where we draw the stars...
            for (int i = 0; i < _numStars; i++) 
            {
                _spriteBatch.Draw(_starSprite, 
                    new Vector2(_starsX[i], _starsY[i]),    //set the star position
                    null,                                   //ignore this
                    _starColors[i] * _starTransparencies[i],//star colour and transparency
                    _starRotations[i],                      // star rotation

                    new Vector2(_starSprite.Width / 2, _starSprite.Height / 2), //ignore this
                    new Vector2(_starScales[i], _starScales[i]), // individual star scale
                    SpriteEffects.None,                     //ignore this
                    0f);                                    //ignore this
            }
            _spriteBatch.End();



            //***This is for the goblin. Ignore it for now.
            goblin.Draw(_spriteBatch);

            base.Draw(gameTime);
        }
    }
}
