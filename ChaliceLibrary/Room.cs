using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaliceLibrary
{
    public class Room //TODO Create Room method
    {
        public static string GetRoom()
        {
            string[] rooms =
            {
               //TODO populate room lore
                "You enter a barren street, blockaded with discarded and ravaged vehicles.\n" +
                "Rubble and glass is everywhere. The sky beckons with a terrifying storm cloud.\n" +
                "This storm has a ruby red hue you can make out,\n" +
                "occasionally when angry lightning shoots across the sky.\n",

"This turn into the alley way seems to be the only way\n" +
"through the wreckage of demolished buildings.\n" +
"Same sky above raging with lightning. This alley is dark.\n" +
"With your helmet flashlight you can make out a pair of searing red eyes,\n" +
"now fixed... now staring...\n",

"The only way to advance the scorched city\n" +
"was through this manhole you've now found yourself in.\n" +
"You deeply regret this decision as the stench of standing water,\n" +
"which had been marinading the now discarded human lives scattered around,\n" +
"can be picked up through your helmet's air filter.\n" +
"You dash further down the  with heavy plunging boots.\n" +
"Clopping through these wading bodies so buoyant... Until...\n",

"Finding resources for your equipped weapon in an old parking garage,\n" +
"was the highlight of your curiosity to enter here. The downside… well.\n",

"Blood spattered automatic doors brokenly roll ajar...\n" +
"This metro station has seen a fair share of action.\n" +
"Images of a recently functioning society flood your mind.\n" +
"This just isn't right. Humanity flourished in the commute for better lives once. \n" +
"Now threatened by this impending demonic presence.\n" +
"You clench your fist in anger,\n" +
"but are quickly reminded to be cautious as you hear heavy grunts\n" +
"from an unhuman sounding set of lungs… To your right!\n",

"Candles flicker and partially illuminate the narrow alley.\n" +
"Discarded and blood drenched newspapers litter every square inch of the pavement here.\n" +
"Who lit these candles?\n" +
"You see blood lined calligraphy in some archaic looking language circling what\n" +
"looks to be a precise pentagram. Demonic language?\n" +
"A candle at every point of the star, actually burnt out.\n" +
"It appears to be a summoning circle... Summoned what though?\n",

"Climbing through a destroyed elevator shaft,\n" +
"you reach the third floor of a street level office building.\n" +
"It is pitch black here.\n" +
"Occasionally the lightning from the hellish storm outside beams through for a brief moment.\n" +
"You strategize the rhythm of your footsteps\n" +
"with the eruption of this angry but now helpful lightning.\n" +
"You notice you can advance forward between flashes. Slowly...\n" +
"You expect trouble… Just when will they appear?\n",

"Sneaking around this set of still standing ever green trees\n" +
"you find yourself in the middle of a city park.\n" +
"Blocked in by unmanned city busses lazily scattered about you notice you can only move forward.\n" +
"There is a playground. Swing set seats only hanging on by a single chain…\n" +
"You see a single hand poking out of a nearby bush.\n" +
"It appears to be holding something tightly. You go in for a closer look...\n" +
"Then...\n",

"Running away from a horde of hungry looking demons,\n" +
"you barricade yourself into the park bathroom.\n" +
"Trying to set yourself center in these walls you try the stall door... Why?\n" +
"Why are they always locked in these situations? Did Capcom develop these circumstances?\n" +
"*BOOM... your barricade failed... Brace yourself!\n",

"Crashed windows reveal the marble floor of the local Police Station.\n" +
"The locals would have been counting on the help of these officers in the brink of danger...\n" +
"Helpless though the officers were. They are all just human after all.\n" +
"You enter hoping to find resources for your equipped weapon.\n" +
"Batteries, ammunition, anything. You see a few camera monitor feeds behind a desk.\n" +
"Cameras appear to be working. \n" +
"You see the shadow of something sprinting past one of the live camer...\n" +
"Was that down the hall? You brace yourself behind the desk!\n",

"Radio chatter lead you to a body holding a walkie talkie.\n" +
"Slumped, half in and half out of a military issued Jeep,\n" +
"this body suspended by the still latched seat be...\n" +
"Whatever was speaking through the radio didn’t seem to be English… Let alone human.\n" +
"It's as though the demon invasion\n" +
"was able to override all frequencies we communicate on. How devilish...\n",
















            };
            return rooms[new Random().Next(rooms.Length)];
        }
    }//endclass
}//endnamespace
