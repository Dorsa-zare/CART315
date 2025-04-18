﻿# Process Journal


##  Final Iterative Prototype | 04.12.25

This week, we achieved most of the goals that we set for this game. I’d say it’s currently at a mid to high-fidelity prototype stage. We divided the tasks among ourselves to move forward efficiently.

**My contributions this week:**
1. Illustrated more character variations for the TSA check line and added them into the scene.
2. Designed and implemented the main menu in Unity using UI elements.
3. Created the layout, background, buttons, and title design.
4. Added functionality with scene management:
   * The Play button transitions to the game scene.
   * The Quit button closes the game (this will fully work in the build version).
5. Added tw0 ui texts on the first scene to guide player.

**Luca’s contributions:**
1. Worked on the character movement within the TSA line.
2. Fixed game ending. Added Win and lose condition.
3. Fixed layout issues in the scan scene, ensuring that the interaction options now display correctly.

**Hanif’s contributions:**
1. Added the banned items reference note to the game scene for players to see during inspection.

**Challenges we faced:**
* Our biggest issue this week was pushing updates and syncing changes across the project. We often ran into problems where one person's updates wouldn’t show up for the others, which slowed down our progress and made collaboration tricky.
* We also noticed some uneven contribution levels within the team. While some members were able to put in more time and effort, others weren’t as involved in completing the tasks we had discussed. This affected how much we were able to improve the project overall.


**Playtest and feedbacks we got:**

During the playtest, we received a lot of positive comments about the visual style, the playful vibe, and the overall concept of the game. People seemed to really enjoy the topic and how fun it feels.
That said, we also got some helpful feedback on areas we could improve:

1. Dragging passengers issue: Some people experienced bugs when trying to drag passengers toward the “Exit” or “Board” sections.
2. Win/Lose logic: One of the main points raised by the professor was about how the win/lose condition is currently set up. Right now, in the second scene where the player selects banned items, the game only lets you continue if you’ve made the correct choices. This basically makes it impossible for players to lose, which takes away from the challenge and learning experience.
3. Passenger tags: Another issue is that passengers are pre-tagged as “dangerous” or “not,” which doesn't actually reflect whether or not the player correctly identified the banned items in their suitcase. This breaks the connection between gameplay and consequences.
4. A suggestion we received was to let players proceed no matter what they selected, and then determine the outcome based on their choices. For example, the passenger’s status could change depending on whether banned items were correctly flagged.
5. Title alignment: Someone mentioned that the title wasn’t centered, so I fixed that.
6. Banned items list: It was also suggested that the list of banned items would be more useful if players could zoom in or expand it. Hanif worked on this and implemented a solution.

Overall, the feedback gave us a clear direction for what we need to improve if we decide to work on the game again. 

TSA SIMULATION Game:
Link: https://github.com/LucaSab48/TSASimCART315/tree/main/TSA_Sim_Prototype1 

![MenutoGame.gif](Media/MenutoGame.gif)
![banneditemslist.gif](Media/banneditemslist.gif)
![selectitems.gif](Media/selectitems.gif)


---------------------

## Iterative Prototype 5 | 04.03.25

This week, my teammates and I had a Discord meeting to plan our next steps for the game. 

We came up with a new mechanic: after finding a banned item and pressing the red button, the game zooms out to show the airport, where the player can drag the passenger toward either a board sign or an exit sign using the mouse. This adds a more whimsical interaction instead of relying on buttons or stamps, making the game feel more playful and unexpected.


To support this mechanic, I designed the board and exit signs, and Luca added them to the scene. 

![image.png](Media/image.png)


I also created the layout for the zoomed-in view, illustrating a desk setup with space for buttons and a note on the top right of the screen.

![scene2bg.png](Media/scene2bg.png)

Hanif worked on the banned items list, which will be clickable for players to expand. 
Some banned items are intentionally unexpected, like a watermelon slice (banned for having sharp edges) or a fish, adding humor and an extra challenge for players.

![Screenshot_2025-04-03_at_1.07.01_PM.png](Media/Screenshot_2025-04-03_at_1.07.01_PM.png)

This is how things look like when put together
![BOARD.png](Media/BOARD.png)


**What We Learned**
1. Dragging passengers to different signs adds a more engaging way to interact with the game.
2. A banned items list helps players but also adds humor and unpredictability.

**Next Steps**
1. Add a countdown timer to increase difficulty and create urgency.
2. Develop UI elements, including the timer, progress bar, start menu, and game-over conditions.
3. Animate the plane's outcome (taking off or crashing) based on player performance.

The game is progressing well, and we’re excited about the next updates!


