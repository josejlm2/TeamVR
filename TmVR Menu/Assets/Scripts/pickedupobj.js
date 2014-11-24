#pragma strict

var refusethrow = false;
function Start () {

}

function Update () {

}

function onTriggerEnter (other : Collider) {
 if (other.gameObject.tag != "player" && other.gameObject.tag != "pickto"){ refusethrow = true;}
 
}

function onTriggerExit (other : Collider) {

 if (other.gameObject.tag != "play" && other.gameObject.tag != "pickto") { refusethrow = false;}
 
 }
 