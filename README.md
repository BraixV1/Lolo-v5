# Lolo-v5



## Uptime praktika ülesanne.

ülesanne on lahendatud kasutade Blazori.

Miks Blazor? - Kuna ma algselt proovisin ülesannet lahendada kasutades VUE.js aga fetch päring riku CORSI ja ei anna RSS faili.
Pärast 2 päevast mõtlemist kuidas seda probleemi lahendada otsustasin proovid mis on blazor.
Blazor lahendab probleemi sellega et ta on kliendi poolel ja serveri poolel samal ajal andes võimaluse olla lehel reactive,
aga samas ei ole vaja eraldi teist serverit mis jooksutaks serverit, sest kõik toimub ühes serveris. Samuti ei kasuta see leht andmebaasi, 
sest kuna on õeldud et ei ole vaja teha kasutajaid ja rolle siis mingil määral tagada võimalus kasutada seda lehte rohkematel inimestel kui ainult mina,
ostsustasin linke hoida local storages, mida on palju raskem manipuleerida kui tegemist on puhta MVC modeliga kus .NET backend saadab välja genereeritud html lehe kasutajale.


Iga RSS feedi artiklitel on oma tausta värv mis on genereeritud suvaliselt.


Deploytud lehega saab tutvuda: https://lolo-v5-exal.onrender.com/