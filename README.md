# Town Of Host Plus

## Regarding this mod

This mod is not affiliated with Among Us or Innersloth LLC, Town Of Host, Town Of Host: The Other Roles, and the content contained therein is not endorsed or otherwise sponsored by Innersloth LLC. Portions of the materials contained herein are property of Innersloth LLC. © Innersloth LLC.

## Message to Hosts

When a player leaves the game on the Shhh screen with the message "<player> left the game due to error.", use SHIFT+L+ENTER to force end the game.<br>
It's very common that players will black screen when even one players disconnects in this way.<br>
Causes to why players disconnect like this are poor internet and/or bad hardware (common on mobile).<br>
High ping is another likely cause, try to make sure players have reasonable ping (50 ms to 150 ms), especially for mobile.<br>

Along with this, don't use any role marked as broken.<br>
They are marked this way due to a main function not working (eg Werewolf rampage, Veteran alerts, and bastion vents)

## Changes, Fixes, and Additions
### Changes
- Witch renamed to Spellcaster so two roles don't share a name
- FireWorks renamed to Fireworker for TOH accuracy
- Morphling and Mechanic replaced with Shapeshifter and Engineer directly from vanilla
- That scientist remake was removed
- Sabotage Master is now a modifier
- Trapster is now a modifier
- All TOHTOR tags were removed (including the dev tags and gradient tags), and the code that handles server booster tags was removed
- Friend code for Loonie (the dev) was removed from the default banned friend codes list
- /winner is no longer host only and modified to be nicer
- The original TOH role style is now the default mode
- "Lovers Wins!" is now "Love Couple Wins!"
- An exclamation mark was added to the end of the role winner text on the end screen
- Serial Killer rename reverted back to Jackal
- Crewmate and Impostor end screens now say "Crewmates Win!" and "Impostors Win!", while the Jackal end screen says "Team Jackal Wins!"
- Added a space between schrodinger and cat in the role SchrodingerCat.
- Oblivious now hides the report button for modded players rather than disabling it from lighting up
- Jester can no longer get the Torch modifier due to it having the option for Impostor vision
- Role sub text changed to sentence case as Discussions is unoriginal and made it title case like in Town of Us Reactivated
- Terrorist color is now orange
- Opportunist color is now a nice looking aqua color
- Executioner color is now gray
- Snitch partially recoded so Trickster can't be found by the Snitch (by design)
- Sheriff not being able to kill for modded players when shot count is 0 fixed (re-added -1 as an option that does the same thing as 0, but it can kill)
- /tag removed due to tags now being built in and also being minor
- Code that prevents TOHTOR devs from being banned removed
- Changed the modded options icon to the kill button so it feels more "vanilla"
- Impostor and madmate color adjusted to match the vanilla color (#ff0000 -> #ff1313)
- Assassin is now a modifier!

### Fixes
- Double cooldown bug fixed
- Black screen after a meeting when a dead desynced impostor fixed
- Roles are now displayed correctly when TOU styled roles is disabled  
- Fade effect now matches the alignment color rather than the role you got
- Witch win condition added (Discussions somehow forgot this?)

### Additions
- New, original roles! (I lost count)
- New modifiers, mix of original and some originally roles
- Trapster is now a modifier called Sticky
- Sabotage Master is now a modifier called Quick Fix
- Assassin is now a modifier called.. well... Assassin
- Setting to disable the task counter for roles with tasks
- Settings to disable the vent cleaning task, the waterwheels task on Polus, and the three waiting tasks (Reboot Wifi, Inspect Sample, and Run Diagnostics)
- Parasite options for kill cooldown, venting, guessing and additional votes
- Vanilla roles now have god dang descriptions when using /m instead of saying "Vanilla roles currently do not have descriptions."
- Executioner target now appears on the alignment screen for Executioner, like Guardian Angel
- Snitch option for revealing madmates, to make it harder for the Snitch and to make madmates a bit more useful
- Arsonist and Plaguebearer now have options to have Impostor vision
- Added a message for Pestilence in the Medium results


## Releases

**Latest Version: [Here](https://github.com/SkullCreeper/TownOfHostPlus/releases/latest)**

Old Versions: [Here](https://github.com/SkullCreeper/TownOfHostPlus/releases)

## KNOWN BUGS

KNOWN BUGS:

- Lovers win when they die
- Egoist cannot win
- Manipulator meeting sabotage doesn't clear when sabotage ends
- Identity Thief bans for hacking.
- Lag spikes on Xbox and Playstation, which cause black screens after meetings when all impostors die/dying as a neutral killing role. Oddly, the Nintendo Switch runs smoothly so it doesn't have this issue.
- Sometimes players will see some or all players using desynced Impostor roles (known as Impostor Desync)
- Chat sometimes disappears for the host
- Sometimes a crewmate win ends in an Impostor win
- Roles that rely on the vent button cease to function after using the vent button once (eg Veteran and Bastion)
- Demolitionist kills Vampire and Poisoner instantly on death
- Grenadier just doesn't work at all
- Corrupted Sheriff prevents roles from killing impostors
- Werewolf cannot rampage
- The Glitch cannot swap abilties correctly (replaced with a new role with a similar name)
- Sometimes, impostors win when crewmates should when certain (unknown) conditions are met
- Vampire and Poisoner die instantly to Demolitionist when the Demolitionist dies (Demolitionist is also marked as broken because of this)
- Poisoner kills don't occur if Vampire is 0% (poison kills still go through when a meeting is started)

## Features

This mod only needs to be installed on the host's client to work, and works regardless of whether or not other client mods have been installed, and regardless of the type of device.<br>
Unlike mods that use custom servers, there is no need to add servers by editing URLs or files.<br>

However, please note that the following restrictions apply.<br>

- If the host changes and does not have this installed, the server isn't modded and is now just a regular Among Us game.<br>
- If someone will original TOH or TOHTOR, joins a TOH+ lobby, they will be automatically kicked for a version mismatch.<br>

Note that if a player other than the host plays with this mod installed, the following changes will be made.<br>

- Custom Role Reveals
- Custom End Screens
- Additional settings
- Better UI
- etc.

## Features
### Hotkeys

#### Host Only
| HotKey              | Function                       | Usable Scene    |
| ------------------- | ------------------------------ | --------------- |
| `Shift`+`L`+`Enter` | Terminate the game             | In Game         |
| `Shift`+`M`+`Enter` | Skip meeting to end            | In Game         |
| `Shift`+`C`+`Enter` | Force chat to be visible       | In Meeting      |
| `Ctrl`+`N`          | Show active role descriptions  | Lobby&In Game   |
| `C`                 | Cancel game start              | In Countdown    |
| `Shift`             | Start the game immediately     | In Countdown    |
| `Ctrl`+`Delete`     | Set default all options        | In TOH Settings |
| `Ctrl`+`RMB`        | Execute clicked player         | In Meeting      |
| `RightCtrl`+`RMB`   | Kill clicked player            | In Meeting      |

#### MOD Client Only
| HotKey      | Function                                                               | Usable Scene |
| ----------- | ---------------------------------------------------------------------- | ------------ |
| `Tab`       | Option list page feed                                                  | Lobby        |
| `Ctrl`+`F1` | Output log to desktop                                                  | Anywhere     |
| `F11`       | Change resolution<br>480x270 → 640x360 → 800x450 → 1280x720 → 1600x900 | Anywhere     |
| `Ctrl`+`C`  | Copy the text                                                          | Chat         |
| `Ctrl`+`V`  | Paste the text                                                         | Chat         |
| `Ctrl`+`X`  | Cut the text                                                           | Chat         |
| `↑`         | Go back in time of chat send history                                   | Chat         |
| `↓`         | Go future in time of chat send history                                 | Chat         |

### Chat Commands
You can execute chat commands by typing in chat.

#### Host Only
| Command                                               | Function                                          |
| ----------------------------------------------------- | ------------------------------------------------- |
| /rename <string><br>/r <string>                       | Change my name                                    |
| /dis <crewmate/impostor>                              | Ending the match as a Crewmate/Impostor severance |
| /messagewait <sec><br>/mw <sec>                       | Set message send interval                         |
| /help<br>/h                                           | Show command description                          |
| /help roles <role><br>/help r <role>                  | Show role description                             |
| /help attributes <attribute><br>/help att <attribute> | Show attribute description                        |
| /help modes <mode><br>/help m <mode>                  | Show mode description                             |
| /help now<br>/help n                                  | Show active setting descriptions                  |
| /changerole <crewmate, impostor, engineer...>         | Change your In-Game Role                          |
| /level <0-2147483647>                                 | Change your Among Us level                        |

#### MOD Client Only
| Command        | Function                    |
| -------------- | --------------------------- |
| /dump          | Dump log                    |
| /version<br>/v | Show version of MOD clients |

#### All Clients
| Command                     | Function                                |
| --------------------------- | --------------------------------------- |
| /winner<br>/win<br>/w       | Show winner                             |
| /lastresult<br>/l           | Show game result                        |
| /now<br>/n                  | Show active settings                    |
| /now roles<br>/n r          | Show active roles settings              |
| /template <tag><br>/t <tag> | Show template text corresponding to tag |
| /color<br>/colour           | Change your current color (0-20)        |
| /name                       | Change your current name                |
| /myrole                     | Display your current role's description |

### Template
This function allows you to send prepared messages.<br>
Execute by typing `/template <tag>` or `/t <tag>`.<br>
To set the text, edit `template.txt` in the same folder as AmongUs.exe.<br>
Separate each entry with a colon, such as `tag:content`.<br>
Also, you can break lines by writing `\n` in the sentence like `tag:line breaks can be\nmade like this`.<br>

#### Welcome Message
If the tag is set to "welcome" in the template function, it will be sent automatically when a player joins.<br>
For example: `welcome:This room is using the mod Town Of Host: The Other Roles.`

### Impostor Disconnect Detection
If all Impostors leave the game, the game will automatically end with the unused Impostor Disconnected screen. This was done as all impostors leaving the game would black screen all players who do not use desynced Impostor roles after the next meeting.

### Colored Names and Preferred Colors
The dev and a few select people get unique colored names and a color change so they always get their preferred color.


# Roles

### GM

The GM (Game Master) is an observer role.<br>
Their presence has no effect on the game itself, and all players know who the GM is at all times.<br>
Always assigned to a host and is ghosted from the start.<br>

## Impostor

### Bounty Hunter

Team : Impostors<br>
Basis : Impostor<br>

The Bounty Hunter is an Impostor with assigned bountys. Kill the bounty for a short cooldown, kill anyone else for a long cooldown.<br>


### Camouflager

Team : Impostors<br>
Basis : Shapeshifter<br>

The Camouflager is an Impostor who can have every player shift into the chosen player for a limited time.

### Fireworker

Create and idea by こう。<br>

Team : Impostors<br>
Basis : Shapeshifter<br>

The Fireworker can set off fireworks and kill all at once. <br>
They can put a few fireworks by Shapeshift. <br>
After they put all the fireworks and after the other impostors are all gone, they can ignite all fireworks at once by Shapeshift. <br>
They can perform kills after setting off fireworks. <br>
Even if they mistakenly bomb themselves, killing everyone results in Impostor win. <br>

### Mare

Create by Kihi, しゅー, そうくん, ゆりの<br>
Idea by Kihi

Team : Impostors<br>
Basis : Impostor<br>

They can kill only in lights out, but next kill cooldown will be half.<br>
While lights out they can move faster, and yet their name looks red by everyone.<br>


### Puppeteer

Team : Impostors<br>
Basis : Impostor<br>

The Puppeteer can curse a crewmate and force them to kill the next non-impostor they come near.<br>
The cursed crewmate can kill a mad role also.<br>
It is not possible for puppeteer to perform a normal kill.<br>

### Mercenary

Team : Impostors<br>
Basis : Shapeshifter<br>

The Mercenary has a shorter kill cooldown.<br>
Unless they get a kill by deadline, they suicide instantly.<br>

### Shapeshifter

Create and idea by Innersloth<br>

Team : Impostors<br>
Basis : Shapeshifter<br>

It's just a vanilla Shapeshifter.<br>

### Sniper

Create and idea by こう。<br>

Team : Impostors<br>
Basis : Shapeshifter<br>

Sniper can shoot players so far away. <br>
they kill a player on the extension line from Shapeshift point to release point.<br>
Players on the line of bullet hear sound of a gunshot.<br>
You can perform normal kills after all bullets run out.<br>

Precise Shooting:OFF<BR>
![off](https://user-images.githubusercontent.com/96226646/167415213-b2291123-b2f8-4821-84a9-79d72dc62d22.png)<BR>
Precise Shooting:ON<BR>
![on](https://user-images.githubusercontent.com/96226646/167415233-97882c76-fcde-4bac-8fdd-1641e43e6efe.png)<BR>

### Time Thief

Created by integral, しゅー, そうくん, ゆりの<br>
Idea by みぃー<br>

Team : Impostors<br>
Basis : Impostor<br>

Every kill cuts down discussion and voting time in meeting.<br>
Depending on option, the lost time is returned after they die.<br>


### Vampire

Team : Impostors<br>
Basis : Impostor<br>

When the vampire kills, the kill is delayed (the bitten player will die in a set time based on settings or when the next meeting is called).<br>
If the vampire bites [Bait](#Bait), the player will die immediately and a self-report will be forced.<br>


### Warlock

Team : Impostors<br>
Basis : Shapeshifter<br>

When a warlock presses kill, the target is cursed. <br>
The next time the warlock shifts, the cursed player will kill the nearest person.<br>
If you shapeshift as Warlock, you can make a regular kill. <br>
Beware, if you or another impostor are the nearest to the player you have cursed when you shift you will be killed.<br>

### Spellcaster

Team : Impostors<br>
Basis : Impostor<br>

The Spellcaster can perform kills or spells by turns.<br>
The players spelled by a Spellcaster before a meeting are marked with a cross in the meeting, and unless exiling the Spellcaster, They all die just after the meeting.<br>

### Mafia

Team : Impostors<br>
Basis : Impostor<br>

The Mafias can initially use vents and sabotage, but cannot kill (still have a button).<br>
They will be able to kill after Impostors except them are all gone.<br>

### Silencer 

Team : Impostors<br>
Basis : Impostor<br>

The Silencer's first kill attempt will silence the crewmate inside the next meeting.<br>
After the Silence, the Silencer is a regular Impostor until the next meeting.<br>
After the next meeting, the process restarts and they can silence again.<br>
  
### Corrupted Sheriff

Team : Impostors<br>
Basis : Impostor<br>

Corrupted Sheriff spawns when all Impostors die by kill or vote.<br>
As soon as all Impostors die, the [Sheriff](#sheriff) turns into the Corrupted Sheriff.<br>
Corrupted Sheriff is a regular impostor with nothing new.<br>

### Miner

Team : Impostors<br>
Basis : Shapeshifter<br>

The Miner is an Impostor who can shapeshift to warp to the last vent they were in.<br>

### Grenadier

Team : Impostors<br>
Basis : Shapeshifter<br>

The Grenadier is an Impostor who can shapeshift to blind nearby crewmates. During this time, you may kill undetected.<br>

### Ying Yanger

Team : Impostors<br>
Basis : Impostor<br>

The Ying Yanger is an Impostor with the ability to make two crewmates kill each other once within kill range of each other.<br>

### Pickpocket

Team : Impostors<br>
Basis : Impostor<br>

The Pickpocket is an Impostor who steals the votes of players they kill.<br>
These votes stack up, which can make the Pickpocket very powerful.<br>

### Janitor

Team : Impostors<br>
Basis : Impostor<br>

The Janitor is an Impostor who can use their report button to clean bodies, making them unreportable.<br>

### Freezer

Team : Impostors<br>
Basis : Shapeshifter<br>

The Freezer is an Impostor who can shapeshift into a player to freeze them in place for a set amount of time.<br>

### Identity Thief

Team : Impostors<br>
Basis : Impostor<br>

The Identity Thief is an impostor that steals the appearance of who they kill.<br>

### Manipulator

Team : Impostors<br>
Basis : Impostor<br>

The Manipulator is an impostor that sabotages meetings using regular sabotages.<br>

### Swooper

Team : Impostors<br>
Basis : Impostor<br>

The Swooper is an Impostor that can vent to temporarily turn invisible.<br>
  
  
### Bomber

Team : Impostors<br>
Basis : Impostor<br>

The Bomber is a buffed Puppeteer that makes their target die if they don't kill.<br>

### Trickster

Create and idea by Loonie<br>
  
Team : Impostors<br>
Basis : Impostor<br>

The Trickster is an Impostor that cannot vent, but appears innocent to Investigator.<br>
The Sheriff misfires. Snitch cannot find the Trickster.<br>

### Eradicator

Create and idea by Loonie<br>

Team : Impostors<br>
Basis : Impostor<br>

The Eradicator is an Impostor that leaves no bodies behind when they kill.<br>
In addition to this, they have a longer cooldown to help balance the role.<br>
Whether or not the Eradicator can vent is up to the settings.<br>

### Imp

Create and idea by Loonie<br>
  
Team : Impostors<br>
Basis : Impostor<br>

The Imp is an Impostor that appears to be a Child.<br>
While killing the Child ends the game, killing the Imp does nothing.<br>

## Madmate

### Madmate

Team : Impostors<br>
Basis : Engineer<br>

The Madmates belong to team Impostors, but they don't know who are Impostors.<br>
Impostors don't know Madmates either.<br>
They cannot kill or sabotage, but they can use vents.<br>

### MadGuardian

Create and idea by 空き瓶/EmptyBottle<br>

Team : Impostors<br>
Basis : Crewmate<br>

The MadGuardians belong to team Impostors, one type of Madmates.<br>
Compared with Madmates, MadGuardian cannot use vents, while they can guard kills by Impostors after finishing all tasks.<br>


### MadSnitch

Create and idea by そうくん<br>

Team : Impostors<br>
Basis : Crewmate or Engineer<br>

The MadSnitches belong to team Impostors, one type of Madmates.<br>
They can see who is the Impostor after finishing all their tasks.<br>
Depending on option, they can use vents.<br>

### Parasite

Team : Impostors<br>
Basis : Shapeshifter

The Parasite is the only Madmate role with the ability to kill.<br>
Impostors do not know the Parasite.<br>
Parasites can kill and vent.<br>

### SidekickMadmate

Create and idea by たんぽぽ<br>

Team : Impostors<br>
Basis : Undecided<br>

The SidekickMadmate is an acquired Madmate Role assigned by Impostors in task phases.<br>
Some kind of Shapeshifter-based Impostors can give SidekickMadmate by Shapeshifting next to a target.<br>

**NOTE:**
- The **"nearest"** Crewmate becomes SidekickMadmate no matter to whom the Impostors Shapeshift.
  
## Saboteur
  
Create and idea by Loonie<br>
  
Team : Impostors<br>
Basis : Impostor<br>
  
The Saboteur is a madmate that can sabotage.
  
## Consigliere
  
Create and idea by Loonie<br>
  
Team : Impostors<br>
Basis : Impostor<br>
  
The Consigliere is a madmate role that can find the alignment of others using their kill button.<br>
- Red = Impostors, Madmates<br>
- Cyan = Crewmates<br>
- Gray = Neutrals<br>
- Purple = Coven<br>

## Impostor/Crewmate

### Guesser

Create by たんぽぽ<br>

Team : Impostors, Crewmates, or Neutral<br>
Basis : Impostor or Crewmates<br>

If you can guess target's role during meeting, you can kill the target.<br>
In addition, Evil Guesser has a chance to kill even after being exiled.<br>
There is also a neutral Guesser called Pirate. Their goal is guess a number of people to succesfully win.<br>



#### Guesser Commands

| Command                      | Function                         |
| ---------------------------- | -------------------------------- |
| /shoot show                  | Show role IDs and player IDs     |
| /shoot playerID roleID       | Shoot a player ID with a role ID |


## Crewmate

### Dictator

Create and idea by そうくん<br>

Team : Crewmates<br>
Basis : Crewmate<br>

When voting for someone in a meeting, the Dictators forcibly break that meeting and exile the player they vote for.<br>
After exercising the force, the Dictators die just after meeting.<br>

### Doctor

Team : Crewmates<br>
Basis : Scientist<br>

The doctor can see when Crewmates die using vitals anywhere in the map.<br>
By closing the chat, the doctor can see the dead players cause of death next to their name in all meetings.<br>



### Lighter

Team : Crewmates<br>
Basis : Crewmate<br>

After finishing all the task, The lighters have their vision expanded and ignore lights out.<br>



### Mayor

Team : Crewmates<br>
Basis : Crewmate or Engineer<br>

The Mayors' votes count twice or more.<br>
Depending on the options, they can call emergency meeting by entering vents.<br>



### Sheriff

Team : Crewmates<br>
Basis : Impostor<br>

Sheriff can kill impostors always.<br>
Depending on settings, Sheriff may also kill neutrals.<br>
The sheriff has no tasks.<br>
Killing Crewmates will result in suicide. <br>

* As a measure against blackout, after death, the Sheriff can only see the motion of committing suicide at each meeting. There is no corpse. <br>


### Deputy

Team : Crewmates<br>
Basis : Impostor<br>

The Deputy is the Sheriff's partner, and the Sheriff and Deputy know each other.<br>
Deputy cannot spawn without a Sheriff.<br>
All Sheriff settings apply to the Deputy<br>


### Snitch

Team : Crewmates<br>
Basis : Crewmate<br>

Once all of the snitch's tasks are completed, the imposters names will be displayed in red.<br>
Dependent on the settings, the snitch may also see arrows pointed in the remaining impostors directions when their tasks are completed.<br>
When the snitch has 0 or 1 tasks remaining, the impostors will be able to see a star next to the name of the snitch and that there is an alive snitch who has 0 or 1 tasks left.<br>
The impostors also see an arrow pointed in the snitch's direction when the snitch has one or less tasks remaining.<br>

### Engineer

Create and idea by Innersloth<br>
  
Team : Crewmates<br>
Basis : Engineer<br>

Engineer from the base game.<br>


### Scientist

Create and idea by Innersloth<br>
  
Team : Crewmates<br>
Basis : Scientist<br>

Scientist from the base game.<br>

### SpeedBooster

Create and idea by よっキング<br>

Team : Crewmates<br>
Basis : Crewmate<br>

Finishing all the tasks boosts the player speed of someone alive.<br>




### Child

Created by Discussions<br>
Original idea by ???<br>

Team & Basis: Crewmates<br>

When the Child dies by any matter, everyone loses (including the Child).<br>



### Bastion

Created by Discussions<br>
Original Idea by Mek<br>

Team : Crewmates<br>
Basis : Engineer<br>

The Bastion can vent to plant a bomb in that vent.<br>
The next person that attempts to vent will die with the Bombed death reason.<br>
You can only bomb 1 person.<br>
The Bastion can also bomb themselves or other Bastions.<br>

### Demolitionist

Created by Discussions<br>
Original Idea by Mek<br>

Team : Crewmates<br>
Basis : Crewmate<br>

When a killer kills the Demolitionist, they have a few seconds to go hide and vent, or else they will die with the Suicide Death Reason.<br>
The time is configurable. You will know when you are bombed when you see an arsonist triangle by your name.<br>


  
### Investigator

Team : Crewmates<br>
Basis : Impostor(Only host is the Crewmate)<br>

Sheriff can investigate roles to find out what they are.<br>
Impostors and coven will always be red, or purple if settings say so.<br>
The Investigator has no tasks.<br>
The Host can choose if neutrals appear red.<br>

* As a measure against blackout, after death, the Investigator can only see the motion of committing suicide at each meeting. There is no corpse. <br>



### Veteran

Created by Discussions<br>
Original idea by TOuR<br>

Team: Crewmates<br>
Basis: Engineer

The Veteran can vent to go on Alert.<br>
While Veteran is on alert, any killing role that tries to use their kill button on Veteran, crew roles too if turned on, will make the Veteran lunge to kill.<br>



### Psychic

Team : Crewmates<br>
Basis : Crewmate<br>

The Psychic is a crewmate with the ability to see potential evils during a meeting.<br>
Three players are chosen to be highlighted in red, at least one of them are evil.<br>



### Mystic

Team: Crewmates<br>
Basis : Crewmate<br>

The Mystic is a crewmate who can sense kills that occur and when.<br>
When a kill occurs, the Mystic gets a flash.<br>
  
### Detective

Create and idea by Loonie<br>
  
Team : Crewmates<br>
Basis : Crewmate<br>
  
The Detective is a crewmate with additional info in their reports.<br>
When reporting a body, they will learn the role of the killer AND the role of the body they report.<br>
Optionally, Detective may have arrows.<br>
  
### Ironclad
  
Create and idea by Loonie<br>
  
Team : Crewmates<br>
Basis : Crewmate<br>

The Ironclad is a crewmate that becomes immortal on task completion.<br>
Optionally, the Ironclad can see who attacks them.<br>


### Marshall
  
Create and idea by Loonie<br>
  
Team : Crewmates<br>
Basis : Crewmate<br>

The Marshall is a crewmate that, on task completion, is revealed to all crewmates.<br>
Impostors and neutrals cannot see the revealed Marshall.<br>
Optionally, Madmates can see the revealed Marshall.<br>

## Neutral



### Arsonist

Team : Neutral<br>
Basis : Impostor<br>
Victory Condition : Douse and ignite all the living players<br>

When an arsonist tries to use the kill button, they douse oil onto the crewmates.<br>
To win as Arsonist, you must douse all fellow players and vent to win.<br>
To douse, you must stand next to a player after pressing kill until the orange triangle is filled in.<br>

* As a measure against blackout, after death, the Arsonist can only see the motion of committing suicide at each meeting. There is no corpse. <br>



### PlagueBearer

Team : Neutral<br>
Basis : Impostor<br>
Victory Condition : Be the last one standing with a crewmate<br>

When an PlagueBearer tries to use the kill button, they infect the crewmate.<br>
To win as PlagueBearer, you must be the last one alive with a crewmember.<br>
To infect, you just have to press the kill button. No infecting timer. <br>
After infecting everyone, you turn into Pestilence.

* As a measure against blackout, after death, the Plaguebearer can only see the motion of committing suicide at each meeting. There is no corpse. <br>



### Jackal

Team: Neutral<br>
Basis: Impostor<br>
Victory Condition: Kill everyone<br>

The Jackal can kill both impostors and crewmates.<br>
Their goal is to be the last one standing.<br>



### Pestilence

Team : Neutral<br>
Basis : Impostor<br>
Victory Condition : Kill all living players<br>

PlagueBearer becomes Pestilence when they finish infecting.<br>
Pestilence is an unkillable force. When someone tries to kill Pestilence, the pestilence will kill with a lunge. Pestilence can only be voted.<br>
However, if Pestilence is killed by an un-direct source, such as Warlock and Puppeteer, the Pestilence WILL die.<br>

* As a measure against blackout, after death, the Pestilence can only see the motion of committing suicide at each meeting. There is no corpse. <br>



### Vulture

Team : Neutral<br>
Basis : Crewmate<br>
Victory Condition : Eat Bodies to Win<br>

The Vulture can use their report button to eat the body. Making it unreportable.<br>
You can still see it though due to techincal limitations.<br>
You can change how many bodies they have to eat.<br>



### The Glitch

Team : Neutral<br>
Basis : Impostor<br>

The Glitch can vent to switch killing modes.<br>
After every meeting, they are on killing mode.<br>
Once they vent, they are on hacking mode.<br>
Hack someone to prevent them from reporting, sabotaging, killing, and venting if turned on.<br>



### Werewolf

Team : Neutral<br>
Basis : Impostor<br>

The Werewolf can vent to activate their rampage.<br>
They can only kill during a rampage.<br>
This requires tweaking until you get it right.<br>



### Guardian Angel

Team : Neutral<br>
Basis : Engineer<br>

The Guardian Angel can vent to temportarily prevent their target from being killed.<br>
If their target wins, so does the Guardian Angel.<br>



### Amnesiac

Team : Neutral<br>
Basis : Impostor<br>

The Amnesiac reports a body to join the body's team.<br>

If reporting a crewmate body, Amnesiac becomes [Sheriff](#sheriff).<br>
If reporting an Impostor body, Amnesiac becomes [Traitor](#traitor).<br>
If reporting a non killing neutral body, Amnesiac becomes [Opportunist](#opportunist).<br>
If reporting a neutral killer, Amnesiac becomes that neutral killer.<br>


### Egoist

Create by そうくん<br>
Original idea by しゅー<br>

Team : Neutral<br>
Basis : Shapeshifter<br>
Victory Condition : Satisfy the Impostor victory condition after all the Impostors die.<br>

The Egoists are counted among the Impostors.<br>
They have the same ability as Shapeshifters.<br>
Impostors and Egoists can see but cannot kill each other.<br>
The Egoists have to exile all Impostors before leading to Impostor win.<br>
Egoist win means Impostor lose and vice versa.<br>

**NOTE:**
- The Egoists lose in the following condition:<br>
1. Egoist dies.<br>
2. Impostor win with some Impostors remained.<br>
3. Crewmate or other Neutral win.<br>



### Executioner


Team : Neutral<br>
Basis : Crewmate<br>
Victory Conditions : Have the target voted out<br>

Executioner’s target is is marked with a diamond which only they can see.<br>
If the executioner’s target is voted off, they win alone.<br>
If the target is a [Jester](#jester), they will win an additional victory with the executioner.<br>



### Jester

Team : Neutral<br>
Basis : Crewmate<br>
Victory Conditions : Get voted out<br>

The Jesters don't have any tasks. They win the game as a solo, if they get voted out during a meeting.<br>
Remaining alive until the game end or getting killed results Jester lose.<br>

### Opportunist

Team : Neutral<br>
Basis : Crewmate<br>
Victory Conditions : Remain alive until the game end<br>

Regardless of the game outcome, Opportunist wins an additional victory if they survive to the end of the match.<br>

### SchrodingerCat

Team : Neutral<br>
Basis : Crewmate<br>
Victory Conditions : None<br>

The SchrodingerCats have no tasks and by default, no victory condition. Only after fulfiling the following condition they obtain victory conditions.<br>

1. If killed by **Impostors**, they prevent the kill and belong to **team Impostors**.<br>
2. If killed by [Sheriff](#sheriff), they prevent the kill and belong to **team Crewmate**.<br>
3. If killed by **Neutral**, they prevent the kill and belong to the **Neutra team**.<br>
4. If exiled, they die with the victory condition same as before.<br>
5. If killed with special abilities of Impostors (except for [Vampire](#vampire)), they die with the victory condition same as before.<br>



### Terrorist

Create and original idea by 空き瓶/EmptyBottle<br>

Team : Neutral<br>
Basis : Engineer<br>
Victory Conditions : Finish All Tasks, Then Die<br>

The Terrorist are the Neutral Role where they win the game alone if they die with all their tasks completed.<br>
Any cause of death is acceptable except vote.<br>
If they die before completing their tasks, or if they survive at the game end, they lose.<br>

### Juggernaut

Team : Neutral<br>
Basis : Impostor<br>

The Juggernaut starts from the starting kill cooldown.<br>
However, with every kill, their next kill cooldown decreases by the chosen amount.<br>



### Hacker

Create and idea by Mek<br>

Team : Neutral<br>
Basis : Crewmate<br>
Victory Conditions : Fix enough sabotages<br>

The Hacker's goal is to reach a certain number of points<br>
They reach these points by sabotages.<br>
When a Sabotage is called, and/or the Hacker fixes it, the Hacker gains a point.<br>
Reach the required amount of points to win.<br>



### Marksman

Create and idea by WaW<br>

Team : Neutral<br>
Basis : Impostor<br>

The Marksman gets a longer kill distance for each kill they make.<br>



### Crewpostor

Create and idea by Crewpostor<br>

Team : Neutral<br>
Basis: Crewmate<br>
Victory Conditions : Same as Impostors<br>

The Crewpostor is a neutral who wins with the Impostors. The Crewpostor does tasks to kill.<br>
When they complete a task, they kill the nearest player, which can be their fellow Impostors.<br>

### Phantom

Team : Neutral<br>
Basis : Crewmate<br>
Victory Conditions : Complete all your tasks without getting killed<br>

The Phantom is a neutral who cannot be killed until later, they win when they complete all their tasks without dying.<br>
When the Phantom has a certain amount of tasks remaining, everyone gets an arrow and the Phantom can be killed.<br>
The Phantom's vote do not count and votes on the Phantom do not count.<br>

### Swapper

Team : Neutral<br>
Basis : Crewmate<br>
Victory Conditions : Vote your target out<br>

The Swapper is essentially [Executioner](#executioner) but with one key difference, being that their target changes every meeting.<br>

### Hitman

Team : Neutral<br>
Basis : Impostor<br>
Victory Conditions : Survive to the end<br>

The Hitman is a neutral benign role with the ability to kill.<br>
Hitman can win with anyone and does not count as a killer.<br>
Optionally, Hitman can also win with roles like Jester and Executioner.<br>
  
### Masochist
  
Create and idea by Loonie<br>
  
Team : Neutral<br>
Basis : Crewmate<br>
Victory Condition : Get attacked a certain amount of times to win<br>
  
The Masochist is a neutral evil who must be attacked a set amount of times to win.<br>
Because of this, the Masochist is pratically unkillable.<br>
  
### Poisoner


Create and idea by Loonie<br>
  
Team : Neutral<br>
Basis : Impostor<br>
Victory Condition : Kill everyone<br>

The Poisoner is a neutral killer with delayed kills.<br>
Kill everyone to win<br>
  
### Serial Killer

Create and idea by Loonie<br>
  
Team : Neutral<br>
Basis : Impostor<br>
Victory Condition : Kill everyone<br>

The Serial Killer is a neutral killer that can sabotage.<br>
Optionally, the Serial Killer can guess roles like a guesser.<br>

### Predator

Create and idea by Loonie<br>
  
Team : Neutral<br>
Basis : Impostor<br>
Victory Condition : Kill enough players to win.<br>

The Predator is a killing role not counted to the game.<br>
They cannot vent but have a set goal of killing a certain amount of players to win.<br>
If they don't kill enough, they lose.<br>

### Vindicator

Create and idea by Loonie<br>
  
Team : Neutral<br>
Basis : Impostor<br>
Victory Condition : Kill everyone<br>

The Vindicator is a neutral killer with extra votes, like a Mayor.<br>
Kill everyone to win.<br>

### Traitor

Create and idea by Loonie<br>
  
Team : Neutral<br>
Basis : Impostor<br>
Victory Condition : Kill everyone<br>

The Traitor is a neutral impostor that must kill literally everyone.<br>
The Traitor will not win if the game is 1 Traitor and 1 Crewmate.<br>
The Traitor must kill that crewmate to win.<br>
The Traitor has every ability a regular Impostor has, due to its lore being a former Impostor.<br>

### Wraith

Create and idea by Loonie<br>
  
Team : Neutral<br>
Basis : Impostor<br>
Victory Condition : Kill everyone<br>

The Wraith is a neutral killer that cannot report bodies, call emergency meetings, or cast a vote.<br>
However, they can sabotage doors.<br>
Along with that, since they are a ghost-like creature, they show up as innocent to crew roles and can't be found by the Detective.<br>

### Glitch

Create and idea by Loonie<br>
  
Team : Neutral<br>
Basis : Impostor<br>
Victory Condition : Kill everyone<br>

The Glitch is a neutral killer that must kill literally everyone to win.<br>
If the last two players are a Glitch and Crewmate, the game will NOT end.<br>
The Glitch must kill that crewmate.<br>
Glitch cannot vent, but can sabotage.<br>
Glitch also corrupts its kills, preventing roles from being found.<br>

## Coven

### Coven Leader

Team : Coven<br>
Basis : Impostor<br>

The Coven Leader is essentially [Puppeteer](#puppeteer) until the possession of the Necronomicon, where they kill normally afterwards.<br>



### Medusa

Team : Coven<br>
Basis : Impostor<br>

The Medusa is essentially an evil [Veteran](#veteran).<br>
Bodies will become unreportable after a certain amount of time.<br>



### Hex Master

Team : Coven<br>
Basis : Impostor<br>

The Hex Master hexes players. They switch between killing and hexing.<br>
Once all living non-Coven players are hexed, they must eject the Hex Master or the Coven wins.<br>
With the Necronomicon, the Hex Master can kill normally every time.<br>



## Modifiers

### Bait

Assigned To : Crewmates Only<br>

When Bait is killed, the impostor will automatically self report.<br>
This also applies to delayed kills- Once the kill button is pressed, the report will be immediate.<br>

### Sleuth

Created by Discussions<br>
Original Idea by ToUR<br>

Assigned To : All<br>

The Sleuth can report a body to know its role.<br>
The Sleuth has to report to know the role.<br>
The Sleuth has no settings.<br>

### Bewilder

Created by Discussions<br>
Original Idea by Mek<br>

Assigned To : Crewmates Only<br>

The Bewilder is similar to bait, meaning that something happens when you kill it.<br>
As Bewilder, when a killer kills you they gain your small vision. Making them have small vision for the rest of the game.<br>
You can customize the vision using Settings.

### Oblivious

Created by Discussions<br>
Original Idea by ???<br>

Assigned To : All<br>

The Oblivious cannot report bodies.<br>

### Torch

Created by Discussions<br>
Original Idea by ToUR<br>

Assigned To : Crewmates Only<br>

The Torch is unaffected by the lights sabotage.<br>

### Flash

Created by Discussions<br>
Original Idea by ToUR<br>

Assigned To : All<br>

The Flash makes the player move faster.<br>
Due to technical limitations, Flash moves at normal speed for other players and Flash sees other players moving at the speed of Flash.<br>

### Lovers

Created by Discussions<br>
Idea by TOuR<br>

Assigned To : All<br>
Victory Conditions : Be Among the Last 3 People Alive<br>

Randomly assigned to two players (regardless of team).<br>
The lovers goal is to keep the other lover alive and be among the last 3 standing.<br>
The host can choose whether the lovers die together.<br>
THe host can also choose whether the Lovers know the role of their partner<br>

### Watcher

Assigned To : All<br>

The Watcher can see who each player has voted during every meeting.<br>

### Diseased

Assigned To: Crewmates<br>

The Diseased is a crewmate modifier which multiplies the killer's kill cooldown upon killing the Diseased.

### Overclocked

Create and idea by Loonie<br>
  
Assigned To: Killers<br>

The Overclocked is a killer-only modifier that modifies the kill cooldown of the assigned player.<br>

### Quick Fix

Create and idea by Loonie<br>
  
Assigned To: Crewmates<br>

The Quick Fix is a crew modifier that allows the player to fix sabotages quickly.<br>

### Sticky

Create and idea by Loonie<br>
  
Assigned To: All<br>

The Sticky is a modifier that, when killed, locks the killer in place for a bit.<br>

### Amplify

Create and idea by Loonie<br>
  
Assigned To: All<br>

The Amplify is a modifier that grants the player one extra vote.<br>
Roles that modify their votes cannot recieve this modifier.<br>

### Eternal

Create and idea by Loonie<br>
  
Assigned To: Crewmates and Impostors<br>

The Eternal is a modifier only assigned to crewmate-aligned and impostor-aligned players.<br>
The modifier prevents the game from ending as long as the Eternal is alive.<br>
This includes being the only player alive.<br>

### Blind

Create and idea by InfWorks<br>
  
Assigned To: All<br>

The Blind is a modifier that sets the vision of the assigned player to 0.1x.

### Undercover

Create and idea by Loonie<br>
  
Assigned To: Neutral Killing<br>

The Undercover is a modifier only assigned to neutral killers.<br>
As an Undercover neutral killer, you win with the Impostors.<br>

### Insight / Outsight



Create and idea by Loonie<br>
  
Assigned To: Crewmates / Impostors<br>

Insight: Insight is a crew modifier that gives the crewmate the same vision as the Impostors.<br>
Outsight: Outsight is an impostor modifier that gives the impostor the same vision as the crew.<br>

### Forensic

Create and idea by Loonie<br>
  
Assigned To: All except Doc and Trickster<br>

The Forensic is a modifier that allows the assigned player to see death causes like a Doctor.<br>

### Tethered

Create and idea by Loonie<br>
  
Assigned To: Impostors<br>

The Tethered is a modifier that disables the ability to vent for the assigned impostor.<br>

### Chainlink

Create and idea by Loonie<br>
  
Assigned To: All<br>

The Chainlink is a modifier assigned to two players.<br>
When one player with the modifier dies, the other dies as well.<br>


### Necroview

Create and idea by Loonie<br>

Assigned to: All but Doctor and Trickster<br>

The Necroview is a modifier that allows the player to see the alignments of dead players.<br>


### Assassin

Assigned to: Impostors<br>

The Assassin is a modifier that grants the ability to guess roles in meetings.<br>
Guessing correctly kills the target, while guessing incorrectly kills you.<br>



## Attribute

### LastImpostor

Create and idea by そうくん<br>

An Attribute given to the last Impostor.<br>
kill cooldown gets shorter than usual.<br>
Not assigned to [BountyHunter](#bountyhunter), [Mercenary](#mercenary), or [Vampire](#vampire).<br>

#### Game Options

| Name                       |
| -------------------------- |
| LastImpostor Kill Cooldown |

## DisableDevice

Reference source : [SuperNewRoles](https://github.com/ykundesu/SuperNewRoles), [The Other Roles: GM Edition](https://github.com/yukinogatari/TheOtherRoles-GM)<br>

Various devices can be disabled (currently admin only, MiraHQ not supported)

| Settings Name         |
| --------------------- |
| Disable Admin         |
| ・ Which Disable admin |
## SabotageTimeControl

The time limit for some sabotage can be modified.

| Name                      |
| ------------------------- |
| Polus Reactor TimeLimit   |
| Airship Reactor TimeLimit |

## Mode

### DisableTasks

It is possible to not assign certain tasks.<br>

| Name                       |
| -------------------------- |
| Disable StartReactor Tasks |
| Disable SubmitScan Tasks   |
| Disable SwipeCard Tasks    |
| Disable UnlockSafe Tasks   |
| Disable UploadData Tasks   |

### Fall from ladders

There is a configurable probability of fall to death when you descend from the ladder.<br>

| Name                 |
| -------------------- |
| Fall To Death Chance |

### HideAndSeek

Create and idea by 空き瓶/EmptyBottle<br>

#### Crewmates Team (Blue) Victory Conditions

Completing all tasks.<br>
※Ghosts' tasks are not counted.<br>

#### Impostor Team (Red) Victory Conditions

Killing all Crewmates.<br>
※Even if there are equal numbers of Crewmates and Impostors, the match will not end unless all the Crewmates are killed.<br>

#### Fox (Purple) Victory Conditions

Staying alive when one of the teams (Except Troll) wins.<br>

#### Troll (Green) Victory Conditions

Killed by Impostors.<br>

#### Prohibited items

- Sabotage<br>
- Admin<br>
- Camera<br>
- Exposing by ghosts<br>
- Ambush (This may make it impossible for Crewmates to win with the tasks.)<br>

#### What you can't do

- Reporting a dead bodies<br>
- Emergency meeting button<br>
- Sabotage<br>

#### Game Options

| Name                      |
| ------------------------- |
| Allow Closing Doors       |
| Impostors Waiting Time(s) |
| Ignore Cosmetics          |
| Disable Vents             |

### Splatoon

Create and idea by Discussions<br>

#### Workers and Janitors (Blue) Victory Conditions

Completing all tasks.<br>
The Janitor can use their kill button to reverse a paint.<br>
*You cannot die.

#### Painter Team (Orange) Victory Conditions

The Painters goal is to use their kill button to paint everyone their color.<br>
Painters can paint other painters.<br>
When everyone is painted the same color, the Painters win.<br>

#### Prohibited items

- Sabotage<br>
- Admin<br>
- Camera<br>
- Venting if turned Off<br>

#### What you can't do

- Reporting a dead bodies<br>
- Emergency meeting button<br>
- Sabotage<br>

#### Game Options

| Name                      |
| ------------------------- |
| Allow Venting.            |
| Impostors Waiting Time(s) |
| Ignore Cosmetics          |
| Paint/Clean Cooldown      |

### NoGameEnd

#### Crewmates Team Victory Conditions

None<br>

#### Impostor Team Victory Conditions

None<br>

#### Prohibited items

None<br>

#### What you can't do

Exiting the game with anything other than host's SHIFT+L+Enter.<br>

This is a debug mode with no win Basis.<br>

### RandomMapsMode

Created by つがる<br>

The RandomMapsMode changes the maps at random.<br>

#### Game Options

| Name                |
| ------------------- |
| Include The Skeld   |
| Include MIRA HQ     |
| Include Polus       |
| Include The Airship |

### SyncButtonMode

This mode limits the maximum number of meetings that can be called in total.<br>

#### Game Options

| Name             |
| ---------------- |
| Max Button Count |

### Global RoleBlock Duration

Every role than can roleblock shares the same global cooldown.<br>

## OtherSettings

| Name           |
| -------------- |
| When Skip Vote |
| When Non-Vote  |

#### Client Settings

## Hide Codes

By activating, you can hide the lobby code.

You can rewrite the`Hide Game Code Name`in the config file (BepInEx\config\com.emptybottle.townofhost.cfg) to display any character you like when HideCodes are enabled.
You can also change the text color as you like by rewriting`Hide Game Code Color`.

## Force Japanese

Activating forces the menu to be in Japanese, regardless of the language setting.

## Japanese Role Name

By activating, the Role name can be displayed in Japanese.
If the client language is English, this option is meaningless unless `Force Japanese` is enabled.

## Credits

Roles from:
1. [The Other Roles](https://github.com/Eisbison/TheOtherRoles)<br>
2. [The Other Roles: GM Edition](https://github.com/yukinogatari/TheOtherRoles-GM)<br>
3. [The Other Roles: GM Haoming Edition](https://github.com/haoming37/TheOtherRoles-GM-Haoming)<br>
4. [Nebula on the Ship](https://github.com/Dolly1016/Nebula)<br>
5. [au.libhalt.net](https://au.libhalt.net)<br>
6. [Foolers Mod](https://github.com/MengTube/Foolers-Mod)<br>
7. [Town-Of-Us-R](https://github.com/eDonnes124/Town-Of-Us-R)<br>
8. Mek - Role Ideas (Bewilder, Bastion, Demolitionist)<br>
9. Original [Town Of Host](https://github.com/tukasa0001/TownOfHost) (Mod itself plus pull requests for roles such as the guesser roles)

## Developers
- Loonie#0003 (Discord)
