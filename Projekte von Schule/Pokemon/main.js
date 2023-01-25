var color; // Aktuelle Farbe (Spieler)
var fields = new Array(); // Felder, welche bereits besetzt sind. Verhindert, dass zwei mal dasselbe Feld gefaerbt wird
var zuege = 0; // Anzahl Züge - Nach neun ist Schluss.
var p1; // Spieler 1
var p2; // Spieler 2
 
// Farb auswahl der Spieler
 //p1 = prompt("Farbe für Spieler 1, die Farben nur in Englisch schreiben!");
 //p2 = prompt("Farbe für Spieler 2, die Farben nur in Englisch schreiben!");
 

  
  function changecolor() {
 if(color == red) {
  color = blue;
  color_zahl = 0;
  document.getElementById("player").textContent = "Spieler 1 ist drann"; //"Spieler 1 ist drann!"
 } else {
  color = red;
  color_zahl = 1;
  document.getElementById("player").textContent = "Spieler 2 ist drann"; //"Spieler 2 ist drann!"
 }
}


function makemecolored(id) {

  if(fields[id] != 1 && fields[id] != 0) {
    changecolor();
    //var ctx = document.getElementById(id).getContext("2d");
    //ctx.fillStyle = color;
    if(color == "blue")
		let img = document.getElementById("pic2");
	else
		let img = document.getElementById("pic1");
	ctx.drawImage(img,10,10,130,130);
    fields[id] = color_zahl;
    testwin();
    zuege++;
    testende();
	
  }
}

function testende(){
 if(zuege == 9) {
   alert("unentschieden");
   neustart();
 }
}

function neustart(){
    location.reload();
}

function testwin() {
if(fields[0]+fields[1]+fields[2] == 0) { alert("Spieler 2 Gewinnt"); neustart(); }
if(fields[0]+fields[1]+fields[2] == 3) { alert("Spieler 1 Gewinnt"); neustart(); }
if(fields[3]+fields[4]+fields[5] == 0) { alert("Spieler 2 Gewinnt"); neustart(); }
if(fields[3]+fields[4]+fields[5] == 3) { alert("Spieler 1 Gewinnt"); neustart(); }
if(fields[6]+fields[7]+fields[8] == 0) { alert("Spieler 2 Gewinnt"); neustart(); }
if(fields[6]+fields[7]+fields[8] == 3) { alert("Spieler 1 Gewinnt"); neustart(); }

if(fields[0]+fields[3]+fields[6] == 0) { alert("Spieler 2 Gewinnt"); neustart(); }
if(fields[1]+fields[4]+fields[7] == 0) { alert("Spieler 2 Gewinnt"); neustart(); }
if(fields[2]+fields[5]+fields[8] == 0) { alert("Spieler 2 Gewinnt"); neustart(); }
if(fields[0]+fields[3]+fields[6] == 3) { alert("Spieler 1 Gewinnt"); neustart(); }
if(fields[1]+fields[4]+fields[7] == 3) { alert("Spieler 1 Gewinnt"); neustart(); }
if(fields[2]+fields[5]+fields[8] == 3) { alert("Spieler 1 Gewinnt"); neustart(); }

if(fields[0]+fields[4]+fields[8] == 0) { alert("Spieler 2 Gewinnt"); neustart(); }
if(fields[2]+fields[4]+fields[6] == 0) { alert("Spieler 2 Gewinnt"); neustart(); }

if(fields[0]+fields[4]+fields[8] == 3) { alert("Spieler 1 Gewinnt"); neustart(); }
if(fields[2]+fields[4]+fields[6] == 3) { alert("Spieler 1 Gewinnt"); neustart(); }
}