---------------------
## Iterative Prototype 4 | 03.27.25

This week, we focused on planning the full game loop and addressing ongoing issues rather than making major progress. Our main goal was to refine how the line of passengers behaves in the background and how movement fits into the game flow.
This was primarily an implementation prototype with some look and feel elements, particularly in visuals. We are working at a low- to mid-fidelity level, the mechanics still need polishing, but we now have a clearer vision of interactions.
I worked on illustrations, creating a simple, repeatable set of 4-5 people for the background line, which moves forward as passengers are processed. Luca implemented this moving line into the prototype.

The new illustrations: 

![people.png](Media/people.png)


The line of people integrated in the prototype:

![line.png](Media/line.png)

**What We Learned**
* The line movement enhances immersion but needs smoother integration with mechanics.
* The game loop needs clearer steps for processing passengers efficiently.


**Next Steps**
* Refine the game loop and interactions.
* Add UI elements.
* Playtest to evaluate pacing and flow.


---------------------

## Iterative Prototype 3 | 03.20.25

This week, with my teammates Hanif and Luca, we talked about the game loop and how one would actually look, since we had already made some basic progress last week. We decided to focus on the mechanic that makes the suitcase move forward on the conveyor belt. Then, as soon as it arrives at the X-ray machine, the scene transitions to a close-up of the scan.

We discussed our progress with the professor, and he suggested adding a random array feature that allows us to tag certain items as acceptable and others as unacceptable, then randomize them in each suitcase. We decided to focus on implementing this system.

Luca worked on programming the random item generation and arrays.
Hanif focused on the AI and interactive buttons like the "Deport" button.
I worked on the illustrations of suitcases and xray items.
I created multiple suitcase designs, matching the colors with our game’s palette. Luca then used my illustrations as prefabs, making them actually move along the conveyor belt. I also started illustrating the items that would appear on the X-ray screen. I created 7 acceptable items and 6 unacceptable ones, drawing them in Procreate and tagging them as A1, A2, A3... for acceptable and U1, U2, U3... for unacceptable.

While designing the items, I included some obviously prohibited ones and some that create a moral dilemma, like a dead goldfish or a slice of watermelon, to keep things unexpected and funny. Once I completed the illustrations, Luca imported my prefabs, replacing the basic shapes with my X-ray item designs. He then finalized the item selection system and the transition to the next scene.

- **Goals:** We focused on refining the game loop, specifically how the suitcase moves on the conveyor belt and transitions to the X-ray screen. We also worked on randomizing items in each suitcase and tagging them as acceptable or unacceptable.

- **Prototype Type:** It was mainly an **implementation prototype**, testing mechanics like item randomization, tagging, and scene transitions.

- **Fidelity Level:** **Mid-fidelity** functional mechanics with placeholder UI but refined visuals for suitcases and X-ray items.

- **What We Learned:** The randomization system works, but balancing the mix of obvious vs. morally questionable items is key for engagement. Also, animations need smoothing.

- **Next Steps:** Improve item balancing, refine UI feedback when players select an item, and polish the conveyor belt movement.

The items I illustrated:
![items.png](Media/items.png)

The suitcases I illustrated:
![suitcases.png](Media/suitcases.png)

The UI Hanif worked on:
![tsagif1.gif](Media/tsagif1.gif)

---------------------

## Iterative Prototype 2 | 03.13.25

**Game Prototype Update – TSA Agent Role-Playing Game**

This week, we refined our game concept during studio time. Our game puts the player in the role of a TSA agent responsible for scanning passengers' luggage and identifying suspicious items. However, instead of focusing on obvious airport security threats, the game will present players with unexpected and humorous situations.
For example, a player might discover a suitcase filled with ketchup packets that a grandma has collected to bring back home. The player then faces a dilemma, should they confiscate the items, let them through, or take further action?

**Gameplay Overview**

The game starts with an airport scene, zooming into the player’s POV as a TSA agent behind the conveyor belt.
Suitcases pass through an X-ray machine, displaying their contents.
If the player spots a suspicious item, they press a red button/joystick to flag the passenger for further investigation.
In the second phase, passengers react differently. Some may cry, try to bribe the player, or demand to see a manager.
At the end of the game, the player will see the consequences of their decisions. Whether they made the right calls or accidentally let a dangerous passenger board the plane.

**Task Division for This Week**

Dorsa: Created and illustrated game assets (prefabs) with a simple airport-themed color palette (blue/gray/red). Used Canva and Procreate to design elements like the conveyor belt, scanning machine, and buttons.

