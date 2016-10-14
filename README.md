Model based testing
-------------------

The idea is to test out Model based testing, using Graphwalker (http://graphwalker.github.io/) and Selenium

Models are drawn in yED

Then a rest service is started, using the graphwalker standalone jar, using command java -jar .\graphwalker-cli-3.4.2.jar -d all online -o -s RESTFUL 

The model is sent in from the program with syntax MBTTest20160926\bin\Debug\MBTTest20160926.exe NetCleanModel.gw3

So the whole model is first rendered in graphwalker, using convert -i InputFile.graphml Outputfile.gw3, and then manipulating the json

Every model gets its own class, with a Helper class for Selenium, and a Program to communicate with the Rest service

Two examples from the graphwalker example page, both for C#
https://github.com/GraphWalker, one called PetClinic and one called SmallModel, in c-sharp-rest
One with a small model, and one with a bigger model. I have used copy+paste to build my own solution, but now have problems when trying to create separate classes for the different models
There is a main program which handles the connection to the Graphwalker Rest service, and a helper for setting up and using Selenium
It seems that the current implementation I have needs an offline generated gw3 file for the whole model, rather than the simpler example that just uses the same model
But the java graphwalker explodes when it gets the gw3


The file Program.cs contains the two implementations I've tried. The top one cannot handle the different classes, the bottom one seems to require the model in gw3, but when entered the java explodes.
Would like the top one to work, but with different files for the different classes
