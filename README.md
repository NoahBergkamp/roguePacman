# roguePacman

## concept



Het doel van rogue Pacman is zo lang als mogelijk overleven door het ontwijken van de enemies.
maar hoe doe je dat?
hoelanger je speelt hoe meer upgrades je kan kopen door middel van coins. 
door deze upgrade kan je sneller worden sterker worden of andere coole abilies unlocken.

## Ontwerp Keuzes

### Hoe communiceer ik dat de player kan bewegen?
de standaard WASD movement zorgt er voor dat de speler er snel genoeg achter komt hoe de momement werkt

### Hoe communiceer ik wat het doel van het level is?
Alle orbs verzamelen en spenderen aan upgrades.

### Hoe communiceer ik wat gevaarlijk is?
Trail And error/ enemies knipperen rood bij de start van het lvl om gevaar te laten zien.

## Noahs level 1 design:
![Lvl1](grid_64x36_2048x1152.jpg)


## Cady's level 2 design:
![Lvl2](level2.jpg)



## Vijand ontwerpen

### Gedrags regels van de vijand: 

#### Wanneer start het gedrag?

5-10 sec na de start

#### Wat zijn de triggers?

line of sight

#### Wanneer verandert het gedrag?

als de enemy de speler ziet

#### Hoe beweegt de vijand?

standaard movement

#### Wat gebeurt er als de speler zichtbaar is?

snelste pad naar de speler toe

#### Wat gebeurt er als de speler niet zichtbaar is?

Loopt naar verschillende coordinaten, blijft nooit in een hoek
Bewegingen verschilt per enemy

#### Wanneer stopt het gedrag?

eind van het lvl / player power up


