Gunship Mission Planner pt 2

The goal is to use a pathfinding algorithm that finds the optimal path to begin at point of origin, traverse all targets and on completion return to point of origin.
In the case of this assignment, the at start of the game a randomly generated number of enemy targets (set in inspector) instantiated onto the game map which is a grid of size (set in inspector from - to +). Although set in 3D world, for the purposes of this assignment, only the x and z axis are considered vairable. Y is locked at on for all object except gunship which is above the ground locked at y:2.
The point of origin (player) is preset at the bottom of the map.

![Gunship03](https://user-images.githubusercontent.com/112468923/222990247-619c6708-1fb0-4788-91a6-1f95ff7d4025.png)

There is a complexity to this problem that need to be considered when choosing how to solve this.
Because the player can choose to visit any given target and from each target visit any other target, the possible permutations become astronomical very quickly and overwhelm the computational abilities of current computers.
This problem is know as the Travelling Saleman Problem, where all possible permutations of a given number of targets are given mathematically as n!, where eg. 4! = 4*3*2*1 = 24.
This however quickly spirals out of control with every increase of 1 more target. by only 10 targets, the possible number of permutations are 10! = 1,307,674,368,000.

Brute force solving of this is out of the question as with 10 targets, at 1 millisecond for 1 permutations, it would take 41 years to solve... we don't have that long to wait.

![Gunship 03](https://user-images.githubusercontent.com/112468923/221442282-94e177d9-c0f3-479a-bc44-67d5031270b3.png)

I thought to bypass this by grouping the targets. If the targets are grouped in such a way that it it unlikely that the targets in 1 group will have the optimal path to the targets of another gorup, then we can divide the total number of targets into groups, brute force the optimal path to each group, then within each group brute force a solution for the optimal path to each target, thereby finding the optimal path to all targets. Not 100% accurate, but a serviceable solution.
Unfortunately I was not able to figure out how to do this successfully.

![Gunship02](https://user-images.githubusercontent.com/112468923/221442277-df1281ea-8e43-4640-bc8f-18467fe24739.png)

Instead I used a nother possible solution which was to use the Nearest Neighbour algorithm. This is where starting in our case the origin we travel to the nearest target, and from there the nearest target until eventually we traverse all targets and return to origin. This too does not guarantee the optimal path but it is a servieable solution (that I could implement)

There are many other alternatives, however there is no clear optimal solution to solving the Travelling Salesman problem as of right now. Heuristics are often employed in many solutions to give best guess answers, other then brute force and actually calculating every permutation, it will always be best guess.

I ended up having many problems with this assignment, firstly because it was a problem a little more complex then I had first thought.
Spent lots of time building the world with enemy targets but also "not-walkable" areas that added to the complexity of the problem. Plus the original idea was to limit the number of steps (range) the player had to move, so possibly not going to all targets which added more complexity.
I tried to use the grouping method to attempt a brute force but could not correctly create the algorithm.
Then tried to use one of the algorithms in class, like A* or Dijkstra but could not achieve what I wanted, as they ended up finding the best path to each node, in the order of the nodes, rather then finding the nodes with shortest path and creating a path based on the best. this I discovered to my dismay 3 days before assignment was due that it was completely wrong so had to redo the entire assginment and in the end after some quick search settled on the Nearest Neighbour as the easiest way to implement a soluton.
Ran out of time to implement other elements i wanted like restricting the range, and so on.

The program does have the ability to randomly generate any size map and any number of targets making it scaleable and different each iteration.

With a little extra time managed to upgrade the project a little more. Added more realitic scenery, but also mountain obstacles as added challenge to pathing. Decided rather than having static targets, added a* pathfinding algorithm to the enemy tanks, so that they randomly spawned then found path to the player base to attack. Each path is represented by the black lines in the secene of the game, with the black boxes as nodes. This works well and the enemy tanks avoid obstacles and attack the player base.

![Gunship04](https://user-images.githubusercontent.com/112468923/222990445-229e129a-246c-4a25-a4ac-93e6c9bdaad6.png)

However this of course presented new challenges since the original pathfinding project which was predicated on stationary targets mapped out optimal path at game start but did not change as the enemy tanks moved. Tried to implement a constant update to the path but realised that would take a lot of performance. Decided to try to change the game into a turn based game so that the algorithm would only be called once per player turn, but the complexity (for me) to change the entire game in the time I had available meant ultimately I did not succceed.

As it stands the game starts with instantiating the base tower and sapwning of random number of enemy tanks (1 - 10) The Nearest Neighbour algorithm generates the optimal path to traverse all enemy tanks, at the same time the enemy tanks using A* create the shortest path, avoiding obstacles, to attack player base. Unfortunately not having been able to successfully implement an updateable path for the player means right now the player traverses the first created at game start. Maybe will revisit this and fix it time permitting at a later stage. (and maybe attempt again the Brute Force group method to find optimal path just to see if it is feasible)

GitHub Link; https://github.com/forsbergsskola-se/201-algorithms-and-datastructures-nice1stu/tree/main/Algorithms-And-DataStructures/My%20Project%20Gunship
