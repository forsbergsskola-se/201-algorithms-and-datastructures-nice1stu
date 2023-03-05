Gunship Mission Planner pt 2

The goal is to use a pathfinding algorithm that finds the optimal path to begin at point of origin, traverse all targets and on completion return to point of origin.
In the case of this assignment, the at start of the game a randomly generated number of enemy targets (set in inspector) instantiated onto the game map which is a grid of size (set in inspector from - to +). Although set in 3D world, for the purposes of this assignment, only the x and z axis are considered vairable. Y is locked at on for all object except gunship which is above the ground locked at y:2.
The point of origin (player) is preset at the bottom of the map.

![Gunship01](https://user-images.githubusercontent.com/112468923/221442219-14fe3f7c-df04-4a9e-947d-cb93040d2e52.png)

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

GitHub Link; https://github.com/forsbergsskola-se/AlgorithmsDataStructuresFinalAssignment/tree/main/My%20project
