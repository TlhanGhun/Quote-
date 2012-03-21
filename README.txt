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
User 1 => pwaldhauer

Username to fetch (default is quotefm):
Using default username quotefm
User 37 => QUOTEfm

Followers of quotefm
 User 7 => uarrr
 User 47 => moeffju
 User 48 => fabu
 User 49 => zimtsternin
 User 51 => balkonzimmer
 User 52 => Wuar
 User 53 => nilzenburger
 User 54 => maiways
 User 55 => sunny
 User 56 => jens
 User 8 => martinwolf
 User 57 => Lisa
 User 58 => Din
 User 59 => antpaw
 User 60 => andyTest
 User 61 => mmeschnuerschuh
 User 62 => FlowB
 User 63 => andytest2
 User 64 => heartcore
 User 65 => muppfel
 User 66 => pewpew
 User 67 => Mckbrother
 User 68 => ugotit
 User 69 => rob
 User 70 => Jeriko
 User 71 => phil
 User 21 => kanni
 User 72 => herrbertling
 User 35 => Luise
 User 73 => ruhepuls
 User 74 => 7h0ma5
 User 16 => JanOelze
 User 75 => jakuuub
 User 76 => bornmann
 User 77 => ttfan81
 User 78 => beetlebum
 User 80 => frankreimann
 User 81 => StefanBogi
 User 83 => testtest
 User 84 => goebelmeier
 User 85 => patsyjones
 User 86 => Vitruvo
 User 87 => martinweigert
 User 88 => luca
 User 89 => dotdean
 User 90 => kommanderkat
 User 91 => evaschulz
 User 92 => nzyan
 User 93 => stilpirat
 User 19 => carsten
 User 94 => electricgecko
 User 95 => maatien
 User 97 => freakbe
 User 98 => matthias
 User 99 => fhauck
 User 100 => cgast
 User 101 => kathrynsky
 User 102 => bosch
 User 103 => mkunze
 User 104 => flaneur
 User 105 => janz
 User 106 => yeahsara
 User 107 => herm
 User 108 => flo
 User 50 => maxhaesslein
 User 109 => moerchenlala
 User 110 => Ben
 User 111 => Flaschenputtel
 User 112 => LaSchnack
 User 113 => danielploetz
 User 114 => caharo
 User 115 => gerdkeller
 User 116 => Bob
 User 117 => maxfraenkel
 User 118 => tobus81
 User 119 => erol
 User 120 => dieSiiiina
 User 121 => DoppelM
 User 122 => hugovoss
 User 28 => chris_werlin
 User 123 => raventhird
 User 124 => dantz
 User 125 => nerdismus
 User 126 => kat
 User 127 => finnkirchner
 User 128 => sashoff
 User 129 => booldog
 User 130 => sprichmitlisa
 User 131 => sgoethling
 User 132 => svenwiesner
 User 133 => yasminTL
 User 134 => svensonsan
 User 135 => Sokoloff
 User 136 => Eay
 User 137 => Lukas
 User 138 => admartinator
 User 139 => freshmango
 User 140 => Salzig
 User 141 => cainvommars
 User 142 => alex233

Followings of quotefm
 User 1 => pwaldhauer
 User 8 => martinwolf
 User 7 => uarrr
 
Completed... Press enter to close