Luca: Worked on coding and prototyping the X-ray screen scene, allowing players to press a button when selecting a suspicious item.

This stage focused on refining the TSA role and testing how players interact with luggage. We wanted to see if the scanning system felt intuitive and if the decision-making process created a strong dilemma.

**Goals & Questions & Type of prototype**

Our prototype was mostly implementation-based, with some focus on look and feel. We wanted to figure out "How intuitive is the scanning and flagging system?" We worked with low- to mid-fidelity assets—simple visuals, a functional but basic X-ray system, and early planning for passenger interactions.

We learned that the scanning mechanic works but needs better feedback when selecting items. The decision phase is key to the game’s tension, so we’ll add more varied passenger reactions.

**Next Steps for Next Week**

Combine our work into a playable prototype.
Add more game mechanics, including searching passengers and interacting with them.
Design passengers’ appearances and expressions to enhance the dilemma-based gameplay.

![scene assembly.png](Media/scene%20assembly.png)

![TSAPrototype1.gif](Media/TSAPrototype1.gif)

---------------------
## Iterative Prototype 1 | 03.05.25
For the first stage of our prototyping process, my group followed the brainstorming method we used in class. We each contributed different ideas, themes, and art styles in a shared Google Doc. Afterward, we met in person to discuss common elements in our ideas and how we could combine them into a cohesive concept. We also considered the project timeline, our individual skill levels, and which aspects each member was most passionate about.

For example, I offered to work on UI elements, visuals, and defining the win/lose conditions. Luca expressed interest in coding, while Hanif planned to contribute both to coding and pixel art. Together, we decided on a fun and whimsical theme—something unconventional and out of the ordinary. We also settled on a 2D art style, though specific details like the color palette will be determined based on the game’s story.

This prototype focuses on the look/feel of the game, helping us explore visual direction and core mechanics. At this stage, we're working with low- to mid-fidelity elements. Moving forward, we will refine our art direction, establish basic gameplay mechanics, and create an early interactive version to test how our ideas translate into gameplay.



---------------------
## Alien Invasion Game 2 (Prototype 4) and game analysis| 02.18.25 

### **1. Alien Invasion Game journal:**

This week, I continued working on my Breakout-style game with an alien invasion theme.
I made several improvements to add more challenge and excitement to the gameplay.

**What I Worked On**
- Added falling stones:
    - Stones now spawn randomly from a random alien’s position.
    - They fall toward the spaceship, forcing the player to dodge while shooting aliens.
    - If a stone collides with the wall, it gets destroyed.
- Implemented a GameOver condition:
    - If a stone collides with the spaceship, the game ends.
- Implemented a win condition:
    - Added a countdown timer (60 seconds) displayed on the UI.
    - If the player destroys all aliens before the timer reaches 0 without getting hit by stones, they win.
    - Created a script to track how many aliens are left.
    - Displayed “Game Over” or “You Win!” text depending on the outcome.

**What I Learned**
I feel really happy with how this turned out, especially the falling stones animation (they drop like popcorn), making the game feel dynamic and fun. It was great to have two weeks to work on this game since I had the chance to continue working and build on what I already made and gave me more time to gather ideas and take more time to learn. Overall I think that it’s also a good balance of challenge and engagement.
I applied multiple things I learned from previous weeks: Random spawning, Object shooting mechanics, Breakout-style gameplay, and UI implementation.

**Next Steps (Ideas to Implement)**
- Power-ups (e.g., shield, extra life, faster shooting).
- Different types of aliens with unique abilities.

