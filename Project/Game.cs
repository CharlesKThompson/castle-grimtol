using System.Collections.Generic;
using System;
using System.Linq;

namespace CastleGrimtol.Project
{
    public class Game : IGame
    {
        public Room CurrentRoom { get; set; }

        public Player CurrentPlayer { get; set; }

        public Dictionary<string, Player> PlayerList = new Dictionary<string, Player>();

        public bool Playing { get; set; } = true;
        public void UseItem(string itemName)
        {
            var foundItem = CurrentPlayer.Inventory.Find(i => i.Name.ToLower() == itemName.ToLower());
            if (foundItem == null)
            {
                System.Console.WriteLine("What?! You don't have a " + itemName + "silly goose!");
                return;
            }

            if (CurrentRoom.Name == "Swamp" && foundItem.Name.ToLower() == "boots")
            {
                System.Console.WriteLine("Congratulations, you have waded through the murky water to save the swamp kitty! Unfortunately there is no place else to go...");
            }
            else if (foundItem.Name.ToLower() == "cap")
            {
                System.Console.WriteLine("By using this cap you are able to lure a fluffy grey kitteh out of danger and it is appreciateive and loving and you decide to adopt it!");
            }
            else if (foundItem.Name.ToLower() == "acorn")
            {
                System.Console.WriteLine("A friendly group of adorable creatures surround you, salivating at the chance to consume this delicius looking source of sustinence. You panic at the prospect of not being able to feed them all and quickly toss the acorn in your mouth. It seems you are heartless.");
            }
            else if (foundItem.Name.ToLower() == "leaf")
            {
                System.Console.WriteLine(@"You toss this leaf into the air. As it falls, drifting back and forth, a pair of orange cat twins sprint out from a hidden crevace, competing to destroy this leaf before it can hit the ground.
                They are adorable and you decide to adopt them.");
            }
            else if (foundItem.Name.ToLower() == "hint")
            {
                System.Console.WriteLine(@"
                Seriously? This is just a hint, stop being lazy and just open your inventory, the description is literally in there.");
            }
            else if (foundItem.Name.ToLower() == "fish")
            {
                System.Console.WriteLine(@"Since you are hungry you pull the herring out of your inventory and prepare to cook it. As you go to fillet the fish, a small grey cat with large round yellow eyes looks up at you sadly, clearly in need of food. Do you eat the fish yourself or share with the kitten?");
                System.Console.WriteLine("You may choose to 'eat' or 'share'");
                string answer = Console.ReadLine();
                if (answer == "eat")
                {
                    System.Console.WriteLine(@"You are a heartless soul, devoid of morals or any sense of propriety. No God would allow you to live on this plane of existece.
                Lighting striks you where you stand, blowing you to a million peices of burning contempt, which is honestly too good of a fate for someone so ruthlessly heartless.");
                    Playing = false;
                }
                else
                {
                    System.Console.WriteLine(@"Well done, you did the right thing and deserve to live another day. You would have neen severly judged had you chosen a differnt path in life.
                the kitten Milo decides to join you on your quest, but will decisivly leave if you do something to get killed, no offense.");
                }
            }
            else if (foundItem.Name.ToLower() == "thread")
            {
                System.Console.WriteLine(@"You decide to play around with with spectacular device as you ponder your next move. Suddenly three cats spurt forth from, joining in the fun! 
                Their names are Cassiopia, Cassandra, and Cassidy and you are their new owner.");
            }
            else if (foundItem.Name.ToLower() == "coconut")
            {
                System.Console.WriteLine(@"You split open this coconut and prepare to eat it.  Turns out this was a magical coconut, and you just activated a portal to a different dimension. The portal quickly closes, as this was supposed to be initiated using a ritual of several coconuts at a time rather than just this one by itself.
                Before the portal closes however, a black and white cat standing on two legs wearing an eye patch curiously steps out and looks up at you in surprise.  Since this little guy has no way of returning home, you dicide to adopt him and he joins you on his journey.
                ");
            }
            else if (foundItem.Name.ToLower() == "whisker")
            {
                System.Console.WriteLine(@"Don't try to use this item, these are collecteable and you will never part with such precious artifiacts!
                ");
            }
            else if (foundItem.Name.ToLower() == "coffee")
            {
                System.Console.WriteLine(@"What strange substance this coffee! You don't know the proper way of prepping this, but legend says it gives you energy, so you grudginly consume the entire can.
                An unknown amount of days later so regain your consiousness, whatever that coffee was, it had a kick, and perhaps it should be taken in smaller quantities and not mixed with certain herbs...
                ");
            }
            else if (foundItem.Name.ToLower() == "rock")
            {
                System.Console.WriteLine(@"This is seriously just a rock, not really sure what you are trying to accomplish here...
                ");
            }
            else if (foundItem.Name.ToLower() == "slipper")
            {
                System.Console.WriteLine(@"You attempt to put this slipper on but is simply wont fit. However. This WILL fit the body of any of your cats, many of whom take turns napping in this slipper.
                You are inspired to adopt Snickers, the brindle colored kitty with a snub face, but loving heart.
                ");
            }
            else if (foundItem.Name.ToLower() == "coffee")
            {
                System.Console.WriteLine(@"What strange substance this coffee! You don't know the proper way of prepping this, but legend says it gives you energy, so you grudginly consume the entire can.
                An unknown amount of days later so regain your consiousness, whatever that coffee was, it had a kick, and perhaps it should be taken in smaller quantities and not mixed with certain herbs...
                ");
            }
            else if (foundItem.Name.ToLower() == "plant")
            {
                System.Console.WriteLine(@"You spread the gooey aloe on your burnt skin and it feel rejuvenating! The desert is no challenge if you are smart now, and you are excited about carrying on in this endeavor.
                Also you are inspired to adopt a sand kitty, light brown with very short fur.
                ");
            }
            else if (foundItem.Name.ToLower() == "crinkle")
            {
                System.Console.WriteLine(@"Behold the Crinkle toy! Dropping this absolutely anywhere will summon any of your current pets, and attract new ones as well.
                You notice among your possie a new face, one black kitty with white socks.
                It is adorable and you adopt it.
                ");
            }
            else if (foundItem.Name.ToLower() == "keyboard")
            {
                System.Console.WriteLine(@"You study this item all day but simply cannot figure out what its purpose could possibly be. About to walk away, you find that it is the perfect seating device for your cats, so you keep it.
                For good measure, you also adopt a white cat with blue eyes.
                ");
            }
            else if (foundItem.Name.ToLower() == "hairtie")
            {
                System.Console.WriteLine(@"You find no use for this item and decide to toss it on the ground. It bounces just the slightes bit, and Annie (obviously a red colored cat with purple stripes) pounces on it and now the hairtie is a permanent toy.
                Annie is now a part of your family, you adopt her.
                ");
            }
            else if (foundItem.Name.ToLower() == "bag")
            {
                System.Console.WriteLine($@"You toss the bag inn the air to experiement with the physics of air resistance on items of small densities with large surface areas.
                Your experiment is joined by a large calico cat named Shareena, and toether you discover quantum mechanics.
                Also, you adopt Shareena and she joins your adventure.
                ");
            }
            else if (foundItem.Name.ToLower() == "shrubbery")
            {
                System.Console.WriteLine($@"You have brought...a Shrubbery! Welcome to the cult of {CurrentRoom.Name} adventurer, you may not leave this cult in the current life.
                ");
            }
            else if (foundItem.Name.ToLower() == "twisty")
            {
                System.Console.WriteLine(@"A wise decision to use this Twisty adventurer! A hoarde of ghouls were streaking toward you, a dark miasma flowing of each of their decrepid bodies. Using your pointer finger and thumb, your very craftily hook the Twisty into projectile form. Taking aim, you lower your thumb and the Twisty shoots off, a neon-green fire exploding in the direction the Twitsy was flying.
                your aim was true, the ghouls have been vanquished this day.
                ");
            }
            else if (CurrentRoom.Name == "Castle Grimtol" && foundItem.Name.ToLower() == "box")
            {
                System.Console.WriteLine("Well done human, you have satisfied the Cat Gods and proven your worth! Now you may ascend!");
                System.Console.WriteLine("YOU WIN THE GAME!!!");
                Playing = false;
            }
            else if (CurrentRoom.Name == "Castle Grimtol" && foundItem.Name.ToLower() == "catnip")
            {
                System.Console.WriteLine("Well done human, you have satisfied the Cat Gods and proven your worth! Now you may ascend!");
                System.Console.WriteLine("YOU WIN THE GAME!!!");
                Playing = false;
            }
            else if (CurrentRoom.Name == "Castle Grimtol" && foundItem.Name.ToLower() == "laser")
            {
                System.Console.WriteLine("Well done human, you have satisfied the Cat Gods and proven your worth! Now you may ascend!");
                System.Console.WriteLine("YOU WIN THE GAME!!!");
                Playing = false;
            }
            else
            {
                System.Console.WriteLine($"You cannot use {itemName} here");
            }
        }
        public void Setup()
        {
            Console.Clear();
            beginningMenu();
        }

        public void Reset()
        {
            Console.Clear();
            beginJourney();
        }
        public void go(string direction)
        {
            System.Console.WriteLine("Which direction will travel next?");
            // string nav = Console.ReadLine();
            if (CurrentRoom.Directions.ContainsKey(direction) == false)
            {
                System.Console.WriteLine("Please select a valid direction yo");
            }
            else
            {
                Console.Clear();
                nextRoom(direction);
                System.Console.WriteLine($"Current Location: {CurrentRoom.Name}");
                System.Console.WriteLine((CurrentRoom.Description));
            }
        }

        public void nextRoom(string nav)
        {
            if (CurrentRoom.Directions[nav] != null)
            {
                CurrentRoom = CurrentRoom.Directions[nav];
            }
            else
            {
                System.Console.WriteLine("Please select a valid direction yo");
                CurrentRoom = CurrentRoom;
            }


        }

        public void takeItem()
        {
            var currentItem = CurrentRoom.Items[0];
            if (CurrentPlayer.Inventory.Contains(currentItem))
            {
                System.Console.WriteLine("So sorry, there is nothing here to pick up :( ");

                System.Console.WriteLine((CurrentRoom.Description));
            }
            else if (CurrentRoom.Items[0].Name == "Hairball")
            {
                Console.Clear();
                System.Console.WriteLine(@"YOU'VE BEEN HAIRBALLED!
                You pick up the suspicious lump with justified hesitation. Upon realizing you are holding a repulsive aged and goopy hairball, your repulsion grows until you vomit. You continue vomitting until your mortal body runs out of fluids and die of dehydration alone.
                END GAME, YOU LOSE SUCKA!
                ");
                Playing = false;
                beginningMenu();
            }
            else if (CurrentRoom.Items[0].Name == "Glass")
            {
                System.Console.WriteLine("You have tipped the glass of water over completely. This pleases the Cat Gods and you have been blessed.");
            }
            else if (CurrentRoom.Items[0].Name == "Mittens")
            {
                System.Console.WriteLine(@"You put the mittnes on, and from a cavern you didn't see before (a sign you are making a wise decision to train!) emerges with its own set of mittens. You spar for two days, and are now a fully trained badass!
                Caus' everybody loves kung fu kitteh! 
                Na na na na na, na  na,  na na!");
            }
            else if (CurrentRoom.Items[0].Name == "Permission")
            {
                System.Console.WriteLine(@"You wisely decide to use diplomacy rather than batte this fearsome yet majestic creature. Turns out Nalsa is a rather friendly creature, and you are allowed to pass
                You adopt Nalsa");
            }
            else if (CurrentRoom.Items[0].Name == "bird")
            {
                System.Console.WriteLine(@"This bird seems to have been brought to you as a gift by a friendly enough critter, disgustin as it is.  You appreciate the kind gesture, but deem this particular creature more appropriate to stay in this environmet rather than bring it into the outside world.
                Sadly you do not adopt this kitteh, but its happy anyways because it has more birds to kill.
                ");
            }
            else if (CurrentRoom.Items[0].Name == "Hovel")
            {
                System.Console.WriteLine(@"You have made your existence known to the Crazy Cat Lady of Grimtol Wilds! She goes into a frenzied rage out of the jealous prospect that you may adopt more cats than her and kills you.
                You Lose this round mortal
                ");
            }
            else if (CurrentRoom.Items[0].Name == "Scorpion")
            {
                System.Console.WriteLine(@"DEATH BY SCORPION!
                So...a common rule of thumb is to NOT pick up poiosonous critters. 
                You get stung and die of scorpion venom.
                END GAME, YOU LOSE!");
                Playing = false;
            }
            else if (CurrentRoom.Items[0].Name == "Sculpture")
            {
                System.Console.WriteLine(@" If you couldn't infer the details from this item's description, this is actually a dog related item.
                The Cat Gods are displeased at your interation with a dog scuplture, and you lose favor.
                SO dissapointing.
                ");
            }
            else if (CurrentRoom.Items[0].Name == "Mouse")
            {
                System.Console.WriteLine(@"You found a mouse! This little guy runs away from you, but you unwittingly assisted in a tabby cat ambush. The cat catches the mouse, and thanks your for your services. 
                You grow fond of the cat and decided to adopt it.
                ");
            }
            else if (CurrentRoom.Items[0].Name == "Bell")
            {
                System.Console.WriteLine(@"Well done getting this bell ball to make noise! 
                Some glowig rainbow kittens come run-tumling out of the meadow to play with you.
                 Heart melting, you quickly throw the ball bell into the wonderland, for allowing the kittens too close would surely be the end of your ambition to ever leave.
                ");
            }
            else if (CurrentRoom.Items[0].Name == "Polearm")
            {
                System.Console.WriteLine(@"Upon greedily taking the polearm you realize too late that it was supporting the weight of the wagon, which falls over you, trapping you until help arrives. In hindsight this was clearly a trap set by the mountain trolls, who come out of their cave dwelling to eat you.
                This is not the help you were hoping for.
                Greed was your downfall this day mortal!
                END GAME, YOU LOSE
                "); Playing = false;
            }
            else if (CurrentRoom.Items[0].Name == "Buffallo")
            {
                System.Console.WriteLine(@"This creature was very peacefully doing its own thing. So why disturb it?
                The buffallo goes into a rage at being disturbed, and you get trampled to death!
                END GAME, YOU LOSE
                "); Playing = false;
            }
            else if (CurrentRoom.Items[0].Name == "Crystal")
            {
                System.Console.WriteLine(@"You peer deebly into the crystal for approxiamtely 42 minutes, and learn secrets of lif.
                With your new wisdom, you decide to adopt another cat. 
                ");
            }
            else if (CurrentRoom.Items[0].Name == "Rum")
            {
                System.Console.WriteLine(@"By drinking the rum here you get the brilliant idea of setting up camp permantnetly to live in paradise! The world hasn't done you many favors so why should you be obligated? 
                You live out the rest of your days here, drinking rum and eating coconuts day after day until finally you body decides alchohol and lack of protein are not a sustainable combo and, being too drunk to realize you are on a lake island rather than out at sea, you collapse in a druken heap, forever dreaming you are on a vacation island.
                Way to be lazy and let everyone down.
                END GAME YOU LOSE!
                ");
                Playing = false;
            }
            else if (CurrentRoom.Items[0].Name == "Thorn")
            {
                System.Console.WriteLine(@"Well, not many people would have taken that action, so this is kind of akward.
                As per the nature of neeldes on cacti, you get pricked badly enough to bleed. Since you are in and have been in a desert for some time now, you are already in rough shape. 
                Although you don't lose massive amounts of blood, you get light-headed and pass out, dying of heat stroke in your unconsiuosness.
                END GAME, YOU LOSE!
                ");
                Playing = false;
            }

            else if (CurrentRoom.Items[0].Name == "Rope")
            {
                System.Console.WriteLine(@"This rope was clearly described as very old. Thus it is brittle AF and breaks as soon as you put any wieght on it.
                Sadly you were relying on this to prevent you falling off a cliff, and since it failed...well...you fell off the cliff.
                END GAME, YOU LOSE!
                ");
                Playing = false;
            }
            else
            {
                CurrentPlayer.Inventory.Add(currentItem);
                System.Console.WriteLine($"You have successfully acquired {currentItem.Name}");
                System.Console.WriteLine($"{currentItem.Description}");
            }
        }
        public void viewInventory()
        {
            System.Console.WriteLine($@"
            Here is your backpack:
            ");
            CurrentPlayer.Inventory.ForEach(Item =>
            {
                System.Console.WriteLine($@" 
            --------------------------------
            {Item.Name} : {Item.Description}
            --------------------------------
            ");
            });

            System.Console.WriteLine("Would you like to return to your adventures?");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "y":
                    go(CurrentRoom.Name);
                    break;
                case "n":
                    System.Console.WriteLine("Ok that's cool...we'll just sorta hang then I guess...");
                    viewInventory();
                    break;
                default:
                    System.Console.WriteLine("Please select either yes or no");
                    break;
            }
        }

        public void beginningMenu()
        {
            System.Console.WriteLine("You have entered the Wilds of Grimtol, what is your name mortal?");
            string playerName = Console.ReadLine();
            CurrentPlayer = new Player(playerName);
            System.Console.WriteLine($"Brave of you to enter {CurrentPlayer.Name}, fare thee well in this adventure...");
        }
        public Room init()
        {
            //Add Rooms
            Room entrance = new Room("Entrance", "You beign your journey at the entrance, you can go west or you can die...");
            Room bog = new Room("Bog", "A murkey green and brown liquid meets you with a foul smell, a breeze comes from the north and a bubbling sound from the south. To the west are odd shapes protruding from the earth. Something rubbery shows between fallen branches");
            Room swamp = new Room("Swamp", "A wretched stench permeates the air. You see a rustle in the distance but the water has become downright acidic. The air is slightly less acrid to the north.");
            Room field = new Room("Field", "Possibly the most mundane field you have ever seen, but at least it doesnt stink anymore... There is a slight rustle in the taller grass, perhaps you are capable of taking up the challenge of 'cath me if you can'? You see a large structure to the west and the ground looks soggy to the north. South of you basically looks like sewage.");
            Room ruins = new Room("Ruins", "Looks like a civilization may have dwelled here once upon a time, but only the shambles of sophistication remain.  A suspicious looking device lies beneath a crumbling auquaduct. East of you smells horrid, to the west lies a very stationary and large looking animal, to the North lies a gate that may be passable.");
            Room statue = new Room("Statue", "You approach a statue of a dog. This is a dignified looking dog, yet you can't shake the feeling of being judged somehow for appreciating it's beauty. The artist portrays the shagginess of this dog really well...perhaps it actually feels soft? As there are no furthur ventures to explore, you feel the need to turn back.");
            Room fort = new Room("Fort", "A strudy yet menacing structure of stone surrounds you. There is a shiny light reflecting off a high tech looking device... Rubble lies to the south, the fort is collapsed to the west and north, and to the east is a boring yet open field.");
            Room wetlands = new Room("Wetlands", "Your shoes become soggy as the ground softens in a possible not so romantic type of way. You see a suspicious looking bubble near a rock that seems more solid than liquid... To your left is an impassable expanse of the fort. Ahead lies a glistening lake, and from your right comes the calming white noise. South is a boring field.");
            Room lakeshore = new Room("Lakeshore", "Beauty finally arrives in the form of a beach, gentle waves crashing against the sand await to embrace your weary ankles. A school of fish swim close to the shore. There is an island to the west on the lake, a steep trail to the north, regret to the south, and a lot of noise in the distance to the east.");
            Room island = new Room("Island", "You can't beleive this place is not actually tropical, probably because its summer and this place sucks in winter, but hey, you deserve this right? Coconut trees litter the grass while swaying in the wind. A draft comes from a suspicious rock outcropping in the west, and your swim back to shore in the east is doable. The Lake expands very far north and south.");
            Room secretCave = new Room("Secret Cave", "Congrats on making it here, feel free to make a personal secret fort for yourself with here...but you'll never save the world that way! An overwhelming feeling of excitement about having this place to yourself prevents you paying attention to anything past this secret cave, you may stay here forever or return to the island east. There is a wooden crate that drifted in on the beach.");
            Room delta = new Room("Fluvial Delta", "You must navigate through a series of water flows and frogs. You see something sitting on giant lillypad... Some climbable rocks appear in the north, the water flows from the south. To the west lies glistening water and to the east the land begins to rise.");
            Room river = new Room("River de Purrzalot", "A raging river deafens you as you approach the waters edge. There seems to be a valuable item drifting past the bridge you are about to cross. A torrent of water crashes to the south, drains to the north, and begins looking peaceful off to the east. West is a waste of time, as there is just soggy spongegrass there.");
            Room meadow = new Room("Meadow", "A peaceful looking landscape spreads out before you. Rainbows and butterflies await you in the east but your conscience won't allow you to deviate from the mission, so forget about it!. A cheery looking artifact has made its way out of the chipper territory and jingles as it rolls by. The land begins to rise in the north and the trees become more dense to the south. West is a wild river.");
            Room foothill = new Room("Foothill", "The scenery becomes rolling. You find hills larger than the small mounds of a shire but pathetic still compared to real mountains. In the side of a paritfularly curious hill there sees to be an opening. South lies a meadow, west becomes wet, to the north a high yet flat area and to the east the altitud climbs and terra becomes sharp.");
            Room outskirts = new Room("Forest Outskirts", "Trees start becoming more populous, shrubs appear and vegetaion becomes thicker. One such vegetation looks to be healthier than the rest. To the south you see a primitive structure, the west has water raging so intense you don't dare consider it, and to the east the woods get thicker.");
            Room camp = new Room("Abandoned Camp", "It appears a group of individuals once used this place as resting site, or they were just super underdeveloped but who knows?. A strange metallic container sits near an old campfire. The river west and south are too strong to change, and the woods are simply too thick to the east. You must turn back or go out primitive like the fools who last had this camp.");
            Room woods = new Room("Deep Woods", "You can hardly see there is so little light from all the dense vegetation. A patch of herbs smells divins as you approach. Making out the path is a struggle, but you see it continues east. Fear of being eaten alive or getting lost prevents you going north or south. To the west you see light peering through the edge of this black forest.");
            Room arena = new Room("Jagged Arena", "Everything you see is sharp and dangerous looking in this rocky terrain. Skydiving is not suggested, although there seems to be a strange miniature bungee style device hanging from a sharp rock outcropping. West are more gentle hills, north is a real mountain, east is another part of that same mountain, only it seems a little more tempting...");
            Room haunted = new Room("Haunted Forest", "This place seriously gives the creeps to peeps. You find it absurd that there are actually owls hooting thier spooky noise with bats in the background and cant wait to get out. Your foot nudges something as you pass through that seems portable. There is a sing to the south that reads: Cave of Deception. To the west is an extremely dense forest and east seems to be getting colder.");
            Room deception = new Room("Cave of Deception", "An odd choice to enter a place with this name but whatevs. For your bravery you are rewarded with the presence of...a cat! This one is a stuffed animal though, hence the word 'deception'. Mwahahah! Now take your item leave.");
            Room chillwood = new Room("Chillwoods", "Trees surround you, but the temperature is a little less than favorable.  Frost covers the treebranch tips and a nearby stream has icecicle at its edges. One chunk on the ground looks out of place, possibly even edible. West is warmer but freaky as heck but north is an open expanse that seems to get colder.");
            Room frozen = new Room("Frozen Wasteland", "You see snow everywhere and cannot go into the empty east. West is an Ice Dragon Lair that is SO last generation so obviously thats out of the question. You are welcome to a suspicious looking lump at your feet or you can continue. North is less snow but doesn't seem any warmer and south has some trees that glisten in the sun.");
            Room tundra = new Room("Tundra", "You find an annoying spanse of land that is barren of most vegetation, has perafrost yet little snow. As ludicrous as Tundras are, you are standing in one so...north is still frigid but more beautified and west becomes more defined by mountains. East is a frozen death zone.");
            Room smountain = new Room("South Mountain", "Southern side of mountain where there is a wagon with a Polearm by a pond. A very formiddable looking Polarm. East is a drop in temperature, north is as high as this landscape seems to get but you find a path, and west looks like a bunch of blades are thrusting from the earth.");
            Room arctic = new Room("Arctic Shelf", "The acrtic shelf where nobody wants to be. The perk is that some places are rather beautiful where the sea ice washes ashore in a display of deep blue decorations. In fact one piece looks like a brilliant sapphire, waiting for a good home. West lies a high peak, south loses beauty and snow. East and north are impassable due to the freezing ocean.");
            Room peak = new Room("Peak", "You are on top of the world! I hope that makes you feel good because other than a nice view there isn't much else here. Well, maybe a small flag waving on the peak. East is a blue iceland, north a strange tree, west some trees on the mountain, and south an inviting pond.");
            Room nmountain = new Room("North Mountain", "Even though you are on a mountain there is a single large tree standing above the world, solitary and respectable. You are inspired to meditate here if not leaving. A single leaf falls by your side as you ponder the questions of the world. To the south is the mountains highes location.");
            Room wmountain = new Room("West Mountain", "The part of the mountain most covered with vegetation. A good place for a short nap, and there is a sweet looking artifact laying near your anticipated napping spot! East is a mountain peak, south is an intimidating rock formation, and west levels out.");
            Room plateau = new Room("Plateau", "Although high in altitude, this area is rather flat and has a nice view of this world. Since its a great place for training, you get some practice in, during which time you notice a very futuristic relic half buried. East is a mountainside with trees, south some petty hills, and to the west is a formiddable looking rock formation. North is a sheer drop to death.");
            Room boulder = new Room("Highland Boulder", "You climb a massive granite boulder and feel like kingqueen of this region. There  are small freidnly looking rocks all around, one of which looks nicer than the rest. East is a flat expanse of smooth rocky pathways, to the south water pours across the land, and west has a more difficult terrain but you see a pathway.");
            Room cliffside = new Room("Cliffside", "You are very careful to climb through these cliffs with the provided pathway. You are high up, but secure when agains the rock walls. Someone left a rope hanging from one overlook long ago. East is a sweet looking boulder, you overlook the large body of water in the south and west is too far to fall for comfort. North seems to shows signs of architecture.");
            Room grotto = new Room("Sandstone Grotto", "As you decend the cliffs you find carved structures in the sides of the clif with a stream running through the middle of this once flourishing civilization. You stumble upon what seems to be a vault of sorts, obviously gaurding something priceless... South is the cliff passage and west feels warmer than you're used to.");
            Room odesert = new Room("Desert Outskirts", "Its starting to get really warm and vegetation is scarce. The ground is getting gritty and water less common. Something scurries as you pass a narrow part of the path. East is a beatiful living artwork of ancient vacant dwellings, west is super hot and north is super hot.");
            Room sdesert = new Room("Desert South", "A massive expanse of open heat, you see darker colored sand. There is a shiny peice of something sticking out of a dark patch, waiting for an owner. To the east lies less sand and to the north a huge mound with a possible vantage point.");
            Room edesert = new Room("East Desert", "You experience the expected desert heat but this portion has an unusual proportion of rocky earth to sand. At one particular convergence is a wierd looking round object that seems to make noise, yet isn't alive. South is less hot and north seems to be an mirage of a tree. West is a large mound surrounded by sand.");
            Room cdesert = new Room("Central Desert", "You climb a huge mound of hot earth completely surrounded by grains of sand and desert in all directions. Go any direction and you get more heat. Feel free to inspect that small mound on the ground near the apex of the mound...or not.");
            Room wdesert = new Room("West Desert", "You have arrived at the hottest region of the desert. A small hole in a dune is emmitting a light squeking noise, as if wanting to be found. With no icentive to stay, you quickly access wether going to the mound east of here or risking the thorny looking plants north is better.");
            Room aloe = new Room("Aloe Fields", "You enter a rather picturesque looking field of Aloe Vera plants. How they all grow is a mystery to most, however there is a sudden dead zone just past the field. One of the nearest aloe plants looks particularly refreshing. You can go no furthur in this direction.");
            Room cactus = new Room("Cactus Forest", "Cacti as far as the eye can see, whats the deal with that? Fanstasy world bruh, deal with it. Or if you feel like raging feel free to try taking action, totes your choice. There are smaller plants to the west, heat waves coming from the south, and empty sand to the east.");
            Room ndesert = new Room("North Desert", "This is probably the most typical desert you can imagine. Absolutely nothing special, which you suspect is why the structure to the north chose this location as one to keep outsiders away. A scurrying sound comes from under a rock near your snacking spot. West are a bunch of cacti looking plants and south is a large mound. East is difficult to decipher as there are reflections reflecting off someting.");
            Room fortress = new Room("Sand Fortress", "Welcome to a fortress made to keep the royalty of the Grotto people safe. Unfortunately they didn't have the ambition to span the desert for supplies so they all died here long ago, but hey, it looks pretty sweet! You can stay in this fortress and follow the fate of the Grotto Royalty or you can brave the desert once more. As you look poke your nose around like any normal adventurer you stuble across an epic piece of furniture, too stoic in structure to resist!");
            Room oasis = new Room("Oasis", "It wasn't an illusion! Refreshing springwater is a relief, you feel glorius in having perhaps overcome the desert epic. On a flat boulder rising out of the water lies a strange aporphic liquide, tipping toward the water but not quite tipping...just yet. West is a typical desert and south is a mix of sand and rock. East has a strange looking entrance that goes downhill.");
            Room wisdom = new Room("Spring of Wisdom", "You have arrived at the Spring of Wisdom. A small soft item seems welcoming to the right being. Feel free to medidate here before venturing forth, as the path looks to be headed underground...west is retreat and east is facing your challenges head on.");
            Room chasm = new Room("Underground Chasm", "You are now under the earth, and alhtough that is normally a gloomy concept you are releived to have left the hot desert sun. A small streak zooms past on the ground over and over, refusing to stop playing 'catch me if you can' Temples flank you, a red one north and a blue one south. To the east are archways inviting you to a great challenge. Feel free to head west if you want more Wisdom time.");
            Room fire = new Room("Fire Temple", "Glowing on all sides are eternal flames of fiery energy. This is clearly a sacred place, untouched by civilizations for centuries. The temple takes up the entire space, the only way out appears to be the way you came. A suspicious looking lump is sitting on a small pillar near a warning sign.");
            Room water = new Room("Water Temple", "Behold: towering pillars of limestone turrets ascend from the groun on all sides, each with an opening spewing crisp glowing turqoise water that cascades down the smooth surfaces and collect in a pool sevral feet below you. An item seems to glow in the pool, and you cannot decide on whether it adds the beautiful complexity of the room or takes away from the purity by floating in the pristine water. As beautiful as this place is, the ancient architechts could not chance a collapse which would ruin this structure. Enjoy your stay, but the exit north is the only way out.");
            Room proving = new Room("Proving Grounds", "Welcome to the proving grounds. Training equipment and obstacles surround this open cavern. Although this place seems deserted, most of the equipment has held up pretty well. You see a pair of deadly fighting gloves on a weapons cart, apparenlty just your size. When you are finished training you may head west toward the most open part of the Underdark, or east toward the pulsing orange glow.");
            Room lava = new Room("Lava Pit", "Here is the pit of eternal lava. There is a platform floatin above the pit, ashes float in the air and it's difficult to breath. A huge lion withe a mane of blue flames peers into your sould, daring you to ask permission to carry on with this quest. Ask is you are brave enough! West is back to the proving grounds.");
            Room castle = new Room("Castle Grimtol", "You have been teleported to this castle, your ultimate goal! Now finish the riddle to win the game! As a reward for getting this far, you will not die from taking action. Now present an offering worthy of a God!");

            //Add Items
            Item hairball = new Item("Hairball", "A disgusting glop of horror, you cannot live after this experience.");
            Item glass = new Item("Glass", "A full glass of water that teeters on the edge of the Oasis area");
            Item hovel = new Item("Hovel", "A dark opening on the side of the foothills. Unfortunately its inhabited.");
            Item thorn = new Item("Thorn", "A sharp and pointy thing that is perhaps best left untouched");
            Item polearm = new Item("Polearm", "A weapon of formiddable power. Too bad it was so intrumental in holding up that wagon...");
            Item rum = new Item("Rum", "A rather delicious aged coconut that is only worth drinking on this island.");
            Item catnip = new Item("Catnip", "This is the supreme substance of the realm, unquestionably so by divine judgement.");
            Item rope = new Item("Rope", "A questionable looking rope thats probably aged enough that it will break it pressure is applied.");
            Item scorpion = new Item("Scorpion", "A very dangerous critter, those who play with it are foolish.");
            Item thread = new Item("Thread", "An amazing piece of entertainment whose limits know no bounds");
            Item mouse = new Item("Mouse", "A scurrying critter of light brown color");
            Item fish = new Item("Fish", "You could have nasty chips, or you could have this fish raw and wriggly!");
            Item mittens = new Item("Mittens", "A pair of very soft mittens with which peace is obtained.");
            Item coffee = new Item("Coffee", "A delightful substance when prepared properly. Sucks for you.");
            Item shrubbery = new Item("Shrubbery", "You have found a shrubbery! Congratulations, you are now able to join a cult were you to find one");
            Item bird = new Item("Bird", "A decapitated specimen whose guts have been seperated from its body. You are sick to be carrying this around.");
            Item whisker = new Item("Whisker", "A blessed artifact of the ages, mysteriuos to many and rare to find.");
            Item hint = new Item("Hint", "I can sleep anywhere- any table, any chair* top of piano, window ledge- in the middle, on the edge* open drawer, empty shoe- anybody's lap will do* fitted in a cardboard box, in the cupboard with your frocks*");
            Item sculpture = new Item("Sculpture", "A handsome statue of a canine, yet somehow it feels unwelcome in this realm...");
            Item acorn = new Item("Acorn", "An admirable looking piece of wood that some critters like to eat.");
            Item laser = new Item("Laser", "A most superior device of all ages, covetted by all relevant societies and cherished among the furriest of species. Your life feels somehow more complete just being around this magnificent peice of technology");
            Item compass = new Item("Compass", "Your ability to navigate east west north and south depends on this");
            Item boots = new Item("Boots", "Footware durable enough to..perhaps not get poisoned?");
            Item cap = new Item("Cap", "A milk cap: mysterious futuristic device that magically contains liquids in containers and prevents evaporation entirely if used properly");
            Item twisty = new Item("Twisty", "An exciting piece of technology from the distant future, you are fortunate to find this marvel. It is said that those who find a Twisty find mercy");
            Item leaf = new Item("Leaf", "A curios looking leaf you found out of place, yet still healthy");
            Item coconut = new Item("Coconut", "A fruit/nut hybrid type item of treelike origin, hard on the outside and edible on the inside. You rejoice.");
            Item box = new Item("Box", "A magnanimous little monument, born of genius architecture now rests in your hands, you lucky duck you. You. Lucky. Duck.");
            Item bell = new Item("Bell", "A bell ball that noisily entices playful critters");
            Item buffallo = new Item("Buffalo", "A wile looking beast who doesn't look threatening.");
            Item crystal = new Item("Crystal", "A beautiful blue shard of ice permanently frozen. Foreverishly cold, this thing never warms. Literally it can't melt. For realzies.");
            Item bag = new Item("Bag", "A plastic bag, of the future this item has many uses, though it doesn't look really impressive to you at this moment.");
            Item hairtie = new Item("Hairtie", "A strang contraptions worn by certain members of society to perform a certain funtion for a certain part of their certain bodies.");
            Item keyboard = new Item("Keyboard", "A wierd plastic device with part called keys. Apparently useless, it seems cats are fond of sitting on this device.");
            Item rock = new Item("Rock", "An ordinary rock. Congratulations on getting this. You should be thrilled.");
            Item crinkle = new Item("Crinkle", "A wonderfully crinkly ball used by the feline species to show how their levels of adoreableness when playing have transcended that of other creatures.");
            Item plant = new Item("Plant", "A leaf of Aloe Vera whose insides ooze with a soothing gelatinous liquid, making your desert woes becoming a less painful, but still painful rather recent memory");
            Item slipper = new Item("Slipper", "A soft and roomy slipper, the perfect size for felines to snooze in.");
            Item permission = new Item("Permission", "You have been granted the grace of the lion king, dont' mess it up now!");

            //default start item for navigation
            entrance.Items.Add(compass);
            CurrentPlayer.Inventory.Add(compass);

            //Assign Items to Rooms
            bog.Items.Add(boots);
            swamp.Items.Add(hairball);
            ruins.Items.Add(twisty);
            statue.Items.Add(sculpture);
            fort.Items.Add(thread);
            field.Items.Add(mouse);
            wetlands.Items.Add(hairball);
            lakeshore.Items.Add(fish);
            island.Items.Add(coconut);
            secretCave.Items.Add(rum);
            river.Items.Add(cap);
            delta.Items.Add(hairball);
            meadow.Items.Add(bell);
            foothill.Items.Add(hovel);
            outskirts.Items.Add(shrubbery);
            camp.Items.Add(coffee);
            woods.Items.Add(catnip);
            haunted.Items.Add(bird);
            deception.Items.Add(whisker);
            chillwood.Items.Add(acorn);
            frozen.Items.Add(hairball);
            arctic.Items.Add(crystal);
            smountain.Items.Add(polearm);
            peak.Items.Add(bag);
            nmountain.Items.Add(leaf);
            wmountain.Items.Add(whisker);
            arena.Items.Add(hairtie);
            plateau.Items.Add(keyboard);
            boulder.Items.Add(rock);
            cliffside.Items.Add(rope);
            grotto.Items.Add(laser);
            odesert.Items.Add(scorpion);
            sdesert.Items.Add(whisker);
            edesert.Items.Add(crinkle);
            cdesert.Items.Add(hairball);
            wdesert.Items.Add(mouse);
            aloe.Items.Add(plant);
            cactus.Items.Add(thorn);
            ndesert.Items.Add(scorpion);
            fortress.Items.Add(box);
            oasis.Items.Add(glass);
            wisdom.Items.Add(slipper);
            chasm.Items.Add(mouse);
            fire.Items.Add(hairball);
            water.Items.Add(whisker);
            proving.Items.Add(mittens);
            lava.Items.Add(permission);
            castle.Items.Add(hint);

            //Add Directions
            entrance.Directions.Add("west", bog);
            bog.Directions.Add("east", entrance);
            bog.Directions.Add("south", swamp);
            bog.Directions.Add("north", field);
            bog.Directions.Add("west", ruins);
            swamp.Directions.Add("north", bog);
            ruins.Directions.Add("west", statue);
            ruins.Directions.Add("north", fort);
            ruins.Directions.Add("east", bog);
            statue.Directions.Add("east", ruins);
            fort.Directions.Add("south", ruins);
            fort.Directions.Add("east", field);
            field.Directions.Add("south", bog);
            field.Directions.Add("west", fort);
            field.Directions.Add("north", wetlands);
            wetlands.Directions.Add("south", field);
            wetlands.Directions.Add("east", river);
            wetlands.Directions.Add("north", lakeshore);
            river.Directions.Add("west", wetlands);
            river.Directions.Add("north", delta);
            river.Directions.Add("east", meadow);
            meadow.Directions.Add("north", foothill);
            meadow.Directions.Add("south", outskirts);
            meadow.Directions.Add("west", river);
            outskirts.Directions.Add("north", meadow);
            outskirts.Directions.Add("south", camp);
            outskirts.Directions.Add("east", woods);
            camp.Directions.Add("north", outskirts);
            woods.Directions.Add("west", outskirts);
            woods.Directions.Add("east", haunted);
            haunted.Directions.Add("west", woods);
            haunted.Directions.Add("south", deception);
            haunted.Directions.Add("east", chillwood);
            deception.Directions.Add("north", haunted);
            chillwood.Directions.Add("west", haunted);
            chillwood.Directions.Add("north", frozen);
            frozen.Directions.Add("south", chillwood);
            frozen.Directions.Add("north", tundra);
            tundra.Directions.Add("south", frozen);
            tundra.Directions.Add("west", smountain);
            tundra.Directions.Add("north", arctic);
            arctic.Directions.Add("south", tundra);
            arctic.Directions.Add("west", peak);
            smountain.Directions.Add("east", tundra);
            smountain.Directions.Add("west", arena);
            smountain.Directions.Add("north", peak);
            peak.Directions.Add("south", smountain);
            peak.Directions.Add("east", arctic);
            peak.Directions.Add("north", nmountain);
            peak.Directions.Add("west", wmountain);
            nmountain.Directions.Add("south", peak);
            arena.Directions.Add("east", tundra);
            arena.Directions.Add("north", wmountain);
            arena.Directions.Add("west", foothill);
            wmountain.Directions.Add("east", peak);
            wmountain.Directions.Add("south", arena);
            wmountain.Directions.Add("west", plateau);
            foothill.Directions.Add("east", arena);
            foothill.Directions.Add("south", meadow);
            foothill.Directions.Add("west", delta);
            foothill.Directions.Add("north", plateau);
            plateau.Directions.Add("east", wmountain);
            plateau.Directions.Add("south", foothill);
            plateau.Directions.Add("west", boulder);
            delta.Directions.Add("east", foothill);
            delta.Directions.Add("south", river);
            delta.Directions.Add("west", lakeshore);
            delta.Directions.Add("north", boulder);
            lakeshore.Directions.Add("east", delta);
            lakeshore.Directions.Add("soth", wetlands);
            lakeshore.Directions.Add("west", island);
            lakeshore.Directions.Add("north", cliffside);
            island.Directions.Add("east", lakeshore);
            island.Directions.Add("west", secretCave);
            secretCave.Directions.Add("east", island);
            boulder.Directions.Add("east", plateau);
            boulder.Directions.Add("south", delta);
            boulder.Directions.Add("west", cliffside);
            cliffside.Directions.Add("east", boulder);
            cliffside.Directions.Add("south", lakeshore);
            cliffside.Directions.Add("north", grotto);
            grotto.Directions.Add("south", cliffside);
            grotto.Directions.Add("west", odesert);
            odesert.Directions.Add("east", grotto);
            odesert.Directions.Add("west", sdesert);
            odesert.Directions.Add("north", edesert);
            edesert.Directions.Add("south", odesert);
            edesert.Directions.Add("west", cdesert);
            edesert.Directions.Add("north", oasis);
            cdesert.Directions.Add("south", sdesert);
            cdesert.Directions.Add("west", wdesert);
            cdesert.Directions.Add("east", edesert);
            cdesert.Directions.Add("north", ndesert);
            sdesert.Directions.Add("east", odesert);
            sdesert.Directions.Add("north", cdesert);
            wdesert.Directions.Add("east", cdesert);
            wdesert.Directions.Add("north", cactus);
            aloe.Directions.Add("east", cactus);
            cactus.Directions.Add("west", aloe);
            cactus.Directions.Add("south", wdesert);
            cactus.Directions.Add("east", ndesert);
            ndesert.Directions.Add("south", cdesert);
            ndesert.Directions.Add("west", cactus);
            ndesert.Directions.Add("north", fortress);
            ndesert.Directions.Add("east", oasis);
            fortress.Directions.Add("south", ndesert);
            oasis.Directions.Add("west", ndesert);
            oasis.Directions.Add("south", edesert);
            oasis.Directions.Add("east", wisdom);
            wisdom.Directions.Add("west", oasis);
            wisdom.Directions.Add("east", chasm);
            chasm.Directions.Add("west", wisdom);
            chasm.Directions.Add("south", water);
            chasm.Directions.Add("north", fire);
            chasm.Directions.Add("east", proving);
            proving.Directions.Add("west", chasm);
            proving.Directions.Add("east", lava);
            water.Directions.Add("north", chasm);
            fire.Directions.Add("south", chasm);
            lava.Directions.Add("west", proving);
            lava.Directions.Add("east", castle);
            lava.Directions.Add("north", fire);




            return entrance;
        }

        public void beginJourney()
        {
            CurrentRoom = init();
            System.Console.WriteLine((CurrentRoom.Description));

        }

        // public void nextRoom(string nav)
        // {
        //     if (CurrentRoom.Directions[nav] != null)
        //     {
        //         CurrentRoom = CurrentRoom.Directions[nav];
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Please select a valid direction yo");
        //         CurrentRoom = CurrentRoom;
        //     }


        // }
        public void help()
        {
            System.Console.WriteLine(@"
            1- Your objective should be to get to Castle Grimtol and solve the riddle to win the game
            2- You will have one or more of the following options in every room, choose one to advance
              *North
              *South
              *East
              *West
            3- You can view your inventory and try to use an item if you deem it wise
            4- Try not to die
            ");
        }

    }
}