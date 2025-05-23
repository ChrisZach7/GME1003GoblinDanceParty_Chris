Tasks Completed (1�6)
---------------------

I completed all 6 required tasks from the assignment:

1. Random number of stars � now generates between 50�300 pizza sprites each run.

2. Unique rotation per sprite � each pizza rotates with its own random speed.

3. Different transparency per sprite � pizzas appear with randomized opacity.

4. Different size per sprite � each pizza is scaled individually using a small range to fit the screen.

5. Different color per sprite � though the pizza has baked-in color, random tinting is applied.

6. Customization � replaced the star sprite with a pizza slice sprite and added a party-themed background.


Git Workflow Summary
---------------------

1. I committed my changes at meaningful checkpoints (after each major task).

2. I pushed regularly after confirming changes worked.

3. Commit messages clearly reflect what was done at each stage.


Troubleshooting
---------------

1. I had some difficulty figuring out how to properly scale the pizza image without it overwhelming the screen.

2. I also ran into a few MonoGame pipeline issues when switching out images, but resolved them through trial and error and reviewing the Content.mgcb settings.


AI Usage
---------

I used AI as a support tool to help me understand and troubleshoot specific parts of the assignment. Specifically:

1. Sprite Rotation, Transparency, and Scaling - I used AI to better understand how to rotate sprites and apply transparency. I also struggled with getting the pizza image to scale properly within the game room, and AI helped guide me toward the right approach using smaller float values and randomized scaling.

2. Replacing the Star Sprite with a Custom Image - When swapping out the default star with my own pizza sprite, I encountered build errors where the image wasn't being recognized. AI helped me resolve these issues by walking me through the MonoGame content pipeline steps, including correcting the Importer and Processor settings in Content.mgcb.