Game: [Alien Invasion Game](https://github.com/Dorsa-zare/CART315/tree/main/Projects/breakinOut)

This is a GIF of the game play.
![AlienInvasionGif2.gif](Media/AlienInvasionGif2.gif)

### **2. Game Analysis: Level Devil:**

What Makes It Interesting:
The game constantly tricks you, platforms that seem stable disappear, and jumps behave weirdly. It keeps players on edge and forces them to stay alert. The controls are super simple, just running and jumping, but the way the game messes with physics makes it both fun and frustrating. It’s all about trial and error. You die a lot, but quick respawns make it feel more like a learning process than a punishment.

Where It Falls Short:
Some traps feel like pure guessing, which can get frustrating. Sometimes it feels less like skill and more like luck, which might turn some players off.

What I Can Use in Future Projects:
I like the idea of adding unexpected twists to gameplay, like power-ups with random effects. Also, designing levels that encourage players to experiment and learn by failing—but without making them rage-quit.


---------------------
## Breakout/Alien Invasion Game (Prototype 3)| 02.13.25
This week, as we worked on the Breakout game in class, I decided to build on that for my assignment. I started by thinking about the theme and the fun games I used to play as a kid that had similar mechanics. One of the first games that came to mind was Chicken Invaders which is a series of shoot 'em up games created by Greek indie developer Konstantinos Prouskas. It’s kind of like Space Invaders, but what I always loved about it was the aesthetic, the sound effects, and the way the chickens moved. Some would take multiple hits to defeat, and the challenge of dodging attacks while shooting made it really fun. So, I decided to take inspiration from that for my own game.

I started by replacing the original sprites to match a more neon, space-themed vibe. Instead of traditional bricks, I swapped them for alien faces that look like they’re screaming, which makes it both funny and a little chaotic. Then, instead of using the ball mechanic from Breakout, I changed it to a shooting mechanic. I added a bullet prefab and a script to make bullets spawn from the top of the spaceship (which was originally the paddle) whenever the player presses space. Once that was working, I made sure the bullets actually collided with the aliens and destroyed them on impact.

To add a bit of challenge, I made the aliens randomly change size, so sometimes they shrink to almost nothing and then suddenly grow back. This makes it harder to hit them and adds an unpredictable element to the game. At first, I thought making a shooting game would be really complicated, but once I got into it, it wasn’t as scary as I expected. It’s actually pretty similar to how we learned to spawn balls in our first game, where apples dropped from the top, it’s just even easier now because the bullets always spawn from a fixed point instead of randomly.

Right now, the game already looks fun, and I feel happy with how it’s turning out. But I definitely want to expand on it next week. My main goals are to make the aliens move around so they’re harder to hit, add sound effects to make the gameplay more satisfying, and create extra scenes like a main menu and a game over screen. That way, it’ll feel more like a complete game. For now, though, I’m satisfied with the progress, and I’m excited to keep working on it!

Game: [Alien Invasion Game](https://github.com/Dorsa-zare/CART315/tree/main/Projects/breakinOut)

This is a GIF of the game play.

![AlienInvasionGif.gif](Media/AlienInvasionGif.gif)


---------------------
## My Pong Game (Prototype 2) | 02.05.25

This week, I decided to make the Pong game from scratch to test how much I remembered from class. I quickly realized I forgot a lot of the script details, so I had to follow a YouTube tutorial for the base of the game. Once I got that down, I created the basic Pong gameplay, added a main menu with options like Play and Exit, and then set up the main game and game over scenes. I also made sure to show the scores during the game, and if a player hits -7 points, it triggers the game over screen.

To make the game more immersive, I added background music and sound effects, which really brought everything to life. After getting the basics down, I wanted to add something unexpected and fun to the game. I thought about arcade ice hockey tables, where it’s frustrating when you’re slow and the puck is speeding toward you.
So, I decided to add items into the scene: a purple square for Player 1 (who has a purple racket) and a yellow square for Player 2 (whose racket is yellow). When either player hits the matching-colored square, their racket speed gets slowed down for a short time. The twist is that it takes 10 seconds for the racket speed to restore, adding a surprising and frustrating challenge when you can’t move fast enough to hit the ball.

Overall, I’m super satisfied with how it turned out! One challenge I ran into was adding a glowing trail to the ball and applying post-processing effects to make the scene glow. I managed to add the effect, but for some reason, it wasn’t glowing like I expected. It’s something I definitely want to dive deeper into and figure out in the upcoming days.

Game: [My Glowing Pong Game](https://github.com/Dorsa-zare/CART315/tree/main/Projects/MyPong)


This is a photo of the game's Menu.
![ This is a photo of main menu](Media/pongmenu.png)

This is a GIF of the game play.

![ This is a GIF of game](Media/ponggif.gif)

This is a photo of the game's GameOver Screen. 
![Pong Game Over screen](Media/ponggameover.png)

---------------------


## Exploration Prototype | 01.30.25

This week, I started working with the Unity test game we built in class, which includes a collector and a dropper that drops circles on the screen. Once the circles collide with the collector, they get destroyed. I spent some time brainstorming game ideas that could work with this mechanic and wouldn't be too complicated for me as a beginner to build. I watched a bunch of tutorials on YouTube to get inspiration and learn how to proceed with the game development process.

After a bit of thinking, I decided to make the game about apple picking. I began with the same project we started in class last week. Even though I eventually changed the names and scripts, I used that initial project as a foundation. The first thing I did was modify the shape of the collector and updated the control system. Instead of using the keyboard, I made it so the collector moves with the mouse input. I also changed the dropper to an apple spawner, and recreated the apple spawner script from scratch.

To add some depth to the game, I decided to introduce two types of apples: a good one that the player should collect and a bad one to avoid. I initially used basic circle shapes with different colors for these apples. But later, I created pixel art for the apples and added them as sprites to make it look better. I wanted to add an unexpected element to the game, so I decided to include a bomb as the "bad apple"—something people wouldn't expect to find at an apple picking garden, adding a funny twist to the gameplay.

Next, I added a script for a timer and score tracking. This part was a bit tricky because the tutorial I was following had a different Unity interface than the one I was using. At first, I used Unity's text component, but that caused some issues, so I switched to TextMeshPro. I also had to adjust my code to replace the Unity UI with TMPro at the top of my script and it worked in the end!

After that, I added a canvas for the end screen, where I could display the game over message, the score, and the highest score. I also included a restart button so the player could restart the game. Then, I made a few final tweaks to improve the look of the game, like changing some of the object designs and text to make everything more polished.

One of my favorite changes was updating the background. I replaced the empty background with an image of a garden, which I created as a sprite. At first, I couldn't see it, but then I figured out that I needed to change the camera background to transparent and adjust the image’s size and location. Once I did that, everything came together perfectly.

Overall, I had a great time working with Unity this week. I feel like making the prototype, and even rewriting similar scripts, really helped me understand how they work and what they do. For future projects, I’d love to incorporate my 3D art or create multi-layered background images to give the game more depth. I’m also excited to add sounds to make the experience more engaging.

There’s still a bit I’m unsure about, like how to submit a Unity game to GitHub or how others could play my Unity game without having Unity installed. I’m hoping to clarify this process and figure out the best way to organize and submit my projects, including my process journal. Overall, it’s been a productive and exciting week, and I’m looking forward to what comes next!

Game: [Apple Picking Game](https://github.com/Dorsa-zare/CART315/tree/main/Projects/Cart315%20Test)

### Below are the images of my game:

This is a photo of unity editor.

![ This is a photo of unity](Media/appleunity.png)

This is a photo of Gameplay.

![ This is a photo of Gameplay](Media/applegame.png)

This is another photo of Gameplay with the bombs falling.

![ This is a photo of Gameplay 2](Media/applegame2.png)

This is a photo of Game over screen.

![ This is a photo of Game over screen](Media/applegameover.png)



----------------------------------
## Tiny Game | 01.23.25

Since this was the first week of class, I went through the examples of other projects students made for the tiny games. I also checked the resources and different tools for making the tiny game. Some of the tools' interfaces were a bit more complicated to learn within a week; however, I enjoyed Bitsy. It has a simple interface that makes it easier to create pixel art, sprites, and transitions between rooms.

I decided to explore Bitsy and its features by looking at the games available on the website. After seeing the possibilities of this game engine, I brainstormed ideas for my game. First, I decided on the theme: the story of a cat lost in the woods, trying to find its human owner and get back home. A short, simple story that seemed like a good place to start.

I started by drawing the sprite and pixel art for the cat, human, trees, etc. I created Room 1 and added the tiles and the avatar that the player can control. To make it a bit more interesting and challenging, I thought about adding an item, fireflies, that the cat needs to collect in order to move to the next room. It worked, and then I wanted the next room to go completely dark unless the player had collected enough fireflies (a completely dark palette with only the cat visible).

This part was a bit challenging because Bitsy has limitations when it comes to carrying collected items into the next room. I decided to take a look at the code script, but it was really difficult since I wasn’t familiar with Bitsy’s scripting language. I tried writing some code, but the program crashed, and I lost my designs. So, I learned to save often and not mess with the script too much—instead, just using the interface as much as I can.

Finally, I created three rooms for the game, added dialogues and conditions, and designed the look and palette of each room. It takes about 2–3 minutes to play the game. I learned how to use Bitsy and make a pixel art game with a new tool, which was really helpful. It also helped me not overthink and just make something I enjoy, without feeling restricted by the tool or game mechanics.

The pressure of making a perfect game is gone, and I tried to enjoy the process instead of just focusing on the final result—even though I’m happy with how it turned out. For future games, I want to carry that mindset forward: learning and enjoying the process while also expanding my skills. I want to explore more tools like Unity, create my own 3D characters and environments, and keep experimenting with storytelling in my games.


Game: [Lost in the Woods Game](../Projects/lost_in_the_woods.html)

### Below are the images of the three rooms I have designed for my tiny game: 

This is a photo of room 0

![ This is a photo of room0](Media/Room0.png)

This is a photo of room 1

![ This is a photo of room1](Media/Room1.png)

This is a photo of room 2

![ This is a photo of room2](Media/Room2.png)
