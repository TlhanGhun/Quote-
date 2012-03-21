This is .NET API wrapper for QUOTE.fm
It is licensed under the "Simplified BSD License" - see LICENSE.txt

API description can be found at http://quote.fm/labs

This wrapper includes classes for all currently available data types (recommendations, articles, pages, user and categories) and all API calling methods.
It is an outcome of the current work on my social media (QUOTE.fm, Twitter, Facebook and Google Reader) client Nymphicus for Windows 1.4 http://www.nymphicusapp.com/windows which includes QUOTE.fm. Feel free to use this library whereever you want - would be happy for feedback of course

Parsing is done using the awesome Json.NET http://json.codeplex.com/

A console application which executes all API calls to give you a feeling of how to use is included to - just hit F5 in you Visual studio.

**********************************************
Example output of console test app:

Test tool for API calls in Quote#
###################

-> List of categories
 Category 1 => arts
 Category 2 => work
 Category 3 => culture
 Category 4 => economy
 Category 5 => education
 Category 6 => entertainment
 Category 7 => life
 Category 8 => politics
 Category 9 => sports
 Category 10 => technology
 Category 11 => science

###################

-> Recommendations

Id of recommendation to fetch (default is 900):
Using default 900
Recommendations 900 => Ich muss fragen, immer und immer wieder fragen, doch mein
e Lippen sind stumm. Angst hat keine Worte. Angst hat nicht einmal eine Stimme,
die aus dem Innen-Sein nach Außen dringt. Sie bleibt in mir und macht das Fühlen
 unbegreifbar.

Id of article to fetch recommendations of (default is 123):
Using default 123
Fetched for article Article 123 => Don't just do something; stand there
 Recommendations 224 => That it might be possible to arrange one's life so as to
 be slightly less frantic has somehow become unimaginable. And yet there is a gr
eat deal to be gained from doing nothing. We need space to brood and ruminate an
d mull. We need to slow down to get where we're going.

Username to fetch recommendations of (default is quotefm):
Using default username quotefm
Fetched for username quotefm
 Recommendations 214 => They are ordinary men in extraordinary costumes, and the
y have risen from the ashes of our troubled republic to ensure the safety of the
ir fellow citizens. Jon Ronson goes on patrol with Urban Avenger, Mr. Xtreme, Pi
tch Black, Knight Owl, Ghost, and the baddest-ass "real-life superhero" of them
all, Phoenix Jones
 Recommendations 217 => As the man descends the hill, navigating the vines, he e
xudes the purpose of someone who knows precisely where he's headed and what must
 be done when he gets there. All around him the vine rows are so uniformly strai
ght it's evident they have been meticulously arranged, painstakingly cultivated.
 At one particular vineyard, the man stops.
 Recommendations 227 => So, we made sure that our impressive-looking credentials
 were clearly visible on our chests, we grabbed some sheets of paper off a nearb
y table, and pretended we were talking about something very important and seriou
s as we walked through the entrance to the party, ignoring the guards, like we w
ere important people who owned the place.

###################

-> Articles

Id of article to fetch (default is 2111):
Using default 2111
Article 2111 => "Macht euren Kinderwunsch nicht von Liebe abhängig!"

List of category ids to fetch articles for (commasepareted - default is 1,3):
Using default 1,3
 Article 13981 => Zur Vermeidung von Irreführung des Lesers.
 Article 14039 => Freie WLANs werden aus Angst vor Störerhaftung selten
 Article 13940 => Sexualität So. Und nicht anders
 Article 14167 => My List: Karl Lagerfeld in 24 Hours
 Article 13941 => Salon Skurril
 Article 14163 => Before and After Jeremy Lin
 Article 14154 => 'Saga' Artist Fiona Staples Responds to Dave Dorman Criticism
of 'Breastfeeding Cover'
 Article 14152 => "It was just a case of building the impossible."
 Article 14149 => Warum unretuschierte Daten unfair sind
 Article 13579 => Urheberrecht Lernt zu teilen! Bevor es zu spät ist
 Article 14146 => GRANT THOMAS
 Article 14150 => Der Kunde ist nicht der König!
 Article 14097 => Kunstmagazin "Monopol" lässt Damien Hirst auflaufen
 Article 14090 => TV-Apps auf dem iPad im rechtlichen Graubereich Update
 Article 14136 => Kunst und Mode sind ein Liebespaar

Id of article page fetch articles of (default is 123):
Using default 123
Page is Page 123 => admartinator.de
 Article 2111 => "Macht euren Kinderwunsch nicht von Liebe abhängig!"
 Article 2111 => "Macht euren Kinderwunsch nicht von Liebe abhängig!"
 Article 2111 => "Macht euren Kinderwunsch nicht von Liebe abhängig!"

###################

-> Pages

Id of page to fetch (default is 4223):
Using default 4223
Page 4223 => gamepro.fr

Domain to fetch page of (default is spiegel.de):
Using default domain spiegel.de
Page 11 => spiegel.de

###################

-> Users

Id of user to fetch (default is 1):
Using default 1
User 1 => ***

Username to fetch (default is quotefm):
Using default username quotefm
User 37 => QUOTEfm

Followers of quotefm
 User 7 => ***
 User 47 => ***
 User 48 => ***
 User 49 => ***
 User 51 => ***
 User 52 => ***
 User 53 => ***
 User 54 => ***
 User 55 => ***
 User 56 => ***
 User 8 => ***
 User 57 => ***
 User 58 => ***
 User 59 => ***
 User 60 => ***
 User 61 => ***
 User 62 => ***
 User 63 => ***
 User 64 => ***
 User 65 => ***
 User 66 => ***
 User 67 => ***
 User 68 => ***
 User 69 => ***
 User 70 => ***
 User 71 => ***
 User 21 => ***
 User 72 => ***
 User 35 => ***
 User 73 => ***
 User 74 => ***
 User 16 => ***
 User 75 => ***
 User 76 => ***
 User 77 => ***
 User 78 => ***
 User 80 => ***
 User 81 => ***
 User 83 => ***
 User 84 => ***
 User 85 => ***
 User 86 => ***
 User 87 => ***
 User 88 => ***
 User 89 => ***
 User 90 => ***
 User 91 => ***
 User 92 => ***
 User 93 => ***
 User 19 => ***
 User 94 => ***
 User 95 => ***
 User 97 => ***
 User 98 => ***
 User 99 => ***
 User 100 => ***
 User 101 => ***
 User 102 => ***
 User 103 => ***
 User 104 => ***
 User 105 => ***
 User 106 => ***
 User 107 => ***
 User 108 => ***
 User 50 => ***
 User 109 => ***
 User 110 => ***
 User 111 => ***
 User 112 => ***
 User 113 => ***
 User 114 => ***
 User 115 => ***
 User 116 => ***
 User 117 => ***
 User 118 => ***
 User 119 => ***
 User 120 => ***
 User 121 => ***
 User 122 => ***
 User 28 => ***
 User 123 => ***
 User 124 => ***
 User 125 => ***
 User 126 => ***
 User 127 => ***
 User 128 => ***
 User 129 => ***
 User 130 => ***
 User 131 => ***
 User 132 => ***
 User 133 => ***
 User 134 => ***
 User 135 => ***
 User 136 => ***
 User 137 => ***
 User 138 => ***
 User 139 => ***
 User 140 => ***
 User 141 => ***
 User 142 => ***

Followings of quotefm
 User 1 => ***
 User 8 => ***
 User 7 => ***
 
Completed... Press enter to close