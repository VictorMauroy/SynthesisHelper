# The Dark Prince: Synthesis helper

Launched on december 1st in 2023, **Dragon Quest Monsters: The Dark Prince** contains amazing possibilities to combine monsters and create new ones. 

That website will contains a lot of different tools to help players to quickly **find the right combinations** and **locate the necessary resources and monsters**.

## Content / Tools

### Monster collection
Players might be able to obtain information on every monsters of the game. Thoses datas will be showed as a library / collection of monsters with sheets for every monster. That tool will be connected to the [Search and filter](#search-and-filter) tool.

Every monster will have the following **information displayed** :
- Name
- Game id
- Location with season and/or obtention ways (events, quests)
- Family
- Rank (G to X)
- Statistics (Ex: Strength, wisdom; from 0 to 5)
- Combinations (Classic)
- Combinations (Special)

**Optional datas**:
- English name
- Japanese name
- Games, where it can be found

### Synthesis paths
The synthesis paths or "combinations" tool will be showed inside every monster sheet. 

A lot of monsters can be created by **combining two to four monsters**. There is currently two methods to synthesize monsters.

#### Classic combination
*I'm currently in need of more informations about it.*

#### Special combination
In The Dark Prince, the developers added a new way to synthesize monster : **the special combination**.
*I'm currently in need of more informations about it.*

Both combinations methods will **show the parents / monsters** required in order to create the desired monster. <br />
Informations: Pictures and names. Pictures will redirect to the parent sheet.

**Optionnal** yet useful functionality: being able to click on a parent to quickly display one of its combinations instead of its sheet. Players could reach the parent sheet by clicking on the name area. 

*Note: some monsters cannot be synthesized while some has many combinations paths.*

### Search and filter
What is the most loved thing on a website that contains tons of datas ? A search tool!

Players must be able to quickly **reach that tool from everywhere on the website**. Therefore, it will be added to the navigation bar.

By typing a monster's name or the name of a family, the search tool will **show the most pertinents results**. Peoples will be able to click on one of those results and **be redirected to the matching sheet**.

Additional filter:
- Rank (could access a list of every monster that match the selected rank)
- Game ID
- English name show the french named monster

### Locator

### Additional tools
Tools that could be used later but aren't a priority : 
- Boss guides
- Stat Ranking
- Skill collection

*Note: the project could evolve depending of reviews and useful ideas. (Such an evidence)*




## API startup commands 
*(That section will be deleted on later versions).*

Here are a few commands that helped me to start the project. 

After the creation of a folder. Add a solution (sln is the name of a template):
```
dotnet new sln --name <SolutionName>
```

Add a project (webapi is the name of a template):
```
dotnet new webapi --name <ProjectName>
```

Add the project to the solution (link both):
```
dotnet sln add <./ProjectName/ProjectName.csproj>
```

Useful:
```
dotnet new gitignore
```