# PingPong

Windows Forms Application game.

Goal of this game is to get as big score as possible. A player gains points when a ball hits a paddle. All the points are counted towards final score.

The game is over when the player has lost all lives. A single life is lost when the ball misses the paddle.

The player can control the paddle with arrow keys. Arrow left for moving the paddle to left and arrow right for moving the paddle to right.

# v2.1.0-beta
- introducing new high scores feature
    - scores can now be saved if the player gets enough points to make it to the top 10
    - top 10 high scores can be viewed by choosing High Scores under Game menu

# v2.0.0
- smoother sprites for the ball and the paddle
- changed controls to arrow keys only
- the ball has a small bouncing effect when it hits the walls or the paddle

# v1.1.4
- production ready stable release

# v1.1.3-beta
- removed cursor hide
- fixed a bug where the paddle was visible when game over

# v1.1.2-beta
- changed level progression
    - difficulty increases with levels
    - each level lasts longer than previous level
- game over animation does not freeze when about box is opened

# v1.1.1-beta
- fixed a starting speed of the ball back to 1

# v1.1.0-beta
  - exception handling
  - levels and score multiplier
  - increasing difficulty when advancing in levels

# v1.0.0-beta
  - just a basic PingPong with no extra features
  - an ability to hit a ball with a paddle
  - lives and score counters
  - new game, exit and about window
