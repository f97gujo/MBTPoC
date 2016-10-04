Model based testing

The idea is to test out Model based testing, using Graphwalker (http://graphwalker.github.io/) and Selenium

Models are drawn in yED
The a rest service is started, using the graphwalker standalone jar, using command java -jar C:\graphwalker-cli-3.4.2.jar -d all online -s RESTFUL -m NetCleanModelHomepage.graphml "random(edge_coverage("100"))" 
where you enter all of the relevant models, and what stopping criteria is employed (in this case random walking around until all edges have been traversed at least once). started in a command window
(Needs to be restarted for every new run, otherwise start is not reached)

Two examples from the graphwalker example page, both for C#
https://github.com/GraphWalker, one called PetClinic and one called SmallModel, in c-sharp-rest
One with a small model, and one with a bigger model. I have used copy+paste to build my own solution, but now have problems when trying to create separate classes for the different models
There is a main program which handles the connection to the Graphwalker Rest service, and a helper for setting up and using Selenium
It seems that the current implementation I have needs an offline generated gw3 file for the whole model, rather than the simpler example that just uses the same model
But the java graphwalker explodes when it gets the gw3

When all the test steps are in the same test class, everything seems to work, but would like this PoC to have a separate class for each model

The file Program.cs contains the two implementations I've tried. The top one cannot handle the different classes, the bottom one seems to require the model in gw3, but when entered the java explodes.
Would like the top one to work, but with different files for the different classes
